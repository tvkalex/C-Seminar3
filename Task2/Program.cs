// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] point = new int[6];
System.Console.WriteLine("Введите координаты точки 1(x,y,z) и точки 2(x1,y1,z1)");
System.Console.WriteLine("Введите координату x:");
point[0]= Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите координату y:");
point[1] = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите координату z:");
point[2] = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите координату x1:");
point[3] = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите координату y1:");
point[4] = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите координату z1:");
point[5] = Convert.ToInt32(System.Console.ReadLine());
double rez = (Math.Sqrt(Math.Pow(point[3]-point[0], 2) + Math.Pow(point[4]-point[1], 2) + Math.Pow(point[5]-point[2], 2)));
System.Console.WriteLine($"Расстояние между точками в 3D пространстве: {Math.Round(rez, 2)}");