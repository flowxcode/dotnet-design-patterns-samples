using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DeviceMapper
{
    public interface IDeviceConfiguration : ISerializable
    {
        T GetParameter<T>(string name, T def);

        //DeviceUri ToUri();
    }
}
