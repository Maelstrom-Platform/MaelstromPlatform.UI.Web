namespace MaelstromPlatform.UI.Components.Services.Iteration;

public class IterationModel
{
    public Guid SysId { get; set; }

    public string? Identifier { get; set; }

    public string? Name { get; set; }
    public string? CodeName { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Frequency { get; set; }
    public string? Goal { get; set; }
    public string? Theme { get; set; }
}