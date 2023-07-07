// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int numberA = 3;
int numberB = 5;

int VozvedenieVStepen(int osnova, int mnozhytel)
{
    if(mnozhytel == 0) return 1;
    return VozvedenieVStepen(osnova,  mnozhytel-1) * osnova;
}

Console.Write(VozvedenieVStepen(numberA, numberB));