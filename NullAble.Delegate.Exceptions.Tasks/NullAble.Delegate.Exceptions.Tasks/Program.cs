using DomainLayer.Models;
using NullAble.Delegate.Exceptions.Tasks;
using NullAble.Delegate.Exceptions.Tasks.Constants;
using NullAble.Delegate.Exceptions.Tasks.Exceptions;
using ServicesLayer.Services;
using ServicesLayer.Services.Interfaces;
//PracticeDelegate calculate=new PracticeDelegate();
//calculate.CheckDelegate();
//calculate.CheckWord();
//calculate.ShowString();
//IEmployeeService service = new EmployeeService();
//Console.WriteLine(service.GetCountByAge(26));

#region NullAble
////string name = null;
////if(name == null)
////{
////    Console.WriteLine("Salam");
////}

////int? num = null;


////int? m = 5;

////GetPersonById(5);
////static void GetPersonById(int? id)
////{
////    if (id == null)
////    {
////        Console.WriteLine("Not found");
////    }
////}
#endregion



#region Exceptions
//int m = 5;
//int n = 0;

//var result = m / n;

//Console.WriteLine(result);

//try
//{

// int m = 5;
// int n = 0;

// Divide(m, n);
// //var result = m / n;

// //int[]arr={ 1,2,3};

////arr[5] = 100;
//}
//catch (Exception ex)
//{

//    Console.WriteLine(ex.Message);
//}

//Divide(5, 1);

//static void Divide(int n, int m)
//{
//    bool isSucces = false;
//    try
//    {

//        int[] arr = { 1, 2, 3 };

//        arr[5] = 100;

//        var result = n / m;
//        isSucces = true;
//        Console.WriteLine(result);
//    }
//    catch (IndexOutOfRangeException ex)
//    {

//        Console.WriteLine(ex.Message);
//        isSucces = false;
//}
//    catch (DivideByZeroException ex)
//    {

//        Console.WriteLine(ex.Message);
//    }
//    finally
//    {
//        if (isSucces)
//        {
//            SendEmail("Register is ok ");
//        }
//        else
//        {
//            SendEmail("Something is wrong")
//        }
//    }    
//}
//static void SendEmail(string message)
//{
//    Console.WriteLine(message);
//}


//Login("per2vin123", "pervin12345");
//static void  Login(string username,string password)
//{
//    try
//    {
//        if(username=="pervin123"&& password == "pervin12345")
//        {
//            Console.WriteLine("Login is success");
//        }
//        else
//        {
//            throw new InvolidLoginException(ExceptionMessage.InvalidLogin);
//        }
//    }
//    catch (Exception ex)
//    {

//        Console.WriteLine(ex.Message);
//    }
//}
#endregion



#region Factorial
//GetNum(-1);
//  static void GetNum(int num)
//{
//    int multiple = 1;
//    try
//    {
//        if (num > 0)
//        {
//            for (int i = 1; i <= num; i++)
//            {
//                multiple = multiple * i;
//            }
//            Console.WriteLine(multiple);
//        }
//        else
//        {
//            throw new ExceptionNum("Number is not correct");
//        }

//    }
//    catch (Exception ex)
//    {

//        Console.WriteLine(ex.Message);
//    }
//}
#endregion


//Person tipinden listimiz var. 
//  Maashi 1000-den cox olan personlarin ad, soyad ve addresini gosteren ve parametr olaraq predicate qebul  eden method yazin.


PersonService person = new PersonService();
person.FilterSalary();



