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
        
    }
}
