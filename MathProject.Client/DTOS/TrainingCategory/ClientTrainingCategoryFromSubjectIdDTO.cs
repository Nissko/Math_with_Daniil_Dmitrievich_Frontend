namespace MathProject.Client.DTOS.TrainingCategory;

public record ClientTrainingCategoryFromSubjectIdDTO
{
    public Guid Id { get; init; }
    public Guid SubjectId { get; init; }
    public string Name { get; init; }
    public int DisplayOrder { get; init; }
    public bool IsVisible { get; init; }
}