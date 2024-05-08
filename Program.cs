using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace practice_1
{
    internal class Program
    {
        

        static void Main(string[] args)
        {

            // Array
            //Console.WriteLine("hello ji");
          //  int[] arr = { 1, 2, 3, 4, 5 };
            


            //int value = Array.Find(arr,
            //        element => element == 1);
            //Console.WriteLine(value);

            ////Array.Clear(arr, 1, 5);
            //foreach (int element in arr)
            //{
            //    Console.WriteLine(element);
            //}

            //int index = Array.IndexOf(arr, 2);
            //Console.WriteLine(index);

            //int[] arr2 = new int[4];
            //Array.Copy(arr, arr2, 4);
            //foreach (int element in arr2)
            //{
            //    Console.WriteLine(element);
            //}

            //Array.Resize(ref arr2, 4);

            //List<string> list = new List<string>();
            //list.Add("dalsukh");
            //list.Add("ok");

            //List<int> ll = new List<int>();
            //List<char> ll1 = new List<char>();
            //here i try char not int because i want to check that char is converted to int or not by implicit conversion
            // it will convert into the 98 because in the table B character value is 98
            //ll.Add('b');
            //ll.AddRange(new[] {1,2,'m'});
            //Console.WriteLine(ll[0]);
            //ll.Insert(0, 77);
            //Console.WriteLine(ll[0]);
            //ll.InsertRange(0, new[] {7,8,9});

            //Console.WriteLine("from here this is");
            //Console.WriteLine("count of element is" + ll.Count);
            //foreach (int c in ll)
            //{
            //    Console.WriteLine(c);
            //}


            //ll.Remove(786);
            //ll.RemoveAll(el => { return el == 2; });
            //ll.RemoveAt(0);
            //ll.RemoveRange(0, 2);



            //Console.WriteLine("from here this is");
            //Console.WriteLine("count of element is" + ll.Count);
            //foreach (int c in ll)
            //{
            //    Console.WriteLine(c);
            //}
            //Console.WriteLine("capacity is" + ll.Capacity);


            // Dictionary 

            //  Dictionary<int, int> d = new Dictionary<int, int>();
            //  d.Add(1, 2);
            //  int c;
            // bool flag =  d.TryGetValue(1, out c);
            //bool IsPresent =   d.ContainsKey(1);
            //bool IsPpresent =   d.ContainsValue(1);
            //  d.EnsureCapacity(1);
            //  d.Add(2, 7);
            //  Console.WriteLine(d.Count + "count is ");
            //  foreach (var ok in d)
            //  {
            //      Console.WriteLine(ok.Key);
            //  }
            //  Console.WriteLine("value of c is " + c);

            // Stack
            // Stack<int> stack = new Stack<int>();
            // stack.Push(1);
            ////int val =  stack.Pop();
            // int val2 = stack.Peek();
            // int cnt = stack.Count;


            //Queue
            // Queue<int> q = new Queue<int>();
            //q.Enqueue(11);
            //q.Enqueue(12);
            //q.Enqueue(13);
            //q.Enqueue(14);
            //q.Enqueue(15);
            ////int val3=  q.Dequeue();
            //int vall = q.Peek();
            //Console.WriteLine(vall); 

            //foreach(int i in q)
            //{
            //    Console.WriteLine(i);
            //}


            //   DynamicallyAccessedMembersAttribute Creating Error Directary In Debug Folder

            DateTime dt = DateTime.Now;
            string date = dt.ToString("dd-MM-yyyy");
             string path = AppDomain.CurrentDomain.BaseDirectory +  "Error";
            //Console.WriteLine(path);
            Directory.CreateDirectory(path);
            File.WriteAllText(path + $"{date}.txt", "ok chhe");


            //int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            //int[,] arrr = new int[5, 5];
            //Console.WriteLine( "here it is" + arrr[0,1]);
            //Array.Clear(numbers, 0, 2);

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //ArrayList ar = new ArrayList();
            //ar.Add("yy");
            //ar.Add("dc");
            //ar.Add("dalsukh");
            //foreach(int i in ar)
            //{
            //    Console.WriteLine(i);
            //}

            

        }
    }
}
