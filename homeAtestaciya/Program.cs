//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// System.Console.WriteLine("Input M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int min=0;
// int max=0;
// if (M>N){
//     max=M;
//     min=N;
// }
// else {
//     max=N;
//     min=M;
// }

// if (min==max) System.Console.WriteLine(min);
// else PrintMinToMax(min,max);

// void PrintMinToMax(int min,int max){
//     if(max>min){
//         PrintMinToMax(min,max-1);
//          System.Console.WriteLine(max);
//     }
//     else System.Console.WriteLine(max);
// }

//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// System.Console.WriteLine("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int Akkerman(int m,int n){
//     if(m==0) return n+1;
//     if(m>0&n==0) return Akkerman(m-1,1);
//     else return Akkerman(m-1,Akkerman(m,n-1));
// }

// System.Console.WriteLine(Akkerman(m,n));

//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        System.Console.WriteLine("Input int: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintElement(int[] array, int size){

    if(size>0){
        System.Console.Write(array[size-1]+"  ");
        PrintElement(array,size-1);
    }
    
}


int[] ar=CreateArray(5);
PrintElement(ar,5);