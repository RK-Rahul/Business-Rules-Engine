using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessRulesEngine
{
    /// <summary>
    /// This class test the execute membership order.
    /// </summary>
    [TestClass]
    public class MemberShipOrderTest
    {
        private IOrder order;

        private Order placedOrder;

        private INotificationHandler notificationHandler;
        /// <summary>
        /// This method initialize the order data for passing to execute book order.
        /// </summary>
        [TestInitializeAttribute]
        public void TestInitialize()
        {
            this.placedOrder = TestCaseInitializationHelper.GetMemberShipOrder();
            this.notificationHandler = new NotificationHandler();
            this.order = new MemberShipOrder(this.notificationHandler);
        }

        /// <summary>
        /// Test membership and upgrade payment method.
        /// </summary>
        [TestMethod]
        public void ExecuteOrder()
        {
            //Test member ship payment order
            Assert.IsTrue(this.order.ExecuteOrder(this.placedOrder));

            //Test member ship upgrade order
            this.placedOrder.OrderType = OrderType.UpgradeMemberShip;
            Assert.IsTrue(this.order.ExecuteOrder(this.placedOrder));
        }

        /// <summary>
        /// TestInvalid order / payment exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidOrderException))]
        public void ExecuteOrder_InvalidOrderType()
        {
            this.placedOrder.OrderType = OrderType.None;
            this.order.ExecuteOrder(this.placedOrder);
        }
    }
}