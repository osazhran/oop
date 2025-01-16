using C43_G05_OOP01.Q1;
using C43_G05_OOP01.Q2;
using C43_G05_OOP01.Q3;
using C43_G05_OOP01.Q4;

namespace C43_G05_OOP01
{

    internal class Program
    {
        static string[] GetSeasonMonths(SeasOn seasOn)
        {
            switch (seasOn)
            {
                case SeasOn.Spring:
                    return new string[] { "March", "April", "May" };
                case SeasOn.Summer:
                    return new string[] { "June", "July", "August" };
                case SeasOn.Autumn:
                    return new string[] { "September", "October", "November" };
                case SeasOn.Winter:
                    return new string[] { "December", "January", "February" };
                default:
                    return Array.Empty<string>();

            }
        }


        static void Main(string[] args)
        {
            #region Q1
            //foreach (string name in Enum.GetNames(typeof(WeekDays)))
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region Q2
            //Console.WriteLine("Enter The Session (Spring, Summer, Autumn, Winter):");
            //string? input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out SeasOn selectedSeason))
            //{
            //    string[] months = GetSeasonMonths(selectedSeason);
            //    Console.WriteLine($"Month is : {string.Join(", ", months)}");
            //}
            //else
            //{
            //    Console.WriteLine("Enter valid number");
            //}
            #endregion

            #region Q3
            // Add Peremession
            Permissions userPermissions = Permissions.Read | Permissions.Write;  // 0001 | 0010 => 0011

            // Display Peremession
            Console.WriteLine($"Current Permissions: {userPermissions}");

            // Add New Peremession (Delete)
            //   نفّذ العملية بين المتغير الموجود والقيمة الجديدة، ثم خزّن النتيجة في نفس المتغير"OR" 
            ///متي نستخدم `|=`
            ///-نستخدم *`|=`*عندما نريد إضافة قيمة جديدةإلى متغير يحتوي على مجموعة من القيم الموجودة بالفعل.
            ///يُستخدم لإضافة صلاحيات جديدة إلى مجموعة الصلاحيات الموجودة دون حذف الصلاحيات السابقة.

            userPermissions |= Permissions.Delete;  // 0011 | 0100 => 0111
            Console.WriteLine($"After Adding Delete: {userPermissions}");



            // Remove Peremession  (Write)
            // العملية NOT (~).
            // العملية AND(&).
            // عامل الإسناد المركب(&=)
            /*كيف تعمل &= ~ لإزالة صلاحية؟
            عند استخدام &= ~، نحن نزيل صلاحية معينة من مجموعة الصلاحيات عن طريق:
            عكس الصلاحية المراد إزالتها باستخدام العملية NOT (~).
            إجراء العملية "AND" (&) بين مجموعة الصلاحيات والعكس الناتج، 
            مما يؤدي إلى تصفير البت الخاص بالصلاحية المراد إزالتها مع الحفاظ على بقية الصلاحيات كما هي.

             * */


            userPermissions &= ~Permissions.Write;  // 0111 & ~0010 => 0101
            Console.WriteLine($"After Removing Write: {userPermissions}");
            #endregion

            #region Q4
            //Console.WriteLine("Enter a color name :");
            //string? userInput = Console.ReadLine();
            //if (Enum.TryParse(userInput,true,out Colors colors))
            //{
            //    Console.WriteLine($"{userInput} is a primary color.");
            //}
            //else
            //{
            //    Console.WriteLine($"{userInput} is NOT a primary color.");
            //}
            #endregion
        }
    }


}




