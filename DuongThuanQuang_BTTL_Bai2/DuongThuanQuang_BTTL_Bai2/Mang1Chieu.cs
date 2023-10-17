using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongThuanQuang_BTTL_Bai2
{
    class Mang1Chieu
    {
        private int[] a;
        public int[] A
        {
            get { return a; }
            set { a = value; }
        }
        public Mang1Chieu(int n)
        {
            a = new int[n];
        }
        public void Ascending_Sort()
        {
            Array.Sort(a);
        }
        public void Descending_Sort()
        {
            Array.Sort(a);
            Array.Reverse(a);
        }
        public int Search_Value(int value)
        {
            return Array.IndexOf(a, value);
        }
        public int Search_Index(int index)
        {
            if (index >= 0 && index < a.Length)
                return a[index];
            else
                return -1;
        }
        public void Delete_Value(int value)
        {
            a = a.Where(x => x != value).ToArray();
        }
        public void Delete_Index(int index)
        {
            a = a.Select((value, i) => i != index ? value : -1).Where(value => value != -1).ToArray();
        }
        public void ReplaceValue(int value, int valueReplace)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == value)
                    a[i] = valueReplace;
            }
        }

        public void ReplaceIndex(int index, int valueReplace)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (i == index)
                    a[i] = valueReplace;
            }
        }
        public int TongMang()
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }

        public int TongChan()
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                    sum += a[i];
            }
            return sum;
        }

        public int TongLe()
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                    sum += a[i];
            }
            return sum;
        }

        public int TimMax()
        {
            Array.Sort(a);
            return a[a.Length - 1];
        }

        public int TimMin()
        {
            Array.Sort(a);
            return a[0];
        }

        public bool IsSorted()
        {
            for (int i = 0; i < (a.Length - 1); i++)
            {
                if (a[i] > a[i + 1])
                    return false;
            }
            return true;
        }
    }
}
