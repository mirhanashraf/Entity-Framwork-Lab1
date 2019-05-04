using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Smart.EF.Model;
using UI.Smart.EF.Repository;

namespace UI.Smart.EF.BLL.Managers
{
    public class UniManger : Repository<Uni, LAB1Entities>
    {
        public UniManger(LAB1Entities context) : base(context)
        {
        }
    }
}
