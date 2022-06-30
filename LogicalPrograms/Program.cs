﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("1. Fibonacci\n2. Perfect Number\n3. Prime Numbers between Range\n4. Reverse a Number\n5. Coupon Number\n6. Stopwatch Simulation\n7. Fewer Notes from Vending Machine\n8. Temperature Conversion\n9. Squartroot\n10. Convert Decimal to Binary");
int input = Convert.ToInt32(Console.ReadLine());
switch (input)
{
    case 1:
        LogicalPrograms.FibonacciSeries fibonacci = new LogicalPrograms.FibonacciSeries();
        fibonacci.Fibonacci();
        break;
    case 2:
        LogicalPrograms.PerfectNumber perfect = new LogicalPrograms.PerfectNumber();
        perfect.Perfect();
        break;
    case 3:
        LogicalPrograms.PrimeNumber prime = new LogicalPrograms.PrimeNumber();
        prime.Prime();
        break;
    case 4:
        LogicalPrograms.ReverseNumber number = new LogicalPrograms.ReverseNumber();
        number.Reverse();
        break;
    case 5:
        LogicalPrograms.CouponNumbers coupon = new LogicalPrograms.CouponNumbers();
        coupon.Coupon();
        break;
    case 6:
        LogicalPrograms.StopWatch watch = new LogicalPrograms.StopWatch();
        watch.StopwatchOutput();
        break;
    case 7:
        LogicalPrograms.VendingMachine vending = new LogicalPrograms.VendingMachine();
        vending.Machine();
        break;
    case 8:
        LogicalPrograms.TemperatureConversion temperature = new LogicalPrograms.TemperatureConversion();
        temperature.TempConvert();
        break;
    case 9:
        LogicalPrograms.SquareRoot root = new LogicalPrograms.SquareRoot();
        root.Square();
        break;
    case 10:
        LogicalPrograms.DecimalToBinary binary = new LogicalPrograms.DecimalToBinary();
        binary.Binary();
        break;
    default:
        Console.WriteLine("Invalid Input");
        break;
}