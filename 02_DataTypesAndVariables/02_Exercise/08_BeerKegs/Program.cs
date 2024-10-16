int n = int.Parse(Console.ReadLine());

string biggestKegModel = "";
double maxVolume = int.MinValue;

for (int i = 0; i < n; i++)
{
    string model = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());

    double volume = Math.PI * Math.Pow(radius, 2) * height;
    if (volume > maxVolume)
    {
        maxVolume = volume;
        biggestKegModel = model;
    }
}
Console.WriteLine(biggestKegModel);
