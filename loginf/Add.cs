using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win1.loginf
{
    internal class Add
    {
        public int number { get; set; }   
        public DateTime date { get; set; }

        public int invnumber { get; set; }

        public string objname{ get; set; }

        public int count { get; set; }

        public double price { get; set; }
        public string save()
        {
             return $"Item Has been Saved:\n{objname}\n{price}\n{count}";
        }
    }
}
