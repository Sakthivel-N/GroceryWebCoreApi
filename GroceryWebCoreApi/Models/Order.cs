using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryWebCoreApi.Models
{
    public class Order
    {
		[Key]
		public int OrderId { get; set; }

		
		[Required]
		public int UserId { get; set; }
		public virtual User User { get; set; }
		

		[Required]
		public string CartIdList { get; set; }


		[Required, MaxLength(20)]
		public string PaymentMode { get; set; }

		[Required, MaxLength(20)]
		public string OrderDate { get; set; }

		[Required]
		public int TotalValue { get; set; }

		
	}
}
