int groupOfPeople = int.Parse(Console.ReadLine());
string type = Console.ReadLine();
string dayOfTheWeek = Console.ReadLine();
bool isDiscount = false;
double price = 0;
double total = 0;
if (type == "Students")
{
    if (dayOfTheWeek == "Friday")
    {
        price = 8.45;
    }
    else if (dayOfTheWeek == "Saturday")
    {
        price = 9.80;
    }
    else if (dayOfTheWeek == "Sunday")
    {
        price = 10.46;
    }
    if (groupOfPeople >= 30)
    {
        isDiscount = true;
        total = (groupOfPeople * price) * 0.85;
    }
}
else if (type == "Business")
{
    if (dayOfTheWeek == "Friday")
    {
        price = 10.90;
    }
    else if (dayOfTheWeek == "Saturday")
    {
        price = 15.60;
    }
    else if (dayOfTheWeek == "Sunday")
    {
        price = 16;
    }
    if (groupOfPeople >= 100)
    {
        isDiscount = true;
        total = (groupOfPeople - 10) * price;
    }
}
else if (type == "Regular")
{
    if (dayOfTheWeek == "Friday")
    {
        price = 15;
    }
    else if (dayOfTheWeek == "Saturday")
    {
        price = 20;
    }
    else if (dayOfTheWeek == "Sunday")
    {
        price = 22.50;
    }
    if (groupOfPeople >= 10 && groupOfPeople <= 20)
    {
        isDiscount = true;
        total = (groupOfPeople * price) * 0.95;
    }
}
if (isDiscount)
{
    Console.WriteLine($"Total price: {total:f2}");
}
else
{
    Console.WriteLine($"Total price: {groupOfPeople * price:f2}");
}
