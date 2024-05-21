using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDemo.Models
{
    [Table("product")]
    public class Product
    {

        [Key]
       public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price {  get; set; }

    }
}
