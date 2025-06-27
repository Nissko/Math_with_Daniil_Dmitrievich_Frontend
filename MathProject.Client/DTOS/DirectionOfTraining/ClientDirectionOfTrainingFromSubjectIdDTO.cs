namespace MathProject.Client.DTOS.DirectionOfTraining;

public record ClientDirectionOfTrainingFromSubjectIdDTO
{
    public Guid Id { get; init; }
    public Guid TrainingCategoryId { get; init; }
    public string Name { get; init; }
    public string Date { get; init; }
    public int DisplayOrder { get; init; }
    public bool IsVisible { get; init; }
};