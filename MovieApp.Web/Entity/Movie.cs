using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace MovieApp.Web.Entity
{
	public class Movie
	{
		public int MovieId { get; set; }

		[Required]
		public string Title { get; set; }
		[MaxLength(100)]
		public string Description { get; set; }
		public string Director { get; set; }


		public string ImageUrl { get; set; }
		[Required]
		public int? GenreId { get; set; }
	}
}
