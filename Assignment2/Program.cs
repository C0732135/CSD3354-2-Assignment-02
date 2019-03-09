using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name: Chetan rahanoo
// Student id: C0732135
//CSD3354 Section 2
//Assignment 2
//March 6,2019

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();
        }
    }
    public class DelegateExercises
    {
        public delegate int MyDelegate();

        void Method1()

        {
            System.Console.WriteLine("MyDelegate");
        }

    
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);



            myDelegate();
        }



    }
}
