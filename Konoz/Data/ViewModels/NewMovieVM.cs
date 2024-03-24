using Konoz.Data.Base;
using Konoz.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Konoz.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Movie Name")]
        [Required(ErrorMessage="Name is required")]
        
        public string Name { get; set; }

        [Display(Name = "Movie Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Movie Price")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Movie poster URL")]
        [Required(ErrorMessage = "Movie poster URL is required")]
        public string ImageUrl { get; set; }

        [Display(Name = "Movie Start Date")]
        [Required(ErrorMessage = "Start Date is required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Movie End Date")]
        [Required(ErrorMessage = "End Date is required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Movie category")]
        [Required(ErrorMessage = "Movie category is required")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        [Display(Name = "Slect actor(s)")]
        [Required(ErrorMessage = "Movie actor is required")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Slect a cinema")]
        [Required(ErrorMessage = "Movie cinema is required")]
        public int CinemaId { get; set; }

        [Display(Name = "Slect a producer")]
        [Required(ErrorMessage = "Movie producer is required")]
        public int ProducerId { get; set; }
    }
}
