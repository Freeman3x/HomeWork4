//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*void Cikl(int A,int B)
{
    int D = 1;
    for (int C = 1;C <= B;C++)
   {
    D = D * A;
   }
   Console.WriteLine($"{A},{B} -> {D}");
}

Console.WriteLine("Imput your number A: ");
int user_num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Imput your number B: ");
int user_num1 = Convert.ToInt32(Console.ReadLine());

Cikl(user_num,user_num1);
*/

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*void Sum(int A)
{
   int B = A;
   int D = 0;
    while(B > 0)
    {
    D = D + B % 10;
    B = B / 10;
    }
    int C = D += B;
    Console.WriteLine($"{A} -> {C}");
}

Console.WriteLine("Imput your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

Sum(user_num);
*/

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*int [] Mass()
{
    int size = 8;
    int [] array = new int[size];
    for(int A = 0;A < size;A++)
    array[A] = new Random().Next(1,5);
    return array;
}
void MassShow(int [] array)
{
    for (int i = 0;i < array.Length;i++)
    Console.Write(array[i] + " ");
}

MassShow(Mass());
*/
