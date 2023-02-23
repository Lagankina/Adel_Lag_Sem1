// Напишите программу котораяд принимает два числа  и проверяет является ли первое число квадратом второг
int a;
int b;
Console.WriteLine ("Введите число а: ");
a = int.Parse(Console.ReadLine());
 Console.WriteLine ("Введите число b: ");
 b = int.Parse(Console.ReadLine());

 if (a*a == b) {
    Console.WriteLine("ДА");
 }
 else {
    Console.WriteLine ("НЕТ");
 }