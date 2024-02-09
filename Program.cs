using System;
using System.Data.Common;
using System.Net;
namespace CSharpHelloWorld
{
    class HelloWorld
    {
        static void Main(string[]args)
        {
            //Linea de comentarios
            /*
            Varias lineas de comentarios
            */
            Console.WriteLine("Hola, C#!");

            string myString = "Estos es una cadena de texto";
            myString="Aquí cambio el valor de la cadena";
            Console.WriteLine(myString);

            int myInt = 4;
            myInt = myInt + 4;
            Console.WriteLine(myInt);
            Console.WriteLine(myInt - 1 );
            Console.WriteLine(myInt);

            float myFloat = 6.5f;
            Console.WriteLine(myFloat);

            double myDoble = 6.5;
            Console.WriteLine(myDoble);

            dynamic myDynamic = 6; // Puede cambiar su tipo de dato

            myDynamic = "Mi dato dinámico";

            Console.WriteLine(myDoble + myFloat + myInt);

            bool myBool = true;
            Console.WriteLine(myBool);

            Console.WriteLine($"El valor de mi enero es {myInt} y el valor de mi bool {myBool}");
            const string MyConst = "Mi constante";
            Console.WriteLine(MyConst);

            //ESTRUCTURAS 

            var myArray =  new  string [] {"Andres", "Montoya", "Valkdev"};

            Console.WriteLine(myArray[0]);

            var myDictionary = new Dictionary <string,int>
            {
                {"Andres",25},
                {"Manuela",30},
                {"Alejandro",38}
            };

            Console.WriteLine(myDictionary["Andres"]);


            var mySet = new HashSet<String> {"Andres", "Montoya", "Valkdev"};
            var myTuple = ("Andres", "Montoya", "Valkdev");
            Console.WriteLine(myTuple);

            //Bucles

            for (int index = 0 ; index < 10; index++)
            {
                Console.WriteLine(index);
            }    

            foreach (var myItem in myArray)
            {
                Console.WriteLine(myItem);
            }
             foreach (var myItem in myDictionary)
            {
                Console.WriteLine(myItem);
            }
             foreach (var myItem in mySet)
            {
                Console.WriteLine(myItem);
            }

            //Flujos

            if(myInt == 8 && myBool == true)
            {
                Console.WriteLine("El valor es 8");

            }
            else if(myInt == 12 || myBool==false)
            {

            }
            else
            {
                Console.WriteLine("el valor no es 8");
            }

            //Funciones

            MyFunction();
            Console.WriteLine(MyFunctionWhithReturn(5));
            //Clases 

            var myClass = new MyClass("Alemania");
            Console.WriteLine(myClass.myName);

        } 
         static void MyFunction()
         {
            Console.WriteLine("Mi función");

         }

          static int MyFunctionWhithReturn(int param)
         {
            return 10 + param;

         }

         class MyClass
         {
             public string  myName {get ; set; }
             public MyClass(String myCurrentName)
            {

                myName = myCurrentName;
            }
         }


    }

   
}
