using System;

class Program{

    public static void cookie(int i){
        if(i>0){
            Console.WriteLine("Your number is positive.");
        }
        else if(i<0){
            Console.WriteLine("Your number is negative.");
        }
        else{
            Console.WriteLine("Your number is 0. ");
        }


    }
    static void Main(){

        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        cookie(number);

    }
}