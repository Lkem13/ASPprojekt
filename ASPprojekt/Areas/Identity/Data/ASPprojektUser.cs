using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ASPprojekt.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ASPprojektUser class
public class ASPprojektUser : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Pesel { get; set; }


    [ForeignKey("LocationModel")]
    public  LocationModel? Location { get; set; }
    [ForeignKey("PositionModel")]
    public PositionModel? Position { get; set; }
    [ForeignKey("StatusModel")]
    public  StatusType? Status { get; set; }
}






