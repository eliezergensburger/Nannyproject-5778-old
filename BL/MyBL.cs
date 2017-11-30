using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BL
{
    public class MyBL:Ibl
    {
        public int addMother(Mother m)
        {
            IDal dal = DAL.FactorysingletonDal.getInstance;
            return dal.addMother(m);
        }

        public bool removeMother(Mother m)
        {
            throw new NotImplementedException();
        }

        public List<Mother> getAllMothers()
        {
            IDal dal = DAL.FactorysingletonDal.getInstance;
            return dal.getAllMothers().ToList();
        }
    }
}
