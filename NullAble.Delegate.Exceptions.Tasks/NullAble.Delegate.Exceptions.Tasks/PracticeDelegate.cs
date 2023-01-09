using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullAble.Delegate.Exceptions.Tasks
{
    internal class PracticeDelegate
    {

        #region Predicate
        //public delegate bool CheckNums(int num);

        //public bool CheckNumByOdd(int number)
        //{
        //    return number % 2 == 1;
        //}
        //public bool CheckNumByEven(int number)
        //{
        //    return number % 2 == 0;
        //}

        //public bool CheckNumThanFive(int number)
        //{
        //    return number >5 ;
        //}
        //public void CheckDelegate()
        //{
        //    List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, };

        //    nums.FindAll(m => m > 5);

        //    //var res = nums.FindAll(m => m % 2 == 0 && m>5).Sum(m => m);

        //    Console.WriteLine(SumOfListItems(m=>m>5,nums));
        //}
        //public int SumOfListItems(Predicate<int> func, List<int> nums)
        //{
        //    int sum = 0;

        //    foreach (var item in nums)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}

        //////public int SumOfListByEven(List<int> nums)
        //////{
        //////    int sum = 0;

        //////    foreach (var item in nums)
        //////    {
        //////        if (item % 2 == 0)
        //////        {
        //////            sum += item;
        //////        }
        //////    }
        //////    return sum;
        //////}
        ///
        //static int SumOfListThanFive(List<int> nums)
        //{
        //    int sum = 0;

        //    foreach (var item in nums)
        //    {
        //        if (item > 5)
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}
        #endregion


        #region Action


        //public delegate void ChangeString(string str);

        //public void StringToUpper(string word)
        //{
        //    Console.WriteLine(word.ToUpper());
        //}

        ////public void StringToLower(string word)
        ////{
        ////    Console.WriteLine(word.ToLower());
        ////}

        ////public void ShowWord( ChangeString func,string str)
        ////{
        ////    func(str);
        ////}

        //public void CheckWord()
        //{
        //    //ShowWord(StringToUpper, "Cavid");
        //    //ShowWord(StringToLower, "Cavid");

        //    //ChangeString change = new ChangeString(StringToUpper);

        //    //change += StringToLower;
        //    //change.Invoke("Shaiq");

        //    //Action<string> action = StringToUpper;
        //    //action.Invoke("Pervin");
        //}
        #endregion


        #region Func
public delegate int CheckString(string str,int age);    
        

        public int GetStringLength(string Word,int num)
        {
            return Word.Length+num;
        }
        
        public void ShowStringLength( Func<string,int,int>func,string text)
        {
            Console.WriteLine(func(text,10));
        }

        public void ShowString()
        {
            //ShowStringLength(GetStringLength, "Cavid");

            Func<string, int, int> func = GetStringLength;
            func.Invoke("Cahandar", 6);
            Console.WriteLine(func.Invoke("Cahandar", 6));
        }
        
    }
        #endregion
        


}
