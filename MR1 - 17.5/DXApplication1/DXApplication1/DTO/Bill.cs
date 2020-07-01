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
    [Table("Bills")]
    public class Bill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [DefaultValue("0")]
        public int Discount { get; set; }
        [Required]
        public int Id_Table { get; set; }
        [Required]
        [Column("Date_Order", TypeName = "Date")]
        public DateTime Date_Order { get; set; }
        public DateTime Date_Pay { get; set; }
        [Required]
        [DefaultValue("false")]
        public bool Status { get; set; }
        [Required]
        public int Id_Employee { get; set; }
        [Required]
        [DefaultValue("false")]
        public bool Is_Deleted { get; set; }
        [ForeignKey("Id_Employee")]
        public virtual Employee Employee { get; set; }
        [ForeignKey("Id_Table")]


        public virtual Table Table { get; set; }
        public virtual ICollection<BillInfo> Items { get; set; }
    }
}
