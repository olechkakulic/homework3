// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
void countDistanse(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = Math.Pow((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)), 0.5);
    Console.Write(dist);
}
int getNumber(string text)
{
    Console.WriteLine(text);
    int x = int.Parse(Console.ReadLine());
    return x;
}
int x1 = getNumber("Введите координату x первого числа в трехмерном пространстве");
int y1 = getNumber("Введите координату y первого числа в трехмерном пространстве");
int z1 = getNumber("Введите координату z первого числа в трехмерном пространстве");
int x2 = getNumber("Введите координату x второго числа в трехмерном пространстве");
int y2 = getNumber("Введите координату y второго числа в трехмерном пространстве");
int z2 = getNumber("Введите координату z второго числа в трехмерном пространстве");
countDistanse(x1, y1, z1, x2, y2, z2);