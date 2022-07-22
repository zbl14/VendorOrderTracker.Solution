using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders { get; set; }
    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor(string name)
    {
      Name = name;
      Orders = new List<Order> {};
      _instances.Add(this);
    }

    public Vendor (string name, string description) : this (name)
    {
      Description = description;
    }

    // public static Vendor Find(int searchId)
    // {
    //   int index;
    //   for
    // }
  
    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}