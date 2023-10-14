
string[] snacks = { "sushi", "pizza", "burger", "salad", "wings", "chips", "fries", "pie" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);
Console.WriteLine($"Tonight we eating {snacks[randomIndex]}");