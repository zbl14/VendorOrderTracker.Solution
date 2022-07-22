using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders { get; set; }
    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Orders = new List<Order> {};
      _instances.Add(this);
    }
  
    public static List<Vendor> GetAll()
    {
      return _instances;
    }
  }
}