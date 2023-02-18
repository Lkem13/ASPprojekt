using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPprojekt.Areas.Identity.Data
{

    public class PositionModel
    {
        [Key]
        public int PositionId { get; set; }
        [Required]
        public string PositionName { get; set; }

        public ICollection<ASPprojektUser> Users { get; set; }
    }
}
