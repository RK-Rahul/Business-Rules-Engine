using System;

namespace BusinessRulesEngine
{
    /// <summary>
    /// Represent the class for invoice handler.
    /// </summary>
    public class InvoiceSlip : IInvoiceSlip
    {
        public Invoice GenerateDuplicateSlip(Order order)
        {
            throw new NotImplementedException();
        }

        public Invoice GenerateSlip(Order order)
        {
            throw new NotImplementedException();
        }

        public Invoice GenerateAIDSlip(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
