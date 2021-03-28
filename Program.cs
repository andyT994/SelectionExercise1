using System;

namespace SelectionExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Age");
            string Age = Console.ReadLine();
           
           int ageNum = int.Parse(Age);
           
           // Selection - if
           if (ageNum >= 17) {
               // True Branch

               Console.WriteLine("Legally Adult Age");

               // Gender
               Console.WriteLine("Enter Your Gender");
               String gender = Console.ReadLine();

               if (gender == "M") {
                   System.Console.WriteLine("M is an Adult");
                   
               } else {
                   System.Console.WriteLine("F is not an Adult");
               }
           } else {       
               Console.WriteLine("M is not an Adult"); 
           }
               // Sum of Numbers
            Console.WriteLine("Enter Number");
            string SumNumber = Console.ReadLine();

            int Number = int.Parse(SumNumber);

            if (Number > 10) {
                System.Console.WriteLine("Sum of Number is Greater than 10");
            } else {

                if (Number == 10) {
                    System.Console.WriteLine("Sum of number is Equal to 10");
        
                } else {
                    System.Console.WriteLine("Sum of number is Less than 10"); 
                }
            }       
           
        }
    }
}          
