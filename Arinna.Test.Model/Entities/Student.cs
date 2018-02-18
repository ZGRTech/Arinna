using Arinna.Data.Model;
using Arinna.Data.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Test.Model.Entities
{
    public class Student : AuditableSoftDeletableEntity<int>
    {
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
    }
}
