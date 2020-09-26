namespace PluginCreator
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.creator = new System.Windows.Forms.TextBox();
            this.create_plugin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.name_text = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.overlaypanel = new System.Windows.Forms.CheckBox();
            this.panel_icon = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.CheckBox();
            this.overlay = new System.Windows.Forms.CheckBox();
            this.file_picker = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(21, 30);
            this.name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(233, 32);
            this.name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plugin Name (FILES)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(21, 140);
            this.description.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(233, 32);
            this.description.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Creator";
            // 
            // creator
            // 
            this.creator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creator.Location = new System.Drawing.Point(21, 192);
            this.creator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.creator.Name = "creator";
            this.creator.Size = new System.Drawing.Size(233, 32);
            this.creator.TabIndex = 7;
            this.creator.Text = "ImNo";
            // 
            // create_plugin
            // 
            this.create_plugin.BackColor = System.Drawing.Color.White;
            this.create_plugin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_plugin.Location = new System.Drawing.Point(21, 224);
            this.create_plugin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.create_plugin.Name = "create_plugin";
            this.create_plugin.Size = new System.Drawing.Size(231, 41);
            this.create_plugin.TabIndex = 8;
            this.create_plugin.Text = "Create Plugin";
            this.create_plugin.UseVisualStyleBackColor = false;
            this.create_plugin.Click += new System.EventHandler(this.create_plugin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Plugin Name (TEXT)";
            // 
            // name_text
            // 
            this.name_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_text.Location = new System.Drawing.Point(21, 85);
            this.name_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(233, 32);
            this.name_text.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.overlaypanel);
            this.groupBox1.Controls.Add(this.panel_icon);
            this.groupBox1.Controls.Add(this.SidePanel);
            this.groupBox1.Controls.Add(this.overlay);
            this.groupBox1.Location = new System.Drawing.Point(257, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(195, 250);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Addons";
            // 
            // overlaypanel
            // 
            this.overlaypanel.AutoSize = true;
            this.overlaypanel.Location = new System.Drawing.Point(16, 53);
            this.overlaypanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.overlaypanel.Name = "overlaypanel";
            this.overlaypanel.Size = new System.Drawing.Size(89, 17);
            this.overlaypanel.TabIndex = 3;
            this.overlaypanel.Text = "OverlayPanel";
            this.overlaypanel.UseVisualStyleBackColor = true;
            // 
            // panel_icon
            // 
            this.panel_icon.BackColor = System.Drawing.Color.Red;
            this.panel_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panel_icon.Location = new System.Drawing.Point(16, 104);
            this.panel_icon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_icon.Name = "panel_icon";
            this.panel_icon.Size = new System.Drawing.Size(175, 25);
            this.panel_icon.TabIndex = 2;
            this.panel_icon.Text = "Choose Panel Image";
            this.panel_icon.UseVisualStyleBackColor = false;
            this.panel_icon.Click += new System.EventHandler(this.panel_icon_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.AutoSize = true;
            this.SidePanel.Location = new System.Drawing.Point(16, 83);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(112, 17);
            this.SidePanel.TabIndex = 1;
            this.SidePanel.Text = "SidePanel (16x16)";
            this.SidePanel.UseVisualStyleBackColor = true;
            // 
            // overlay
            // 
            this.overlay.AutoSize = true;
            this.overlay.Location = new System.Drawing.Point(16, 25);
            this.overlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.overlay.Name = "overlay";
            this.overlay.Size = new System.Drawing.Size(62, 17);
            this.overlay.TabIndex = 0;
            this.overlay.Text = "Overlay";
            this.overlay.UseVisualStyleBackColor = true;
            // 
            // file_picker
            // 
            this.file_picker.Filter = "PNG Image (*png) | *.png";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 280);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.create_plugin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.creator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Plugin Creator - By ImNo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox creator;
        private System.Windows.Forms.Button create_plugin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox overlay;
        private System.Windows.Forms.CheckBox SidePanel;
        private System.Windows.Forms.Button panel_icon;
        private System.Windows.Forms.OpenFileDialog file_picker;
        private System.Windows.Forms.CheckBox overlaypanel;
    }
}

