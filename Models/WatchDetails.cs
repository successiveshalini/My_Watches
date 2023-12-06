using System.ComponentModel.DataAnnotations;

namespace MyWatch.Models
{
    public class WatchDetails
    {
        [Key]
        public int WatchId { get; set; }
        [Required]
        public string? WatchName { get; set; }
        [Required]
        public string? WatchModel { get; set; }
        [Required]
        public decimal WatchPrice { get; set; }
        [Required]  
        public string? WatchColor { get; set;}



    }
}
