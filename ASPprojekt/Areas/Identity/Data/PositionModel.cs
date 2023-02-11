using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ASPprojekt.Areas.Identity.Data
{
    public class PositionModel
    {
        [Key]
        public int PositionId { get; set; }
        [NotNull]
        public string PositionName { get; set; }


        public List<ASPprojektUser> Users { get; set; }
    }
}
