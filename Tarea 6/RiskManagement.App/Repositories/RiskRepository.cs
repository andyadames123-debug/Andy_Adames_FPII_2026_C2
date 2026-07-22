using RiskManagement.App.Data;
using RiskManagement.App.Models;

namespace RiskManagement.App.Repositories;

public class RiskRepository
{
    private readonly LiteDbContext _context;

    public RiskRepository()
    {
        _context = LiteDbContext.Instance;
    }

    public List<Risk> GetAll()
    {
        return _context.Risks.FindAll().ToList();
    }

    public List<Risk> GetByAreaId(Guid areaId)
    {
        return _context.Risks.Find(r => r.AreaId == areaId).ToList();
    }

    public List<Risk> GetByRiskLevel(string level)
    {
        return _context.Risks.Find(r => r.RiskLevel == level).ToList();
    }

    public Risk? GetById(Guid id)
    {
        return _context.Risks.FindById(id);
    }

    public void Insert(Risk risk)
    {
        _context.Risks.Insert(risk);
    }

    public void Update(Risk risk)
    {
        _context.Risks.Update(risk);
    }

    public bool Delete(Guid id)
    {
        return _context.Risks.Delete(id);
    }
}
