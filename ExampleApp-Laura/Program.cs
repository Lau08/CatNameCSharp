using Model;
using System;
using System.IO;
using System.Xml.Linq;

public class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Give the cat a name: ");
            string catName = Console.ReadLine();
            NameCat(catName);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    static void NameCat(string catName)
    {
        if (catName == "" || string.IsNullOrWhiteSpace(catName))
        {
            Console.WriteLine("Enter at least one character: ");
            catName = Console.ReadLine();
            NameCat(catName);
            Console.ReadLine();

        }
        else
        {
            Cat cat = new Cat();
            cat.Name = catName;            
            Console.WriteLine("The cat's name is: " + cat.Name);           
            cat.Eat(cat.Name);
            Console.WriteLine("");
            Console.WriteLine("        /\\_/\\");
            Console.WriteLine("       ( o.o )");
            Console.WriteLine("        > ^ <");
            Console.ReadLine();
        }
    }

}

