using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebIrcTests
{
    public class AwbData
    {
        private string awb_number;

        public AwbData(string awb_number)
        {
            this.awb_number = awb_number;
        }

        public string Awb_number
        {
            get
            {
                return awb_number;
            }
            private set
            {
                awb_number = value;
            }
        }
    }
}
