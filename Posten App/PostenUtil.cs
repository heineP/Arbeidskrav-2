using Newtonsoft.Json;

namespace Posten_App;

public class PostenUtil
{
    // Returns file path of the json file.
    // Used in DeserializeJsonFile()
    public static string GetFilePath()
    {
        string filepath = Directory.GetCurrentDirectory();
        filepath = Directory.GetParent(filepath).FullName;
        filepath = Directory.GetParent(filepath).FullName;
        filepath = Directory.GetParent(filepath).FullName;
        filepath = Path.Combine(filepath, "Jsonfiles");
        filepath = Path.Combine(filepath, "items.json");
        return filepath;
    }
    // Deserializes Json file. Returns instance of OrdersFromJsonFile.cs
    // which also contains instances of Package.cs
    public static OrdersFromJsonFile DeserializeJsonFile()
    {
        string jsonString = File.ReadAllText(PostenUtil.GetFilePath());
        return JsonConvert.DeserializeObject<OrdersFromJsonFile>(jsonString);
    }
}