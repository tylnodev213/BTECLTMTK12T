// See https://aka.ms/new-console-template for more information

//Bài 1: Nhập số nguyên n. Tính n!
Console.WriteLine("Bài 1");
Console.Write("n = ");
int n1 = int.Parse(Console.ReadLine());
int giaiThua = 1;
for (int i = 1; i <= n1; i++)
{
    giaiThua *= i;
}
Console.WriteLine("giai thua = "+giaiThua);

//Bài 2: Nhập số nguyên n
// a. Kiểm tra n có phải số nguyên tố không ?
// b. Hiển thị tất cả các số nguyên trong khoảng từ 1 đến n

Console.WriteLine("Bài 2");
Console.WriteLine("a. Kiem tra n có phai so nguyen to khong ?");
Console.Write("n = ");
int n2 = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 1; i <= n2; i++)
{
    if (n2 % i == 0)
    {
        count++;
    }
}

if (count == 2)
{
    Console.WriteLine("\n So {0} la so nguyen to", n2);
}
else
{
    Console.WriteLine("So {0} khong la so nguyen to", n2);
}

Console.WriteLine("b. Hien thi tat ca cac so nguyen tu 1 den n");

for (int i = 1; i <= n2; i++)
{
    Console.Write(i+" ");
}

//Bài 3: Nhập số nguyên n (n>10). Hiển thị dãy Fibonacy có độ dài n
Console.WriteLine("Bài 3");
int n3 = 0;
do
{
    Console.Write("n = ");
    n3 = int.Parse(Console.ReadLine());
} while (n3 <= 10);
Console.Write("day so Fibonacci: \n");
for (int i = 0; i < n3; i++)
{
    Console.Write("{0} ", fibonacci(i));
}
 
Console.WriteLine();
Console.ReadKey();

static int fibonacci(int n)
{
    int f0 = 0;
    int f1 = 1;
    int fn = 1;
    int i;
 
    if (n < 0)
    {
        return -1;
    }
    else if (n == 0 || n == 1)
    {
        return n;
    }
    else
    {
        for (i = 2; i < n; i++)
        {
            f0 = f1;
            f1 = fn;
            fn = f0 + f1;
        }
    }
    return fn;
}