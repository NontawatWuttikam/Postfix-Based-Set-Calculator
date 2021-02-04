using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sets
{
    public class ArraySet : ICloneable
    {
        private ArrayList data;
        private int SIZE;
        public ArraySet(String Snumber)
        {
            data = new ArrayList();
            addString(Snumber);
        }
        public ArraySet()
        {
            data = new ArrayList();
        }
        public bool addString(String Snumber)
        {
            String temp = "";
            try
            {
                foreach (char i in Snumber)
                {
                    if (i.Equals(' '))
                    {
                        add(double.Parse(temp));
                        temp = "";
                    }
                    else if (!i.Equals('.')&&!i.Equals(' ') && !i.Equals('0') && !i.Equals('1') && !i.Equals('2') && !i.Equals('3') && !i.Equals('4') && !i.Equals('5') && !i.Equals('6') && !i.Equals('7') && !i.Equals('8') && !i.Equals('9') && !i.Equals('.') && !i.Equals('-'))
                        return false;
                    else if (i.Equals('.'))
                        temp = temp + i;
                    else temp = temp + i;
                }
                add(double.Parse(temp));
            }
            catch (FormatException)
            {
                return false;
            }
            return true;

        }
        public void add(double e)
        {
            if (!data.Contains(e))
            {
                data.Add(e);
                SIZE++;
            }
        }
        void remove(double e)
        {
            if (data.Contains(e))
            {
                data.Remove(e);
                SIZE--;
            }
        }
        bool isEmpty()
        {
            return SIZE == 0;
        }
        public int size()
        {
            return this.SIZE;
        }
        public bool contains(double e)
        {
            foreach (double i in this.data)
                if (i == e) return true;
            return false;
        }                                                                                               
        public object Clone()
        {
            ArraySet temp = new ArraySet();
            foreach (double i in this.data)
            {
                temp.add(i);
            }
            return temp;
        }
        public ArraySet Union(ArraySet e)
        {
            ArraySet temp = (ArraySet) this.Clone();
            foreach (double j in e.data)
            {
                if(!temp.contains(j))
                {
                    temp.add(j);
                }
            }
            return temp;
        }
        public ArraySet intersection(ArraySet e)
        {
            ArraySet temp = new ArraySet();
            foreach(double i in this.data)
                foreach(double j in e.data)
                    if(i==j)
                    {
                        temp.add(i);
                        break;
                    }
            return temp;
        }
        public ArraySet difference(ArraySet e)
        {
            ArraySet temp = (ArraySet) this.Clone();
            foreach(double i in this.data)
                if (e.contains(i))
                    temp.remove(i);
            return temp;
        }
        public static bool isSubsetOf(ArraySet a,ArraySet b)
        {
            foreach(object i in a.data)
                if (!b.contains((double)i))
                    return false;
            return true;
        }
        public String toString()
        {
            String str = "";
            foreach (double i in data)
                str += i+" ";
            return str;
        }
        public static String getPowerSet(ArraySet e)
        {
            int n = Convert.ToInt32(Math.Pow(2,e.SIZE));
            String result = "{{";
            for(int count = 0;count<n;count++)
            {
                result += "{";
                char[] binary = ToBinary(count).ToCharArray();
                Array.Reverse(binary);
                char[] newArray = new char[e.SIZE];
                for (int i = 0; i < binary.Length; i++)
                    newArray[i] = binary[i];
                while (newArray.Length<e.SIZE)
                {
                    newArray[n - newArray.Length] = '0';
                }
                Array.Reverse(newArray);
                for (int j = 0; j < newArray.Length; j++)
                    if (newArray[j] == '1')
                        result = result + e.data[j] + ",";
                result = result.Remove(result.Length-1);
                result += "},";

            }
            result = result.Remove(result.Length - 1) + "}";
            return result;

        }
        private static string ToBinary(Int64 Decimal)
        {
            Int64 Binary;
            char[] BinaryArray;
            string BinaryResult = "";

            while (Decimal > 0)
            {
                Binary = Decimal % 2;
                BinaryResult += Binary;
                Decimal = Decimal / 2;
            }
            BinaryArray = BinaryResult.ToCharArray();
            Array.Reverse(BinaryArray);
            BinaryResult = new string(BinaryArray);

            return BinaryResult;
        }
        public static IEnumerable<T> Empty<T>()
        {
            return new T[] { };
        }
        public static IEnumerable<T> Cons<T>(T head, IEnumerable<T> tail)
        {
            yield return head;
            foreach (var t in tail)
                yield return t;
        }
        public static IEnumerable<IEnumerable<T>> Crossproduct<T>(IEnumerable<IEnumerable<T>> sets)
        {
            if (!sets.Any())
                return new[] { Empty<T>() };

            var head = sets.First();
            var tailCross = Crossproduct<T>(sets.Skip(1));

            return
                from h in head
                from ts in tailCross
                select Cons(h, ts);
        }
        public static string Cartesian(ArraySet[] e)
        {
            String output = "{";
            double[][] Lists = new double[e.Length][];
            for(int i = 0;i<e.Length;i++)
            {
                Lists[i] = e[i].toDoubleArray();
            }
            var crossp = Crossproduct(Lists);
            foreach (var t in crossp)
            {
                output += "(";
                foreach (double u in t)
                {
                    output += u+",";
                }
                output = output.Remove(output.Length - 1);
                output += "),";
            }
            output = output.Remove(output.Length - 1);
            output += "}";
            return output;
        }
        public double[] toDoubleArray()
        {
            double[] array = new double[SIZE];
            object[] temp = data.ToArray();
            for (int i = 0;i<data.Count;i++)
            {
                array[i] = Convert.ToDouble(temp[i]);
            }
            return array;
        }
    }
}
