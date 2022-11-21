// Напишите программу, которая выводит трехзначное число и удаляет вторую цифру этого числа.
int randomNumber = new Random().Next(100,1000);
int lastDigit = randomNumber % 10;
int firstDigit = randomNumber / 100;

Console.WriteLine(randomNumber);
Console.WriteLine($"{firstDigit}{lastDigit}");
