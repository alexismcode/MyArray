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
            _array = new int[n]; // 10 posiciones
            _top = 0; // tope sercero
            N = n; // mi parte fisica
        }

        public int N { get; } // Lectura

        public bool IsFull => _top == N; // El arreglo esta lleno
        public bool IsEmpty => _top == 0; // El arreglo esta vacio

        public void Fill(int minimo, int maximo)
        {
            Random random = new Random();
            for (int contador = 0; contador < N; contador++)
            {
                _array[contador] = random.Next(minimo, maximo);
            }
            _top = N;
        }

        public Arreglos Pares()
        {
            int countPar = 0;
            for (int i = 0; i < _top; i++)
            {
                if (_array[i] % 2 == 0)
                {
                    countPar++;
                }
            }
            var getPares = new Arreglos(countPar);
            for (int i = 0; i < _top; i++)
            {
                if (_array[i] % 2 == 0)
                {
                    getPares.Add(_array[i]);
                }
            }
            return getPares;
        }
        
        // Sort descendente
        public void Sort()
        {
            Sort(false);

        }

        // Ordenamiento ( metodo de burbuja)
        public void Sort(bool desc)
        {
            for (int i = 0; i < _top - 1; i++)
            {
                for(int j = i + 1; j < _top; j++)
                {
                    if (desc)
                    {
                        if (_array[i] < _array[j])
                        {
                            Change(ref _array[i], ref _array[j]);
                        }
                    }
                    else
                    {
                        if (_array[i] > _array[j])
                        {
                            Change(ref _array[i], ref _array[j]);
                        }
                    }
                }
            }
        }

        public void Add(int n)
        {
            if (IsFull)
            {
                throw new Exception("This array is full");
            }
            _array[_top] = n;
            _top++;
        }

        public void Insert(int position, int number)
        {
            if (IsFull)
            {
                throw new Exception("This array is full");
            }

            if (position < 0) position = 0;
            if (position > _top) position = _top; 

            for (int i = _top; i > position; i--)
            {
                _array[i] = _array[i - 1];
            }
            _array[position] = number;
            _top++;
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
            var aux = a;
            a = b;
            b = aux;
        }
    }
}
