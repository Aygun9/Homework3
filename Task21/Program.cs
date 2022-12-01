//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int EnterXYZ(string str)
{
    Console.Write(str);
    int numberXYZ = int.Parse(Console.ReadLine());
    return numberXYZ;
}

void FindLenght(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double lenght = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    Console.WriteLine(lenght);
}


int x1 = EnterXYZ("Insert coordinate x of 1st point");
int y1 = EnterXYZ("Insert coordnate y of 1st point");
int z1 = EnterXYZ("Insert coordnate z of 1st point");
int x2 = EnterXYZ("Insert coordinate x of 2nd point");
int y2 = EnterXYZ("Insert coordnate y of 2nd point");
int z2 = EnterXYZ("Insert coordnate z of 2nd point");

FindLenght(x1, y1, z1, x2, y2, z2);

