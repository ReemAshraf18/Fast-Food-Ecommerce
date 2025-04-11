using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SubCategory
    {
        [Required]
        public string Titel { get; set; }
        [Key]
        public int Id { get; set; }
        //[ForeignKey]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Item> Items { get; set; }
    }

}
