using System;
using System.Drawing;
using System.Threading;

namespace cstask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1,2,3)); //Task 1
            int[] nums = { 10, 5, 7, 8 };

            Console.WriteLine(SumArr(nums)); //Task 2
            Console.WriteLine(FirstIndex("code academy", 's'));//Task3
            Console.WriteLine(LastIndex("banana",'a'));//Task4
            Console.WriteLine(EnBoyuk(nums));//Task 5
            Console.WriteLine(MusbetCut(10)); //Task 6
            Console.WriteLine(SiyahiSayi(nums)); //Task 7
            

            int[] resultArray = YeniSiyahi(nums);
            Console.WriteLine("Yeni array: [" + string.Join(", ", resultArray) + "]"); //Task 8

            int[] reversedArray = ReversedArr(nums);
            Console.WriteLine("Reversed array: [" + string.Join(", ", reversedArray) + "]");//Task 9

            Console.WriteLine(FrontSpaces("     salam"));//Task 10

            Console.WriteLine(LastSpace("  salam      8   "));//Task 11



        }

        //1.Verilmiş 3 ədədin cəmini tapan method (həm int, həm double ədədlər üçün)

        static int Sum(int num1,int num2,int num3)
        {
            return num1 + num2 + num3;
        }
        static double Sum(double num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        }


        //2.Verilmiş ədədlər siyahısındaki bütün ədədlərin cəmini tapan method (həm int, həm double ədədlər üçün)
        static int SumArr(int[] arr)
        {
            int cem = 0;    
            for(int i=0; i<arr.Length; i++)
            {
                cem += arr[i];
            }
            return cem;
        }
        static double SumArr(double[] arr)
        {
            double cem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                cem += arr[i];
            }
            return cem;
        }

        //3.Verilmiş yazıda veirlmiş charın yerləşdiyi ilk indexi tapan method (yoxdursa -1 qaytarın)

        static int FirstIndex(string yazi, char chr)
        {
            for(int i = 0; i < yazi.Length; i++)
            {
                if(chr == yazi[i])
                    return i;
            }
            return -1;
        }

        //4.Verilmiş yazıda veirlmiş charın yerləşdiyi son indexi tapan method (yoxdursa -1 qaytarı)

        static int LastIndex(string yazi, char chr)
        {
            for (int i = yazi.Length - 1; i >= 0; i--)
            {
                if (chr == yazi[i])
                    return i;
            }
            return -1;
        }
        //5.Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan method

        static int EnBoyuk(int[] siyahi)
        {
            int enboyuk = siyahi[0];
            for(int i=1; i<siyahi.Length; i++)
            {
                if (siyahi[i]> enboyuk)
                    enboyuk = siyahi[i];
            }
            return enboyuk;
        }

        //6.Verilmiş ədədin müsbət və cüt olub olmadığını tapan method
        static bool MusbetCut(int eded)
        {
            if(eded%2==0 && eded > 0)
            {
                return true;
            }
            return false;
        }

        //7.Verilmiş ədədlər siyahısındaki müsbət və cüt ədədlərin sayını tapan method
        static int SiyahiSayi(int[] siyahi)
        {
            int count = 0;
            for(int i=0; i<siyahi.Length;i++)
            {
                if (siyahi[i] % 2 == 0 && siyahi[i] > 0)
                    count++;
            }
            return count;
        }

        //8.Verilmiş ədədlər siyahısındaki müsbət və cüt ədədlərdən ibarət yeni bir array düzəldən method.
        static int[] YeniSiyahi(int[] siyahi)
        {
            int count = 0;
            for (int i = 0; i < siyahi.Length; i++)
            {
                if (siyahi[i] % 2 == 0 && siyahi[i] > 0)
                    count++;
            }

            int[] yeniSiyahi = new int[count];

            int index = 0;  
            for (int i = 0; i < siyahi.Length; i++)
            {
                if (siyahi[i] % 2 == 0 && siyahi[i] > 0)
                {
                    yeniSiyahi[index] = siyahi[i];
                    index++; 
                }
            }

            return yeniSiyahi;  
        }

        //9.Verilmiş ədədlər siyahısından tərsinə düzülmüz yeni bir array qaytaran method.
        //(misalçün verilən arra {10,20,30} olarsa methoddan return olunan array {30,20,10} olacaq.
        static int[] ReversedArr(int[] arr)
        {
            int[] NewArr = new int[arr.Length];
            int index = 0;
            for(int i=arr.Length-1; i>=0; i--)
            {
                NewArr[index] = arr[i];
                index++;
            }
            return NewArr;
        }


        //10.Verilmiş yazının əvvəlindəki boşluqlar silinmiş bir string düzəldən method

        static int IlkIndex(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ') return i;
            }

            return -1;
        }

        static string FrontSpaces(string str)
        {
            string newStr = "";
            int startIndex = IlkIndex(str);

            if (startIndex == -1) return str;

            for (int i = startIndex; i < str.Length; i++)
            {
                newStr += str[i];
            }

            return newStr;
        }

        //11.Verilmiş yazıdan sonundaki boşluqlar silinmiş yeni string düzəldən method

        static string LastSpace(string str)
        {
            string newStr = "";
            int endIndex = SonIndex(str);

            if (endIndex == -1) return str;

            for (int i = 0; i <= endIndex; i++)
            {
                newStr += str[i];
            }

            return newStr;
        }

        
        static int SonIndex(string str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] != ' ') return i;
            }

            return -1;
        }


    }
}
