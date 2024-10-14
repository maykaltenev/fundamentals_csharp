int lostGames = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());

int headset = 0;
int mouse = 0;
int keyboard = 0;
int display = 0;
for (int i = 2; i < lostGames; i++)
{
    if (i % 2 == 0 && i % 3 == 0)
    {
        mouse++;
        headset++;
        keyboard++;
        if (keyboard % 2 == 0)
        {
            display++;
        }
    }
    else if (i % 2 == 0)
    {
        headset++;
    }
    else if (i % 3 == 0)
    {
        mouse++;
    }
}

double cost = 0;

if (headset > 0)
{
    cost += headset * headsetPrice;
}
if (mouse > 0)
{
    cost += mouse * mousePrice;
}
if (keyboard > 0)
{
    cost += keyboard * keyboardPrice;
}
if (display > 0)
{
    cost += display * displayPrice;
}

Console.WriteLine($"Rage expenses: {cost:f2} lv.");
