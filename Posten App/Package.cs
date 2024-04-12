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
    public double[] newDimensions = new double[3];
    
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
    public void SetCombinedWeightAndNewDimensions()
    {
        switch (packing)
        {
            case "boblekonvolutt 11x16cm":
                combinedWeight = weight;
                newDimensions = [110, 160, 2];
                break;
            case "boblekonvolutt 15x21cm":
                combinedWeight = weight;
                newDimensions = [150, 210, 2];
                break;
            case "boblekonvolutt 18x26cm":
                combinedWeight = weight;
                newDimensions = [180, 260, 2];
                break;
            case "boblekonvolutt 27x36cm":
                combinedWeight = weight;
                newDimensions = [270, 360, 2];
                break;
            case "boblekonvolutt 35x47cm":
                combinedWeight = weight;
                newDimensions = [350, 470, 2];
                break;
            case "Eske Norgespakke":
                combinedWeight = weight + 191;
                newDimensions = [350, 250, 120];
                break;
            case "Eske Mini":
                combinedWeight = weight + 67;
                newDimensions = [240, 159, 60];
                break;
            case "Eske Liten":
                combinedWeight = weight + 125.5;
                newDimensions = [332, 246, 65];
                break;
            case "Eske Stor":
                combinedWeight = weight + 359;
                newDimensions = [350, 250, 120];
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
        if (weight <= 350 && newDimensions[0] <= 350 && newDimensions[1] <= 250 && newDimensions[2] <= 70) 
            return "Lite Brev";
        else if (weight >= 350 && weight <= 2000 && newDimensions[0] <= 60 && newDimensions[1] <= 60 && newDimensions[2] <= 60 
                 && (newDimensions[0] + newDimensions[1] + newDimensions[2]) <= 900)
            return "Stort Brev";
        else if (weight >= 350 && weight <= 5000 && newDimensions[0] <= 350 && newDimensions[1] <= 250 &&
                 newDimensions[2] <= 120)
            return "Norgespakke Liten";
        else if (weight >= 2000 && weight <= 35000 && newDimensions[0] >= 350 && newDimensions[1] >= 250 &&
                 newDimensions[2] >= 120 && newDimensions[0] <= 1200 && newDimensions[1] <= 600 && newDimensions[2] <= 600)
            return "Norgespakke Stor";
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

    // Returns correct posting price
    public double GetPostingPrice()
    {
        if (posting == "Norgespakke Liten")
            return 73;
        else if (posting == "Norgespakke Stor")
        {
            if (weight <= 10000)
                return 135;
            else if (weight <= 25000)
                return 240;
            else
                return 314;
        }
        else if (posting == "Lite Brev")
        {
            if (newDimensions[2] <= 20) // Letters under 2cm
            {
                if (weight <= 20)
                    return 23;
                else if (weight <= 50)
                    return 29;
                else if (weight <= 100)
                    return 36;
                else
                {
                    return 55;
                }
            }
            else // Letters over 2cm
            {
                return 57;
            }
        }
        else if (posting == "Stort Brev")
        {
            if (newDimensions[2] <= 20) // Letters under 2cm
            {
                if (weight <= 20)
                    return 23;
                else if (weight <= 50)
                    return 29;
                else if (weight <= 100)
                    return 36;
                else if (weight <= 350)
                    return 55;
                else if (weight <= 1000)
                    return 90;
                else
                {
                    return 125;
                }
            }
            else if (newDimensions[2] <= 70) // Letters under 7cm
            {
                if (weight <= 350)
                    return 57;
                else if (weight <= 1000)
                    return 105;
                else
                {
                    return 135;
                }
            }
            else // Letters over 7cm
            {
                if (weight <= 350)
                    return 90;
                else if (weight <= 1000)
                    return 140;
                else
                {
                    return 175;
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid or missing posting field");
            return 0;
        }
    }
    
    // Sets posting price
    public void SetPostingPrice()
    {
        postingPrice = GetPostingPrice();
    }
}