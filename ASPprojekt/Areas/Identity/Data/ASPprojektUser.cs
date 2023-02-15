using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ASPprojekt.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ASPprojektUser class
public class ASPprojektUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Pesel { get; set; }

    public virtual TypeModel? Type { get; set; }
    public IEnumerable<LocationModel> Location { get; set; }
    public virtual IEnumerable<PositionModel>? Position { get; set; }
    public virtual StatusModel? Status { get; set; }
}






