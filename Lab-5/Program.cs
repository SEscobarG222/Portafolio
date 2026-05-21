// Ejercicio 1:

Console.WriteLine("Ejercicio 1:");
Console.WriteLine();

int Id_usuario, PIN, token_seguridad, modo_seg;

Console.Write("Ingrese su usuario: ");
Id_usuario = int.Parse(Console.ReadLine());



if (Id_usuario == 2026)
{

    Console.WriteLine("Usuario reconocido");
    Console.WriteLine();
}
else
{

    Console.WriteLine("Usuario no reconocido");
    Console.WriteLine();

}

Console.Write("Ingrese su PIN: ");
PIN = int.Parse(Console.ReadLine());

if (PIN == 1234)
{
    Console.WriteLine("PIN correcto");
}
else
{

    Console.WriteLine("PIN incorrecto");
}



Console.WriteLine();
Console.Write("Ingrese el token de seguridad: ");
token_seguridad = int.Parse(Console.ReadLine());

if (token_seguridad == 777)
{

    Console.WriteLine("Token valido");
    Console.WriteLine();
}
else
{

    Console.WriteLine("Token invalido");
    Console.WriteLine();
}


Console.Write("desea activar el modo seguro (1/0): ");
modo_seg = int.Parse(Console.ReadLine());

if (modo_seg == 1)
{

    Console.WriteLine("Modo seguro activado");
}
else if (modo_seg == 0)
{

    Console.WriteLine("Modo seguro desactivado");

}

if (Id_usuario == 2026 && PIN == 1234 && token_seguridad == 777)
{
    Console.WriteLine();
    Console.WriteLine("Acceso total concedido");

}
else
{
    Console.WriteLine();
    Console.WriteLine("Acceso total denegado");
}

if (modo_seg == 1 && token_seguridad >= 700)
{
    Console.WriteLine();
    Console.WriteLine("Regla Extra aprobada");
}

else
{
    Console.WriteLine();
    Console.WriteLine("Regla extra invalida");
}

// Ejercicio 2:
Console.WriteLine("Ejercicio 2:");
Console.WriteLine();

int PIN2;

Console.WriteLine("Ingrese su PIN: ");
PIN2 = int.Parse(Console.ReadLine());

if (PIN2 > 999 && PIN2 <= 9999)
{
    Console.WriteLine();
    Console.WriteLine("Su PIN es de 4 digitos: OK");
}
else
{
    Console.WriteLine();
    Console.WriteLine("PIN invalido: debe de tener 4 digitos");
}

if (PIN2 % 2 == 0)
{
    Console.WriteLine();
    Console.WriteLine("Su PIN es par");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Su PIN es impar");
}

if (PIN2 % 5 == 0)
{
    Console.WriteLine();
    Console.WriteLine("Su PIN es multiplo de 5");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Su PIN NO es multiplo de 5");
}

if (PIN2 > 999 && PIN2 <= 9999 && PIN2 % 2 == 0 && PIN2 % 5 != 0)
{
    Console.WriteLine();
    Console.WriteLine("= PIN aceptado por politica");

}
else
{
    Console.WriteLine();
    Console.WriteLine("= PIN rechazado por politica");
}

// Ejercicio 3:

// Ejercicio 3:

Console.WriteLine("Ejercicio 3:");
Console.WriteLine();

int codigo_activacion, edad, term_y_cond, twofa, verificacion;


Console.Write("Ingrese su codigo de verificacion: ");
codigo_activacion = int.Parse(Console.ReadLine());


if (codigo_activacion == 2026)
{

    Console.WriteLine("Codigo correcto");
    Console.WriteLine();
}
else
{

    Console.WriteLine("Codigo incorrecto");
    Console.WriteLine();

}

Console.Write("Ingrese su edad: ");
edad = int.Parse(Console.ReadLine());

if (edad >= 18)
{

    Console.WriteLine("Edad valida");
}
else
{

    Console.WriteLine("Edad invalida");
}

Console.WriteLine();
Console.Write("Acepta los terminos o condiciones (1 = si / 0 = no): ");
term_y_cond = int.Parse(Console.ReadLine());


if (term_y_cond == 1)
{

    Console.WriteLine("Terminos aceptados");
}
else if (term_y_cond == 0)
{

    Console.WriteLine("Debe de aceptar los terminos y condiciones");

}

Console.WriteLine();
Console.Write("Autentificacion de 2 factores? (1 = si / 0 = no)  ");
twofa = int.Parse(Console.ReadLine());

if (twofa == 1)
{

    Console.WriteLine("2FA activado");
}
else if (term_y_cond == 0)
{

    Console.WriteLine("2FA deshabilitado");
}

Console.WriteLine();
Console.Write("Puntaje (0 - 100): ");
verificacion = int.Parse(Console.ReadLine());

if (verificacion >= 70)
{

    Console.WriteLine("Puntaje suficiente");
}
else
{

    Console.WriteLine("Puntaje insuficiente");
}



if (codigo_activacion == 2026 && edad >= 18 && term_y_cond == 1 && twofa == 1 && verificacion >= 70)
{
    Console.WriteLine();
    Console.WriteLine("CUENTA ACTIVADA EXITOSAMENTE");
}
else
{
    Console.WriteLine();
    Console.WriteLine("CUENTA NO ACTIVADA");

}

//Ejercicio 4:

Console.WriteLine("Ejercicio 4:");
Console.WriteLine();

