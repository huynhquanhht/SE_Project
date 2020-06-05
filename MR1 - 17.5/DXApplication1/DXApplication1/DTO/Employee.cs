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
    [Table("Employees")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength]
        [Column(TypeName = "nvarchar")]
        [Required]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime Birthday { get; set; }
        [MaxLength]
        [Column(TypeName = "nvarchar")]
        [Required]
        public string Address { get; set; }
        [Required]
        public int Id_Account { get; set; }
        [Required]
        [DefaultValue("false")]
        public bool Is_Deleted { get; set; }
        [ForeignKey("Id_Account")]
        public virtual Account Account { get; set; }
        //public virtual Bill Bill { get; set; }
    }
}
