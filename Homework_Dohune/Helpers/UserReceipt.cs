using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Dohune.Helpers
{
    public class UserReceipt
    {
        public string whereEat { get; set; }
        public List<Buger> bugerList { get; set; }
        public List<string> dessert { get; set; }
        public List<string> drink { get; set; }
        public int price { get; set; }
    }
}
