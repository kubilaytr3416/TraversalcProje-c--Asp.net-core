using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Destination
	{
		[Key]
		public int DestinationID { get; set; }
		public String City { get; set; }
		public string DayNight { get; set; }
		public double Price { get; set; }
		public string Image { get; set; }
		public int Capacity { get; set; }
		public string Description { get; set; }
		public bool Status { get; set; }
		public string CoverImage { get; set; }
		public String Details1  { get; set; }
		public String Details2 { get; set;}
		public String Image2 { get; set;}

		public List<Comment>Comments { get; set; }
		public List<Reservation> Reservations { get; set; }



	}
}
