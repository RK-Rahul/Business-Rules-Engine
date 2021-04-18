namespace BusinessRulesEngine
{
    /// <summary>
    /// Represent the interface for notification handler.
    /// </summary>
    public interface INotificationHandler
    {
        bool Notify(Order order);
    }
}
