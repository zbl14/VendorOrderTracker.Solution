using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests // : IDisposable
  {
    // public void Dispose()
    // {
    //   ClassName.ClearAll();
    // }

    [TestMethod]
    public void VendorContructor_CreateInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Ben's Cafe", "Description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnName_Name()
    {
      string name = "Ben's Cafe";
      string description = "100 pastries";
      Vendor newVendor = new Vendor(name, description);
      string reslut = newVendor.Name;
      Assert.AreEqual(name, reslut);
    }
  }
}