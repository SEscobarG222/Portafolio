using System;
class Program
{
    static void Main()
    {
        Console.Clear();

        E1();
        Console.WriteLine("\n---------------------------\n");

        E2();
        Console.WriteLine("\n---------------------------\n");

        E3();
        Console.WriteLine("\n---------------------------\n");

        E4();

        Console.WriteLine("\nFin del programa.");
        Console.ReadKey();
    }
    static void E1()
    {
        Console.WriteLine("Ejercicio 1: Vehículos");
        Console.Write("Tipo (1:Bici 2:Moto 3:Auto 4:Camión 5:Bus): ");

        if (int.TryParse(Console.ReadLine(), out int t))
        {
            switch (t)
            {
                case 1: Console.WriteLine("No motorizado"); break;
                case 2: Console.WriteLine("Ligero"); break;
                case 3: Console.WriteLine("Mediano"); break;
                case 4: Console.WriteLine("Pesado"); break;
                case 5: Console.WriteLine("Público"); break;
                default: Console.WriteLine("Fuera de rango"); break;
            }
        }
        else
            Console.WriteLine("Dato inválido");
    }

    static void E2()
    {
        Console.WriteLine("Ejercicio 2: Banco");

        Console.Write("Tipo tarjeta (1,2,3 u otro): ");
        int tt = int.Parse(Console.ReadLine());

        Console.Write("Límite actual: ");
        double la = double.Parse(Console.ReadLine());

        double pa = 0;

        if (tt == 1) pa = 0.25;
        else if (tt == 2) pa = 0.35;
        else if (tt == 3) pa = 0.40;
        else pa = 0.50;

        double nl = la + (la * pa);

        Console.WriteLine($"Nuevo límite: {nl:C}");
    }

    static void E3()
    {
        Console.WriteLine("Ejercicio 3: Evaluación");

        Console.Write("Puntuación (0.0, 0.4, 0.6+): ");

        if (double.TryParse(Console.ReadLine(), out double p))
        {
            string n = "";
            double d = 0;

            if (p == 0.0)
            {
                n = "Inaceptable";
                d = 2400 * p;
            }
            else if (p == 0.4)
            {
                n = "Aceptable";
                d = 2400 * p;
            }
            else if (p >= 0.6)
            {
                n = "Meritorio";
                d = 2400 * p;
            }
            else
            {
                Console.WriteLine("Puntuación inválida");
                return;
            }

            Console.WriteLine($"Nivel: {n}");
            Console.WriteLine($"Dinero: {d:C}");
        }
        else
            Console.WriteLine("Dato inválido");
    }

    static void E4()
    {
        Console.WriteLine("Ejercicio 4: Pizzería");

        Console.Write("¿Vegetariana? (s/n): ");
        string r = Console.ReadLine().ToLower();

        string tp = "";
        string ing = "";

        if (r == "s")
        {
            tp = "Vegetariana";
            Console.WriteLine("1.Pimiento  2.Tofu");
            Console.Write("Elija: ");
            string oi = Console.ReadLine();

            if (oi == "1") ing = "Pimiento";
            else if (oi == "2") ing = "Tofu";
            else
            {
                Console.WriteLine("Ingrediente inválido");
                return;
            }
        }
        else if (r == "n")
        {
            tp = "No vegetariana";
            Console.WriteLine("1.Peperoni  2.Jamón  3.Salmón");
            Console.Write("Elija: ");
            string oi = Console.ReadLine();

            if (oi == "1") ing = "Peperoni";
            else if (oi == "2") ing = "Jamón";
            else if (oi == "3") ing = "Salmón";
            else
            {
                Console.WriteLine("Ingrediente inválido");
                return;
            }
        }
        else
        {
            Console.WriteLine("Respuesta inválida");
            return;
        }

        Console.WriteLine($"\nPizza {tp} con:");
        Console.WriteLine("- Mozzarella");
        Console.WriteLine("- Tomate");
        Console.WriteLine($"- {ing}");
    }
}


