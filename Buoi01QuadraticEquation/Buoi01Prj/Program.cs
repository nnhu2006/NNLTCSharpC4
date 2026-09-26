using MyLib;

var x1 = 0d;
var x2 = 0d;
var soNghiem = LibBaiTap.GiaiPTBac2(2, -3, 2, ref x1, ref x2);

Console.WriteLine("Giai phuong trinh: 2x^2 - 3x + 2 = 0");
switch (soNghiem)
{
    case -1:
        Console.WriteLine("Phuong trinh vo so nghiem.");
        break;
    case 0:
        Console.WriteLine("Phuong trinh vo nghiem.");
        break;
    case 1:
        Console.WriteLine($"Phuong trinh co 1 nghiem: x = {x1}");
        break;
    case 2:
        Console.WriteLine($"Phuong trinh co 2 nghiem phan biet: x1 = {x1}, x2 = {x2}");
        break;
}
