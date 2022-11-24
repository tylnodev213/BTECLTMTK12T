// See https://aka.ms/new-console-template for more information

void tinhSoNghiemPTB2(Double a, Double b, Double c)
{
    String ptb2 ="("+ a + ")x^2 + (" + b + ")x + (" + c + ")";
    if (a == 0)
    {
        if (b == 0)
        {
            Console.Write("Phuong trinh " + ptb2 + " vo nghiem!");
        }
        else
        {
            Console.Write("Phuong trinh " + ptb2 + " co mot nghiem");
        }
        return;
    }
    Double delta = b * b - 4 * a * c;
    if (delta > 0)
    {
        Console.Write("Phuong trinh " + ptb2 + " co 2 nghiem");
    }
    else if (delta == 0)
    {
        Console.Write("Phong trinh " + ptb2 + " co nghiem kep");
    }
    else
    {
        Console.Write("Phuong trinh " + ptb2 + " vo nghiem!");
    }
}

Double a, b, c;
Console.Write("a = ");
a = Double.Parse(Console.ReadLine());
Console.Write("b = ");
b = Double.Parse(Console.ReadLine());
Console.Write("c = ");
c =Double.Parse(Console.ReadLine());
tinhSoNghiemPTB2(a, b, c);