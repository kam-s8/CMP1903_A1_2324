using System;


public class Statistics
{
    private int total;
    private int count;

    public int GetMaximum()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("No values added yet.");
        }
        return maximum;
    }
        public double GetAverage()
    {
        if (count == 0)
        {
            return 0; // To avoid division by zero
        }
        return (double)total / count;
    }
}
