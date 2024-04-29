using System;


public class Statistics
{
    private int total;
    private int count;
    private int minimum = int.MaxValue;
    private int maximum = int.MinValue;

    // Method to add a new value to the statistics
    public void AddValue(int value)
    {
        total += value;
        count++;
        if (value < minimum)
        {
            minimum = value;
        }
        if (value > maximum)
        {
            maximum = value;
        }
    }

    // Method to get the average value
    public double GetAverage()
    {
        if (count == 0)
        {
            return 0; // To avoid division by zero
        }
        return (double)total / count;
    }

    // Method to get the minimum value
    public int GetMinimum()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("No values added yet.");
        }
        return minimum;
    }

    // Method to get the maximum value
    public int GetMaximum()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("No values added yet.");
        }
        return maximum;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of StatisticsTracker
        StatisticsTracker stats = new StatisticsTracker();

        // Add some sample values
        stats.AddValue(10);
        stats.AddValue(20);
        stats.AddValue(15);
        stats.AddValue(25);

        // Retrieve and display statistics
        Console.WriteLine("Average: " + stats.GetAverage());
        Console.WriteLine("Minimum: " + stats.GetMinimum());
        Console.WriteLine("Maximum: " + stats.GetMaximum());
    }
}
