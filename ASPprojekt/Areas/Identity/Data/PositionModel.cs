using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ASPprojekt.Areas.Identity.Data
{
    public class PositionModel
    {
        [Key]
        public string PositionName { get; set; }


        public List<ASPprojektUser> Users { get; set; }
    }
}
