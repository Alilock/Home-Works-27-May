using System;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers= {1,2,3,4,5};
            //int n = 6;
            //AddNewNum(ref numbers, n);

            //string name = " Ali  Nasrullayev  ";
            //RemoveEmpty(ref name);
            //Console.WriteLine(name);

            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num); 
            //}
            //int b = 5;
            //PositiveNum(ref b);

            //Console.WriteLine(b);

            //int[] nums = { -1, -2, -4, 5, 6, -7 };
            //BePositiveArr(ref nums);
            //foreach (int item in nums)
            //{
            //    Console.WriteLine(item);
            //}
        }


        // Parameter olaraq integer array variable-i
        // ve bir integer value qebul eden ve hemin integer value-nu integer array-e yeni element kimi elave eden metod.
         static void AddNewNum(ref int[] numbers, int n )
        {
            int[] newnumber =new int[numbers.Length+1];
            for (int i = 0; i < numbers.Length; i++)
            {
                newnumber[i] = numbers[i];
            }
            newnumber[newnumber.Length - 1] = n;
            numbers = newnumber;
        }


        //2. Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri əvvəlində və sonunda boşluqlar qalmayacaq hala gətirən metod.
        //Misal olaraq, name = " Hikmet  Abbasov " deyə bir variable-mız varsa onu yaratdigimiz metoda göndərdikdə variable-daki dəyər "HikmətAbbasov" olmalıdır.
         static void RemoveEmpty(ref string text)
        {
            
            int sizeCount = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] !=  ' ')
                {
                    sizeCount++;
                }
            }
            char[] newtextchars = new char[sizeCount];
            int index = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    newtextchars[index++] = text[i];
                }
            }

            var newtext = new string(newtextchars);

            text = newtext;






        }


        // Qəbul etdiyi ədədi musbətə ceviren metod

        static void PositiveNum (ref int a)
        {

            if (a < 0)
                a *= -1;
            
                
        }
        //Qəbul etdiyi ədədlər siyahısının içərisindəki bütün ədədləri müsbət hala gətirən metod

        static void BePositiveArr(ref int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]<0)
                {
                    numbers[i] *= -1;
                }
            }
        }
    }
}
