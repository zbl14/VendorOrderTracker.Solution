using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests 
  {
    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Ben", "Title", "Description", 5, "July 22nd, 2022");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    
    [TestMethod]
    public void GetPrice_ReturnPrice_Price()
    {
      int price = 5;
      Order newOrder = new Order("Ben", "Title", "Description", price, "July 22nd, 2022");
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }
  }
}