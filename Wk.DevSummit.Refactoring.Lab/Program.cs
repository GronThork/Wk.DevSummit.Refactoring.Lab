namespace Wk.DevSummit.Refactoring.Lab;

using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        var l = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        var h = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the operator (+, -): ");
        var o = Convert.ToChar(Console.ReadLine());

        new Program().Sum(l, o, h);

        Console.ReadKey();
    }

    public double Sum(double v, char g, double a)
    {
        double k = 0;

        if (g == '+')
        {
            //cuando es suma entramos por este bloque 
            //para que realice la operación de sumar y
            //escribimos el resultado por consola
            //para que el usuario vea el resultado
            //en la pantalla de su terminal
            k = v + a;
            Console.WriteLine("The result of the addition is: " + k);
        }
        else
        {
            //resta
            if (g == '-')
            {
                k = v - a;
                Console.WriteLine("The result of the subtraction is: " + k);
            }
            else
            {
                //si entra por aquí significa que el operador no es correcto
                Console.WriteLine("Invalid operator");
            }
        }
        return k;
    }
}
