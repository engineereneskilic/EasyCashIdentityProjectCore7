using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class CustomerAccount
    {
        public int CustomerAccountID { get; set; }
        
        public int CustomerAccountNumber { get; set; } // 7 karakterli tamamen random olsun

        public string CustomerAccountCurrency { get; set; } // döviz bilgisi

        public decimal CustomerAccountBalance { get; set; }
        
        public string BankBranch { get; set; }
    }
}
