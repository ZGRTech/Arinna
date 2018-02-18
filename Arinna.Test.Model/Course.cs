using Arinna.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Test.Model
{
    public class Course : BaseModel
    {
        public int CourseId { get; set; }

        public string CourseName { get; set; }

        public string CourseCode { get; set; }

        public int? TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
