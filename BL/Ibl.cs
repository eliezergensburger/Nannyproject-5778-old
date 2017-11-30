using System.Collections.Generic;
using BE;

namespace BL
{
    public interface Ibl
    {
        int addMother(Mother m);
        bool removeMother(Mother m);
        List<Mother> getAllMothers();
    }
}