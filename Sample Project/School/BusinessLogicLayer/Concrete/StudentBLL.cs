using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class StudentBLL : IStudentBLL
    {
        IStudentDAL _studentDAL;
        public StudentBLL(IStudentDAL studentDAL)
        {
            _studentDAL = studentDAL;
        }
        
        public void Insert(Student entity)
        {
            _studentDAL.Add(entity);
        }

        public void Update(Student entity)
        {
            _studentDAL.Update(entity);
        }

        public void Delete(Student entity)
        {
            _studentDAL.Remove(entity);
        }

        public Student GetById(int id)
        {
            return _studentDAL.Get(a => a.StudentID == id);
        }

        public ICollection<Student> GetList()
        {
            return _studentDAL.GetAll();
        }

        public ICollection<Student> GetStudentsByClassroom(int classroomID)
        {
            return _studentDAL.GetAll(a => a.ClassroomID == classroomID);
        }
    }
}
