using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginCreator
{
    class ConfigOptions
    {
        public static string start_stop = @"  @ConfigItem(keyName = @startButton@, name = @Start@, description = @@, position = 2)
  default Button startButton() {
    return new Button();
  }
  
  @ConfigItem(keyName = @stopButton@, name = @Stop@, description = @@, position = 3)
  default Button stopButton() {
    return new Button();
  }";
    }
}
