// Напишите программу, которая принимает на вход целое число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.

System.Console.Write("Введите число из отрезка [10, 99]: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 10 && number < 99) {
    int leftDigit = number / 10;
    int rightDigit = number % 10;

    if(leftDigit > rightDigit) {
        System.Console.WriteLine(leftDigit);
    } else if(leftDigit < rightDigit) {
        System.Console.WriteLine(rightDigit);
    } else {
        System.Console.WriteLine("Цифры равны");
    }
} else {
    System.Console.WriteLine("Введено некорректное число!");
}