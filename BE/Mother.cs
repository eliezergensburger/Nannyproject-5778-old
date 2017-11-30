using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Mother:Person
    {
        private int[,] shaot;

        public string CellPhone { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public bool[] WantedDays { get; set; }
        public List<Day> Days { get; set; }
        //public int[,] Shaot
        //{
        //    get => shaot;
        //    set
        //    {
        //        if (value.Length == 12)
        //        {
        //            shaot = value;
        //        }
        //    }
        //}

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
