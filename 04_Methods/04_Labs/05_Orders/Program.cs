string input = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());
Order(input, quantity);
static void Order(string input, int quantity)
{
    double price = 0;
    if (input == "coffee")
    {
        price = 1.50;
    }
    else if (input == "water")
    {
        price = 1.00;
    }
    else if (input == "coke")
    {
        price = 1.40;
    }
    else if (input == "snacks")
    {
        price = 2.00;
    }
    Console.WriteLine($"{(price * quantity):f2}");
}
