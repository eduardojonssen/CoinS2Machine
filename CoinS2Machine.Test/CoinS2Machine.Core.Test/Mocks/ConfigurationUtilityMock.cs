using CoinS2Machine.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Test.CoinS2Machine.Core.Test.Mocks {

    public class ConfigurationUtilityMock : IConfigurationUtility {

        public string LogPath {
            get { return @"C:\Logs\LogTest.log"; }
        }
    }
}
