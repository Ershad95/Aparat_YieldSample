namespace YieldSample
{
    public class OrderServices
    {
        private readonly IEnumerable<Order> _orders;
        private readonly int _id = 0;
        public OrderServices()
        {
            _orders = new List<Order>()
            {
                new Order(){ Id = ++_id,CustomerId=10},
                new Order(){ Id = ++_id,CustomerId=10},
                new Order(){ Id = ++_id,CustomerId=10},
                new Order(){ Id = ++_id,CustomerId=10},
                new Order(){ Id = ++_id,CustomerId=100},
                new Order(){ Id = ++_id,CustomerId=200},
                new Order(){ Id = ++_id,CustomerId=500},
                new Order(){ Id = ++_id,CustomerId=500},
                new Order(){ Id = ++_id,CustomerId=500},
                new Order(){ Id = ++_id,CustomerId=500},
                new Order(){ Id = 100, CustomerId=500},
            };
        }
        public IEnumerable<Order> GetAllOrders(int customerId=0,int id=0)
        {
            //IList<Order> orders = new List<Order>();
            foreach (var item in _orders)
            {
                if (item.CustomerId == customerId)
                    yield return item;
                if (item.Id == id)
                    yield return item;

                //if (item.CustomerId == customerId)
                //    orders.Add(item);
                //if (item.Id == id)
                //    orders.Add(item);
            }
            //return orders;
        }
    }
}
