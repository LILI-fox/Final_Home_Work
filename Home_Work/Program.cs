using static Common.Helper;

// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символам.

string[] initialArray = new string[] {"hello", "2", "world", ":-)", "1234", "1567", "-2"};
PrintArray(initialArray);

string[] newArr = new string[initialArray.Length];

GenerateThreeDigArr(initialArray, newArr);
PrintArray(newArr);

void GenerateThreeDigArr(string[] initialArray, string[] newArr)
{
    int count = 0;
    for (int i = 0; i < initialArray.Length; i++)
    {
    if(initialArray[i].Length <= 3)
        {
        newArr[count] = initialArray[i];
        count++;
        }
    }
}

