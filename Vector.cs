using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Vector
    {
        public int[] array { get; set; }
        public Vector(params int[] x)
        {
            array = new int[x.Length];
            Array.Copy(x, array, array.Length);
        }

        public override string ToString()
        {
            string result = string.Empty;
            foreach (int x in array)
            {
                result += $"{x.ToString()}, ";
            }
            return result;
        }

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length) { return array[index]; }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index < 0)
                {
                    index = array.Length + index;
                    array[index] = value;
                    return;
                }
                array[index] = value;
                return;
            }
        }
    }
}