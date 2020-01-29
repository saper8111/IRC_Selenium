using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebIrcTests
{
    public class AWBData
    {
        private string awb_number;

        /* резерв для будущих параметров
         private string insurance_value;
         private string insurance_currency_code;

        */


        public AWBData(string awb_number)
        {
            this.awb_number = awb_number;
        }

        public string AWB_number { get; set; }

        /*  резерв для будущих параметров
            public string Insurance_value { get; set; }
            public string Insurance_currency_code { get; set; }

         */
    }
}
