using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentPayment
{
 
        public class User
        {

            public string? Password { get; set; }
            public string? Name { get; set; }
            public decimal Balance { get; set; }
            public string? Account { get; set; }
            
            public string? Product { get; set; }
            public int Initial { get; set; }
        }



  
}
