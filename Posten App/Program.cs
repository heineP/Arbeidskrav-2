

Console.WriteLine("BOBO");

string filepath = Directory.GetCurrentDirectory();
filepath = Directory.GetParent(filepath).FullName;
filepath = Directory.GetParent(filepath).FullName;
filepath = Directory.GetParent(filepath).FullName;
string FILEPATH = Path.Combine(filepath, "items.json");

Console.WriteLine(FILEPATH);
