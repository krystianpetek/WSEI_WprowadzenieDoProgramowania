using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrukturaStos
{
    public class Stos<T> : IStos<T>
    {
        List<T> LISTA;
        public Stos()
        {
            List<T> lista = new List<T>();
            LISTA = lista;
        }

        public T Peek
        {
            get
            {
                if (Count > 0)
                    return LISTA[Count - 1];
                else
                {
                    throw new StosEmptyException();
                }
            }
        }

        public int Count
        {
            get
            {
                return LISTA.Count;
            }


        }

        public bool IsEmpty
        {
            get
            {
                if (Count > 0)
                    return false;
                else
                    return true;
            }
        }

        public void Clear()
        {
            LISTA.Clear();
        }

        public T Pop()
        {
            if (Count > 0)
            {
                var zwroc = LISTA[Count - 1];
                LISTA.RemoveAt(Count - 1);
                return zwroc;
            }
            else
            {
                throw new StosEmptyException();
            }
        }

        public void Push(T value)
        {
            LISTA.Add(value);
        }

        public T[] ToArray()
        {
            T[] tablica = new T[Count];

            for (int x = 0; x < Count; x++)
            {
                tablica[x] = LISTA[x];
            }

            return tablica;
        }

    }
}
