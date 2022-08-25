/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29 */


Console.WriteLine("Ввведите m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n:");
int n = int.Parse(Console.ReadLine());

int ackermanFunc(int m, int n){
    int result = 0;
    if(m == 0){
        result = n+1;
    } else if (m > 0 && n == 0){
        result = ackermanFunc(m - 1, 1);
    } else if (m > 0 && n > 0){
        result = ackermanFunc(m -1, ackermanFunc(m, n -1));
    }
    return result;
}

Console.WriteLine(ackermanFunc(m,n));