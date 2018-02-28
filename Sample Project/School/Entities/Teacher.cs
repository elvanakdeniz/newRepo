using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Teacher : IEntity
    {
        public Teacher()
        {
            Classrooms = new HashSet<Classroom>();
        }

        public int TeacherID { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Classroom> Classrooms { get; set; }
    }
}
