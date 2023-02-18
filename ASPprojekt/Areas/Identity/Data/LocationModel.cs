using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ASPprojekt.Areas.Identity.Data
{
    public class LocationModel
    {
        [Key]
        public int LocationId { get; set; }
        [NotNull]
        public string Town { get; set; } = "Brak";
        [NotNull]
        public string Street { get; set; } = "Brak";


    }
}
