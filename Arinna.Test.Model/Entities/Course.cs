using Arinna.Data.Model;
using Arinna.Data.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Test.Model.Entities
{
    public class Course : AuditableSoftDeletableEntity<int>
    {
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int TeacherId { get; set; }
        public bool IsActive { get; set; }
    }
}
