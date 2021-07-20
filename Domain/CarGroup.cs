using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class CarGroup
    {
        [Key]
        public int Id { get; set; }
        public int CarGrpCode { get; set; }
        public string CarGrpName { get; set; }
        public int IsActive { get; set; }
        public virtual ICollection<CarClass> CarClasses{get;set;}
    }
}
