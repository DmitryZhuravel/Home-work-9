/*Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n. m = 2, n = 3 -> A(m,n) = 29*/
int Promt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

int Akkerman(int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return Akkerman(M - 1, 1);
    return Akkerman(M - 1, Akkerman(M, N - 1));
}

int M = Promt("Введите M => ");
int N = Promt("Введите N => ");
Console.Write(Akkerman(M,N));






