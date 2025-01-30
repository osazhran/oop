using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C43_G05_ADV02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ََQ1 Without Chat GPT
            ////Declare Array With Size N
            //List<int> arra = new List<int>(12) { 1, 2, 8, 7, 58, 10 };
            ////number of queries, in each query you will be given an integer X
            //int Query = 12;
            //int NumbeOfQuerie = 0;
            //for (int i = 0; i < arra?.Count; i++)
            //{
            //    //print how many numbers in array that is greater than  X
            //    if (arra?[i] > Query)
            //        NumbeOfQuerie++;
            //}
            //Console.WriteLine(NumbeOfQuerie); 
            #endregion
            #region Q1 With Chat GPT
            //    //Declare Array With Size N
            //    Console.WriteLine("Enter The Size Of Array");
            //    int N = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter the array elements:");
            //    int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //    // List<int> arra = new List<int>(12) { 1, 2, 8, 7, 58, 10 };
            //    // Sort the array for binary search
            //    Array.Sort(array);

            //    Console.WriteLine("Enter the number of queries:");
            //    int q = int.Parse(Console.ReadLine());
            //    //int Query = 12;

            //    // Process each query
            //    Console.WriteLine("Enter the queries:");
            //    for (int i = 0; i < q; i++)
            //    {
            //        int x = int.Parse(Console.ReadLine());
            //        int result = CountGreaterThanX(array, x);
            //        Console.WriteLine($"Numbers greater than {x}: {result}");
            //    }

            //    static int CountGreaterThanX(int[] array, int x)
            //    {
            //        int left = 0, right = array.Length;

            //        // Binary search to find the first element greater than x
            //        while (left < right)
            //        {
            //            int mid = left + (right - left) / 2;

            //            if (array[mid] <= x)
            //                left = mid + 1;
            //            else
            //                right = mid;
            //        }

            //        // All elements from 'left' to the end are greater than x
            //        return array.Length - left;
            //    }

            //

            #endregion

            #region Q2 Without Chat GPT
            //int n = 7;
            //List<int> lis = new List<int>(n) { 0,1, 3, 2, 3, 1,0 };
            //if (lis.Count % 2 == 1)
            //{
            //    for (int i = 0; i < lis.Count; i++)
            //    {
            //        for (int j = n-1; j>i; j--)
            //        {

            //            if (lis[i] == lis[j] && i != j)
            //            {
            //                i++;
            //                j--;
            //            }

            //        }
            //    }
            //    Console.WriteLine("yes");
            //}
            //else
            //    Console.WriteLine("no");

            #endregion
            #region Q2 With Chat GPT AND My Toutch

            //Console.WriteLine("Enter Siz Of Array");
            //int Size;
            //while (!int.TryParse(Console.ReadLine(), out Size) || Size <= 0)
            //    Console.WriteLine("Plese Entir Valid Info");
            //int[] array = new int[Size];
            //Console.WriteLine("Enter Your Element ");
            //for (int i = 0; i < Size; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    while (!int.TryParse(Console.ReadLine(), out array[i]))
            //    {
            //        Console.WriteLine("Invalid input! Please enter a valid integer:");
            //        Console.Write($"Element {i + 1}: ");
            //    }

            //}
            //Console.WriteLine("\nArray elements are:");
            //foreach (var item in array)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine("\n");
            //if (IsPalindrome(array, Size))
            //{
            //    Console.WriteLine("And YES It Is Palindrome");
            //}
            //else

            //    Console.WriteLine("And NO It Isn't Palindrome");

            #endregion

            #region Q3 With Chat Gpt
            // Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //Console.WriteLine("Original Queue: " + string.Join(", ", queue));
            //ReverseQueue(queue);
            //Console.WriteLine("After  Referse: " + string.Join(", ", queue));


            #endregion

            #region Q4 With Chat GPT
            //string s = "{([])}";
            //if (Isbalanced(s))
            //    Console.WriteLine("true");
            //else
            //    Console.WriteLine("false");
            #endregion

            #region Q5 Without Chat GPT
            //Queue<object> ts = new Queue<object>();
            //ts.Enqueue(1);
            //ts.Enqueue("osama");
            //ts.Enqueue("osama");
            //ts.Enqueue(3);
            //ts.Enqueue(30.20);
            //ts.Enqueue(30.20);
            //ts.Enqueue(30.20);
            //while (ts.Count > 0)
            //{

            //    Console.WriteLine(ts.Dequeue());
            //}

            #endregion

            #region Q6 Without Chat GPT
            //Console.WriteLine("Enter The Target");
            //int target;
            //int count = 0;
            //while (!int.TryParse(Console.ReadLine(), out target))
            //    Console.WriteLine("Plese Entir Valid Info");
            //List<int> list = new List<int>() { 1, 4, 7, 7, 7, 8, 9 };
            //PushSerisIntoStack(list);

            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i] == target)
            //        count++;
            //}
            //if (count == 0)
            //{
            //    Console.WriteLine("Target was not found");
            //}
            //else
            //{
            //    Console.WriteLine($"Target was found successfully and the count ={count} ");

            //}




            #endregion

            #region Q7 without Chat GPT

            #endregion
            #region Q8 Without Chat GPT

            #endregion

        }
        static bool IsPalindrome(int[] arr, int size)
        {
            if (arr.Length % 2 == 1 && arr.Length > 1)
            {
                int left = 0, right = size - 1;
                while (left < right)
                {
                    if (arr[left] != arr[right])
                        return false;
                    left++;
                    right--;
                }
                return true;
            }
            else
                return false;
        }
        static void ReverseQueue(Queue<int> Qu)
        {
            Stack<int> stack = new Stack<int>();
            //This To Clear Queue And Add Element in  Stack
            while (Qu.Count > 0)
            {
                stack.Push(Qu.Dequeue());
            }
            //This To Clear Stack And Add Element In Queue 
            while (stack.Count > 0)
            {
                Qu.Enqueue(stack.Pop());
            }


        }
        static bool Isbalanced(string str)
        {
            Stack<char> st = new Stack<char>();

            if (str?.Length == 0) return false;
            for (int i = 0; i < str?.Length; i++)
            {
                if (str[i] == '(' || str[i] == '[' || str[i] == '{')
                { st.Push(str[i]); }
                else
                {
                    if (st.Count > 0 &&
                    ((st.Peek() == '(' && str[i] == ')') ||
                     (st.Peek() == '{' && str[i] == '}') ||
                     (st.Peek() == '[' && str[i] == ']')))
                    {
                        st.Pop();
                    }
                    else return false;


                }

            }

            return st.Count == 0;

        }
        static void PushSerisIntoStack(List<int> list)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < list.Count; i++)
                stack.Push(list[i]);
        }
        //static void ReversFirstEleInQueue(Queue<int> queue, int K)
        //{
        //    if (queue.Count<1) return ;
        //    for(int i = 0; i<queue.Count;i++);
        //    {
        //        if (queue.Dequeue() == K) ;
                    
        //    }
             
        //}

    }
}
