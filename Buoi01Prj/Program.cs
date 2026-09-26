using MyLib;

var x1 = 0d;
var x2 = 0d;
var soNghiem = LibBaiTap.GiaiPTBac2(2, -3, 2, ref x1, ref x2);

Console.WriteLine($"So nghiem: {soNghiem}");
if (soNghiem == 1)
{
    Console.WriteLine($"x1 = {x1}");
}
else if (soNghiem == 2)
{
    Console.WriteLine($"x1 = {x1}, x2 = {x2}");
}
