using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray.Logic
{
    public class Arreglos
    {
        private int[] _array;
        private int _top;

        public Arreglos(int n)
        {
            _array = new int[n]; // Inicializa un nuevo arreglo con capacidad para 'n' elementos
            _top = 0; // Inicializa el tope en cero
            N = n; // Establece la propiedad de solo lectura 'N' con el valor 'n'
        }

        public int N { get; } // Propiedad que devuelve la capacidad del arreglo

        public bool IsFull => _top == N; // Devuelve verdadero si el arreglo está lleno
        public bool IsEmpty => _top == 0; // Devuelve verdadero si el arreglo está vacío

        public void Fill(int minimo, int maximo)
        {
            // Llena el arreglo con valores aleatorios en el rango [minimo, maximo)
            Random random = new Random();
            for (int contador = 0; contador < N; contador++)
            {
                _array[contador] = random.Next(minimo, maximo);
            }
            _top = N; // Establece el tope en el tamaño del arreglo
        }

        public Arreglos NotRepetidos()
        {
            // Devuelve un nuevo arreglo con los números no repetidos del arreglo original
            int countNotRepet = 0;
            for (int i = 0; i < _top; i++) // Itera a través de cada elemento del arreglo original.
            {
                bool IsRepet = false; // Inicializa una bandera para rastrear si el número en la posición 'i' es repetido.

                for (int j = 0; j < _top; j++) // Itera a través de todos los elementos del arreglo para comparar con el elemento en la posición 'i'.
                {
                    if (i != j) // Si 'i' es diferente de 'j', lo que significa que no estamos comparando el mismo elemento consigo mismo.
                    {
                        if (_array[i] == _array[j]) // Compara si el elemento en la posición 'i' es igual al elemento en la posición 'j'.
                        {
                            IsRepet = true; // Si son iguales, marca la bandera como verdadera para indicar que el número se repite.
                            break; // Sale del bucle interno, ya que no es necesario seguir buscando repeticiones.
                        }
                    }
                }

                if (!IsRepet) // Si la bandera 'IsRepet' es falsa, significa que el número en la posición 'i' no se repite.
                {
                    countNotRepet++; // Incrementa el contador de números no repetidos.
                }
            }

            var nonRepet = new Arreglos(countNotRepet); // Crea un nuevo arreglo 'nonRepet' con capacidad para la cantidad de números no repetidos.

            for (int i = 0; i < _top; i++) // Itera a través de cada elemento del arreglo original.
            {
                bool IsRepet = false; // Inicializa una bandera para rastrear si el número en la posición 'i' es repetido.

                for (int j = 0; j < _top; j++) // Itera a través de todos los elementos del arreglo para comparar con el elemento en la posición 'i'.
                {
                    if (i != j) // Si 'i' es diferente de 'j', lo que significa que no estamos comparando el mismo elemento consigo mismo.
                    {
                        if (_array[i] == _array[j]) // Compara si el elemento en la posición 'i' es igual al elemento en la posición 'j'.
                        {
                            IsRepet = true; // Si son iguales, marca la bandera como verdadera para indicar que el número se repite.
                            break; // Sale del bucle interno, ya que no es necesario seguir buscando repeticiones.
                        }
                    }
                }

                if (!IsRepet) // Si la bandera 'IsRepet' es falsa, significa que el número en la posición 'i' no se repite.
                {
                    nonRepet.Add(_array[i]); // Agrega el número no repetido al nuevo arreglo 'nonRepet'.
                }
            }
            return nonRepet;

        }
        public Arreglos Primos()
        {
            // Devuelve un nuevo arreglo con los números primos del arreglo original
            int countPrimo = 0;
            for (int i = 0; i < _top; i++) // Itera a través de cada elemento del arreglo original.
            {
                if (IsPrimo(_array[i])) // Verifica si el número en la posición 'i' es un número primo.
                {
                    countPrimo++; // Incrementa el contador de números primos.
                }
            }

            var getPrimo = new Arreglos(countPrimo); // Crea un nuevo arreglo 'getPrimo' con capacidad para la cantidad de números primos.

            for (int i = 0; i < _top; i++) // Itera a través de cada elemento del arreglo original.
            {
                if (IsPrimo(_array[i])) // Verifica si el número en la posición 'i' es un número primo.
                {
                    getPrimo.Add(_array[i]); // Agrega el número primo al nuevo arreglo 'getPrimo'.
                }
            }
            return getPrimo;
        }
        public Arreglos Pares()
        {
            // Devuelve un nuevo arreglo con los números pares del arreglo original
            int countPar = 0;
            for (int i = 0; i < _top; i++) // Itera a través de cada elemento del arreglo original.
            {
                if (_array[i] % 2 == 0) // Verifica si el número en la posición 'i' es par.
                {
                    countPar++; // Incrementa el contador de números pares.
                }
            }

            var getPares = new Arreglos(countPar); // Crea un nuevo arreglo 'getPares' con capacidad para la cantidad de números pares.

            for (int i = 0; i < _top; i++) // Itera a través de cada elemento del arreglo original.
            {
                if (_array[i] % 2 == 0) // Verifica si el número en la posición 'i' es par.
                {
                    getPares.Add(_array[i]); // Agrega el número par al nuevo arreglo 'getPares'.
                }
            }
            return getPares;
        }
        
        public Arreglos MoreNumbersRepit()
        {
            // Devuelve un nuevo arreglo con los números más repetidos del arreglo original
            int[,] matrixCount = new int[_top, 2]; // Matriz para almacenar el número y su contador de repeticiones
            int topeMatriz = 0; // Variable que indica la cantidad de elementos únicos en la matriz

            // Fill matriz
            for (int i = 0; i < _top; i++) // Itera a través de cada elemento del arreglo original
            {
                int j = 0;
                for (; j < topeMatriz && _array[i] != matrixCount[j, 0]; j++) ;
                if (j == topeMatriz) // Si el número no se encuentra en la matriz
                {
                    matrixCount[j, 0] = _array[i]; // Almacena el número en la matriz
                    matrixCount[j, 1] = 1; // Inicializa su contador de repeticiones en 1
                    topeMatriz++; // Incrementa la cantidad de elementos únicos en la matriz
                }
                else // Si el número ya se encuentra en la matriz
                {
                    matrixCount[j, 1]++; // Incrementa el contador de repeticiones del número
                }
            }

            // Sort matriz
            for (int i = 0; i < topeMatriz - 1; i++)
                for (int j = i + 1; j < topeMatriz; j++)
                    if (matrixCount[i, 1] < matrixCount[j, 1]) // Ordena la matriz por el contador de repeticiones en orden descendente
                    {
                        Change(ref matrixCount[i, 0], ref matrixCount[j, 0]); // Intercambia los números
                        Change(ref matrixCount[i, 1], ref matrixCount[j, 1]); // Intercambia los contadores de repeticiones
                    }

            // More Number Repet
            var countRepet = 1; // Contador para el número de elementos con más repeticiones
            for (int i = 0; i < topeMatriz; i++) // Itera a través de la matriz ordenada
            {
                if (matrixCount[0, 1] == matrixCount[i + 1, 1]) // Compara el contador del elemento actual con el siguiente
                {
                    countRepet++; // Incrementa el contador si tienen la misma cantidad de repeticiones
                }
            }
            var moreRepetNumber = new Arreglos(countRepet); // Crea un nuevo arreglo para almacenar los números más repetidos
            for (int i = 0; i < countRepet; i++) // Itera hasta el número de elementos con más repeticiones
            {
                moreRepetNumber.Add(matrixCount[i, 0]); // Agrega el número más repetido al nuevo arreglo
            }


            return moreRepetNumber;
        }
        // Sort descendente
        public void Sort()
        {
            Sort(false);

        }

        // Ordenamiento ( metodo de burbuja)
        public void Sort(bool desc)
        {
            for (int i = 0; i < _top - 1; i++) // Itera a través de los elementos del arreglo
            {
                for (int j = i + 1; j < _top; j++) // Itera a través de los elementos restantes después de i
                {
                    if (desc) // Si se desea ordenar en orden descendente
                    {
                        if (_array[i] < _array[j]) // Compara los elementos para determinar si deben intercambiarse
                        {
                            Change(ref _array[i], ref _array[j]); // Intercambia los elementos usando el método Change
                        }
                    }
                    else // Si se desea ordenar en orden ascendente (el valor por defecto)
                    {
                        if (_array[i] > _array[j]) // Compara los elementos para determinar si deben intercambiarse
                        {
                            Change(ref _array[i], ref _array[j]); // Intercambia los elementos usando el método Change
                        }
                    }
                }
            }
        }

        public void Add(int n)
        {
            if (IsFull) // Verifica si el arreglo está lleno
            {
                throw new Exception("This array is full"); // Lanza una excepción indicando que el arreglo está lleno
            }
            _array[_top] = n; // Agrega el número n al final del arreglo
            _top++; // Incrementa el contador de elementos en el arreglo
        }

        public void Insert(int position, int number)
        {
            if (IsFull) // Verifica si el arreglo está lleno
            {
                throw new Exception("This array is full"); // Lanza una excepción indicando que el arreglo está lleno
            }

            if (position < 0) position = 0; // Ajusta la posición para asegurarse de que no sea negativa
            if (position > _top) position = _top; // Ajusta la posición para asegurarse de que no exceda el tope actual

            // Desplaza los elementos desde la posición hacia adelante para hacer espacio para el nuevo número
            for (int i = _top; i > position; i--)
            {
                _array[i] = _array[i - 1];
            }

            _array[position] = number; // Inserta el número en la posición indicada
            _top++; // Incrementa el contador de elementos en el arreglo
        }

        public override string ToString()
        {
            string output = string.Empty;
            int count = 0;
            for (int i = 0; i < _top; i++)
            {
                if (count > 9)
                {
                    output += "\n";
                    count = 0;
                }
                output += $"{_array[i]}\t";
                count++;
            }
            return output;
        }

        private void Change(ref int a, ref int b)
        {
            // Intercambia los valores de 'a' y 'b'
            var aux = a;
            a = b;
            b = aux;
        }
        private bool IsPrimo(int n)
        {
            // Devuelve verdadero si 'n' es un número primo, falso en caso contrario
            if (n == 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
