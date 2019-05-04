using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Smart.EF.BLL.Managers;
using UI.Smart.EF.Model;

namespace UI.Smart.EF.BLL
{
    public class UnitOfWork
    {
        private static LAB1Entities context = new LAB1Entities();
        private static UnitOfWork unitofWork;
        private UnitOfWork()
        {

        }

        public static UnitOfWork Create()
        {
            if (unitofWork == null)
            {
                unitofWork = new UnitOfWork();
            }
            return unitofWork;
        }
        public FacManager FacManager {
            get
            {
                return new FacManager(context);
            }
            
        }
        public UniManger UniManager
        {
            get
            {
                return new UniManger(context);
            }

        }
    }
}
