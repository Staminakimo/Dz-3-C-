/* Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Напиши пятизначное число: ");
string number = Console.ReadLine();
int UsNumber = int.Parse(number);
int firstNumber = UsNumber/10000;
int secondNumber = (UsNumber / 1000)%10;
int thirdNumber = (UsNumber % 1000)/100;
int fourthNumber= (UsNumber %100)/10;
int fifthNumber = UsNumber %10;
if (firstNumber == fifthNumber && secondNumber == fourthNumber)
{
Console.WriteLine($"Число {number} является палиндромом");
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом");
}
