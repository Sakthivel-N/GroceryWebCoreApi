using System.ComponentModel.DataAnnotations;

namespace GroceryWebCoreApi.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required,MaxLength(20)]
		public string CategoryName { get; set; }

        
        
    }
}
