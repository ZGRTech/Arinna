using Arinna.Data.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Data.Model.Models
{
<<<<<<< HEAD:Arinna.Data.Model/Models/BaseEntity.cs
    public abstract class BaseEntity<TIdType> : IBaseEntity, IEntity<TIdType>
=======
    public abstract class BaseModel : IBaseModel,IEntityObjectState
>>>>>>> origin/master:Arinna.Data.Model/BaseModel.cs
    {
        [NotMapped]
        private EntityObjectState objectState = EntityObjectState.Unchanged;

        [NotMapped]
        public EntityObjectState ObjectState
        {
            get { return objectState; }
            set { objectState = value; }
        }

        public virtual TIdType Id { get; set; }
    }
}
