using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace LePlug.Models
{
	public class Product
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[Display(Name = "Product Name")]
		public string ProductName { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		public string Manufacturer { get; set; }
		[Required]
		[Display(Name ="List Price")]
		[Range(1,100000000)]
		public double ListPrice { get; set; }


		[Required]
		[Display(Name = "Price for 1-50")]
		[Range(1, 100000000)]
		public double Price { get; set; }



		[Required]
		[Display(Name = "Price for 50+")]
		[Range(1, 100000000)]
		public double Price50 { get; set; }


		[Required]
		[Display(Name = "Price for 100+")]
		[Range(1, 100000000)]
		public double Price100 { get; set; }

		public int CategoryId { get; set; }
		[ForeignKey("CategoryId")]
		[ValidateNever]
		public Category Category { get; set; }
		[ValidateNever]
		public string ImageUrl { get; set; }
	}
}
