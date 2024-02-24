namespace Task7;

public class Math
{
const double PI = 3.14;
const double E = 2.71;
public double Abs(double value)
{
    if (value < 0)
    {
        return -value;
    }
    else
    {
        return value;
    }
}
public float Abs(float value)
{
    if (value < 0)
    {
        return -value;
    }
    else
    {
        return value;
    }
}
public int Abs(int value)
{
    if (value < 0)
    {
        return -value;
    }
    else
    {
        return value;
    }
}
public double Pow(double x, double y)
{
     
    for (int i = 0; i<y-1; i++)
    {
        x = x * x;
    } 
    return x;
}
public double Sqrt(int d)
{

    for (int i = 0; i < d; i++)
    {
        if (i * i == d)
        {
            return i;
        }

    }
    return 0;

}
public int Max(int val1, int val2)
{
    if (val1 > val2)
    {
        return val1;
    }
    else return val2;
}
public int Min(int val1, int val2)
{
    if (val1 < val2)
    {
        return val1;
    }
    else return val2;

}
}
