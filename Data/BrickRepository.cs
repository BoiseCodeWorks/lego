using System.Data;

namespace Lego.Data
{
  public class BrickRepository
  {
    private readonly IDbConnection _db;

    public BrickRepository(IDbConnection db)
    {
        _db = db;
    }
  }

}