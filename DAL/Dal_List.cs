using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    internal class Dal_List :IDal
    {
        public int addMother(Mother m)
        {
           DS.DataSource.Mothers.Add(m);
            return m.ID;
        }

        public bool removeMother(Mother m)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Mother> getAllMothers()
        {
            List<Mother> mothers = new List<Mother>();
            foreach (var m in DS.DataSource.Mothers)
            {
                mothers.Add(m.clone());
            }
            return mothers.AsEnumerable();
        }
    }
}
