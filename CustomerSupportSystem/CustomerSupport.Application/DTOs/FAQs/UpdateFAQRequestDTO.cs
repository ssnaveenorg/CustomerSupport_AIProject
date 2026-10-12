using System.ComponentModel.DataAnnotations;

namespace CustomerSupport.Application.DTOs.FAQs
{
    // Request model used when an Administrator updates an FAQ.
    public sealed class UpdateFAQRequestDTO
    {
        [Required]
        [StringLength(500, MinimumLength = 5)]
        public string Question { get; set; } = string.Empty;

        [Required]
        public string Answer { get; set; } = string.Empty;

        [Range(1, int.MaxValue)]
        public int? ProductId { get; set; }

        // Allows an Administrator to reactivate/deactivate the FAQ.
        public bool IsActive { get; set; }
    }
}
