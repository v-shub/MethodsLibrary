string task1 = "7.4. Составить функцию, которая при данных a и b возвращает максимумтрех выражений:";
string task2 = "7.9.Задан одномерный массив, состоящий из 10 целых чисел, натуральное число n. С помощью функции надо определить, сколько раз данное число повторяется в массиве.";
string task3 = "7.10.Программа вводит символ, а затем с помощью функции определяет, сколько раз указанный символ встречается в произвольной последовательности символов.";
string task4 = "7.11.Программа с помощью функции определяет максимальный элемент одномерного массива, а затем подсчитывает количество максимумов.";
string task5 = "7.16. Написать функцию замены элементов диагонали матрицы на нули.";
string task6 = "7.17. Написать функцию замены всех отрицательных чисел квадратной матрицы на единицы.";
string task7 = "7.18. Написать функцию нахождения суммы минимальных элементов матрицы по строкам.";
string task8 = "7.21. Дана строка. Получить с помощью функции новую строку путем прочтения ее, начиная с конца.";
string task9 = "7.22. Дана строка. Добавить к ней с помощью функции в начале строки четыре символа «+» и пять символов «-».";
string task10 = "7.23.Дан символ. С помощью функции составить программу, формирующую строку, состоящую из k данных символов.";
string task11 = "7.24. С помощью функции составить программу суммирования первых n элементов одномерного массива.";
while (true)
{
    Console.WriteLine("Выберите номер задания:");
    Console.WriteLine(task1);
    Console.WriteLine(task2);
    Console.WriteLine(task3);
    Console.WriteLine(task4);
    Console.WriteLine(task5);
    Console.WriteLine(task6);
    Console.WriteLine(task7);
    Console.WriteLine(task8);
    Console.WriteLine(task9);
    Console.WriteLine(task10);
    string choiceNum = Console.ReadLine();
    Console.Clear();
    switch (choiceNum)
    {
        case "1":
            break;
        case "2":
            break;
        case "3":
            break;
        case "4":
            break;
        case "5":
            break;
        case "6":
            break;
        case "7":
            break;
        case "8":
            break;
        case "9":
            break;
        case "10":
            break;
        case "11":
            break;
        default:
            Console.WriteLine("It is not a task number. Try again.");
            break;
    }
    Console.WriteLine("\n\nЗадача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач.");
    Console.ReadLine();
    Console.Clear();
}
