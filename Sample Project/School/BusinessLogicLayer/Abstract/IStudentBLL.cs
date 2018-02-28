using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public interface IStudentBLL : IServiceBase<Student>
    {
        ICollection<Student> GetStudentsByClassroom(int classroomID);
    }
}
