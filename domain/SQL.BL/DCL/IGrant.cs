using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql.BL.DCL
{
   public interface IGrant
    {
        void GRANT(User user);
    }
}
