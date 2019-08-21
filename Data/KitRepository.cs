using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using Lego.Models;

namespace Lego.Data
{
  public class KitRepository
  {
    private readonly IDbConnection _db;
    //NOTE DEPENDENCY INJECTION
    public KitRepository(IDbConnection db)
    {
      _db = db;
    }

    public Kit GetKit(int kitId)
    {
      try
      {
        return _db.QueryFirst<Kit>("SELECT * FROM kits WHERE id = @kitId", new { kitId });
      }
      catch (Exception)
      {
        throw new Exception("No kits found at id " + kitId);
      }
    }

    public Kit CreateKit(Kit kitData)
    {
      //NOTE Order matters here Insert is the column names
      //VALUES are the properties found on the 
      //  object passed as the second parameter
      var id = _db.ExecuteScalar<int>(@"
        INSERT INTO kits (name, instructions, price)
        VALUES (@Name, @Instructions, @Price);
        SELECT LAST_INSERT_ID();
      ", kitData);
      kitData.Id = id;
      return kitData;
    }

    public void DeleteKit(int kitId)
    {
      var success = _db.Execute("DELETE FROM kits WHERE id = @kitId", new { kitId });
      if (success != 1)
      {
        throw new Exception("Delete Failed");
      }
    }

    public IEnumerable<KitPart> IDONTBELONGHERE()
    {
      var parts =_db.Query<KitPart>(@"
      SELECT *, b.name AS brickName FROM kitbricks kb
      JOIN bricks b ON b.id = kb.brickId
      JOIN kits k ON k.id = kb.kitId
      WHERE kb.kitId = 1;
      ");
      return parts;
    }

  }
}