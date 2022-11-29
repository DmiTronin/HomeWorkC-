/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

 Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while(number!= 0)
{
    
	sum =sum + number%10;
	number = number/10;
    
}
Console.WriteLine("Сумма равна" + sum); 





/*string stringNumber = Console.ReadLine();
int sum = 0;

for(int i = 0; i < stringNumber.Length; i++)
{
string digit = Convert.ToString(stringNumber[i]);
sum += Convert.ToInt32(digit);
}

Console.WriteLine(sum);


/* int number = Convert.ToInt32(Console.ReadLine());
int countDigit = 0;
int sum = 0;

int temp = number;
while(temp > 0)
{
countDigit++;
temp /= 10;
}

int[] numbers = new int[countDigit];
int index = 0;
while(number > 0)
{
numbers[index++] = number % 10;
number /= 10;
}

for(int i = 0; i < numbers.Length; i++)
{
sum += numbers[i];
}

Console.WriteLine(sum);*/