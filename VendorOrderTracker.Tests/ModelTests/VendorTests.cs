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
      Vendor newVendor = new Vendor("Ben", "Description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}