using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9302
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static Queue<int> Arr2Q(int[] arr)
        {
            Queue<int> q = new Queue<int>();
            foreach (int value in arr)
                q.Insert(value);
            return q;
        }

        //1
        //get a queue of ints
        //count how many numbers in q have most significant digit equal least significant digit
        //example: q = [1451, 123, 7827], return 2
        public static int CountMSDLSD(Queue<int> q)
        {
            return 0;
        }

        //2
        //נגדיר מספר צְמּוד-עשר כמספר שיש לו לפחות שתי ספרות צמודות שסכומן בדיוק 10
        //לדוגמה - 4550 הוא צְמּוד-עשר, 3456 אינו צְמּוד-עשר
        //כתוב פעולה המקבלת שני תורים של מספרים טבעיים
        //הפעולה תחזיר 1 אם לתור הראשון יש יותר צמודי-עשר, 2 אחרת
        static int CountDoubleTen(Queue<int> q1, Queue<int> q2)
        {
            return 0;
        }

        //3
        //get a queue of chars
        //return a queue of char sequence lengths
        //example: q = ['(', '(', 4, 'A','A','A','%','%','%'] -> return: head[2,1,3,3]
        static Queue<int> CharSeq (Queue<char> q)
        {
            return null;

        }

        //4
        //get a queue of doubles
        //return a queue of doubles, each double is the sum of positive sequences
        //example: q=[5.1, -2.2, -6.0, 0.5, 4.5, 2.0, -3.6, 2.2, 1.5], return: head[5.1, 7.0, 3.7]
        static Queue<double> SumPosSeq(Queue<double> q)
        {
            return null;

        }

        //5
        //get a queue of ints and int k
        //return a queue of ints which includes for each k-digit sequence, the length of sequence
        //example: k=3, q=[987, 12, 100, 75, 770, 880, 990, 35, 200, 123], return: head[1,1,3,2]
        static Queue<int> KLenSeq(Queue<int> q)
        {
            return null;
        }


    }
}
