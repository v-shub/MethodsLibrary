using Library;


string task1 = " 1. Составить функцию, которая при данных a и b возвращает максимум трех выражений: x=cos(a+b)^2, y=sin(a+b), z=a/b";
string task2 = " 2. Задан одномерный массив, состоящий из 10 целых чисел, натуральное число n. С помощью функции надо определить, сколько раз данное число повторяется в массиве.";
string task3 = " 3. Программа вводит символ, а затем с помощью функции определяет, сколько раз указанный символ встречается в произвольной последовательности символов.";
string task4 = " 4. Программа с помощью функции определяет максимальный элемент одномерного массива, а затем подсчитывает количество максимумов.";
string task5 = " 5. Написать функцию замены элементов диагонали матрицы на нули.";
string task6 = " 6. Написать функцию замены всех отрицательных чисел квадратной матрицы на единицы.";
string task7 = " 7. Написать функцию нахождения суммы минимальных элементов матрицы по строкам.";
string task8 = " 8. Дана строка. Получить с помощью функции новую строку путем прочтения ее, начиная с конца.";
string task9 = " 9. Дана строка. Добавить к ней с помощью функции в начале строки четыре символа «+» и пять символов «-».";
string task10 = "10. Дан символ. С помощью функции составить программу, формирующую строку, состоящую из k данных символов.";
string task11 = "11. С помощью функции составить программу суммирования первых n элементов одномерного массива.";

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
    Console.WriteLine(task11);
    string choiceNum = Console.ReadLine();
    Console.Clear();
    try
    {
        switch (choiceNum)
        {
            case "1":
                Console.WriteLine(task1 + "\n");
                Console.WriteLine("Enter the first number:");
                double a = ParseDoubleTilWin();
                Console.WriteLine("Enter the second number:");
                double b = ParseDoubleTilWin();
                Console.WriteLine("Result: "+ MyClass.MaxOf3Expr(a, b));
                break;
            case "2":
                Console.WriteLine(task2 + "\n");
                int[] array1 = new int[10];
                Console.WriteLine("Enter ten array numbers:");
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = ParseIntTilWin();
                }
                Console.WriteLine("Enter the number to count:");
                int n = ParseIntTilWin();
                Console.WriteLine("Result: " + MyClass.CountInArray(array1, n));
                break;
            case "3":
                Console.WriteLine(task3 + "\n");
                Console.WriteLine("Enter the simbol:");
                char c1 = ParseCharTilWin();
                Console.WriteLine("Result: " + MyClass.CountInRandomString(c1));
                break;
            case "4":
                Console.WriteLine(task4 + "\n");
                Console.WriteLine("Enter the array length:");
                int l1 = ParseLengthTilWin();
                double[] array2 = new double[l1];
                Console.WriteLine("Enter array numbers:");
                for (int i = 0; i < l1; i++)
                {
                    array2[i] = ParseDoubleTilWin();
                }
                Console.WriteLine("Result: " + MyClass.MaxElementCount(array2));
                break;
            case "5":
                Console.WriteLine(task5 + "\n");
                Console.WriteLine("Enter the matrix rows and columns count:");
                int r1 = ParseLengthTilWin();
                int col1 = ParseLengthTilWin();
                double[,] matrix1 = new double[r1, col1];
                Console.WriteLine("Enter matrix numbers:");
                for(int i = 0; i < r1; i++)
                {
                    Console.WriteLine($"Row {i}:");
                    for(int j = 0; j < col1; j++)
                    {
                        matrix1[i,j] = ParseDoubleTilWin();
                    }
                }
                double[,] result1 = MyClass.ReplaceDiagonalTo0(matrix1);
                Console.WriteLine("Result: ");
                for (int i = 0; i < r1; i++)
                {
                    for (int j = 0; j < col1; j++)
                    {
                        Console.Write($"{result1[i, j]}\t");
                    }
                    Console.WriteLine();
                }
                break;
            case "6":
                Console.WriteLine(task6 + "\n");
                Console.WriteLine("Enter the matrix rows and columns count:");
                int r2 = ParseLengthTilWin();
                int col2 = ParseLengthTilWin();
                double[,] matrix2 = new double[r2, col2];
                Console.WriteLine("Enter matrix numbers:");
                for (int i = 0; i < r2; i++)
                {
                    Console.WriteLine($"Row {i}:");
                    for (int j = 0; j < col2; j++)
                    {
                        matrix2[i, j] = ParseDoubleTilWin();
                    }
                }
                double[,] result2 = MyClass.ReplaceNegativeTo1(matrix2);
                Console.WriteLine("Result: ");
                for (int i = 0; i < r2; i++)
                {
                    for (int j = 0; j < col2; j++)
                    {
                        Console.Write($"{result2[i, j]}\t");
                    }
                    Console.WriteLine();
                }
                break;
            case "7":
                Console.WriteLine(task7 + "\n");
                Console.WriteLine("Enter the matrix rows and columns count:");
                int r3 = ParseLengthTilWin();
                int col3 = ParseLengthTilWin();
                double[,] matrix3 = new double[r3, col3];
                Console.WriteLine("Enter matrix numbers:");
                for (int i = 0; i < r3; i++)
                {
                    Console.WriteLine($"Row {i}:");
                    for (int j = 0; j < col3; j++)
                    {
                        matrix3[i, j] = ParseDoubleTilWin();
                    }
                }
                double result3 = MyClass.SumMinInRows(matrix3);
                Console.WriteLine($"Result: {result3}");
                break;
            case "8":
                Console.WriteLine(task8 + "\n");
                Console.WriteLine("Enter the string:");
                string str1 = Console.ReadLine();
                Console.WriteLine("Result: " + MyClass.ReverseString(str1));
                break;
            case "9":
                Console.WriteLine(task9 + "\n");
                Console.WriteLine("Enter the string:");
                string str2 = Console.ReadLine();
                Console.WriteLine("Result: " + MyClass.AddSimbols(str2));
                break;
            case "10":
                Console.WriteLine(task10 + "\n");
                Console.WriteLine("Enter the simbol:");
                char c2 = ParseCharTilWin();
                Console.WriteLine("Enter the simbol count:");
                int l2 = ParseLengthTilWin();
                Console.WriteLine("Result: " + MyClass.RepeatSimbol(c2, l2));
                break;
            case "11":
                Console.WriteLine(task11 + "\n");
                Console.WriteLine("Enter the array length:");
                int l3 = ParseLengthTilWin();
                double[] array3 = new double[l3];
                Console.WriteLine("Enter array numbers:");
                for (int i = 0; i < l3; i++)
                {
                    array3[i] = ParseDoubleTilWin();
                }
                Console.WriteLine("Enter count of sum numbers:");
                int l4 = ParseLengthTilWin();
                Console.WriteLine("Result: " + MyClass.SumFirstElements(array3, l4));
                break;
            default:
                throw new Exception("It is not a task number. Try again.");
        }
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    Console.WriteLine("\n\nЗадача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач.");
    Console.ReadLine();
    Console.Clear();
}
int ParseIntTilWin()
{
    int x;
    while (true)
    {
        bool isNumInt = Int32.TryParse(Console.ReadLine(), out x);
        if (isNumInt)
            break;
        else
            Console.WriteLine("It is not an integer number. Try again.");
    }
    return x;
}
double ParseDoubleTilWin()
{
    double x;
    while (true)
    {
        bool isInputDouble = Double.TryParse(Console.ReadLine(), out x);
        if (isInputDouble)
            break;
        else
            Console.WriteLine("It is not a number. Try again.");
    }
    return x;
}
char ParseCharTilWin()
{
    char x;
    while (true)
    {
        bool isInputChar = Char.TryParse(Console.ReadLine(), out x);
        if (isInputChar)
            break;
        else
            Console.WriteLine("It is not a character. Try again.");
    }
    return x;
}
int ParseLengthTilWin()
{
    int x;
    while (true)
    {
        bool isNumInt = Int32.TryParse(Console.ReadLine(), out x);
        if (isNumInt & x >= 0)
            break;
        else
            Console.WriteLine("It is not the length. Try again.");
    }
    return x;
}