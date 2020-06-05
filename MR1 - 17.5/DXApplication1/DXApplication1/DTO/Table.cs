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
    [Table("Tables")]
    public class Table
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength]
        [Column(TypeName = "nvarchar")]
        [Required]
        [Index(IsUnique = true)]
        public string Name { get; set; }
        [Required]
        [DefaultValue("false")]
        public bool Status { get; set; }
        [Required]
        [DefaultValue("false")]
        public bool Is_Deleted { get; set; }
        //public virtual Bill Bill { get; set; }
    }
}
