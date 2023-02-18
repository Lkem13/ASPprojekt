using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ASPprojekt.Areas.Identity.Data
{
    public enum StatusType
    {
        Pending,
        Approved
    }

    public class StatusModel
    {
        [Key]
        public int StatusID { get; set; }
        [Required]
        public StatusType statusType { get; set; }
    }
}
