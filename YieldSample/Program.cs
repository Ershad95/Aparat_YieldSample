using YieldSample;

var orders = new OrderServices().GetAllOrders(customerId:10,id:100);

foreach (var item in orders)
    Console.WriteLine(item.Id + "/" + item.CustomerId);

Console.ReadLine();