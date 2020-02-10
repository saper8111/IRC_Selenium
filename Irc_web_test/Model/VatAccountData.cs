using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebIrcTests
{
   
   public class VatAccountData
    {
        private string account0;
        private string account20;


        public VatAccountData (string account0, string account20)
        {
            this.account0 = account0;
            this.account20 = account20;
        }

        public string Account0

        {
            get
            {
                return account0;
            }
            set
            {
                account0 = value;
            }
        }
            


        public string Account20
        {
            get
            {
                return account20;
            }
            set
            {
                account20 = value;
            }
        }
        

        
    }
   
}
