//ejercicio1:
using System;
using System.Collections.Generic;

class Program
{
    static bool EsPrimo(int num)
    {
        if (num <= 1)
            return false;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

    static HashSet<int> NumerosPrimos(int[] conjunto)
    {
        HashSet<int> primos = new HashSet<int>();
        foreach (int num in conjunto)
        {
            if (EsPrimo(num))
            {
                primos.Add(num);
            }
        }
        return primos;
    }

    static void Main(string[] args)
    {
        int[] numeros = { 2, 3, 5, 6, 7, 8, 9, 10 };
        HashSet<int> primos = NumerosPrimos(numeros);
        Console.Write("Números primos: ");
        foreach (int primo in primos)
        {
            Console.Write(primo + " ");
        }
        Console.WriteLine();
    }
}

//ejercicio2:
using System;
using System.Collections.Generic;

class Program
{
    static HashSet<string> PalabrasComienzanCon(string[] palabras, char letra)
    {
        HashSet<string> resultado = new HashSet<string>();
        foreach (string palabra in palabras)
        {
            if (palabra[0] == letra)
            {
                resultado.Add(palabra);
            }
        }
        return resultado;
    }

    static void Main(string[] args)
    {
        string[] palabras = { "hola", "adios", "casa", "carro", "perro" };
        char letra = 'c';
        HashSet<string> palabrasConLetra = PalabrasComienzanCon(palabras, letra);
        Console.Write("Palabras que comienzan con '" + letra + "': ");
        foreach (string palabra in palabrasConLetra)
        {
            Console.Write(palabra + " ");
        }
        Console.WriteLine();
    }
}

//ejercicio3:
using System;
using System.Collections.Generic;

class Program
{
    static HashSet<int> NumerosDivisibles(int[] conjunto, int divisor)
    {
        HashSet<int> resultado = new HashSet<int>();
        foreach (int num in conjunto)
        {
            if (num % divisor == 0)
            {
                resultado.Add(num);
            }
        }
        return resultado;
    }

