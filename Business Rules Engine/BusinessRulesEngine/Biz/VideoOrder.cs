namespace BusinessRulesEngine
{
    /// <summary>
    /// Represent the class for video payment execution.
    /// </summary>
    public class VideoOrder : IOrder
    {
        private readonly IInvoiceSlip iInvoiceSlip;
        public VideoOrder(IInvoiceSlip iInvoiceSlip)
        {
            this.iInvoiceSlip = iInvoiceSlip;
        }
        public bool ExecuteOrder(Order order)
        {
            throw new InvalidOrderException();
        }
    }
}