double totalMoney = 0.0;
string input = "";

while ((input = Console.ReadLine()) != "Start")
{
    double coin;
    if (double.TryParse(input, out coin))
    {
        if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1.0 || coin == 2.0)
        {
            totalMoney += coin;
        }
        else
        {
            Console.WriteLine($"Cannot accept {coin}");
        }
    }
}
string product = "";
double productPrice = 0;
while ((product = Console.ReadLine()) != "End")
{
    if (product == "Nuts")
    {
        productPrice = 2.0;
    }
    else if (product == "Water")
    {
        productPrice = 0.7;
    }
    else if (product == "Crisps")
    {
        productPrice = 1.5;
    }
    else if (product == "Soda")
    {
        productPrice = 0.8;
    }
    else if (product == "Coke")
    {
        productPrice = 1.0;
    }
    else
    {
        Console.WriteLine("Invalid product");
        break;
    }

    if (totalMoney >= productPrice && totalMoney > 0 && productPrice > 0)
    {
        Console.WriteLine($"Purchased {product.ToLower()}");
        totalMoney -= productPrice;
        productPrice = 0;
    }
    else if (productPrice > 0)
    {
        Console.WriteLine($"Sorry, not enough money");
        productPrice = 0;
    }
}
Console.WriteLine($"Change: {totalMoney:f2}");
