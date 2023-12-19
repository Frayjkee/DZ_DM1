// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


using System;

class Program
{
    static void Main()
    {
        // Создаем двумерный массив для примера
        int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.Write("Введите номер строки: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int col = int.Parse(Console.ReadLine());

        // Вызываем функцию для получения значения элемента или вывода сообщения об отсутствии элемента
        int result = GetElementValue(array, row, col);

        if (result != -1)
        {
            Console.WriteLine($"Значение элемента в позиции ({row}, {col}): {result}");
        }
        else
        {
            Console.WriteLine($"Элемента в позиции ({row}, {col}) не существует.");
        }
    }

    static int GetElementValue(int[,] array, int row, int col)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);

        // Проверяем, существует ли элемент в указанных позициях
        if (row >= 0 && row < rowCount && col >= 0 && col < colCount)
        {
            // Возвращаем значение элемента
            return array[row, col];
        }
        else
        {
            // Возвращаем -1, чтобы указать, что элемента нет
            return -1;
        }
    }
}
