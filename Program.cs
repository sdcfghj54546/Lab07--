int[] marks = { 5, 4, 3, 5, 4 };
int[] numbers = new int[5];
int marks = { 5, 4, 3, 5, 4 };
Console.WriteLine(marks[0]);
Console.WriteLine(marks[4]);
marks[2] = 4;
for (int i = 0; i < marks.Length; i++)
{
    Console.WriteLine($"marks[{i}] = {marks[i]}");
}
foreach (int mark in marks)
{
    Console.WriteLine(mark);
}
string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт" };
for (int i = 0; i < days.Length; i++)
{
    Console.WriteLine($"{i}: {days[i]}");
}

//Задание 1.1 сб и вс
// string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт" };

// //Задание 1.1 обр порядок
// string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
// for (int i = 6; i < days.Length; i--)
// {
//     Console.WriteLine($"{i}: {days[i]}");
// }
// //Задание 1.2 массив double
// double[] temps = { -5.3, 14.2, 16.4, 90.7, -10.7, 67.6, -26.4 };
// foreach (double i in temps)
// {
//     Console.WriteLine(i + " ");
// }

//Пример 2
int[] marks = { 5, 4, 3, 5, 4 };
int sum = 0;
foreach (int mark in marks)
{
    sum += mark;
}
double average = (double)sum / marks.Length;
Console.WriteLine($"Сумма: {sum}, среднее: {average}");

//Задание 2
int[] prices = { 120, 45, 300, 80, 15, 210 };

//Пример 3
int[] numbers = { 7, -2, 15, 4, 9 };
int max = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}
Console.WriteLine($"Максимум: {max}");

//Задание 3
int[] prices = { 120, 45, 300, 80, 15, 210 };

//Пример 4
int[] numbers = { 1, 2, 3, 4, 5 };
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = numbers[i] * 2;
}
foreach (int n in numbers)
{
    Console.Write(n + " ");
}
 
 //Задание 4

 //Задание 5

 //Задание 6

 //Итоговая задача