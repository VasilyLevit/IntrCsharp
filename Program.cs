// See README.md for more information

string PrintText(string[] array)
{
    string output = String.Empty;
    
    for (int i = 0; i < array.Length; i++)
    {
        output += ($"{array[i]}  ");
    }
    return output;
}

string[] inArray = {"hello", "2", "world", ":-)"}; // Имеющийся массив строк
int n = 3; // Максимальное число символов в строке

int sizeInArray = inArray.Length;
string[] outArray = new string[sizeInArray];

for (int i = 0, j = 0; i < sizeInArray; i++)
{
    if (inArray[i].Length <= n)
    {
        outArray[j] = inArray[i];
        j++;
    }
}
Console.Write(PrintText(outArray));
File.WriteAllText("output.txt", PrintText(outArray));