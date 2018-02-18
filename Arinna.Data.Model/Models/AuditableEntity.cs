using Arinna.Data.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arinna.Data.Model.Models
{
    public class AuditableEntity<TIdType> : BaseEntity<TIdType>, IAuditableEntity
    {
        [ScaffoldColumn(false)]
        public int? CreatedBy { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? CreatedDate { get; set; }

        [ScaffoldColumn(false)]
        public int? UpdatedBy { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? UpdatedDate { get; set; }
    }
}
