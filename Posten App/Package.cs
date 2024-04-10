namespace Posten_App;

public class Package
{
    public string description;
    public double[] dimensions = new double[3];
    public double weight;
    public string packing;
    public double combinedWeight;
    public string posting;
    public double packagingPrice;
    public double postingPrice;
    
    // Lage best packing option based on weight and dimensions
    // Dim0 = Length, Dim1 = Width, Dim2 = Height
    public string GetBestPackingOption()
    {
        // Checking if bobblekonvolutt is suitable
        if (dimensions[0] < 110 && dimensions[1] < 160 && dimensions[2] < 20 && weight < 2000)
            return $"boblekonvolutt 11x16cm";
        else if (dimensions[0] < 150 && dimensions[1] < 210 && dimensions[2] < 20 && weight < 2000)
            return $"boblekonvolutt 15x21cm";
        else if (dimensions[0] < 180 && dimensions[1] < 260 && dimensions[2] < 20 && weight < 2000)
            return $"boblekonvolutt 18x26cm";
        else if (dimensions[0] < 270 && dimensions[1] < 360 && dimensions[2] < 20 && weight < 2000)
            return $"boblekonvolutt 27x36cm";
        else if (dimensions[0] < 350 && dimensions[1] < 470 && dimensions[2] < 20 && weight < 2000)
            return $"boblekonvolutt 35x47cm";
        // Checking if norgespakke is suitable
        else if (dimensions[0] < 350 && dimensions[1] < 250 && dimensions[2] < 120 && weight < 5000)
            return $"Eske Norgespakke";
        else if (dimensions[0] < 240 && dimensions[1] < 159 && dimensions[2] < 60)
            return $"Eske Mini";
        else if (dimensions[0] < 332 && dimensions[1] < 246 && dimensions[2] < 65)
            return $"Eske Liten";
        else if (dimensions[0] < 500 && dimensions[1] < 300 && dimensions[2] < 200)
            return $"Eske Stor";
        else
        {
            return $"{description} is too large or heavy for packaging";
        }
    }

    // Sets packing choice
    public void SetPackingChoice()
    {
        packing = GetBestPackingOption();
    }

    
    // Method which sets combined weight to weight of the item + weight of packaging
    public void SetCombinedWeight()
    {
        switch (packing)
        {
            case "boblekonvolutt 11x16cm":
                combinedWeight = weight;
                break;
            case "boblekonvolutt 15x21cm":
                combinedWeight = weight;
                break;
            case "boblekonvolutt 18x26cm":
                combinedWeight = weight;
                break;
            case "boblekonvolutt 27x36cm":
                combinedWeight = weight;
                break;
            case "boblekonvolutt 35x47cm":
                combinedWeight = weight;
                break;
            case "Eske Norgespakke":
                combinedWeight = weight + 191;
                break;
            case "Eske Mini":
                combinedWeight = weight + 67;
                break;
            case "Eske Liten":
                combinedWeight = weight + 125.5;
                break;
            case "Eske Stor":
                combinedWeight = weight + 359;
                break;
        }
    }
    // Sets packaging price
    public void SetPackagingPrice()
    {
        switch (packing)
        {
            case "boblekonvolutt 11x16cm":
                packagingPrice = 2.99;
                break;
            case "boblekonvolutt 15x21cm":
                packagingPrice = 2.99;
                break;
            case "boblekonvolutt 18x26cm":
                packagingPrice = 5.90;
                break;
            case "boblekonvolutt 27x36cm":
                packagingPrice = 8.50;
                break;
            case "boblekonvolutt 35x47cm":
                packagingPrice = 15;
                break;
            case "Eske Norgespakke":
                packagingPrice = 24;
                break;
            case "Eske Mini":
                packagingPrice = 18;
                break;
            case "Eske Liten":
                packagingPrice = 20;
                break;
            case "Eske Stor":
                packagingPrice = 27;
                break;
        }
    }
    
    // Finds appropriate posting option
    public string GetPostingOption()
    {
        if (weight >= 350 && dimensions[0] <= 350 && dimensions[1] <= 250 && dimensions[2] <= 70) 
            return "Lite Brev";
        else if (weight >= 350 && weight <= 2000 && dimensions[0] <= 60 && dimensions[1] <= 60 && dimensions[2] <= 60 
                 && (dimensions[0] + dimensions[1] + dimensions[2]) <= 900)
            return "Stort Brev";
        else if (weight >= 350 && weight <= 5000 && dimensions[0] <= 350 && dimensions[1] <= 250 &&
                 dimensions[2] <= 120)
            return "Norgespakke Liten";
        else if (weight >= 2000 && weight <= 35000 && dimensions[0] >= 350 && dimensions[1] >= 250 &&
                 dimensions[2] >= 120 && dimensions[0] <= 1200 && dimensions[1] <= 600 && dimensions[2] <= 600)
            return "NorgesPakke Stor";
        else
        {
            return $"{description} is too large or heavy for posting";
        }
    }
    // Sets posting choice
    public void SetPostingChoice()
    {
        posting = GetPostingOption();
    }
}