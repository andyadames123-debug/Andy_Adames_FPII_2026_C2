using RiskManagement.App.Data;
using RiskManagement.App.Models;

namespace RiskManagement.App.Repositories;

public class AreaRepository
{
    private readonly LiteDbContext _context;

    public AreaRepository()
    {
        _context = LiteDbContext.Instance;
    }

    public List<Area> GetAll()
    {
        return _context.Areas.FindAll().ToList();
    }

    public Area? GetById(Guid id)
    {
        return _context.Areas.FindById(id);
    }

    public void Insert(Area area)
    {
        _context.Areas.Insert(area);
    }

    public void Update(Area area)
    {
        _context.Areas.Update(area);
    }

    public bool Delete(Guid id)
    {
        return _context.Areas.Delete(id);
    }
}
