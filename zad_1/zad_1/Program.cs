using System;

class Rectangle
{
    private int a, b;

    public Rectangle(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public int A
    {
        get { return a; }
        set { a = value; }
    }

    public int B
    {
        get { return b; }
        set { b = value; }
    }

    public void PrintSides()
    {
        Console.WriteLine("Стороны прямоугольника: {0} и {1}", a, b);
    }

    public int GetPerimeter()
    {
        return 2 * (a + b);
    }

    public int GetArea()
    {
        return a * b;
    }

    public bool IsSquare
    {
        get { return a == b; }
    }

    public int this[int i]
    {
        get
        {
            if (i == 0) return a;
            else if (i == 1) return b;
            else throw new IndexOutOfRangeException();
        }
        set
        {
            if (i == 0) a = value;
            else if (i == 1) b = value;
            else throw new IndexOutOfRangeException();
        }
    }

    public static Rectangle operator ++(Rectangle r)
    {
        r.a++;
        r.b++;
        return r;
    }

    public static Rectangle operator --(Rectangle r)
    {
        r.a--;
        r.b--;
        return r;
    }

    public static bool operator true(Rectangle r)
    {
        return r.a == r.b;
    }

    public static bool operator false(Rectangle r)
    {
        return !(r.a == r.b);
    }

    public static Rectangle operator *(Rectangle r, int scalar)
    {
        r.a *= scalar;
        r.b *= scalar;
        return r;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle(5, 10);

        rect.PrintSides();
        Console.WriteLine("Периметр: {0}", rect.GetPerimeter());
        Console.WriteLine("Площадь: {0}", rect.GetArea());

        Console.WriteLine("Длина стороны A: {0}", rect.A);
        Console.WriteLine("Длина стороны B: {0}", rect.B);

        Console.WriteLine("Является ли прямоугольник квадратом? {0}", rect.IsSquare);

        Console.WriteLine("Увеличиваем стороны на 1...");
        ++rect;

        rect.PrintSides();

        Console.WriteLine("Уменьшаем стороны на 1...");
        --rect;

        rect.PrintSides();

        Console.WriteLine("Умножаем стороны на 2...");
        rect *= 2;

        rect.PrintSides();

#if DEBUG
        Console.ReadKey();
#endif
    }
}