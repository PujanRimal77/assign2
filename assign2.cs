using System;

class Interval
{
    static void Main()
    {
        // Setting Interval I
        IntervalSet I = new IntervalSet();

        // Prompting the user to enter a real number
        Console.Write("Enter a real number: ");
        double x;
        if (double.TryParse(Console.ReadLine(), out x))
        {
            // Checking membership and displaying the result
            if (I.IsInInterval(x))
            {
                Console.WriteLine($"x belongs to I");
            }
            else
            {
                Console.WriteLine($"x does not belong to I");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid real number.");
        }

        // line to hold the screen 
        Console.ReadLine();
    }
}

class IntervalSet
{
    // defining the intervals
    private static readonly double[] interval1 = { 2, 3 };
    private static readonly double[] interval2 = { 0, 1 };
    private static readonly double[] interval3 = { -10, -2 };

    // Checking if a value belongs to the set I
    public bool IsInInterval(double x)
    {
        // Testing membership using comparator operators < and ==
        bool isInInterval1 = x >= interval1[0] && x < interval1[1];
        bool isInInterval2 = x >= interval2[0] && x < interval2[1];
        bool isInInterval3 = x >= interval3[0] && x < interval3[1];

        // Using logical operators to combine the results
        return (isInInterval1 || isInInterval2) || isInInterval3;
    }
}
