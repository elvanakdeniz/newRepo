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
    public class ClassroomBLL : IClassroomBLL
    {
        IClassroomDAL _classroomDAL;
        public ClassroomBLL(IClassroomDAL classroomDAL)
        {
            _classroomDAL = classroomDAL;
        }

        public void Insert(Classroom entity)
        {
            _classroomDAL.Add(entity);
        }

        public void Update(Classroom entity)
        {
            _classroomDAL.Update(entity);
        }

        public void Delete(Classroom entity)
        {
            _classroomDAL.Remove(entity);
        }

        public Classroom GetById(int id)
        {
            return _classroomDAL.Get(a=>a.ClassroomID == id);
        }

        public System.Collections.Generic.ICollection<Entities.Classroom> GetList()
        {
            return _classroomDAL.GetAll();
        }
    }
}
