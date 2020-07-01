using DXApplication1.DTO;
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
    [Table("Accounts")]
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength]
        [Column(TypeName = "nvarchar")]
        [Required]
        [Index(IsUnique = true)]
        public string Username { get; set; }
        [MaxLength]
        [Column(TypeName = "nvarchar")]
        [Required]
        public string Password { get; set; }
        [Required]
        public int Id_Employee { get; set; }
        [Required]
        public int Id_Type { get; set; }
        [ForeignKey("Id_Type")]
        public virtual TypeAccount TypeAccount { get; set; }
        [ForeignKey("Id_Employee")]
        public virtual Employee Employee { get; set; }
    }
}
