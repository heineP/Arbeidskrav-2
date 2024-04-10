using Newtonsoft.Json;
using Posten_App;
using JsonSerializer = System.Text.Json.JsonSerializer;

Console.WriteLine("BOBO");

OrdersFromJsonFile orders = PostenUtil.DeserializeJsonFile();

// TEST -- printing second dimension from first package
Console.WriteLine(orders.packages[0].dimensions[1]);
Console.WriteLine(orders.NumberOfPackages());




