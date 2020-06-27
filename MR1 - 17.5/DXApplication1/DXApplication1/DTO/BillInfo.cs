using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DTO
{
    [Table("BillInfos")]
    public class BillInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]

        public int Id_Bill { get; set; }
        [Required]
    
        public int Id_Item { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        [DefaultValue("false")]
        public bool Is_Deleted { get; set; }
        [ForeignKey("Id_Bill")]
        public Bill Bill { get; set; }
        [ForeignKey("Id_Item")]
        public Item Item { get; set; }
      

       
 
    }
}
