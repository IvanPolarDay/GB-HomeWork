// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите номер дня недели");
int dayNumber = Convert.ToInt32(Console.ReadLine());
string[] days = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

if(dayNumber > 5 && dayNumber < 8)
{ 
    Console.WriteLine(days[dayNumber -1]  + " - это выходной день");
}
else if (dayNumber > 0 && dayNumber < 6)
{
  Console.WriteLine(days[dayNumber - 1]);
}
else
{
Console.WriteLine("Такого дня не существует");
}
