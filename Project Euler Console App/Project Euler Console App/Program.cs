using Project_Euler_Console_App;


static void Main(string[] args)
{
    EvenFibonacciNumbers obj = new EvenFibonacciNumbers();
    List<int> fibonacciSeq = obj.GenerateFibonacciSequence(4000000);

    Console.WriteLine(obj.SumEvenNumbers(fibonacciSeq));
}

