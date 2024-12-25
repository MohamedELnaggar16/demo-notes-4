using System;

namespace demo_notes_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Casting [boxing - unboxing] 
            //(not recommended to use bec low performance and time) (not good for memory)
            //Reference Type Casting => convert from reference to reference type
            //Boxing Type Casting (safe casting(convert))=> convert from value type to reference type (store data from stack(value) to heap(reference))
            //UnBoxing Type Casting (not safe casting)=> convert from reference type to Value type 

            //object obj = new object(); 
            //obj = "naggar"; //Reference Type Casting
            //obj = 29; //Boxing Type Casting
            //obj = 'N'; //Boxing Type Casting
            //obj = new Employee(); //Reference Type Casting

            ///////////////////////////////////////////////////////////////////////////////

            //int x = 10;
            //object obj = new object();
            //obj = x; //Boxing Type Casting

            //////////////////////////////////////////////////////////////////////

            //object obj = new object();
            //obj = 10;
            ////int x = obj; // give error bec i dont know which data will stored in obj and the data type here is int
            //int x = (int)obj; // this will not give error but no safe (unboxing casting)


            #endregion

            #region Nullable Type

            #region Value type
            //int x = 29; // accept by defauly any number exept null
            //int? y = null; // with ? accept null and numbers
            //Nullable<int> Number; not use but its like int?

            //int? x = 10;
            //int y = x; // give error bec the first one accept null and the seconed one is not accept null

            //int? x = 10;
            //int y = (int)x;  // not safe bec i dont know the input is int or not 
            //////////////////////////////////////////////////
            //int? k = null;
            //int l;
            //if (k != null) {   // this is the right way to safe cast 
            //    l = (int)k;
            //}
            //else {
            //    l = 0;
            //}
            //////////////////////////////////////////////
            //if (k.HasValue)  // another way by builtin method
            //{
            //    l = k.Value;
            //}
            //else { 
            //    l = 0;
            //}

            //l =k.HasValue ? k.Value : 0;    // another way by ternary operator

            //Console.WriteLine(l);   

            #endregion

            #region Reference type (to avoid warning only)(compiler enhance)
            //string? Name = null;
            //Console.WriteLine(Name);

            #endregion

            #endregion

            #region Null propagation operator
            //int[] Numbers = null;
            //int[] Numbers = { 1,2,3,4,5};
            //for (int i = 0; i < Numbers.Length; i++) {  // error bec there is no data to loop at
            //    Console.WriteLine(Numbers[i]);          
            //}

            //for (int i = 0 ; Numbers != null && i < Numbers.Length; i++) // must && 
            //{  
            //    Console.WriteLine(Numbers[i]);
            //}

            //for (int i = 0;  i < Numbers?.Length; i++) // syntax sugar // Numbers?.Length => low performance bec it check every step
            //{  
            //    Console.WriteLine(Numbers[i]);
            //}

            //if (Numbers != null) {
            //    for (int i = 0; i < Numbers.Length; i++)  
            //    {
            //        Console.WriteLine(Numbers[i]);
            //    }
            //}

            //int L = Numbers?.Length ?? 0; // ?? null coaleasing operator => explain is if numbers is null then make number = zero 
            #endregion

            #region Functions
            // write in class scope in main scope bec CLR comiler run anything in main 
            // functions two types
            // class member class (static function)
            // object member function (none static function) 


        #endregion



    }
}
}
              