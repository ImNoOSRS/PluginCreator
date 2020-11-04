using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginCreator
{
	class Methods
	{
		public static string ConfigButtonClicked = @"  @Subscribe
	public void onConfigButtonClicked(ConfigButtonClicked event) {
		if (!event.getGroup().equals(@@@@NAME@@@@))
			return; 
		if (event.getKey().equals(@startButton@)) {
			pluginStarted = true;
		} else if (event.getKey().equals(@stopButton@)) {
			pluginStarted = false;
		} 
	}";
	}
}
