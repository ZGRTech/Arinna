using Arinna.Data.Model;
using Arinna.Data.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Test.Model.Entities
{
    public class Teacher: AuditableSoftDeletableEntity<int>
    {
        public string TeacherName { get; set; }

        public string TeacherSurname { get; set; }

        public int TeacherBranch { get; set; }

        public bool IsActive { get; set; }
    }
}
