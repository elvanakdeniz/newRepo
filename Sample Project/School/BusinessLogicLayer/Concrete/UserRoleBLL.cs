using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class UserRoleBLL : IUserRoleBLL
    {
        private readonly IUserRoleDAL _userRoleDAL;

        public UserRoleBLL(IUserRoleDAL userRoleDAL)
        {
            _userRoleDAL = userRoleDAL;
        }

        public void Insert(Entities.UserRole entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Entities.UserRole entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Entities.UserRole entity)
        {
            throw new NotImplementedException();
        }

        public Entities.UserRole GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Entities.UserRole> GetList()
        {
            throw new NotImplementedException();
        }

        public Entities.UserRole GetByRoleName(string roleName)
        {
            return _userRoleDAL.Get(a => a.RoleName == roleName);
        }
    }
}
