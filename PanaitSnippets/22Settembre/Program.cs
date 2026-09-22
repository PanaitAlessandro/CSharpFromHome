public class CPunto : Object
{
    public double X, Y;
    public CPunto(double x, double y) { 
        X = x; 
        Y = y;
        }

    public override string ToString()
    {
        return $"X: {X}, Y: {Y}";
    }
}


// 2. Classe Cerchio (HA UN Punto)
public class CCerchio : Object  
{
    public CPunto Centro; // HAS-A
    public double Raggio;
    public CCerchio(double x, double y, double r) { 
        Centro = new CPunto(x, y);
        Raggio = r; 
        }

    public override string ToString()
    {
        return $"Raggio: {Raggio}, Centro: {Centro.ToString()}";
    }
}

public class CCilindro :Object
{
    public CCerchio Base; // HAS-A
    public double Altezza;
    public CCilindro(double x, double y, double r, double h) { 
        Base = new CCerchio(x, y, r); 
        Altezza = h; 
        }
    public override string ToString()
    {
        return $"Altezza: {Altezza}, Base: {Base.ToString()}";
    }

}

class Program
{
    static void Main()
    {
        object[] contenitore = new object[3];

        contenitore[0] = new CPunto(1, 2);
        contenitore[1] = new CCerchio(0, 0, 5);
        contenitore[2] = new CCilindro(3, 4, 2, 10);

        foreach (object elemento in contenitore)
        {
            if (elemento is CPunto p)
            {
                Console.WriteLine(p);
            }
            else if (elemento is CCerchio c)
            {
                Console.WriteLine(c);
            }
            else if (elemento is CCilindro cl)
            {
                Console.WriteLine(cl);
            }
        }

        System.Console.WriteLine(contenitore[0]); // versione col to string
    }
}