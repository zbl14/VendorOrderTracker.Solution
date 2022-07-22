using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

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

    [TestMethod]
    public void GetAll_ReturnListOfVendors_List()
    {
      string name1 = "Ben's Cafe";
      string name2 = "Suzie's Cafe";
      string description = "100 pastries";
      Vendor newVendor1 = new Vendor(name1, description);
      Vendor newVendor2 = new Vendor(name2, description);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> reslut = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, reslut);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name1 = "Ben's Cafe";
      string name2 = "Suzie's Cafe";
      Vendor newVendor1 = new Vendor(name1);
      Vendor newVendor2 = new Vendor(name2);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      Order newOrder = new Order("Title", "Description", 5, "July 22nd, 2022");
      List<Order> newList = new List<Order> { newOrder };
      string name = "Ben's Cafe";
      Vendor newVendor = new Vendor(name);
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }    
  }
}