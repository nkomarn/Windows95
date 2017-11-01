using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace PLTW
{
    public class DataTypes
    {
        //example of types
        public static int MyInteger;
        public static float MyFloat;
        public static double MyDouble;
        public static string MyString;
        public static bool MyBoolean;

      
        //setting values of types
        public static void Integer()
        {
            MyInteger = 1;
        }

        public static void Float()
        {
            MyFloat = 0.1f;
        }

        public static void Double()
        {
            MyDouble = 0.001;
        }

        public static void String()
        {
            MyString = "string";
        }

        public static void Boolean()
        {
            MyBoolean = true;
        }

        //types 2
        public static int ValueInteger;
        public static float ValueFloat;
        public static double ValueDouble;
        public static string ValueString;
        public static bool ValueBoolean;
        
        //function that uses/sets types 2
        public static void Calculator()
        {
            if (MyBoolean)
            {
                ValueInteger = MyInteger + MyInteger;
                ValueFloat = MyFloat + MyFloat;
                ValueDouble = MyDouble + MyDouble;
            }
            if (ValueInteger == MyInteger * 2)
            {
                ValueString = MyString +" " + MyString;
            }
            if (ValueString == "string" +" " + "string")
            {
                ValueBoolean = false;
            }
        }
        //types 3
        public static int AppValue;
        
        //function that uses/sets types 3 
        public static void Application(bool isTrue, int num1, int num2)
        {
            if (isTrue)
            {
                AppValue = num1 + num2;
            }
            else
            {
                AppValue = num1 - num2;
            }
        }
        




        public static void Main(string[] args)
        {
            //sets types
            Integer();
            Float();
            Double();
            String();
            Boolean();
            
            //writes types
            Console.WriteLine(MyInteger);
            Console.WriteLine(MyFloat);
            Console.WriteLine(MyDouble);
            Console.WriteLine(MyString);
            Console.WriteLine(MyBoolean);
            
            //calculates types 2
            Calculator();
            
            //writes types 2
            Console.WriteLine(ValueInteger);
            Console.WriteLine(ValueFloat);
            Console.WriteLine(ValueDouble);
            Console.WriteLine(ValueString);
            Console.WriteLine(ValueBoolean);
            
            //calls application with isTrue as true, num1 as 1, num2 as 1
            Application(true, 1, 1);
            
            //writes types 3
            Console.WriteLine(AppValue);
            
            //calls application with isTrue as false, num1 as 1, num2 as 1
            Application(false, 1, 1);
            
            //writes types 3
            Console.WriteLine(AppValue);
        }

    }
    
}