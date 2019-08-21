namespace Lego.Models
{
  public class KitBrick
  {
    public int Id { get; set; }

    public int KitId { get; set; }
    public int BrickId { get; set; }
    public int Quantity { get; set; }
  }

  //NOTE VIEWMODEL probably not actually necessary
  public class KitPart : KitBrick
  {
    public string KitName { get; set; }
    public string BrickName { get; set; }
    public decimal Price { get; set; }

  }

}