using System;
namespace SchoolLibrary
{
	public class Tutorial
	{
		public Tutorial()
		{
            // Chapter 1: 'Hello World'
            String name = "JJWW";
            Console.WriteLine("Hello" + name);
            Console.WriteLine($"Welcome to C# world, {name}");

            // Chapter 2: String
            String mission = "      Nothing      ";
            Console.WriteLine($"[{mission}]");
            Console.WriteLine("[mission.Trim()]");
            Console.WriteLine("[mission.TrimStart()]");
            Console.WriteLine("[mission.TrimEnd()]");
            Console.WriteLine($"You mission has {mission.Length} words");
            mission = mission.Replace(" ", "||");
            Console.WriteLine($"You mission become {mission.ToUpper()}");

            // Searching String
            var needMoney = mission.Contains("money");
            var startBar = mission.StartsWith("|");
            Console.WriteLine($"Dese your mission need money: {needMoney}");
            Console.WriteLine($"Dese your mission start with |: {startBar}");

            ////////////
            // Note: String property dont need() where String function has '()'


            // Chapter 3: Integer
            double pi = Math.PI;
            int max = int.MaxValue;
            int min = int.MinValue;
            double dmax = double.MaxValue;
            double dmin = double.MinValue;
            decimal decmax = decimal.MaxValue;
            decimal decmin = decimal.MinValue;
            decimal a = 1.0M;
            decimal b = 3;
            double aa = 1;
            double bb = 3;
            Console.WriteLine($"1/3 in double is {aa / bb}, in decimal is {a / b}");

            // Chapter 4: list
            var fruits = new List<String> { "apple", "peach" };
            for (int i = 0; i < fruits.Count; ++i)
                Console.WriteLine(fruits[i].ToUpper());
            fruits.Remove("apple");
            fruits.Add("banana");
            fruits.Sort();
            var index_banana = fruits.IndexOf("banana");
            foreach (String fruit in fruits)
                Console.WriteLine(fruit);

            var pre = 1;
            var cur = 1;
            for (int i = 0; i < 18; ++i)
            {
                var temp = pre + cur;
                pre = cur;
                cur = temp;
                Console.WriteLine(temp);
            }

        }
    }
}

