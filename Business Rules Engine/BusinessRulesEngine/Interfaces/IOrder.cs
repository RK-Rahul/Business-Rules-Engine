namespace BusinessRulesEngine
{
    /// <summary>
    /// Represent the interface for order.
    /// </summary>
    public interface IOrder
    {
        bool ExecuteOrder(Order order);
    }
}
