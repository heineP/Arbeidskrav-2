using Newtonsoft.Json;

namespace Posten_App;

public class PostenUtil
{
    // Returns file path of the json file.
    // Used in DeserializeJsonFile()
    public static string GetJsonFilePath()
    {
        string filepath = Directory.GetCurrentDirectory();
        filepath = Directory.GetParent(filepath).FullName;
        filepath = Directory.GetParent(filepath).FullName;
        filepath = Directory.GetParent(filepath).FullName;
        filepath = Path.Combine(filepath, "Jsonfiles");
        filepath = Path.Combine(filepath, "items.json");
        return filepath;
    }
    
    public static string GetTxtFilePath()
    {
        string filepath = Directory.GetCurrentDirectory();
        filepath = Directory.GetParent(filepath).FullName;
        filepath = Directory.GetParent(filepath).FullName;
        filepath = Directory.GetParent(filepath).FullName;
        filepath = Path.Combine(filepath, "Results.txt");
        return filepath;
    }
    // Deserializes Json file. Returns instance of OrdersFromJsonFile.cs
    // which also contains instances of Package.cs
    public static OrdersFromJsonFile DeserializeJsonFile()
    {
        string jsonString = File.ReadAllText(PostenUtil.GetJsonFilePath());
        return JsonConvert.DeserializeObject<OrdersFromJsonFile>(jsonString);
    }
    
    // Method to set all the fields in the package objects
    public static void CalculateOptimalPackageInfo(List<Package> packages)
    {
        foreach (Package package in packages)
        {
            package.SetPackingChoice();
            package.SetCombinedWeightAndNewDimensions();
            package.SetPostingChoice();
            package.SetPackagingPrice();
            package.SetPostingPrice();
        }
    }
    
    // Method used to print all the info to console.
    // Only to be used AFTER CalculateOptimalPackageInfo is used
    public static void PrintInfoToConsole(List<Package> packages)
    {
        foreach (Package package in packages)
        {
            Console.WriteLine($"ITEM: {package.description}");
            Console.WriteLine($"Best packing option: {package.packing}");
            Console.WriteLine($"Weight after packing: {package.combinedWeight} gram");
            Console.WriteLine($"Best posting option: {package.posting}");
            Console.WriteLine($"Posting price: {package.postingPrice} kr");
            Console.WriteLine($"Packaging price: {package.packagingPrice} kr\n");
        }
    }

    public static void WriteInfoToTxt(List<Package> packages)
    {
        using (StreamWriter sw = new StreamWriter(GetTxtFilePath()))
        {
            foreach (Package package in packages)
            {
                sw.WriteLine($"ITEM: {package.description}");
                sw.WriteLine($"Best packing option: {package.packing}");
                sw.WriteLine($"Weight after packing: {package.combinedWeight} gram");
                sw.WriteLine($"Best posting option: {package.posting}");
                sw.WriteLine($"Posting price: {package.postingPrice} kr");
                sw.WriteLine($"Packaging price: {package.packagingPrice} kr\n");
            }
        }
    }
}