//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.WriteLine("Input your 5digits number ");
int numberPol = Convert.ToInt32(Console.ReadLine());
void Palindrome ()
{
    int num = numberPol;
    int review = 0;
    int temp = num;

    while (temp != 0)
    {
        int rem = temp % 10; // сохранить последнюю цифру в переменной
        review = review * 10 + rem; //добавляем к цифре цифру
        temp = temp/10; // удалить последнюю цифру
    }

    if (num == review)
    {
    Console.WriteLine($"Your number {review} is a palindrome ");
    }

    else
    {
        Console.WriteLine($"Your number {review} is not palindrome");
    }
}
Palindrome ();


















/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

/*double Distance (int x1, int x2, int y1, int y2, int z1, int z2)
{
    double LenghtAB = Math.Sqrt((x1 - x2)*(x1 - x2)+ (y1 - y2)*(y1 - y2)+ (z1 - z2)*(z1 - z2));
    return LenghtAB;
}
Console.WriteLine("Input X coordinate A: ");
int xCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Y coordinate A: ");
int yCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Z coordinate A: ");
int zCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input X coordinate B: ");
int xCoordB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Y coordinate B: ");
int yCoordB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Z coordinate B: ");
int zCoordB = Convert.ToInt32(Console.ReadLine());

double dist = Distance (xCoordA, yCoordA, zCoordA, xCoordB, yCoordB, zCoordB);

Console.WriteLine($"Distance AB is {dist:f3}");

*/


/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

/*void CubeFinder ()
{
    Console.WriteLine("Input your number: ");
    int numberN = Convert.ToInt32(Console.ReadLine());

    if (numberN > 0)
    {
        int current_i = 1;
        while (current_i <= numberN)
        {
            int result = current_i*current_i*current_i;
            Console.Write($"{result}, ");
            current_i++;
        }
       Console.WriteLine("\b\b."); 
    }
    else
    {
        int current_i = 1;
        while (current_i >= numberN)
        {
            Console.WriteLine(current_i* current_i  + ", ");
            current_i--;
        }
        Console.WriteLine("\b\b.");
    }
    Console.WriteLine("Impossible value");

}
CubeFinder ();
*/
