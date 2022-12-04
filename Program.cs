/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int PowTwoNumber(int a, int b) {
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result *= a;
    }
    Console.WriteLine(result);
    return result;
    
}

int GetNumber(string number) {
    Console.WriteLine(number);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetNumber("Input a: ");
int num1 = GetNumber("Input b: ");
PowTwoNumber(num, num1);



/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/



int number = GetNumber("Введите число: ");
int SumNumber(int number){
    int counter = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;
    for (int i = 0; i < counter; i++){
      advance = number - number % 10;
      result = result + (number - advance);
      number = number / 10;
    }
    return result;
}

int numberSum = SumNumber(number);
Console.WriteLine(numberSum);


/*
 Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
 6, 1, 33 -> [6, 1, 33]
 */

void RandomArray(int[] arr) {
    int count = arr.Length;
    int index = 0;
    while (index < count)
    {
        arr[index] = new Random().Next(1,100);
        index++; 
    }
}

void Print(int[] randomArray) {
    int count = randomArray.Length;
    int pos = 0;
    while (pos< count)
    {
        Console.WriteLine(randomArray[pos]);
        pos++;
    }
}

int[] array = new int[8];
RandomArray(array);
Print(array);