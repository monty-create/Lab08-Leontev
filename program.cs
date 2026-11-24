using System;

int lessonNumber = 5;
while (lessonNumber >= 1)
{
    Console.WriteLine($"Пара {lessonNumber}");
    lessonNumber--;
}
Console.WriteLine("Пары закончились");

Console.WriteLine();

int gradesCount = 0;
Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());
while (grade != -1)
{
    Console.WriteLine($"Оценка принята: {grade}");
    gradesCount++;
    grade = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Ввод завершён. Всего оценок: {gradesCount}");

Console.WriteLine();

int baseSum = 0;
int baseCount = 0;
int maxGrade = 0;

Console.WriteLine("Вводите оценки, для завершения введите -1:");
int currentGrade = int.Parse(Console.ReadLine());
while (currentGrade != -1)
{
    if (baseCount == 0 || currentGrade > maxGrade)
    {
        maxGrade = currentGrade;
    }
    baseSum += currentGrade;
    baseCount++;
    currentGrade = int.Parse(Console.ReadLine());
}

if (baseCount > 0)
{
    Console.WriteLine($"Средний балл: {(double)baseSum / baseCount}");
    Console.WriteLine($"Наибольшая оценка: {maxGrade}");
}
else
{
    Console.WriteLine("Оценок не было введено");
}

Console.WriteLine();

string correctPassword = "qwerty123";
int failedAttempts = 0;

while (true)
{
    Console.Write("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();

    if (password == correctPassword)
    {
        Console.WriteLine("Доступ разрешён");
        Console.WriteLine($"Неудачных попыток: {failedAttempts}");
        break;
    }

    failedAttempts++;
    Console.WriteLine("Неверный пароль, попробуйте снова");
}

Console.WriteLine();

string answer;
do
{
    Console.Write("Введите дату посещения (например, 01.09): ");
    string date = Console.ReadLine();
    Console.WriteLine($"Запись добавлена: {date}");

    Console.Write("Добавить ещё одну запись? (да/нет): ");
    answer = Console.ReadLine();
} while (answer == "да");
Console.WriteLine("Дневник сохранён");

Console.WriteLine();

// Задача А
int n = 6;
int mult = 1;
while (mult <= 10)
{
    Console.WriteLine($"{n} * {mult} = {n * mult}");
    mult++;
}

Console.WriteLine();

// Задача Б
int namesCount = 0;
Console.WriteLine("Вводите имена учеников (для выхода введите «конец»):");
string studentName = Console.ReadLine();
while (studentName != "конец")
{
    namesCount++;
    studentName = Console.ReadLine();
}
Console.WriteLine($"Введено имён: {namesCount}");

Console.WriteLine();

// Вариант 1
int startNum = 5;
while (startNum >= 1)
{
    Console.WriteLine(startNum);
    startNum--;
}
Console.WriteLine("Старт!");

Console.WriteLine();

// Вариант 2
int posSum = 0;
Console.WriteLine("Вводите целые числа (0 для завершения):");
int num2 = int.Parse(Console.ReadLine());
while (num2 != 0)
{
    if (num2 > 0)
    {
        posSum += num2;
    }
    num2 = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Сумма положительных чисел: {posSum}");
