using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PierresSweets.Models
{
  public class Treat
  {
    public Treat() 
    {
      this.TreatFlavor = new HashSet<TreatFlavor>();
    }

    public int TreatId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<TreatFlavor> TreatFlavor { get; }
  }
}