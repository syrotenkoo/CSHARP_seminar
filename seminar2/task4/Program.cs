// Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

while(number / 10 > 0) {
    System.Console.Write($"{number % 10}, ");
    number /= 10;
}

System.Console.Write(number);