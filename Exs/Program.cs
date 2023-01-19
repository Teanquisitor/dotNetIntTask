using System;
using System.Collections.Generic;


//---------- 1# ----------
class Ex1
{
    public static void Boot()
    {
        // Hours input
        Console.WriteLine("Please enter the hours: ");
        int hours = int.Parse(Console.ReadLine());
        while (hours < 0 || hours > 12)
        {
            Console.WriteLine("Invalid input. Please enter the hours (0-12): ");
            hours = int.Parse(Console.ReadLine());
        }

        // Minutes input
        Console.WriteLine("Please enter the minutes: ");
        int minutes = int.Parse(Console.ReadLine());
        while (minutes < 0 || minutes > 60)
        {
            Console.WriteLine("Invalid input. Please enter the minutes (0-60): ");
            minutes = int.Parse(Console.ReadLine());
        }

        // Working with 360 degrees
        double hourAngle = (hours % 12) * 30 + (minutes / 60.0) * 30;
        double minuteAngle = minutes * 6;
        double angle = Math.Abs(hourAngle - minuteAngle);
        angle = Math.Min(360 - angle, angle);

        // Output
        Console.WriteLine("The angle between the hour and minute arrows is: " + angle + " degrees.");

        // I could make whole method and reuse it every time I need, this time I won't.
        Console.WriteLine("\nNow you can again enter the exercise №(1 / 2 / 3): ");
    }
}


//---------- 2# ----------
class Ex2
{
    public static void Boot()
    {
        Console.WriteLine("That's tree data structure, where each branch may have it's own branches as it's child objects.");

        Console.WriteLine("\nNow you can again enter the exercise №(1 / 2 / 3): ");
    }
}


//---------- 3# ----------
class Branch
{
    public List<Branch> branches;
    public Branch()
    {
        branches = new List<Branch>();
    }
}

class Ex3
{
    static int GetDepth(Branch root)
    {
        if (root.branches.Count == 0) return 1;
        else
        {
            int maxDepth = 0;
            foreach (Branch b in root.branches)
            {
                int depth = GetDepth(b);
                if (depth > maxDepth)
                    maxDepth = depth;
            }
            return maxDepth + 1;
        }
    }
    public static void Boot()
    {
        // Here's hardcoded version of that tree in the task image.

        Branch root = new Branch();

        Branch b1_1 = new Branch();
        Branch b1_2 = new Branch();

        Branch b2_1 = new Branch();
        Branch b2_2 = new Branch();
        Branch b2_3 = new Branch();
        Branch b2_4 = new Branch();

        Branch b3_1 = new Branch();
        Branch b3_2 = new Branch();
        Branch b3_3 = new Branch();

        Branch leaf = new Branch();

        root.branches.Add(b1_1);
        root.branches.Add(b1_2);

        b1_1.branches.Add(b2_1);

        b1_2.branches.Add(b2_2);
        b1_2.branches.Add(b2_3);
        b1_2.branches.Add(b2_4);

        b2_2.branches.Add(b3_1);

        b2_3.branches.Add(b3_2);
        b2_3.branches.Add(b3_3);

        b3_2.branches.Add(leaf);

        int depth = GetDepth(root);
        Console.WriteLine("Depth of the tree is: " + depth);

        Console.WriteLine("\nNow you can again enter the exercise №(1 / 2 / 3): ");
    }
}


//---------- Start ----------
class Exs
{

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the exercise №(1 / 2 / 3): ");

        while (true)
        {
            switch(Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("1#");
                    Ex1.Boot();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("2#");
                    Ex2.Boot();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("3#");
                    Ex3.Boot();
                    break;
                default:
                    Console.WriteLine("Please try again, enter the exercise №(1 / 2 / 3): ");
                    break;
            }
        }
    }
}