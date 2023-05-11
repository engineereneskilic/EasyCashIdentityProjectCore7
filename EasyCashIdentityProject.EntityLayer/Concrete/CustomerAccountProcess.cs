using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class CustomerAccountProcess // Customer Account işlem logları   -  para yatırma 5 lira - para gönderme 100 lira - eft 5 lira
    {
        public int CustomerAccountProcessID { get; set; }
        
        public string ProcessType { get; set; }

        public decimal Amount { get; set; }

        public DateTime ProcessDate { get; set; }

        // appuser1
        // appuser2
    }
}
