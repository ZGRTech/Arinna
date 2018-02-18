using Arinna.Data.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Data.Model.Models
{
    public abstract class BaseEntity<TIdType> : IBaseEntity, IEntity<TIdType>
    {
        [NotMapped]
        private ObjectState objectState = ObjectState.Unchanged;

        [NotMapped]
        public ObjectState ObjectState
        {
            get { return objectState; }
            set { objectState = value; }
        }

        public virtual TIdType Id { get; set; }
    }
}
