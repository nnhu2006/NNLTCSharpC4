namespace MyLib;

public class LibBaiTap
{
    private const double Eps = 1e-9;

    private static bool IsZero(double value) => Math.Abs(value) <= Eps;

    public static int GiaiPTBac2(double a, double b, double c, ref double x1, ref double x2)
    {
        if (IsZero(a))
        {
            if (IsZero(b))
            {
                return IsZero(c) ? -1 : 0;
            }

            x1 = -c / b;
            return 1;
        }

        var delta = b * b - 4 * a * c;
        if (delta < -Eps)
        {
            return 0;
        }

        if (IsZero(delta))
        {
            x1 = -b / (2 * a);
            return 1;
        }

        var sqrtDelta = Math.Sqrt(delta);
        var r1 = (-b - sqrtDelta) / (2 * a);
        var r2 = (-b + sqrtDelta) / (2 * a);

        x1 = Math.Min(r1, r2);
        x2 = Math.Max(r1, r2);
        return 2;
    }
}
