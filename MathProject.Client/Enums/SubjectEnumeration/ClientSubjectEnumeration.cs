namespace MathProject.Client.Enums.SubjectEnumeration;

/// <summary>
/// Класс для работы выбора предметов
/// ВАЖНО: Нужно заполнить после деплоя на хостинг (указать актульные Guid предметов)
/// При добавлении новых предметов, тоже нужно добавить сюда
/// </summary>
public static class ClientSubjectEnumeration
{
    public static readonly Subject Math = new Subject(id: Guid.Parse("d7787d23-15c3-45c1-ad6c-0904c73451f7"));
    public static readonly Subject Inform = new Subject(id: Guid.Parse("e2232288-14d2-47f7-8919-c3f46eacc6ac"));
    
    public class Subject
    {
        public Guid Id { get; }

        internal Subject(Guid id)
        {
            Id = id;
        }
    }
}