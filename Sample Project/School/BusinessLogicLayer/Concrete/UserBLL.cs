using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class UserBLL : IUserBLL
    {
        IUserDAL _userDAL;
        public UserBLL( IUserDAL userDAL)
        {
            _userDAL = userDAL;
        }

        public void Insert(Entities.User entity)
        {
            _userDAL.Add(entity);
        }

        public void Update(Entities.User entity)
        {
            _userDAL.Update(entity);
        }

        public void Delete(Entities.User entity)
        {
            _userDAL.Remove(entity);
        }

        public Entities.User GetById(int id)
        {
            return _userDAL.Get(x => x.UserID == id);
        }

        public ICollection<Entities.User> GetList()
        {
            return _userDAL.GetAll();
        }

        public User GetByEmailAndPassword(string email, string password)
        {
            return _userDAL.Get(a => a.EMail == email && a.Password == password);
        }


        public bool IsActivationCodeRight(Guid code, string email)
        {
            User checkUser = _userDAL.Get(a => a.ActivationCode == code && a.EMail == email);

            return checkUser != null;
        }
    }
}
