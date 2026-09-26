using MyLib;

namespace MyLib.Tests;

public class LibBaiTapTests
{
    private const double Tolerance = 1e-9;

    [Fact]
    public void GiaiPTBac2_000_TraVeVoSoNghiem()
    {
        var x1 = 0d;
        var x2 = 0d;
        var result = LibBaiTap.GiaiPTBac2(0, 0, 0, ref x1, ref x2);
        Assert.Equal(-1, result);
    }

    [Fact]
    public void GiaiPTBac2_005_TraVeVoNghiem()
    {
        var x1 = 0d;
        var x2 = 0d;
        var result = LibBaiTap.GiaiPTBac2(0, 0, 5, ref x1, ref x2);
        Assert.Equal(0, result);
    }

    [Fact]
    public void GiaiPTBac2_02m4_TraVeMotNghiemLinear()
    {
        var x1 = 0d;
        var x2 = 0d;
        var result = LibBaiTap.GiaiPTBac2(0, 2, -4, ref x1, ref x2);
        Assert.Equal(1, result);
        Assert.Equal(2d, x1, Tolerance);
    }

    [Fact]
    public void GiaiPTBac2_101_TraVeVoNghiemDoDeltaAm()
    {
        var x1 = 0d;
        var x2 = 0d;
        var result = LibBaiTap.GiaiPTBac2(1, 0, 1, ref x1, ref x2);
        Assert.Equal(0, result);
    }

    [Fact]
    public void GiaiPTBac2_1m21_TraVeMotNghiemKep()
    {
        var x1 = 0d;
        var x2 = 0d;
        var result = LibBaiTap.GiaiPTBac2(1, -2, 1, ref x1, ref x2);
        Assert.Equal(1, result);
        Assert.Equal(1d, x1, Tolerance);
    }

    [Fact]
    public void GiaiPTBac2_1m32_TraVeHaiNghiemTangDan()
    {
        var x1 = 0d;
        var x2 = 0d;
        var result = LibBaiTap.GiaiPTBac2(1, -3, 2, ref x1, ref x2);
        Assert.Equal(2, result);
        Assert.Equal(1d, x1, Tolerance);
        Assert.Equal(2d, x2, Tolerance);
    }

    [Fact]
    public void GiaiPTBac2_m13m2_TraVeHaiNghiemTangDan()
    {
        var x1 = 0d;
        var x2 = 0d;
        var result = LibBaiTap.GiaiPTBac2(-1, 3, -2, ref x1, ref x2);
        Assert.Equal(2, result);
        Assert.Equal(1d, x1, Tolerance);
        Assert.Equal(2d, x2, Tolerance);
    }

    [Fact]
    public void GiaiPTBac2_HeSoAGanBangKhong_ChoCaBacNhat()
    {
        var x1 = 0d;
        var x2 = 0d;
        var result = LibBaiTap.GiaiPTBac2(1e-12, 2, -4, ref x1, ref x2);
        Assert.Equal(1, result);
        Assert.Equal(2d, x1, Tolerance);
    }

    [Fact]
    public void GiaiPTBac2_DeltaGanKhong_ChoNghiemKep()
    {
        var x1 = 0d;
        var x2 = 0d;
        var result = LibBaiTap.GiaiPTBac2(1, 2, 1 + 1e-12, ref x1, ref x2);
        Assert.Equal(1, result);
        Assert.Equal(-1d, x1, Tolerance);
    }
}
