namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }

    public Order (string Title, string Description, int Price, string Date)
    {

    }
  }
}