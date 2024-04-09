//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine("введи  число : ");
 int a=Convert.ToInt32(Console.ReadLine());

 kratnost(a);

 void kratnost(int a){
    if (7 % a== 0 && 23 % a== 0 ) Console.WriteLine(a + " кратно одновременно 7 и 23 ");
    else Console.WriteLine(a + " не кратно одновременно 7 и 23 ");
 }

 //Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y),
 // причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

 Console.WriteLine("введи x : ");
 int x=Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("введи y : ");
 int y=Convert.ToInt32(Console.ReadLine());

 koordinatChetvert(x,y);

  void koordinatChetvert(int x , int y){
    if(x==0 && y==0) Console.WriteLine( " x или y не должны равняться 0 ");
    else if(x>0 && y>0) Console.WriteLine(" 1 четверть");
    else if(x<0 && y>0) Console.WriteLine(" 2 четверть");
    else if(x<0 && y<0) Console.WriteLine(" 3 четверть");
    else if(x>0 && y<0) Console.WriteLine(" 4 четверть");
  }

  //Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

  Console.WriteLine("введи целое число из отрезка [10, 99] : ");
 int c=Convert.ToInt32(Console.ReadLine());

 Console.WriteLine(maxChislo(c));

int maxChislo(int c){
    int c1=c/10;
    int c2=c%10;
    int max=c1;
    if(c1>c2) max=c1;
    else if(c2>c1) max=c2;
    return max;
}

//Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

 Console.WriteLine("введи натуральное число : ");
 int n=Convert.ToInt32(Console.ReadLine());

cifra(n);

void cifra(int n){
    int val=n;
    while(val>0){
     if(val/10>0)   Console.Write(val%10 +" ,");
     else Console.Write(val);
     val=val/10;
    }
     
}

