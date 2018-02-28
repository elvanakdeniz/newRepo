using DataAccessLayer.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IOC.Ninject
{
    public class DALModule : NinjectModule
    {
        public override void Load()
        {
            //Bind<DbContext>().To<SchoolDBContext>().InSingletonScope();
        }
    }
}
