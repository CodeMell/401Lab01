
class labB
{
    static void Main(string[] args)
    {
        try
        {
            StartSequence();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Program completed.");
        }
    }

    static void StartSequence()
    {
        Console.WriteLine("Please enter a number greater than zero:");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[size];
        Populate(array);

        int sum = GetSum(array);
        int product = GetProduct(array, sum);
        decimal quotient = GetQuotient(product);
        Console.WriteLine($"arry size: {array.Length}");
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Quotient: {quotient}");
    }

    static void Populate(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Please enter number {i + 1}/{array.Length}:");
            string input = Console.ReadLine();
            array[i] = Convert.ToInt32(input);
        }
    }

    static int GetSum(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }

        if (sum < 20)
        {
            throw new Exception($"Value of {sum} is too low");
        }

        return sum;
    }

    static int GetProduct(int[] array, int sum)
    {
        Console.WriteLine($"Please select a random number between 1 and {array.Length}:");
        int index = Convert.ToInt32(Console.ReadLine()) - 1;

        if (index < 0 || index >= array.Length)
        {
            throw new IndexOutOfRangeException("Invalid index.");
        }

        int product = sum * array[index];
        return product;
    }

    static decimal GetQuotient(int product)
    {
        Console.WriteLine($"Please enter a number to divide your product {product} by:");
        decimal dividend = Convert.ToDecimal(Console.ReadLine());

        try
        {
            decimal quotient = decimal.Divide(product, dividend);
            return quotient;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
            return 0;
        }
    }
};
