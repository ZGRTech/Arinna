using Arinna.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Test.Model
{
    public class Teacher : BaseModel
    {
        public int TeacherId { get; set; }

        public string TeacherName { get; set; }

        public string TeacherSurname { get; set; }


    }
}
