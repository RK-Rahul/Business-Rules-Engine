namespace BusinessRulesEngine
{
    /// <summary>
    /// This class represent the order entity.
    /// </summary>
    public class Order
    {
        public OrderType OrderType { get; set; }

        public string customerEmail { get; set; }
    }
}