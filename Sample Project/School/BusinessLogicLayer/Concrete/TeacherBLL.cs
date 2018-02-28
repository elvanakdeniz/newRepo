using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class TeacherBLL : ITeacherBLL
    {
        ITeacherDAL _teacherDAL;
        public TeacherBLL(ITeacherDAL teacherDAL)
        {
            _teacherDAL = teacherDAL;
        }
        public void Insert(Entities.Teacher entity)
        {
            _teacherDAL.Add(entity);
        }

        public void Update(Entities.Teacher entity)
        {
            _teacherDAL.Update(entity);
        }

        public void Delete(Entities.Teacher entity)
        {
            _teacherDAL.Remove(entity);
        }

        public Entities.Teacher GetById(int id)
        {
            return _teacherDAL.Get(a => a.TeacherID == id);
        }

        public ICollection<Entities.Teacher> GetList()
        {
            return _teacherDAL.GetAll();
        }
    }
}
