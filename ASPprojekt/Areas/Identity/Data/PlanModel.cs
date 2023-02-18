using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPprojekt.Areas.Identity.Data
{
    public class PlanModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ShiftStart { get; set; }
        public int ShiftEnd { get; set; }
        [DataType(DataType.Date)]
        public DateTime ShiftDay { get; set; }
        [ForeignKey("ASPprojektUserId")]
        public virtual ASPprojektUser ASPprojektUser { get; set; }
    }

}
