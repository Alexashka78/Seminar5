// Задача: Необходимо задать массив из 5 элементов заполненные случайными числами
//  и найти сумму отрицательных 
/*
int[] CreatArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} element of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Complete!");
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int SumOfNegatives(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            sum += array[i];
    }

    return sum;
}

Console.Write("Input a number of element: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreatArray(size);
int result = SumOfNegatives(myArray);

ShowArray(myArray);
Console.WriteLine("Sum of a negative elements is " + result);
*/

/*
// Задача: 1. Замена элементов массива положительные на отрицательные и наоборот.

int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int [size];

    for(int i = 0; i < size; i++)
        newArray[i] =new Random().Next(minValue, maxValue +1);

    return newArray;    
}

int[] ReversedArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[] myArray = CreateRandomArray(5, -100, 100);
ShowArray(myArray);
int[] reversed = ReversedArray(myArray);
ShowArray(reversed);
*/
/*
//         2. Задать массив и написать программу которая определяет присутствует ли
//            заданное число в массиве.

bool Find(int num, int [] array)               // Можно сделать так:
{                                              // bool Find(int num, int [] array
    bool find = false;                         // {
    for (int i = 0; i < array.Length; i++)     //       for (int i = 0; i < array.Length; i++)
    {                                          //           if (array[i] == num)
        if (array[i] == num)                   //               return true;
        {                                      //       return false;
            find = true;                       // }
            break;
        }
            
    }

    return find;
}

int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int [size];

    for(int i = 0; i < size; i++)
        newArray[i] =new Random().Next(minValue, maxValue +1);

    return newArray;    
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number to find: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, -10, 10);
bool find = Find(number, newArray);
ShowArray(newArray);
Console.WriteLine($"Число {number} содержится в нашем массиве. Это {find}");
*/
/*
//         3. Необходимо задать одномерный массив из 12 случайных чисел и найти
//            количество элементов значение которых лежат в отрезке от 10 до 99.
int minValue = 10;
int maxValue = 99;
int Count(int[] array, int minValue, int maxValue)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= minValue && array[i] <= maxValue) count ++;
    }

    return count;
}

int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int [size];

    for(int i = 0; i < size; i++)
        newArray[i] =new Random().Next(minValue, maxValue +1);

    return newArray;    
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[] arrayToFind = CreateRandomArray(12, -100, 150);
ShowArray(arrayToFind);
int count = Count(arrayToFind, minValue, maxValue);
Console.WriteLine($"В нутри вашего массива содержится {count} элементов в диапазоне от {minValue} до {maxValue}");
*/
