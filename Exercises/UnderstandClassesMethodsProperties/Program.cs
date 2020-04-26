using System;

namespace UnderstandClassesMethodsProperties
{
    class Program
    {
        ////Variables declared outside the main.
        //int x = 100;
        //int y = 200;
        //static void Main(string[] args)
        //{
        //    //Object created
        //    Program a = new Program();

        //    //Instance variables called
        //    Console.WriteLine(a.x);
        //    Console.WriteLine(a.y);
        //}

        //*NEW* Method declared outside the main//
        //static void show()
        //{
        //    int x = 100;
        //    int y = 200;
        //    Console.WriteLine(x);
        //    Console.WriteLine(y);
        //}

        //public static void Main()
        //{
        //    //object created
        //    Program a = new Program();

        //    //Instance method called
        //    a.show();
        //}

        //*NEW* Methods
        //A class method declared
        //static void show()
        //{
        //    int x = 100;
        //    int y = 100;
        //    Console.WriteLine(x);
        //    Console.WriteLine(y);
        //}

        //public static void Main()
        //{
        //    //class method called without creating an object of the class
        //    Program.show();
        //}

        //*NEW* Declaring methods with parameters
        //method declared with two parameters x and y of the type integer
        //void show(int x, int y)
        //{
        //    Console.WriteLine(x);
        //    Console.WriteLine(y);
        //}

        //public static void Main()
        //{
        //    //object created
        //    Program a = new Program();

        //    //method "show" called by passing two interger values
        //    a.show(200, 250);
        //}

        //*NEW* Method Overloading - In the preceding example, we declared a single method with a single parameter. But you can declare the signature of the same method once again in the same class but with different parameters. The parameters should be different. If not, the C# compiler would show errors. 

        //method declared ith one integer parameter
        //void show(int x)
        //{
        //    Console.WriteLine(x);
        //}

        //method declared with two integer parameters
        //void show(int a, int b)
        //{
        //    Console.WriteLine(a);
        //    Console.WriteLine(b);
        //}

        //public static void Main()
        //{
        //    //object created
        //    Program a = new Program();

        //    //methods called by passing respective values
        //    a.show(100);
        //    a.show(300, 500);
        //}

        //*NEW* Properties - Properties provide added functionality to the .NET Framework. 
        //A C# property consists of: Field declaration & Accessor Methods(getter and setter methods)
        //Getter methods are used to retrieve the field's value and setter methods are used to modify the field's value. 
        //C# uses a special Value keyword to achieve this. Listing 10 declares a single field named zipcode and shows how to apply the field in a property.

        //field "idValue" declared
        public string idValue;

        //property declared with a capital "I"
        public string Idvalue
        {
            get
            {
                return idValue;
            }
            set
            {
                idValue = value;
            }
        }
        
        public static void Main(string [] args)
        {
            //object created
            Program pe = new Program();
            pe.Idvalue = "009878";
            string p = pe.Idvalue;
            Console.WriteLine("The value is {0}", p);
        }

    }
}
