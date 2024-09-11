using Dungeons.Models;
using System.Reflection;

public class Program
{
    public static void Main()
    {
        Player Char1 = new Player("DaringDingo", 100, 36, 25, 18, 25, 32, "Sword", "Elve", "Warior");
        Char1.PrintPlayer();

        Type type = Char1.GetType();
        PropertyInfo[] playerproperties = type.GetProperties();
        foreach (var property in playerproperties)
        {
            // Get the property name
            string Name = property.Name;

            // Get the value of the property
            Type Type = property.PropertyType;

            // Print the property name and value
            Console.WriteLine($"{Name}: {Type}");
        }
    }
}
