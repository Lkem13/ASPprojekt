using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ASPprojekt.Areas.Identity.Data
{
    public class LocationModel
    {
        [Key]
        public int LocationId { get; set; }
        [NotNull]
        public string Town { get; set; }
        [NotNull]
        public string Street { get; set; }
        [NotNull]
        public string ZipCode { get; set; }

        public List<ASPprojektUser> Users { get; set; }
    }
}
