using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace DAL
{
    static class DalTools
    {
        public static Mother clone(this Mother mother)
        {
            return new Mother
            {
                ID = mother.ID,
                FirstName = mother.FirstName,
                LastName = mother.LastName,
                WantedDays = mother.WantedDays.ToArray(),
                Address = mother.Address,
                Location = mother.Location,
                Days = mother.Days,
                CellPhone = mother.CellPhone
            };
        }
    }
}
