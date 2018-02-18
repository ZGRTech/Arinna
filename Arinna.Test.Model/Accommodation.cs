using Arinna.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Test.Model
{
    public class Accommodation : BaseModel
    {
        public int AccommodationId { get; set; }

        public string AccommodationName { get; set; }

        public string AccommodationDescription { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
