using Arinna.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Test.Model
{
    public class StudentDetail : BaseModel
    {
        public int StudentId { get; set; }

        public string ContactAddress { get; set; }

        public string ContactPhoneNumber { get; set; }

        public string ContactEmail { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public virtual Student Student { get; set; }
    }
}
