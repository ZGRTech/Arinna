using Arinna.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Test.Model
{
    public class Student : BaseModel
    {
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public string StudentSurname { get; set; }

        public int? AccommodationId { get; set; }

        public virtual Accommodation Accommodation { get; set; }

        public virtual StudentDetail StudentDetail { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
