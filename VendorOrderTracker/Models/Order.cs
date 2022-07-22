namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }

    public Order (string name, string title, string description, int price, string date)
    {
      Name = name;
      Title = title;
      Description = description;
      Price = price;
      Date = date;
    }
  }
}