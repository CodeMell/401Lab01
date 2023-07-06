
class labB
{
    static void StartSequence()
    {
        Console.WriteLine("Enter a number greater than zero");
        int arrayLength = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[arrayLength];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Please enter a number: {i} of {arrayLength}");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    static void Main(string[] args)
    {
        StartSequence();

    }
};
