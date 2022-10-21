using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps
{
    public class Examples
    {
        public static void Examples2()
        {
            char[] arrCharr = new char[3] { 'b', 't', 'k' };
            var arrCharr1 = new char[3];
            char[] arrCharr2 = new char[] { 'b', 't', 'k' };


            //Array
            var arrInt = Array.CreateInstance(typeof(int), 5);
            arrInt.SetValue(10, 0);
            arrInt.SetValue(7, 1); //arrInt[1]=7
            arrInt.SetValue(88, 2);
            arrInt.GetValue(1);    //7


            //ArrayList
            //Not Type Safe
            var arrObj = new ArrayList();
            arrObj.Add(10);
            arrObj.Add("afasdfs");
            arrObj.Remove(10);//not index, value
            foreach (var item in arrObj)
            {
                Console.WriteLine("ArrayList: " + item);
            }

            //List<T> - int
            var arrInt2 = new List<int>();
            arrInt2.Add(10);
            arrInt2.Add('b'); //b is converted to int can not add string
            arrInt2.AddRange(new int[] { 1, 2, 3, 4 });
            arrInt2.Remove(3);


            foreach (var item in arrInt2)
            {
                Console.WriteLine("List<T>: " + item);
            }

        }




    }
}
