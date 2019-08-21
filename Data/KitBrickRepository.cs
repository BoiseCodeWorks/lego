using System.Data;

namespace Lego.Data
{
  public class KitBrickRepository
  {
    private readonly IDbConnection _db;

    public KitBrickRepository(IDbConnection db)
    {
        _db = db;
    }
  }
}