using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace day12;

class Program
{
    static void Main(string[] args)
    {
        //Verilmiş ədədi kvadratına yüksəldən metod. (Metodu cağırdıqdan sonra variable kvadratına yüksəlmiş olmalıdı)

        int num = 12;
        Power( ref num);
        Console.WriteLine(num);

        //Verilmiş ədədlər siyahısını içindəki bütün ədədlər kvadratına yüksəlmiş array - ə çevirən metod
        int[] arr = new int[] {1,2,3,4,5};
        PowerArr( ref arr);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        // Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq hala gətirən metod.Misal olaraq, name = " Hikmet  Abbasov "
        //    deyə bir variable - mız varsa onu yaratdigimiz metoda göndərdikdə variable-daki dəyər "HikmətAbbasov" olmalıdır.

        string name = "        Hikmet   Abbasov     ";
        DeleteSpace( ref name);
        Console.WriteLine(name);

        // Parameter olaraq integer array variable - i ve bir integer value qebul eden ve hemin integer value-nu integer array-e yeni element kimi elave eden metod.
        // Misal üçün int[] nums = { 1, 5, 7 } deyə bir variable - mız var.yazdığımız metodu çağırıb arqument olaraq nums və 3 göndərsək nums arrayının dəyəri  { 1,5,7,3}
        //olmalıdır.

        int[] nums = new int[] {2,3,4,6};

        AddElementToArr( ref nums, 8);

        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);

        }

        Console.ReadLine();
    }

    static void Power(ref int eded)
    {
        
        eded *= eded;
    }
    static void PowerArr( ref int[] arr)
    {
        
         for (int i = 0; i < arr.Length; i++)
         {
             arr[i] *= arr[i];
         }

    }
    static void DeleteSpace( ref string str)
    {
         string newStr = "";

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i]!=' ')
            {
                newStr += str[i];

            }
        }
       str=newStr;

    }
    static void AddElementToArr( ref int[] arr, int n)
    {
        int count = arr.Length+1;
        int[] arr2 = new int[count];
        int index = 0;

        for (int i = 0; i < arr.Length; i++)
        {

            arr2[index++] = arr[i];

        }
        arr2[count-1] = n;
        arr = arr2;
        
    }

}

