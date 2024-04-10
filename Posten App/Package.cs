namespace Posten_App;

public class Package
{
    public string description;
    public double[] dimensions = new double[3];
    public double weight;
    public string packing;

    
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
            return $"{description} is too large";
        }
    }

    public void SetPackingChoice()
    {
        packing = GetBestPackingOption();
    }
}