using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            Console.WriteLine("ma ata rotze vreech");
            try
            {
                option = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("kuku was here");
                throw e;
            }

            switch (option)
            {
                case 1:
                    addMother();
                    break;
            }
         }

        private static void addMother()
        {
            Mother imma = new Mother
            {
                ID = 37,
                FirstName = "Mamme",
                LastName = "Sheli",
                Address = "Ha-Va'ad ha-Le'umi St 21, Jerusalem",
                Location = "Mal'akhi St 16, Bnei Brak",
                CellPhone = "052222222",
                WantedDays = new bool[6] { true, true, true, true, true, false },
                Days = new List<Day>(6)
                {
                    new Day {  StartDay = new Time(7), EndDay = new Time(16)},
                    new Day {  StartDay = new Time(8), EndDay = new Time(16)},
                    new Day {  StartDay = new Time(7,30), EndDay = new Time(13)},
                    new Day {  StartDay = new Time(8), EndDay = new Time(16)},
                    new Day {  StartDay = new Time(8), EndDay = new Time(17)},
                    new Day {  StartDay = new Time(), EndDay = new Time(0)},
                }
            };
            BL.FactorySingletonBL.getInstance.addMother(imma);
            List<Mother> immaot = BL.FactorySingletonBL.getInstance.getAllMothers();
            foreach (var m in immaot)
            {
                Console.WriteLine(m);
            }
            Console.ReadLine();
        }

    }
}
