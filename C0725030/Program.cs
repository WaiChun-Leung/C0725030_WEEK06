using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0725030
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object reference
            //var a = new WorkBench();
            new WorkBench().Run();


            WorkBench2 wb2 = new WorkBench2(); //wb2 is object reference
            wb2.VariableA = 7;
            WorkBench2.VariableB = 8; //if this have static, can't just wb2.VariableB = 8;
            wb2.Run();
            WorkBench2 wb2_b = new WorkBench2();
            Console.WriteLine(WorkBench2.VariableB);

            new Building().run();
            string lookFor = "Shoes";
            Console.WriteLine("{0} found in area {1} ", lookFor, Search.FindItem("Shoes"));

        }
    }

    class WorkBench2
    {
        //create 2 variable
        public int VariableA;
        public static int VariableB;

        public void Run()
        {
            Console.WriteLine(" VariableA is {0} ", VariableA);
            Console.WriteLine(" VariableB is {0} ", VariableB);
            VariableA++;
            VariableB++;
            Console.WriteLine(" VariableA is {0} ", VariableA);


        }

    }

    class WorkBench
    {
        Random rand = new Random();
        int randomChoice = 0;

        public void Run()
        {
            //infinite loop
            //for ( ; ; )
            //{
            //    Console.WriteLine("Happy Valentine's Day!!");
            //}

            //this will run until see the false, then the method will stop
            //for (;  MethodA() ; )

            //this will just run one time
            //for (Console.WriteLine("YIPPIE") ;  MethodA() ; )

            randomChoice = rand.Next(0, 25);
            //printing variables is called tracing
            Console.WriteLine("POINT A: randomChoice is {0} ", randomChoice);


            for (Console.WriteLine("YIPPIE"); MethodA(); Console.WriteLine(MethodB()) )
                //run YIPPIE once time, then go to the MethodA, then increate the MethodB
            {
                Console.WriteLine("Happy Valentine's Day!!");
                Console.ReadLine();
            }
        }

        public bool MethodA()
        {
            if (randomChoice < 13)
            {
                return true;
            }
            return false;
            //return true; //if this is false, the method will stop
        }

        public string MethodB()
        {
            //Create a string array of the letters of the alphabet
            string[] letters = new string[26] { "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z" };
            string output;

            //Random rand = new Random(); //rand is object reference
            //randomChoice = rand.Next(0, 25); //rand the next number is between 0 - 25
            output = letters[randomChoice];
            
            return output;
        }
    }

    //Writer a Method in class Building which will iterate over the FirstFloor Array and report on the Array Element Number which corresponds to Shoes:
    class Building
    {
        Floors[] Floor = new Floors[4];
        public static Floors FirstFloor = new Floors();

        public void run()
        {
            FirstFloor.Departments[0] = "Toys";
            FirstFloor.Departments[1] = "Tools";
            FirstFloor.Departments[2] = "Shoes";
            FirstFloor.Departments[3] = "Housewares";
        }
    }
    class Search
    {
        public static int FindItem(string lookingFor)
        {
            string[] catalog;

            catalog = Building.FirstFloor.Departments;
            for (int i = 0; i < catalog.Length; i++)
            {
                if (catalog[i] == lookingFor)
                {
                    return i;
                }
            }
            return -1;
        }
    }
    class Floors
    {
        public string[] Departments = new string[4];
    }
    
}

//4 Type
//class name {} is class instance variable, is outside any methods, is the variable for the whole class
//class static is only one copy of that variable of heap
//method local variable is like public void
//2 way to create memory: the new keyword (create an object)
//                        type a primitive 
//                        string  name = "Joe", int k = 5;
//Loop local

