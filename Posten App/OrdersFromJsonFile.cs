namespace Posten_App;

public class OrdersFromJsonFile
{
    public string info;
    public List<Package> packages;
    
    //GetLength
    public int NumberOfPackages()
    {
        return packages.Count;
    }
}