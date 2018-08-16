using System.ComponentModel.DataAnnotations;

namespace TGXFExampleApp.Models
{
    public class SupermarketItems
    {
        [Key]
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Group { get; set; }
    }
}
