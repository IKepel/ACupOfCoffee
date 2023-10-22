using ACupOfCoffee.Contracts;
using ACupOfCoffee.Entities;

var cup = new Cup();

AddCoffee(cup);
AddWater(cup);
cup.Stir();
AddMilk(cup);
cup.Stir();
AddSugar(cup);
cup.Stir();
Console.WriteLine("Your coffee's ready.");

void AddCoffee(IContainingCoffee cup)
{
    cup.AddCoffee();
}

void AddMilk(IContainingMilk cup)
{
    cup.AddMilk();
}

void AddSugar(IContainingSugar cup)
{
    cup.AddSugar();
}

void AddWater(IContainingWater cup)
{
    cup.AddWater();
}