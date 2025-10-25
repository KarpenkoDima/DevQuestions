namespace DevQuestions.Domain.Reports;

public class Rport
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid ReportedUserId { get; set; }
    public required string Reason { get; set; }
    public Status Status { get; set; } = Status.Open;
    public DateTimeOffset CreateAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public Guid ResolvedByUserId { get; set; }
}

public enum Status
{
    Open,
    InProgress,
    Resolved,
    Dismissed
}