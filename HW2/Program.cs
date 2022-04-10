/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных э
лементов в промежутке от M до N.*/
int Promt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

int PrintSumm(int M, int N)
{
    if ( M==N ) return M;
    return M + PrintSumm(M + 1, N);
}

int N = Promt("Введите N => ");
int M = Promt("Введите M => ");
Console.WriteLine($"Сумма чисел равна {PrintSumm(N, M)}");