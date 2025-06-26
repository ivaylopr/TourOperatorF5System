using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TourOperatorF5System.Infrastructure.Constants.DataConstants;

namespace TourOperatorF5System.Infrastructure.Data.Models
{
    public class Vacation
    {
        [Comment("Vacation identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Vacation title")]
        [Required]
        [MaxLength(VacationTitleMaxLenght)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(VacationInfoMaxLenght)]
        public string VacationInfo { get; set; } = string.Empty;

        [Comment("Start date of the vacation")]
        [Required]
        public DateTime StartDate { get; set; }

        [Comment("End date of the vacation")]
        [Required]
        public DateTime EndDate { get; set; }

        [Comment("Capacity for the vacation")]
        [Required]
        public int VacationCapacity { get; set; }

        [Comment("Hotel of the vacation")]
        [Required]
        public Hotel Hotel { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Hotel))]
        public int HotelId { get; set; }
        [Comment("Agent responsible for the vacation")]
        [Required]
        public Agent Agent { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Agent))]
        public int AgentId { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }

        public ICollection<Customer> Custromenrs { get; set; } = new List<Customer>();

    }
}
