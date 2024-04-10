using Newtonsoft.Json;
using Posten_App;
using JsonSerializer = System.Text.Json.JsonSerializer;


//Loads info from JSON file into OrdersFromJsonFile
OrdersFromJsonFile orders = PostenUtil.DeserializeJsonFile();

//Calculates and updates the best Packing, Posting and Pricing options for each package
PostenUtil.CalculateOptimalPackageInfo(orders.packages);

//Prints the generated info to console
PostenUtil.PrintInfoToConsole(orders.packages);






