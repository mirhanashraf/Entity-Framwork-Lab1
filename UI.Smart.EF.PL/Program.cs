using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Smart.EF.BLL;
using UI.Smart.EF.BLL.Managers;
using UI.Smart.EF.Model;

namespace UI.Smart.EF.PL
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unit = UnitOfWork.Create();
            unit.UniManager.Add(new Uni { Name="Ain Shams" });
            //FacManager facManager = new FacManager(new LAB1Entities());
            //UniManger uniManager = new UniManger(new LAB1Entities());
        }
    }
}
