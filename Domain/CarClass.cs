using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class CarClass
    {
        [Key]
        public int Id { get; set; }
        
        public int CarClassCode { get; set; }

        [ForeignKey("CarGroup")]
        public int CarGrpId { get; set; } 


        public string CarClassName { get; set; }

        public int IsActive { get; set; }    

        public virtual CarGroup CarGroup{get;set;}

    }
}
