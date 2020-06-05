﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DTO
{
    [Table("Items")]
    public class Item
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
        public int Id_Category { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        [DefaultValue("false")]
        public bool Is_Deleted { get; set; }

        [ForeignKey("Id_Category")]
        public virtual Category Category { get; set; }
        public virtual ICollection<BillInfo> Bills { get; set; }
    }
}
