using System.ComponentModel.DataAnnotations;

namespace EstateApp.Web.Models
{
    public class PropertyModel
    {
        [Required]
        public string Title { get; set;} //# 3 bedroom flat in Abule Egba 
        public string ImageUrl { get; set; }
        
        [Required]
        public double Price { get; set;} 

        [Required]
        public string Description { get; set; }

        [Required]
        public int NumberOfRooms { get; set; }

        [Required]
        public int NumberOfBaths { get; set; }

        [Required]
        public int  NumberOfToilets { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string ContactPhoneNumber { get; set; } 
    }
}