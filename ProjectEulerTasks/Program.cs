// See https://aka.ms/new-console-template for more information
using static ProjectEulerTasks.Main.Logic.EulerTasks;

using ProjectEulerTasks.Main.Logic;

Console.WriteLine("Enter your number");
var testNo = Convert.ToInt64(Console.ReadLine());


var sumOfMultiplesOf3And5 = SumOfMultiplesOf3And5();
var sumOfEvenFibonacciValues = SumOfEvenFibonacciNumbers();
var largestPrimeFactorValue = EfficientLargestPrimeFactor(testNo);

//Console.WriteLine(sumOfMultiplesOf3And5);
//Console.WriteLine("The sum of even Fibonacci Values is" + sumOfEvenFibonacciValues);
Console.WriteLine("The largest prime factor value is " + largestPrimeFactorValue);
