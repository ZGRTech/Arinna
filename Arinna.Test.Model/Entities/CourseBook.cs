using Arinna.Data.Model;
using Arinna.Data.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Test.Model.Entities
{
    public class CourseBook: AuditableSoftDeletableEntity<int>
    {
        public string CourseBookName { get; set; }
        public int CourseId { get; set; }
        public bool IsActive { get; set; }
    }
}
