namespace BusinessRulesEngine
{
    /// <summary>
    /// Represent the class for book order.
    /// </summary>
    public class BookOrder : IOrder
    {
        private readonly IAgentCommission agentCommision;

        private readonly IInvoiceSlip iInvoiceSlip;
        public BookOrder(IAgentCommission agentCommision, IInvoiceSlip iInvoiceSlip)
        {
            this.iInvoiceSlip = iInvoiceSlip;
            this.agentCommision = agentCommision;
        }
        public bool ExecuteOrder(Order order)
        {
            if (order.IsBookPayment())
            {
                this.iInvoiceSlip.GenerateDuplicateSlip(order);
                this.agentCommision.GenerateCommision(order);
                return true;
            }
            else
            {
                throw new InvalidOrderException();
            }
        }
    }
}