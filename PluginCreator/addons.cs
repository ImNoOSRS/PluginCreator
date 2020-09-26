using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginCreator
{
    class addons
    {

		public static string overlay_panel_base1 = @"
@Inject
private @@NAME@@OverlayPanel overlaypanel;
";


		public static string overlay_base1 = @"
@Inject
private @@NAME@@Overlay overlay;
@Inject
private OverlayManager overlayManager;";

		public static string overlay_text1 = @"overlayManager.add(overlay);";

		public static string overlay_text2 = @"overlayManager.remove(overlay);";

		public static string overlay_panel_text1 = @"overlayManager.add(overlaypanel);";

		public static string overlay_panel_text2 = @"overlayManager.remove(overlaypanel);";


		public static string panel_text1 = @"	public void sidepanel(Boolean show)
	{
		if(show)
		{
			final @@NAME@@Panel panel = injector.getInstance(@@NAME@@Panel.class);

			final BufferedImage icon = ImageUtil.getResourceStreamFromClass(getClass(), @@@@NAME@@_icon.png@@);

			navButton = NavigationButton.builder()
					.tooltip(@@@@NAME_TEXT@@@@)
					.icon(icon)
					.priority(2)
					.panel(panel)
					.build();

			clientToolbar.addNavigation(navButton);
		}
		else
		{
			clientToolbar.removeNavigation(navButton);
		}
	}";
    }
}
