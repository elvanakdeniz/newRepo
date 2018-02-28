using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework.DAL;
using DataAccessLayer.IOC.Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IOC.Ninject
{
    public class BLLModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IUserDAL>().To<UserDAL>();
            this.Bind<ITeacherDAL>().To<TeacherDAL>();
            this.Bind<IUserRoleDAL>().To<UserRoleDAL>();

            List<INinjectModule> moduleList = new List<INinjectModule>();
            moduleList.Add(new DALModule());

            Kernel.Load(moduleList);
        }
    }
}
