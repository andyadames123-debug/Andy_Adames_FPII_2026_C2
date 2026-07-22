using LiteDB;

namespace RiskManagement.App.Models;

public class Risk
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string ProjectName { get; set; } = string.Empty;
    public Guid AreaId { get; set; } = Guid.Empty;
    public string EvaluatorUser { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    // Criterios MOSLER (1-5)
    public int Funcion { get; set; } = 1;
    public int Sustitucion { get; set; } = 1;
    public int Profundidad { get; set; } = 1;
    public int Extension { get; set; } = 1;
    public int Agresion { get; set; } = 1;
    public int Vulnerabilidad { get; set; } = 1;

    // Calculos MOSLER
    [BsonIgnore] public double I => Funcion * Sustitucion;
    [BsonIgnore] public double D => Profundidad * Extension;
    [BsonIgnore] public double C => I + D;
    [BsonIgnore] public double PR => Agresion * Vulnerabilidad;
    [BsonIgnore] public double ER => C * PR;

    [BsonIgnore]
    public string RiskLevel => ER switch
    {
        <= 20 => "Bajo",
        <= 40 => "Medio",
        <= 60 => "Alto",
        _ => "Muy Alto"
    };

    public DateTime CreatedAt { get; set; } = DateTime.Now;
}
