namespace MathProject.Client.DTOS.LearningTopic;

public record ClientLearningTopicTaskSelectDTO
{
    public Guid Id { get; init; }
    public Guid DirectionOfTrainingId { get; init; }
    public string Number { get; init; }
    public string Name { get; init; }
    public int DisplayOrder { get; init; }
    public bool IsVisible { get; init; }
}