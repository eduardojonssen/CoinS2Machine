using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core.Utility {

    public class ConfigurationUtility : IConfigurationUtility {

        public ConfigurationUtility() { }

        public string LogPath {
            get { return ConfigurationManager.AppSettings["LogPath"]; }
        }
    }
}
