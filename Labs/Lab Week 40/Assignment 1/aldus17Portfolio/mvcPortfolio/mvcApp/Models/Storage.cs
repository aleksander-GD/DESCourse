using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mvcApp.Models
{
    public class Storage
    {
        public int StorageID { get; set; }

        public string StorageType { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime StorageDate { get; set; }

        public string StorageDescription { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal StorageValue { get; set; }

        public string Comment { get; set; }
    }
}
