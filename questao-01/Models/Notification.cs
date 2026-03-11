namespace AvaliacaoInstrutoresQuestao_01.Models;

public class NotificationHandler
{
    public List<Notification> Notifications { get; }

    public NotificationHandler()
    {
        Notifications = new List<Notification>();
    }
    
    public Notification AddNotification(string message, NotificationType type)
    {
        return new Notification(message, type);
    }

    public void AddError(string message)
    {
        AddNotification(message, NotificationType.Error);
    }

    public void AddWarning(string message)
    {
        AddNotification(message, NotificationType.Warning);
    }

    public void AddSuccess(string message)
    {
        AddNotification(message, NotificationType.Success);
    }

    public bool HasNotifications()
    {
        return Notifications.Any();
    }

    public bool HasErrors()
    {
        return Notifications.Any(n => n.Type == NotificationType.Error);
    }

    public void ClearNotifications()
    {
        Notifications.Clear();
    }

    public void GetAndClearErrors()
    {
        var errors = Notifications.Where(n => n.Type == NotificationType.Error).ToList();

        Console.WriteLine("Erros:");
        foreach (var error in errors)
            Console.WriteLine($"- {error.Message}");

        ClearNotifications();
    }
}

public class Notification
{
    public Notification(string message, NotificationType type)
    {
        Message = message;
        Type = type;
    }

    public string Message { get; }
    public NotificationType Type { get; }
}

public enum NotificationType
{
    Error = 1,
    Warning = 2,
    Success = 3
}
