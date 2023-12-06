using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Collection = new CustomList<String>();
            Collection[0] = "Payal Bansal";
            Collection[1] = "Khushi Varshney";
            Collection[2] = "Vaishnavi Tripathi";
            Collection[3] = "Vandana";
            Collection[4] = "Urvashi Saini";
            Console.WriteLine("Payal's Friendlist : ");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(Collection[i]);
        }
    }
    class CustomList<T>
    {
        private T[] list = new T[5];
        public T this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }
    }
}