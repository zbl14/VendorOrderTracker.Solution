using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders { get; set; }

    public Vendor(string name, string description)
    {

    }
  
  }
}