using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }    
    
    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Title", "Description", 5, "July 22nd, 2022");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    
    [TestMethod]
    public void GetPrice_ReturnPrice_Price()
    {
      int price = 5;
      Order newOrder = new Order("Title", "Description", price, "July 22nd, 2022");
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }
    
    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      Order newOrder = new Order("Title", "Description", 5, "July 22nd, 2022");
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      Order newOrder1 = new Order("Title", "Description", 5, "July 22nd, 2022");
      Order newOrder2 = new Order("Title", "Description", 10, "July 22nd, 2022");
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }

  }
}