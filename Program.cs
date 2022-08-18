 // 19 задача - Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите 5-ти значное число: ");
string? number = Console.ReadLine();

void Check(string number)
{
  if(number[0] == number[4] && number[1] == number[3])
  {
    Console.WriteLine($"число {number} - палиндром.");
  }
  else {Console.WriteLine($"число {number} - НЕ палиндром.");}
}

if (number!.Length == 5)
{
  Check(number);
}
else {Console.WriteLine("Нужно ввести 5-ти значное число!");}



// 21 задача - Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");


// 23 задача - Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число для возведения в куб: ");

int N = Convert.ToInt32(Console.ReadLine());

for(int j = 1; j <= N; j++)
        {
            Console.WriteLine(j * j * j);
        }
