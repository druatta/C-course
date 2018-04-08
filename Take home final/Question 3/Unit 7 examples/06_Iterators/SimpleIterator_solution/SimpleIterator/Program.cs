// Declare the collection:
public class SampleCollection
{
    public int[] items;

    public SampleCollection()
    {
        items = new int[5] { 5, 4, 7, 9, 3 };
    }

    public System.Collections.IEnumerable BuildCollection()
    {
        for (int i = 0; i < items.Length; i++)
        {
            yield return items[i];
        }
    }
}

class MainClass
{
    static void Main()
    {
        SampleCollection col = new SampleCollection();

        // Display the collection items:
        System.Console.WriteLine("Values in the collection are:");
        foreach (int i in col.BuildCollection())
        {
            System.Console.Write(i + " ");
        }

        // Keep the console window open in debug mode.
        System.Console.WriteLine("Press any key to exit.");
        System.Console.ReadKey();
    }
}
