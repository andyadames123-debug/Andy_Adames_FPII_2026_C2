using LiteDB;
using RiskManagement.App.Models;

namespace RiskManagement.App.Data;

public class LiteDbContext : IDisposable
{
    private static LiteDbContext? _instance;
    private static readonly object _lock = new();
    private readonly LiteDatabase _db;

    private LiteDbContext()
    {
        var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RiskManagement.db");
        _db = new LiteDatabase(dbPath);
    }

    public static LiteDbContext Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance ??= new LiteDbContext();
                }
            }
            return _instance;
        }
    }

    public ILiteCollection<Area> Areas => _db.GetCollection<Area>("areas");
    public ILiteCollection<Risk> Risks => _db.GetCollection<Risk>("risks");

    public void Dispose()
    {
        _db?.Dispose();
        _instance = null;
    }
}