int nota_previa, min_tarde, solvencia, id, calculadora;

Console.Write("Ingrese la nota previa: ");
nota_previa = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.Write("Ingrese los minutos de llegada tarde: ");
min_tarde = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.Write("Tiene solvencia de pagos (1 = si/ 0 = no): ");
solvencia = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.Write("Tiene Identificacion fisica (1 = si/ 0 = no): ");
id = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.Write("Tiene una calculadora permitida (1 = si/ 0 = no): ");
calculadora = int.Parse(Console.ReadLine());


if (nota_previa >= 61)
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("REQUISITO ACADEMICO APROBADO");
}
else
{
    Console.WriteLine();
    Console.WriteLine("REQUISITO ACADEMICO NO APROBADO");
}


if (min_tarde <= 10)
{
    Console.WriteLine();
    Console.WriteLine("HORA VALIDA");
}

if (min_tarde <= 10 && min_tarde > 0)
{
    Console.WriteLine("Advertencia: El estudiante llego tarde pero puede ingresar");
}
else
{
    Console.WriteLine();
    Console.WriteLine("LLEGADA TARDE: fuera de tiempo");

}



if (solvencia == 1)
{
    Console.WriteLine();
    Console.WriteLine("Solvencia validada");
}
if (solvencia == 0)
{
    Console.WriteLine();
    Console.WriteLine("Sin solvencia");
}

if (id == 1)
{
    Console.WriteLine();
    Console.WriteLine("Identificacion validada");
}
if (id == 0)
{
    Console.WriteLine();
    Console.WriteLine("Sin identificacion");
}






if (calculadora == 1)
{
    Console.WriteLine();
    Console.WriteLine("Calculadora aceptada");
}
if (calculadora == 0)
{
    Console.WriteLine();
    Console.WriteLine("Calculadora no permitida");
}


if (nota_previa >= 61 && min_tarde <= 10 && solvencia == 1 && id == 1 && calculadora == 1)
{
    Console.WriteLine();
    Console.WriteLine("ACCESO A LA SALA DE EXAMEN CONCEDIDO");
}
else
{
    Console.WriteLine();
    Console.WriteLine("ACCESO DENEGADO");

}

// Bonus ejercicio

using System;

namespace San ValentinHackerEdition
{
    class Program
{
    static void Main(string[] args)
    {
 

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("========================================");
        Console.WriteLine("   💘 SAN VALENTÍN HACKER EDITION 💘   ");
        Console.WriteLine("========================================");
        Console.ResetColor();
        Console.WriteLine();

        // Solicitar datos al usuario
        Console.Write("👉 Ingresa el nombre de la persona: ");
        string nombre = Console.ReadLine();

        Console.Write("👉 Nivel de valentía (0-100): ");
        int valentia = int.Parse(Console.ReadLine());

        Console.Write("👉 ¿Le gusta la programación? (1=Sí, 0=No): ");
        int programacion = int.Parse(Console.ReadLine());

        Console.Write("👉 ¿Le gustan los memes técnicos? (1=Sí, 0=No): ");
        int memes = int.Parse(Console.ReadLine());

        Console.Write("👉 Nivel de interés (0-100): ");
        int interes = int.Parse(Console.ReadLine());

        Console.Write("👉 ¿Está soltera/o? (1=Sí, 0=No): ");
        int soltera = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("           ANÁLISIS DE DATOS       ");
        Console.WriteLine("========================================");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" ANÁLISIS DE INTERÉS:");
        Console.ResetColor();
        if (interes >= 70)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("   ✓ Interés alto detectado.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   ✗ Interés insuficiente. Riesgo de friend zone elevado.");
        }
        Console.ResetColor();
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("🔍 ANÁLISIS DE VALENTÍA:");
        Console.ResetColor();
        if (valentia >= 70)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("   ✓ Valentía favorable. Confía en sí mismo(a).");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   ✗ Nivel de valentía bajo. Actualización de hardware requerida (vaya al gym).");
        }
        Console.ResetColor();
        Console.WriteLine();


        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" ANÁLISIS ESTADO SENTIMENTAL:");
        Console.ResetColor();
        if (soltera == 1)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("   ✓ Estado sentimental favorable… aunque lo esté, no le crea: todos/todas mienten.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   ✗ Estado sentimental comprometido, no es recomendable hackear esa relación.");
        }
        Console.ResetColor();
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("🔍 ANÁLISIS COMPATIBILIDAD TÉCNICA:");
        Console.ResetColor();
        if (programacion == 1 && memes == 1)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("   ✓ Compatibilidad geek detectada. 💻🧡");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   ✗ Compatibilidad parcial o inexistente.");
        }
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("          🎯 DECISIÓN FINAL 🎯         ");
        Console.WriteLine("========================================");
        Console.WriteLine();

        if (interes >= 70 && soltera == 1 && programacion == 1 && memes == 1 && valentia >= 70)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║  DECLARACIÓN APROBADA.                ║");
            Console.WriteLine("║  Proceder con chocolates y flores.    ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
        }
        else if (interes >= 70 && soltera == 1 && programacion == 1 && memes == 1 && valentia < 70)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║  ¡No le tenga miedo al éxito!          ║");
            Console.WriteLine("║  Que la vida solo hay 1.               ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"╔════════════════════════════════════════╗");
            Console.WriteLine($"║  {nombre}, no te ama... por ahora.     ║");
            Console.WriteLine($"╚════════════════════════════════════════╝");
        }

        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
}