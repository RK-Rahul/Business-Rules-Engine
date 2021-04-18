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
            if (order.IsVideoPayment())
            {
                //Fetch JSON file and check if AID applicable then execute.
                this.iInvoiceSlip.GenerateAIDSlip(order);
                return true;
            }
            else
            {
                //Can be replaced by custom exception
                throw new InvalidOrderException();
            }
        }
    }
}