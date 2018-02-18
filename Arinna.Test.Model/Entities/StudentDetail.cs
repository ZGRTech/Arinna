using Arinna.Data.Model;
using Arinna.Data.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Test.Model.Entities
{
    public class StudentDetail : BaseEntity<int>
    {
        public string ContactAdress { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string ContactEmail { get; set; }
    }
}
