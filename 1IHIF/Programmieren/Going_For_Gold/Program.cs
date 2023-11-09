Console.WriteLine("Welcome to the going for gold mission");
Console.WriteLine("Please enter your ore number");
int ore = int.Parse(Console.ReadLine()!);
int gold = 0;

gold += Math.Min(ore,10)*10;
ore -= Math.Min (ore,10);

gold += Math.Min(ore , 5)*5;
ore -= Math.Min(ore, 5);

gold += Math.Min(ore, 3)*2;
ore -= Math.Min(ore, 3);

gold += ore *1;
ore -= ore;

Console.WriteLine("You now have : " + gold +"");

// Path: Program.cs