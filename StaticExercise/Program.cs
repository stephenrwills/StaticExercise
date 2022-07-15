

using StaticExercise;

Console.WriteLine("Please enter the temp you wish to convert:");
var x = double.Parse(Console.ReadLine());
Console.WriteLine(TempConverter.FahrenheitToCelsius(x));
Console.WriteLine(TempConverter.CelsiusToFahrenheit(x));