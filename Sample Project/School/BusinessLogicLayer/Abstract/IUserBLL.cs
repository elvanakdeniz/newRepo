using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public interface IUserBLL : IServiceBase<User>
    {
        User GetByEmailAndPassword(string email, string password);
        bool IsActivationCodeRight(Guid code, string email);
    }
}
