using DeviceMapper.Base;
using DeviceMapper.Black;
using DeviceMapper.White;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceMapper
{
    public class DeviceMapper : IDeviceMapper // factory class
    {
        private const string ConfigFile = "DeviceMapper.config.json";
        private const string DmPrefix = "$.DeviceMapper";
        private const string DevicesPrefix = DmPrefix + ".Devices";
        private const string MappingPrefix = DmPrefix + ".Mapping";

        private static IConfiguration _cfg = null;

        public DeviceMapper()
        {
            Debug.WriteLine("ctor");

            var configuration = new ConfigurationBuilder()
                // custom config file
                .AddJsonFile("DeviceMapper.config.json", optional: false, reloadOnChange: false)
                .Build();

            //ar jsonConfigurationProvider = new JsonConfigurationProvider();
            //_cfg = jsonConfigurationProvider.ReadConfiguration(ConfigFile);
        }

        public Device GetDevice(string name)
        {
            if (name == null)
            {
                return null;
            }
            if (string.Equals(name, "white", StringComparison.OrdinalIgnoreCase))
            {
                return new WhiteDevice();

            }
            else if (string.Equals(name, "black", StringComparison.OrdinalIgnoreCase))
            {
                return new BlackDevice();

            }

            return null;
        }

        public IList<IDeviceConfiguration> FindDevices()
        {
            throw new NotImplementedException();
        }

        public IList<IDeviceConfiguration> FindDevicesFromConfig()
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public static DeviceMapping GetDeviceMapping(string name)
        {
            if (null == _cfg)
            {
                return null;
            }
            return new DeviceMapping(
                GetMapingParameter(name, "Device", ""),
                GetMapingParameter(name, "Protocol", ""),
                GetMapingParameter(name, "AutoPowerOn", false));
        }

        #region private
        private static T GetMapingParameter<T>(string name, string param, T def = default(T)) where T : IConvertible
        {
            if (null == _cfg) return def;
            return default;
            //return _cfg.GetParameter(MappingPrefix + string.Format(".{0}.{1}", name, param), def);
        }

        private static T GetParameter<T>(string param, T def = default(T)) where T : IConvertible
        {
            if (null == _cfg) return def;
            return default;
            //return _cfg.GetParameter(DmPrefix + string.Format(".{0}", param), def);
        }
        #endregion


    }
}
