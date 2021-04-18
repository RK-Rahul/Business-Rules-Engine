namespace BusinessRulesEngine
{
    /// <summary>
    /// Represent the class for physical payment execution.
    /// </summary>
    public class PhysicalProductOrder : IOrder
    {
        private readonly IInvoiceSlip iInvoiceSlip;
        public PhysicalProductOrder(IInvoiceSlip iInvoiceSlip)
        {
            this.iInvoiceSlip = iInvoiceSlip;
        }
        public bool ExecuteOrder(Order order)
        {
            if (order.IsPhysicalPayment())
            {
                this.iInvoiceSlip.GenerateSlip(order);
                return true;
            }
            else
            {
                throw new InvalidOrderException();
            }
        }
    }
}