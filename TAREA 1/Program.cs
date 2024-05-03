//ejercicio.1
using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Ingrese el primer número:");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        double numero2 = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine($"La suma de {numero1} y {numero2} es: {numero1 + numero2}");


        Console.WriteLine("Presione cualquier tecla para cerrar la ventana...");


        Console.ReadKey();
    }
}
//ejercicio.2
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la base del triángulo:");
        double baseTriangulo;


        while (!double.TryParse(Console.ReadLine(), out baseTriangulo) || baseTriangulo <= 0)
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número positivo para la base del triángulo:");
        }


        Console.WriteLine("Ingrese la altura del triángulo:");
        double alturaTriangulo;


        while (!double.TryParse(Console.ReadLine(), out alturaTriangulo) || alturaTriangulo <= 0)
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número positivo para la altura del triángulo:");
        }


        double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;


        Console.WriteLine($"El área del triángulo con base {baseTriangulo} y altura {alturaTriangulo} es: {areaTriangulo}");
    }
}
//ejercicio 3 :
using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Ingrese la base del triángulo:");
        double baseTriangulo;


        while (!double.TryParse(Console.ReadLine(), out baseTriangulo) || baseTriangulo <= 0)
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número positivo para la base del triángulo:");
        }


        Console.WriteLine("Ingrese la altura del triángulo:");
        double alturaTriangulo;


        while (!double.TryParse(Console.ReadLine(), out alturaTriangulo) || alturaTriangulo <= 0)
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número positivo para la altura del triángulo:");
        }
        double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;


        Console.WriteLine($"El área del triángulo con base {baseTriangulo} y altura {alturaTriangulo} es: {areaTriangulo}");
    }
}
//ejercicio 4:
using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Ingrese un número para calcular su factorial:");
        int numero;


        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero no negativo:");
        }


        long factorial = CalcularFactorial(numero);


        Console.WriteLine($"El factorial de {numero} es: {factorial}");
    }

    static long CalcularFactorial(int n)
    {

        long factorial = 1;


        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}
//ejercicio 5:
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número para verificar si es primo:");
        int numero;


        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 2)
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero mayor o igual a 2:");
        }

        bool esPrimo = VerificarPrimo(numero);


        if (esPrimo)
        {
            Console.WriteLine($"El número {numero} es primo.");
        }
        else
        {
            Console.WriteLine($"El número {numero} no es primo.");
        }
    }

    static bool VerificarPrimo(int n)
    {
        if (n == 2)
        {
            return true;
        }

        if (n % 2 == 0)
        {
            return false;
        }

        int limite = (int)Math.Sqrt(n);
        for (int i = 3; i <= limite; i += 2)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
//ejercicio 6:
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese una cadena de texto:");
        string texto = Console.ReadLine();

        string textoInvertido = InvertirCadena(texto);
        Console.WriteLine($"La cadena invertida es: {textoInvertido}");
    }

    static string InvertirCadena(string cadena)
    {

        char[] caracteres = cadena.ToCharArray();


        Array.Reverse(caracteres);


        string cadenaInvertida = new string(caracteres);

        return cadenaInvertida;
    }
}
//ejercicio 7:
using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Ingrese el número inicial del rango:");
        int inicio;
        while (!int.TryParse(Console.ReadLine(), out inicio))
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero:");
        }

        Console.WriteLine("Ingrese el número final del rango:");
        int fin;
        while (!int.TryParse(Console.ReadLine(), out fin) || fin < inicio)
        {
            Console.WriteLine($"Entrada no válida. Por favor, ingrese un número entero mayor o igual a {inicio}:");
        }


        int sumaPares = CalcularSumaPares(inicio, fin);


        Console.WriteLine($"La suma de los números pares en el rango [{inicio}, {fin}] es: {sumaPares}");
    }

    static int CalcularSumaPares(int inicio, int fin)
    {
        int suma = 0;

        for (int i = inicio; i <= fin; i++)
        {
            if (i % 2 == 0)
            {
                suma += i;
            }
        }
        return suma;
    }
}
//ejercicio 8:
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        List<int> cuadrados = new List<int>();


        for (int i = 1; i <= 10; i++)
        {
            int cuadrado = i * i; // Calculamos el cuadrado de cada número
            cuadrados.Add(cuadrado); // Agregamos el cuadrado a la lista
        }


        Console.WriteLine("Los cuadrados de los primeros 10 números naturales son:");
        foreach (int numero in cuadrados)
        {
            Console.WriteLine(numero);
        }
    }
}
//ejercicio 9 :
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese una cadena de texto:");
        string texto = Console.ReadLine();


        int contadorVocales = ContarVocales(texto);


        Console.WriteLine($"El número de vocales en la cadena de texto es: {contadorVocales}");
    }

    static int ContarVocales(string cadena)
    {

        cadena = cadena.ToLower();


        int contador = 0;


        foreach (char caracter in cadena)
        {

            if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u')
            {
                contador++;
            }
        }

        return contador;
    }
}
//ejercicio 10 :
using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Los primeros 10 números de la serie Fibonacci son:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
//ejercicio 11:
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese los números separados por espacios:");
        string entrada = Console.ReadLine();


        string[] numerosString = entrada.Split(' ');


        List<int> numeros = new List<int>();
        foreach (string numeroString in numerosString)
        {
            if (int.TryParse(numeroString, out int numero))
            {
                numeros.Add(numero);
            }
            else
            {
                Console.WriteLine($"El valor '{numeroString}' no es un número entero válido y será ignorado.");
            }
        }


        numeros.Sort();


        Console.WriteLine("Números ordenados de menor a mayor:");
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }
    }
}
//ejercicio 12:
using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Ingrese una palabra:");
        string palabra = Console.ReadLine();


        bool esPalindromo = VerificarPalindromo(palabra);


        if (esPalindromo)
        {
            Console.WriteLine($"La palabra '{palabra}' es un palíndromo.");
        }
        else
        {
            Console.WriteLine($"La palabra '{palabra}' no es un palíndromo.");
        }
    }

    static bool VerificarPalindromo(string palabra)
    {

        palabra = palabra.ToLower();


        for (int i = 0; i < palabra.Length / 2; i++)
        {
            if (palabra[i] != palabra[palabra.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}
//ejercicio 13:
using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Ingrese un número para generar su tabla de multiplicar:");
        int numero;
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero:");
        }


        Console.WriteLine($"Tabla de multiplicar del {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    }
}
//ejercicio 14:
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el radio del círculo:");
        double radio;

        while (!double.TryParse(Console.ReadLine(), out radio) || radio <= 0)
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número positivo para el radio del círculo:");
        }


        double area = Math.PI * Math.Pow(radio, 2);


        Console.WriteLine($"El área del círculo con radio {radio} es: {area}");
    }
}
//ejercicio 15:
using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Ingrese un número entero:");
        int numero;

        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero:");
        }

        int sumaDigitos = CalcularSumaDigitos(numero);

        Console.WriteLine($"La suma de los dígitos de {numero} es: {sumaDigitos}");
    }

    static int CalcularSumaDigitos(int n)
    {
        int suma = 0;

        while (n != 0)
        {
            suma += n % 10;
            n /= 10;
        }
        return suma;
    }
}