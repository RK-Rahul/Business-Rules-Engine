namespace BusinessRulesEngine
{
    /// <summary>
    /// This is an extension class for Order entity for validation given order type.
    /// </summary>
    public static class OrderExtensions
    {
        public static bool IsBookPayment(this Order order)
        {
            return order.OrderType == OrderType.Book ? true : false;
        }

        public static bool IsPhysicalPayment(this Order order)
        {
            return order.OrderType == OrderType.PhysicalProduct ? true : false;
        }

        public static bool IsMemberShipPayment(this Order order)
        {
            return order.OrderType == OrderType.MemberShip ? true : false;
        }

        public static bool IsMemberShipUpgradePayment(this Order order)
        {
            return order.OrderType == OrderType.MemberShip ? true : false;
        }

        public static bool IsVideoPayment(this Order order)
        {
            return order.OrderType == OrderType.Video ? true : false;
        }
    }
}