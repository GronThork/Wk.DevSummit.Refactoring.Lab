namespace Wk.DevSummit.Refactoring.Lab;

using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        var operator1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        var operator2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the operator (+, -, *, /): ");
        var operation = Convert.ToChar(Console.ReadLine());

        new Program().Calculon(operator1, operation, operator2);

        Console.ReadKey();
    }

    public double Calculon(double operator1, char operation, double operator2)
    {
        double result = 0;

        if (operation == '+')
        {
            //cuando es suma entramos por este bloque 
            //para que realice la operación de sumar y
            //escribimos el resultado por consola
            //para que el usuario vea el resultado
            //en la pantalla de su terminal
            result = operator1 + operator2;
            Console.WriteLine("The result of the addition is: " + result);
        }
        else
        {
            //resta
            if (operation == '-')
            {
                result = operator1 - operator2;
                Console.WriteLine("The result of the subtraction is: " + result);
            }

            if (operation == '*')
            {
                result = operator1 * operator2;
                Console.WriteLine("The result of the multiplication is: " + result);
            }
            if (operation == '/')
            {
                if (operator2 == 0)
                {
                   throw new Exception("Second parameter cant be 0 when operator is /");
                }
                
                result = operator1 / operator2;
                Console.WriteLine("The result of the division is: " + result);
            }
            else
            {
                //si entra por aquí significa que el operador no es correcto
                Console.WriteLine("Invalid operator");
            }
        }
        return result;
    }
}
