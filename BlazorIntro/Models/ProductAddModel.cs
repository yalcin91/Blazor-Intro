using System.ComponentModel.DataAnnotations;

namespace BlazorIntro.Models
{
    public class ProductAddModel
    {
        [Required(ErrorMessage ="Product naam is verplicht")]
        [StringLength(20, ErrorMessage ="Product naam is te lang! (Max 20")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Product informatie is verplicht")]
        [StringLength(40, ErrorMessage = "Product informatie is te lang! (Max 40")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Product category is verplicht")]
        public string CategoryId { get; set; }
    }
}
