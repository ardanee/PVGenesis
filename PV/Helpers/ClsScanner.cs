using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WIA;

namespace PV 
{
    public class ClsScanner
    {
        
        private readonly DeviceInfo _deviceInfo;

        public ClsScanner(DeviceInfo deviceInfo)
        {
            this._deviceInfo = deviceInfo;
        }

        public ImageFile Scan()
        {
            try
            {
                var device = this._deviceInfo.Connect();
                var item = device.Items[1];
                var imageFile = (ImageFile)item.Transfer("{B96B3CAE-0728-11D3-9D7B-0000F81EF32E}");
                return imageFile;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override string ToString()
        {
            return this._deviceInfo.Properties["Name"].get_Value().ToString();
        }
    }
}

