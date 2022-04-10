/* Задайте значения M и N. Напишите программу, которая выведет все Вчётные и все нечетные натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"*/
int Promt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

void PrintNumber(int M, int N)
{
    if (M>N) return;
    Console.Write(M+" ");
    PrintNumber(M + 1, N);
}

void PrintEvenNumber(int M, int N)
{
    if (M > N) return;
    if (M % 2 == 0)
    Console.Write(M+" ");
    PrintEvenNumber(M + 1, N);
}



void PrintOddNumber(int M, int N)
{
    if (M > N) return;
    if (M % 2 != 0)
    Console.Write(M+" ");
    PrintOddNumber(M + 1, N);
}

int M = Promt("Введите N => ");
int N = Promt("Введите M => ");
PrintNumber(M, N);
System.Console.WriteLine();
PrintEvenNumber(M, N);
System.Console.WriteLine();
PrintOddNumber(M, N);