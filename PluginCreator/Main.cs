using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginCreator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        string namex = "";
        private void create_plugin_Click(object sender, EventArgs e)
        {
            imports = "";
            if (name.Text == "")
            {
                MessageBox.Show("Choose a name first.");
                return;
            }
            if (description.Text == "")
            {
                MessageBox.Show("Choose a description first.");
                return;
            }
            if (creator.Text == "")
            {
                MessageBox.Show("Choose a creator first.");
                return;
            }
            if (SidePanel.Checked)
            {
                if (panel_icon.BackColor != Color.Green)
                {
                    MessageBox.Show("You need to choose an image for the SidePanel.");
                    return;
                }
            }
            if (name_text.Text == "")
            {
                name_text.Text = name.Text;
            }
            namex = name.Text.Replace(" ", "_");
            if (Directory.Exists(namex))
            {
                Directory.Delete(namex, true);
                MessageBox.Show("Deleted previous folder, click OK to continue.");
            }
            Directory.CreateDirectory(namex);
            File.WriteAllText(namex + "/" + namex + ".gradle.kts", replace_values(texts.gradle));
            Directory.CreateDirectory(namex + "/src");
            Directory.CreateDirectory(namex + "/src/main");
            Directory.CreateDirectory(namex + "/src/main/java");
            Directory.CreateDirectory(namex + "/src/main/java/net");
            Directory.CreateDirectory(namex + "/src/main/java/net/runelite");
            Directory.CreateDirectory(namex + "/src/main/java/net/runelite/client");
            Directory.CreateDirectory(namex + "/src/main/java/net/runelite/client/plugins");
            Directory.CreateDirectory(namex + "/src/main/java/net/runelite/client/plugins/" + namex);
            File.WriteAllText(namex + "/src/main/java/net/runelite/client/plugins/" + namex + "/" + namex + "Plugin.java", replace_values(texts.plugin_file));
            File.WriteAllText(namex + "/src/main/java/net/runelite/client/plugins/" + namex + "/" + namex + "Config.java", replace_values(texts.config_file));
            if (overlay.Checked)
            {
                File.WriteAllText(namex + "/src/main/java/net/runelite/client/plugins/" + namex + "/" + namex + "Overlay.java", replace_values(texts.overlay_file));
            }
            if (overlaypanel.Checked)
            {
                File.WriteAllText(namex + "/src/main/java/net/runelite/client/plugins/" + namex + "/" + namex + "OverlayPanel.java", replace_values(texts.overlay_panel_file));
            }
            if (SidePanel.Checked)
            {
                File.WriteAllText(namex + "/src/main/java/net/runelite/client/plugins/" + namex + "/" + namex + "Panel.java", replace_values(texts.panel_file));
                create_panel_image();
            }
            if (task_system.Checked)
            {
                Directory.CreateDirectory(namex + "/src/main/java/net/runelite/client/plugins/" + namex + "/Tasks");
                File.WriteAllText(namex + "/src/main/java/net/runelite/client/plugins/" + namex + "/" + namex + "Panel.java", replace_values(texts.panel_file));
                File.WriteAllText(namex + "/src/main/java/net/runelite/client/plugins/" + namex + "/" + "Task.java", replace_values(task_system_files.Task));
                File.WriteAllText(namex + "/src/main/java/net/runelite/client/plugins/" + namex + "/" + "TaskSet.java", replace_values(task_system_files.task_set));
            }
            if(utils.Checked)
            {
                File.WriteAllText(namex + "/src/main/java/net/runelite/client/plugins/" + namex + "/" + "ImNoUtils.java", replace_values(task_system_files.Utils));
            }
            Process.Start(Directory.GetCurrentDirectory() + "/" + namex + "/src/main/java/net/runelite/client/plugins/" + namex);
        }

        public void create_panel_image()
        {
            Directory.CreateDirectory(namex + "/src/main/resources/");
            Directory.CreateDirectory(namex + "/src/main/resources/net");
            Directory.CreateDirectory(namex + "/src/main/resources/net/runelite");
            Directory.CreateDirectory(namex + "/src/main/resources/net/runelite/client");
            Directory.CreateDirectory(namex + "/src/main/resources/net/runelite/client/plugins");
            Directory.CreateDirectory(namex + "/src/main/resources/net/runelite/client/plugins/" + namex);
            using (FileStream stream = new FileStream(file_picker.FileName, FileMode.Open, FileAccess.Read))
            {
                Image original = Image.FromStream(stream);
                if ((original.Width != 16) || (original.Height != 16))
                {
                    original = new Bitmap(original, new Size(16, 16));
                    MessageBox.Show("The size of this image is not 16x16 so its cropped to 16x16 now.");
                }

                original.Save(namex + "/src/main/resources/net/runelite/client/plugins/" + namex + "/" + namex + "_icon.png");
            }
        }

        string temp = "";
        string imports = "";
        public string get_top_data()
        {
            temp = "";
            bool need_overlaymanager = overlay.Checked || overlaypanel.Checked;
            if (need_overlaymanager)
            {
                import("import net.runelite.client.ui.overlay.OverlayManager;");
                inject();
                addtemp("private OverlayManager overlayManager;", true);
                if (overlay.Checked)
                {
                    inject();
                    addtemp("private @@NAME@@Overlay overlay;", true);
                }
                if (overlaypanel.Checked)
                {
                    inject();
                    addtemp("private @@NAME@@OverlayPanel overlaypanel;", true);
                }
            }
            if(task_system.Checked)
            {
                addtemp("private TaskSet tasks = new TaskSet(new Task[0]);", true);
            }
            if (config_start_button.Checked)
            {
                addtemp("boolean pluginStarted;", true);
            }
            return temp;
        }

        public void import(string import)
        {
            imports += "\r\n" + import;
        }

        public string get_startup()
        {
            temp = "";
            bool need_overlaymanager = overlay.Checked || overlaypanel.Checked;
            if (need_overlaymanager)
            {
                if (overlay.Checked)
                {
                    addtemp("overlayManager.add(overlay);");
                }
                if (overlaypanel.Checked)
                {
                    addtemp("overlayManager.add(overlaypanel);");
                }
            }
            if (task_system.Checked)
            {
                if (config_start_button.Checked)
                {
                    addtemp("pluginStarted = false;");
                }
                addtemp("tasks.clear();");
                addtemp("//Example task");
                addtemp("//tasks.addAll(this, this.client, this.config, new Task[] { (Task)new OpenBankTask() });");
            }
            return temp;
        }

        public string get_shutdown()
        {
            temp = "";
            bool need_overlaymanager = overlay.Checked || overlaypanel.Checked;
            if (need_overlaymanager)
            {
                if (overlay.Checked)
                {
                    addtemp("overlayManager.remove(overlay);");
                }
                if (overlaypanel.Checked)
                {
                    addtemp("overlayManager.remove(overlaypanel);");
                }
            }
            if (task_system.Checked)
            {
                if (config_start_button.Checked)
                {
                    addtemp("pluginStarted = false;");
                }
                addtemp("tasks.clear();");
            }
            return temp;
        }

        public void addtemp(string tempdata, bool main = false)
        {
            if (temp == "")
            {
                if (main)
                {
                    temp = "	" + tempdata;
                }
                else
                {
                    temp = "	" + "	" + tempdata;
                }
            }
            else
            {
                if (main)
                {
                    temp += "\r\n" + "	" + tempdata;
                }
                else
                {
                    temp += "\r\n" + "	" + "	" + tempdata;
                }
            }
        }

        public void inject()
        {
            if (temp == "")
            {
                temp = " @Inject";
            }
            else
            {
                temp += "\r\n" + " @Inject";
            }
        }

        public string get_extra_methods()
        {
            string methods = "";
            if(config_start_button.Checked)
            {
                methods += Methods.ConfigButtonClicked.Replace("@", "\"");
            }
            return methods;
        }


        public string replace_values(string base_input)
        {
            string result = base_input;
            result = result.Replace("%IMPORTSPOT%", imports);
            result = result.Replace("%EXTRAMETHODS%", get_extra_methods());
            result = result.Replace("%TOPDATA%", get_top_data());
            result = result.Replace("%STARTUP_DATA%", get_startup());
            result = result.Replace("%SHUTDOWN_DATA%", get_shutdown());
            result = result.Replace("%PANELSPOT1%", SidePanel.Checked ? addons.panel_text1 : "");
            if (config_start_button.Checked)
            {
                result = result.Replace("%CONFIG_EXTRA%", "\r\n" + ConfigOptions.start_stop.Replace("@", "\""));
            }
            else
            {
                result = result.Replace("%CONFIG_EXTRA%", "");
            }
            result = result.Replace("@@NAME@@", namex).Replace("@@NAME_TEXT@@", name_text.Text).Replace("@@DESC@@", description.Text).Replace("@@CREATOR@@", creator.Text).Replace("@@", "\"");
            return result;
        }

        private void panel_icon_Click(object sender, EventArgs e)
        {
            if (file_picker.ShowDialog() == DialogResult.OK)
            {
                panel_icon.BackColor = Color.Green;
            }
        }
    }
}
