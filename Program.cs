// See README.md for more information
// Написать программу, которая из имеющегося массива строк сформирует массив строк, 
// длина которых меньше, либо равна 3 символа. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма.

string[] inArray = {"hello", "2", "world", ":-)"}; // Имеющийся массив строк
int n = 3; // Максимальное число символов в строке

int sizeInArray = inArray.Length;
string[] outArray = new string[sizeInArray];

for (int i = 0, j = 0; i < sizeInArray; i++)
{
    if (inArray[i].Length <= n)
    {
        outArray[j] = inArray[i];
        Console.Write($"{outArray[j]} "); // Тест
        j++;
    }
}
