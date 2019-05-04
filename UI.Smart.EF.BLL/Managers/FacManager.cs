using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Smart.EF.Model;
using UI.Smart.EF.Repository;

namespace UI.Smart.EF.BLL.Managers
{
    public class FacManager : Repository<Fac, LAB1Entities>
    {
        public FacManager(LAB1Entities context) : base(context)
        {
        }
    }
}
