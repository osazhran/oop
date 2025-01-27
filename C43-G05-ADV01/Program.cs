using System.Collections;

namespace C43_G05_ADV01
{
    internal class Program
    {
        //public static  void  ReverseArrayList(ArrayList arrayList)
        //{
        //    int i = 0;
        //    int j = arrayList.Count - 1;
        //    while (i < j)
        //    {
        //        var temp = arrayList[i];
        //        arrayList[i] = arrayList[j];
        //        arrayList[j] = temp;

        //        i++;
        //        j--;
        //    }

        //}
        //public static void GetEvenNumInList(List<int> list)
        //{
        //    //cheak if list is not null && lenth >0
        //    if(list?.Count>0)
        //    {
        //        for(int i = 0; i < list.Count; i++)
        //        {
        //         // var x= list[i] %2;
        //            if(list[i] % 2 is 0)
        //                Console.WriteLine(list[i]);

        //        }

        //    }
           
        //}
        static void Main(string[] args)
        {
            #region Q1
            //var intRange = new Range<int>(5, 15);
            //Console.WriteLine(intRange);
            //Console.WriteLine($"Is 10 in range? {intRange.IsInRange(10)}");
            //Console.WriteLine($"Is 20 in range? {intRange.IsInRange(20)}");
            //Console.WriteLine($"Range length:   {intRange.Length()}");
            #endregion
            #region Q2
            // ArrayList arrayList = new ArrayList() { 1,2 , 3, 4 };
            // Console.WriteLine("arrayList befor");
            // for (int i = 0; i < arrayList.Count; i++)
            // {
            //     Console.WriteLine(arrayList[i]);
            // }
            // Console.WriteLine("arrayList After");

            //ReverseArrayList(arrayList);
            // for (int i = 0; i < arrayList.Count; i++)
            // {
            //     Console.WriteLine(arrayList[i]);
            // }
            #endregion
            #region Q3
            //List<int> list = new List<int>() { 1,2,3,4,5,6};
            //GetEvenNumInList(list);

            #endregion
            #region Q4
            FixedSizeList<int> fixedSizeList = new  FixedSizeList<int>(8);
            fixedSizeList.Add(4,new List<int> { 5});
            fixedSizeList.Get(1, new List<int> { 5 });


            #endregion
        }
    }
}
