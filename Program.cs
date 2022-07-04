/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.  */

/* string [] FillArray()
{
    string [] StringArrayToFill;

    return StringArrayToFill;
}
 */
string AssembleStringFromArray(string [] arrayToCollect)
{
    string resultString = string.Empty;
    int arrayLength = arrayToCollect.Length;
    for (int i = 0; i < arrayLength; i++)
    {
        resultString += $"\"{arrayToCollect[i]}\""; 
        if( i < arrayLength -1 ) resultString +=", ";
    }
    
    return resultString +=".";
}

string [] PickElementsFromArray(string [] StringToSeek, int strLength)
{
    int resArrayCount = 0; 
    for (int i = 0; i < StringToSeek.Length; i++)
    {
        if(StringToSeek[i].Length <= strLength)
        {
            resArrayCount++;
        }
    }
    string [] resultArray = new string [resArrayCount];
    for (int k = 0, l = 0; k < StringToSeek.Length; k++)
    {
        if(StringToSeek[k].Length <= strLength)
        {
            resultArray[l] = StringToSeek[k];
            l++;
        }
    }
    return resultArray;
}

/* string CreateRandomString()
{
    string newString = string.Empty;

    return newString;
}

string [] CreateRandomStrArray (int ElementsNumber)
{
    string [] newStringArray;

    return newStringArray;
} */


int CountOutputElements = 0;
int CountInputElements = 0;
string [] inputArray = new string [] {"привет","я","это","смотрю","ТВ"};

const int stringLength = 3; // отбираем строки, количество символов в которой меньше либо равно этому значению 

Console.Clear();

// string [] inputArray = FillArray();
string [] outputArray = PickElementsFromArray (inputArray, stringLength);
string outputString  = AssembleStringFromArray(outputArray);

Console.WriteLine("Результатом выборки из массива строк, является новый массив, \n строки в котором меньше либо равны {0}", stringLength);
Console.WriteLine(outputString);
