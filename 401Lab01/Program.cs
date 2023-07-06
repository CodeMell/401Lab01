
class labB
{
    static void StartSequence()
    {
        Console.WriteLine("Enter a number greater than zero");
        int arrayLength = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[arrayLength];
    }

    static void Main(string[] args)
    {
        StartSequence();
    }
}