//LAB 7//

using System;

namespace EjerciciosWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            E1();
            Console.WriteLine("\nPresione una tecla...");
            Console.ReadKey();

            E2();
            Console.WriteLine("\nPresione una tecla...");
            Console.ReadKey();

            E3();
            Console.WriteLine("\nPresione una tecla...");
            Console.ReadKey();

            E4();
            Console.WriteLine("\nFin del programa.");
            Console.ReadKey();
        }

        static void E1()
        {
            Console.WriteLine("\n--- Ejercicio 1 ---");
            int n, c = 0;
            double num, s = 0;

            Console.Write("¿Cuántos números?: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                Console.Write("Ingrese entero > 0: ");

            while (c < n)
            {
                Console.Write($"Número {c + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out num))
                    Console.Write("Número válido: ");

                s += num;
                c++;
            }

            Console.WriteLine($"Suma: {s}");
            Console.WriteLine($"Promedio: {s / n:F2}");
        }

        static void E2()
        {
            Console.WriteLine("\n--- Ejercicio 2 ---");
            int op;
            double v, r;
            bool s = false;

            do
            {
                Console.WriteLine("\n1.C→F  2.F→C  3.Km→Mi  4.Salir");
                Console.Write("Opción: ");

                while (!int.TryParse(Console.ReadLine(), out op))
                    Console.Write("Número válido: ");

                switch (op)
                {
                    case 1:
                        Console.Write("Celsius: ");
                        while (!double.TryParse(Console.ReadLine(), out v))
                            Console.Write("Número válido: ");
                        r = (v * 9 / 5) + 32;
                        Console.WriteLine($"Resultado: {r:F2} °F");
                        break;

                    case 2:
                        Console.Write("Fahrenheit: ");
                        while (!double.TryParse(Console.ReadLine(), out v))
                            Console.Write("Número válido: ");
                        r = (v - 32) * 5 / 9;
                        Console.WriteLine($"Resultado: {r:F2} °C");
                        break;

                    case 3:
                        Console.Write("Kilómetros: ");
                        while (!double.TryParse(Console.ReadLine(), out v))
                            Console.Write("Número válido: ");
                        r = v * 0.621371;
                        Console.WriteLine($"Resultado: {r:F2} Millas");
                        break;

                    case 4:
                        s = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (!s);
        }

        static void E3()
        {
            Console.WriteLine("\n--- Ejercicio 3 ---");
            Random r = new Random();
            int na = r.Next(1, 101);
            int i, c = 0;
            bool ok = false;

            Console.WriteLine("Adivina el número (1-100)");

            while (!ok)
            {
                Console.Write("Intento: ");
                while (!int.TryParse(Console.ReadLine(), out i))
                    Console.Write("Número válido: ");

                if (i < 1 || i > 100)
                {
                    Console.WriteLine("Fuera de rango.");
                    continue;
                }

                c++;

                if (i < na)
                    Console.WriteLine("Más alto");
                else if (i > na)
                    Console.WriteLine("Más bajo");
                else
                {
                    ok = true;
                    Console.WriteLine($"Correcto en {c} intentos");
                }
            }
        }

        static void E4()
        {
            Console.WriteLine("\n--- Ejercicio 4 ---");
            const int pc = 1234;
            const int mi = 3;
            int pi, c = 0;
            bool ok = false;

            do
            {
                Console.Write("PIN: ");
                while (!int.TryParse(Console.ReadLine(), out pi))
                    Console.Write("Número válido: ");

                c++;

                if (pi == pc)
                {
                    Console.WriteLine("Acceso concedido");
                    ok = true;
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                    if (c < mi)
                        Console.WriteLine($"Intentos restantes: {mi - c}");
                }

            } while (c < mi && !ok);

            if (!ok)
                Console.WriteLine("Cuenta bloqueada");
        }
    }
}
