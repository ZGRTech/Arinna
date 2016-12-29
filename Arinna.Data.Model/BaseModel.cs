using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Data.Model
{
    public abstract class BaseModel
    {
        [NotMapped]
        private ObjectState objectState = ObjectState.Unchanged;

        [NotMapped]
        public ObjectState ObjectState
        {
            get { return objectState; }
            set { objectState = value; }
        }

        public DateTime? CreateDate { get; set; }

        public DateTime? ChangeDate { get; set; }
    }
}
