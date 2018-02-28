using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public interface IUserRoleBLL : IServiceBase<UserRole>
    {
        UserRole GetByRoleName(string roleName);
    }
}
