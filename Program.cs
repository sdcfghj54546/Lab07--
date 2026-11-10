// int[] marks = { 5, 4, 3, 5, 4 };
// int[] numbers = new int[5];
// int marks = { 5, 4, 3, 5, 4 };
// Console.WriteLine(marks[0]);
// Console.WriteLine(marks[4]);
// marks[2] = 4;
// for (int i = 0; i < marks.Length; i++)
// {
//     Console.WriteLine($"marks[{i}] = {marks[i]}");
// }
// foreach (int mark in marks)
// {
//     Console.WriteLine(mark);
// }
// string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт" };
// for (int i = 0; i < days.Length; i++)
// {
//     Console.WriteLine($"{i}: {days[i]}");
// }

//Задание 1.1 сб и вс
// string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
// for (int i = days.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine($"{i}: {days[i]}");
// }

// Задание 1.2 массив double
// double[] temps = { -5.3, 14.2, 16.4, 90.7, -10.7, 67.6, -26.4 };
// foreach (double i in temps)
// {
//     Console.Write(i + " ");
// }
// Console.WriteLine();

//Пример 2
// int[] marks = { 5, 4, 3, 5, 4 };
// int sum = 0;
// foreach (int mark in marks)
// {
//     sum += mark;
// }
// double average = (double)sum / marks.Length;
// Console.WriteLine($"Сумма: {sum}, среднее: {average}");

// Задание 2
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int sum = 0;
// int bolsh100 = 0;
// foreach (int price in prices)
// {
//     sum += price;
//     if (price >100)
//     bolsh100++;
// }
// double sredn = (double)sum / prices.Length;
// Console.WriteLine($"Сумма: {sum}");
// Console.WriteLine($"Средняя цена: {sredn:F2}");
// Console.WriteLine($"Количество товаров дороже 100: {bolsh100}");

// Пример 3
// int[] numbers = { 7, -2, 15, 4, 9 };
// int max = numbers[0];
// for (int i = 1; i < numbers.Length; i++)
// {
//     if (numbers[i] > max)
//     {
//         max = numbers[i];
//     }
// }
// Console.WriteLine($"Максимум: {max}");

// Задание 3
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int minprice = prices[0];
// int maxprice = prices[0];
// int maxindex = 0;
// for (int i = 1; i < prices.Length; i++)
// {
//     if (prices[i] < minprice)
//         minprice = prices[i];
//     if (prices[i] > maxprice)
//     {
//         maxprice = prices[i];
//         maxindex = i;
//     }
// }
// Console.WriteLine($"Минимальная цена: {minprice}");
// Console.WriteLine($"Индекс самого дорогого товара: {maxindex} (цена {maxprice})");

// Пример 4
// int[] numbers = { 1, 2, 3, 4, 5 };
// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = numbers[i] * 2;
// }
// foreach (int n in numbers)
// {
//     Console.Write(n + " ");
// }
 
//Задание 4
// int[] balance = { 100, -50, 20, -5, 0, 75 };
// for (int i = 0; i < balance.Length; i++)
// {
//     if (balance[i] < 0)
//         balance[i] = 0;
// }
// Console.WriteLine("Массив после замены отрицательных значений:");
// foreach (int b in balance)
// {
//     Console.Write(b + " ");
// }
// Console.WriteLine();

 //Задание 5
// int[] numbers = new int[5];
// Console.WriteLine("Введите 5 целых чисел:");
// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.Write($"Число {i + 1}: ");
//     numbers[i] = int.Parse(Console.ReadLine());
// }
// Console.WriteLine("Массив в обратном порядке:");
// for (int i = numbers.Length - 1; i >= 0; i--)
// {
//     Console.Write(numbers[i] + " ");
// } 
// Console.WriteLine();

// int c = 0;
// foreach (int n in numbers)
// {
//     if (n % 2 == 0)
//         c++;
// }
// Console.WriteLine($"Количество четных чисел: {c}");

 //Задание 6
// string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };
// Console.Write("Введите имя для поиска: ");
// string searchname = Console.ReadLine();
// int foundindex = -1;
// for (int i = 0; i < names.Length; i++)
// {
//     if (names[i] == searchname)
//     {
//         foundindex = i;
//         break;
//     }
// }
//     if (foundindex != -1)
//         Console.WriteLine($"Имя \"{searchname}\" найдено на позиции {foundindex}");
//     else
//         Console.WriteLine("Не найдено");

 //Итоговая задача
int[] grades = new int[8];
Console.WriteLine("Введите 8 оценок (от 2 до 5):");
for (int i = 0; i < grades.Length; i++)
{
    Console.Write($"Оценка {i + 1}: ");
    grades[i] = int.Parse(Console.ReadLine());
}
Console.Write("Все оценки: ");
foreach (int g in grades)
{
    Console.Write(g + " ");
}
Console.WriteLine();

int sum = 0;
int max = grades[0];
int min = grades[0];
int two = 0;
int five = 0;

foreach (int g in grades)
{
    sum += g;
    if (g > max) max = g;
    if (g < min) min = g;
    if (g == 2) two++;
    if (g == 5) five++;
}
double sredn = (double)sum / grades.Length;

Console.WriteLine($"Средняя оценка: {sredn:F2}");
Console.WriteLine($"Наибольшая оценка: {max}");
Console.WriteLine($"Наименьшая оценка: {min}");
Console.WriteLine($"Количество двоек: {two}");
Console.WriteLine($"Количество пятёрок: {five}");

if (sredn >= 4.5)
    Console.WriteLine("Отличник");
else if (sredn >= 3.5)
    Console.WriteLine("Хорошист");
else
    Console.WriteLine("Есть над чем поработать");