using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TGXFExampleApp.Models
{
    public class SupermarketItems
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string ImageProduct
        {
            get
            {
                return Name.ToLower() + ".png";
            }            
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Group { get; set; }
    }
}
