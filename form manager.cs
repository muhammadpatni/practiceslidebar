using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace practiceslidebar
{
    public static class form_manager
    {
        public static login mainforminstance { get; set; }
        public static login2 employeelogin { get; set; }
        public static ownerInventory ownerInventory { get; set; } 
        public static admininventory adminInventory { get; set; }
        public static adminview adminview { get; set; }
        public static messagebox messagebox { get; set; }   
        public static adminempolyee adminempolyee { get; set; }
        public static employeebill employeebill { get; set;}



    }
}