    static void Main(string[] args)
    {
        int[] numeros = { 2, 4, 6, 8, 10, 12, 15, 20 };
        int divisor = 3;
        HashSet<int> numerosDivisibles = NumerosDivisibles(numeros, divisor);
        Console.Write("Números divisibles por " + divisor + ": ");
        foreach (int num in numerosDivisibles)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

//ejercicio4:
using System;
using System.Collections.Generic;

class Program
{
    static HashSet<int> NumerosEnAmbos(int[] conjunto1, int[] conjunto2)
    {
        HashSet<int> resultado = new HashSet<int>();
        foreach (int num1 in conjunto1)
        {
            foreach (int num2 in conjunto2)
            {
                if (num1 == num2)
                {
                    resultado.Add(num1);
                }
            }
        }
        return resultado;
    }

    static void Main(string[] args)
    {
        int[] numeros1 = { 1, 2, 3, 4, 5 };
        int[] numeros2 = { 3, 4, 5, 6, 7 };
        HashSet<int> numerosEnAmbos = NumerosEnAmbos(numeros1, numeros2);
        Console.Write("Números en ambos conjuntos: ");
        foreach (int num in numerosEnAmbos)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

//ejercicio5:
using System;
using System.Collections.Generic;

class Program
{
    static HashSet<int> NumerosEnPrimerNoEnSegundo(int[] conjunto1, int[] conjunto2)
    {
        HashSet<int> resultado = new HashSet<int>();
        foreach (int num1 in conjunto1)
        {
            bool encontrado = false;
            foreach (int num2 in conjunto2)
            {
                if (num1 == num2)
                {
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                resultado.Add(num1);
            }
        }
        return resultado;
    }

    static void Main(string[] args)
    {
        int[] numeros1 = { 1, 2, 3, 4, 5 };
        int[] numeros2 = { 3, 4, 5, 6, 7 };
        HashSet<int> numerosEnPrimerNoEnSegundo = NumerosEnPrimerNoEnSegundo(numeros1, numeros2);
        Console.Write("Números en el primer conjunto pero no en el segundo: ");
        foreach (int num in numerosEnPrimerNoEnSegundo)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

//ejercicio6:
using System;
using System.Collections.Generic;

class Program
{
    static HashSet<int> NumerosEnSegundoNoEnPrimer(int[] conjunto1, int[] conjunto2)
    {
        HashSet<int> resultado = new HashSet<int>();
        foreach (int num2 in conjunto2)
        {
            bool encontrado = false;
            foreach (int num1 in conjunto1)
            {
                if (num2 == num1)
                {
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                resultado.Add(num2);
            }
        }
        return resultado;
    }

    static void Main(string[] args)
    {
        int[] numeros1 = { 1, 2, 3, 4, 5 };
        int[] numeros2 = { 3, 4, 5, 6, 7 };
        HashSet<int> numerosEnSegundoNoEnPrimer = NumerosEnSegundoNoEnPrimer(numeros1, numeros2);
        Console.Write("Números en el segundo conjunto pero no en el primero: ");
        foreach (int num in numerosEnSegundoNoEnPrimer)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

//ejercicio7:
using System;
using System.Collections.Generic;

class Program
{
    static bool SonAnagramas(string palabra1, string palabra2)
    {
        if (palabra1.Length != palabra2.Length)
        {
            return false;
        }

        Dictionary<char, int> conteoLetras = new Dictionary<char, int>();

        foreach (char letra in palabra1)
        {
            if (conteoLetras.ContainsKey(letra))
            {
                conteoLetras[letra]++;
            }
            else
            {
                conteoLetras[letra] = 1;
            }
        }

        foreach (char letra in palabra2)
        {
            if (!conteoLetras.ContainsKey(letra) || conteoLetras[letra] == 0)
            {
                return false;
            }
            conteoLetras[letra]--;
        }

        return true;
    }

    static HashSet<string> Anagramas(string[] palabras)
    {
        HashSet<string> resultado = new HashSet<string>();

        for (int i = 0; i < palabras.Length; i++)
        {
            for (int j = i + 1; j < palabras.Length; j++)
            {
                if (SonAnagramas(palabras[i], palabras[j]))
                {
                    resultado.Add(palabras[i]);
                    resultado.Add(palabras[j]);
                }
            }
        }

        return resultado;
    }

    static void Main(string[] args)
    {
        string[] palabras = { "roma", "amor", "perro", "orper" };
        HashSet<string> anagramas = Anagramas(palabras);
        Console.Write("Anagramas: ");
        foreach (string palabra in anagramas)
        {
            Console.Write(palabra + " ");
        }
        Console.WriteLine();
    }
}

//ejercicio8:
using System;
using System.Collections.Generic;

class Program
{
    static bool EsPalindromo(string palabra)
    {
        int i = 0;
        int j = palabra.Length - 1;

        while (i < j)
        {
            if (palabra[i] != palabra[j])
            {
                return false;
            }
            i++;
            j--;
        }

        return true;
    }

    static HashSet<string> Palindromos(string[] palabras)
    {
        HashSet<string> resultado = new HashSet<string>();

        foreach (string palabra in palabras)
        {
            if (EsPalindromo(palabra))
            {
                resultado.Add(palabra);
            }
        }

        return resultado;
    }

    static void Main(string[] args)
    {
        string[] palabras = { "ana", "casa", "oso", "reconocer", "perro" };
        HashSet<string> palindromos = Palindromos(palabras);
        Console.Write("Palíndromos: ");
        foreach (string palabra in palindromos)
        {
            Console.Write(palabra + " ");
        }
        Console.WriteLine();
    }
}

//ejercicio9:
using System;
using System.Collections.Generic;

class Program
{
    static HashSet<string> PalabrasLongitud(string[] palabras, int longitud)
    {
        HashSet<string> resultado = new HashSet<string>();

        foreach (string palabra in palabras)
        {
            if (palabra.Length == longitud)
            {
                resultado.Add(palabra);
            }
        }

        return resultado;
    }

    static void Main(string[] args)
    {
        string[] palabras = { "hola", "adios", "casa", "carro", "perro" };
        int longitud = 5;
        HashSet<string> palabrasLongitud = PalabrasLongitud(palabras, longitud);
        Console.Write("Palabras de longitud " + longitud + ": ");
        foreach (string palabra in palabrasLongitud)
        {
            Console.Write(palabra + " ");
        }
        Console.WriteLine();
    }
}

//ejercicio10:
using System;
using System.Collections.Generic;

class Program
{
    static HashSet<string> PalabrasContienenLetra(string[] palabras, char letra)
    {
        HashSet<string> resultado = new HashSet<string>();

        foreach (string palabra in palabras)
        {
            if (palabra.Contains(letra))
            {
                resultado.Add(palabra);
            }
        }

        return resultado;
    }

    static void Main(string[] args)
    {
        string[] palabras = { "hola", "adios", "casa", "carro", "perro" };
        char letra = 'o';
        HashSet<string> palabrasConLetra = PalabrasContienenLetra(palabras, letra);
        Console.Write("Palabras que contienen '" + letra + "': ");
        foreach (string palabra in palabrasConLetra)
        {
            Console.Write(palabra + " ");
        }
        Console.WriteLine();
    }
}

//ejercicio11:
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static HashSet<int> NumerosOrdenadosMenorAMayor(int[] numeros)
    {
        HashSet<int> resultado = new HashSet<int>(numeros);
        resultado.OrderBy(num => num);
        return resultado;
    }

    static void Main(string[] args)
    {
        int[] numeros = { 5, 3, 7, 2, 1, 6, 4 };
        HashSet<int> numerosOrdenados = NumerosOrdenadosMenorAMayor(numeros);
        Console.Write("Números ordenados de menor a mayor: ");
        foreach (int num in numerosOrdenados)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

//ejercicio12:
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static HashSet<int> NumerosOrdenadosMayorAMenor(int[] numeros)
    {
        HashSet<int> resultado = new HashSet<int>(numeros);
        resultado = new HashSet<int>(resultado.OrderByDescending(num => num));
        return resultado;
    }

    static void Main(string[] args)
    {
        int[] numeros = { 5, 3, 7, 2, 1, 6, 4 };
        HashSet<int> numerosOrdenados = NumerosOrdenadosMayorAMenor(numeros);
        Console.Write("Números ordenados de mayor a menor: ");
        foreach (int num in numerosOrdenados)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

//ejercicio13:
using System;
using System.Collections.Generic;

class Program
{
    static HashSet<int> NumerosDuplicados(int[] numeros)
    {
        HashSet<int> conjunto = new HashSet<int>();
        HashSet<int> duplicados = new HashSet<int>();

        foreach (int num in numeros)
        {
            if (!conjunto.Add(num))
            {
                duplicados.Add(num);
            }
        }

        return duplicados;
    }

    static void Main(string[] args)
    {
        int[] numeros = { 1, 2, 3, 4, 5, 3, 6, 7, 2, 8 };
        HashSet<int> numerosDuplicados = NumerosDuplicados(numeros);
        Console.Write("Números duplicados: ");
        foreach (int num in numerosDuplicados)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

//ejercicio14:
using System;
using System.Collections.Generic;

class Program
{
    static HashSet<int> NumerosNoDuplicados(int[] numeros)
    {
        HashSet<int> conjunto = new HashSet<int>();
        HashSet<int> noDuplicados = new HashSet<int>();

        foreach (int num in numeros)
        {
            if (!conjunto.Add(num))
            {
                noDuplicados.Remove(num);
            }
            else
            {
                noDuplicados.Add(num);
            }
        }

        return noDuplicados;
    }

    static void Main(string[] args)
    {
        int[] numeros = { 1, 2, 3, 4, 5, 3, 6, 7, 2, 8 };
        HashSet<int> numerosNoDuplicados = NumerosNoDuplicados(numeros);
        Console.Write("Números que no están duplicados: ");
        foreach (int num in numerosNoDuplicados)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

//ejercicio15:
using System;
using System.Collections.Generic;

class Program
{
    static bool EsPrimo(int num)
    {
        if (num <= 1)
            return false;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

    static HashSet<int> NumerosPrimosOrdenados(int[] numeros)
    {
        HashSet<int> primos = new HashSet<int>();
        foreach (int num in numeros)
        {
            if (EsPrimo(num))
            {
                primos.Add(num);
            }
        }
        List<int> listaPrimos = new List<int>(primos);
        listaPrimos.Sort();
        return new HashSet<int>(listaPrimos);
    }

    static void Main(string[] args)
    {
        int[] numeros = { 2, 3, 5, 6, 7, 8, 9, 10 };
        HashSet<int> primosOrdenados = NumerosPrimosOrdenados(numeros);
        Console.Write("Números primos ordenados de menor a mayor: ");
        foreach (int primo in primosOrdenados)
        {
            Console.Write(primo + " ");
        }
        Console.WriteLine();
    }
}

//ejercicio16:
using System;
using System.Collections.Generic;

class Program
{
    static bool EsPalindromo(string palabra)
    {
        int i = 0;
        int j = palabra.Length - 1;

        while (i < j)
        {
            if (palabra[i] != palabra[j])
            {
                return false;
            }
            i++;
            j--;
        }

        return true;
    }

    static HashSet<string> PalindromosOrdenados(string[] palabras)
    {
        HashSet<string> palindromos = new HashSet<string>();
        foreach (string palabra in palabras)
        {
            if (EsPalindromo(palabra))
            {
                palindromos.Add(palabra);
            }
        }
        List<string> listaPalindromos = new List<string>(palindromos);
        listaPalindromos.Sort();
        return new HashSet<string>(listaPalindromos);
    }

    static void Main(string[] args)
    {
        string[] palabras = { "ana", "casa", "oso", "reconocer", "perro" };
        HashSet<string> palindromosOrdenados = PalindromosOrdenados(palabras);
        Console.Write("Palíndromos ordenados de menor a mayor: ");
        foreach (string palindromo in palindromosOrdenados)
        {
            Console.Write(palindromo + " ");
        }
        Console.WriteLine();
    }
}

//ejercicio17:
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static HashSet<string> PalabrasLongitudOrdenadas(string[] palabras, int longitud)
    {
        HashSet<string> palabrasFiltradas = new HashSet<string>(palabras.Where(p => p.Length == longitud));
        List<string> palabrasOrdenadas = palabrasFiltradas.OrderBy(p => p).ToList();
        return new HashSet<string>(palabrasOrdenadas);
    }

    static void Main(string[] args)
    {
        string[] palabras = { "hola", "adios", "casa", "carro", "perro" };
        int longitud = 5;
        HashSet<string> palabrasLongitudOrdenadas = PalabrasLongitudOrdenadas(palabras, longitud);
        Console.Write("Palabras de longitud " + longitud + " ordenadas de menor a mayor: ");
        foreach (string palabra in palabrasLongitudOrdenadas)
        {
            Console.Write(palabra + " ");
        }
        Console.WriteLine();
    }
}

//ejercicio18:
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static HashSet<string> PalabrasContienenLetraOrdenadas(string[] palabras, char letra)
    {
        HashSet<string> palabrasFiltradas = new HashSet<string>(palabras.Where(p => p.Contains(letra)));
        List<string> palabrasOrdenadas = palabrasFiltradas.OrderByDescending(p => p).ToList();
        return new HashSet<string>(palabrasOrdenadas);
    }

    static void Main(string[] args)
    {
        string[] palabras = { "hola", "adios", "casa", "carro", "perro" };
        char letra = 'a';
        HashSet<string> palabrasConLetraOrdenadas = PalabrasContienenLetraOrdenadas(palabras, letra);
        Console.Write("Palabras que contienen '" + letra + "' ordenadas de mayor a menor: ");
        foreach (string palabra in palabrasConLetraOrdenadas)
        {
            Console.Write(palabra + " ");
        }
        Console.WriteLine();
    }
}

//ejercicio19:
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static HashSet<int> NumerosOrdenadosNoDuplicados(int[] numeros)
    {
        HashSet<int> conjunto = new HashSet<int>(numeros);
        List<int> numerosOrdenados = conjunto.OrderBy(num => num).ToList();
        return new HashSet<int>(numerosOrdenados);
    }

    static void Main(string[] args)
    {
        int[] numeros = { 5, 3, 7, 2, 1, 6, 4, 3, 5, 1 };
        HashSet<int> numerosOrdenadosNoDuplicados = NumerosOrdenadosNoDuplicados(numeros);
        Console.Write("Números ordenados de menor a mayor y no duplicados: ");
        foreach (int num in numerosOrdenadosNoDuplicados)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

//ejercicio20:
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static bool EsPalindromo(string palabra)
    {
        int i = 0;
        int j = palabra.Length - 1;

        while (i < j)
        {
            if (palabra[i] != palabra[j])
            {
                return false;
            }
            i++;
            j--;
        }

        return true;
    }

    static HashSet<string> PalindromosLongitudOrdenados(string[] palabras, int longitud)
    {
        HashSet<string> palindromos = new HashSet<string>();

        foreach (string palabra in palabras)
        {
            if (palabra.Length == longitud && EsPalindromo(palabra))
            {
                palindromos.Add(palabra);
            }
        }

        List<string> palindromosOrdenados = palindromos.OrderBy(p => p).ToList();
        return new HashSet<string>(palindromosOrdenados);
    }

    static void Main(string[] args)
    {
        string[] palabras = { "ana", "casa", "oso", "reconocer", "perro" };
        int longitud = 3;
        HashSet<string> palindromosLongitudOrdenados = PalindromosLongitudOrdenados(palabras, longitud);
        Console.Write("Palíndromos de longitud " + longitud + " y ordenados de menor a mayor: ");
        foreach (string palindromo in palindromosLongitudOrdenados)
        {
            Console.Write(palindromo + " ");
        }
        Console.WriteLine();
    }
}

