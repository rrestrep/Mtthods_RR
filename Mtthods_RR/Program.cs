/*
	Author: Clinton Daniel
	Date: 1/5/2019
	Comments: This C# Console application code demonstrates the use of
	methods after getting input from a user. The program has two
	methods. One value return method and one void method.
	One method is designed to calculate the users maximum heart rate
	after entering their age. The other method is designed to 
	calculate the users recommended heart rate range during exercise
	based on the calculated maximum heart rate. 
	*/
using System;

namespace Methods_RR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your age. You must be between 18 and 100 years of age: ");
            /*
            Use the try catch block to validate user input.
            If the user provides bad input, the catch block
            will handle the error and a message will be displayed.
            */
            try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();
                // This variable will be used to calculate the maximum heart rate and is parsed as an integer
                int value_of_input = int.Parse(input);
                // This IF statement tests to see if the user input an age between 18 and 100
                if ((value_of_input > 17) && (value_of_input <= 100))
                {
                    /* 
                    Execute the Max_Heart_Rate method and pass the age of the user from input.
                    This is a value return method. 
                    The method then returns the maximum heart rate that will be used later
                    to calculate the recommended heart rates during exercise
                    */
                    int get_max_heart_rate = Max_Heart_Rate(value_of_input);
                    /*
                    Execute the Recommend_Exercise method and pass the maximum heart rate.
                    This is a void method. The method simply executes with nothing returned. 
                    */
                    Recommend_Exercise(get_max_heart_rate);
                }
                else
                {
                    Console.WriteLine("This program calculates heart rate for adults only.");
                    Console.WriteLine("You must enter an age greater between 18 and 100 to calculate the max heart rate");
                    Console.WriteLine("Press any key to exit the program and try again ...");
                    Console.ReadKey(true);
                }
            } // End of try
            catch
            {
                Console.WriteLine("Please enter an integer value for your age next time ...");
                Console.WriteLine("Press any key to exit the program and try again ...");
                Console.ReadKey(true);
            } // End of catch
        } // End of Main

        /*
        This static value return method calculates your maximum heart rate
        A static method cannot be instantiated with the key word "new".
        The accessor is private which means the method is limited to the
        containing class. 
        */
        private static int Max_Heart_Rate(int get_age)
        {
            // The formula for max heart rate during exercise is 220 minus your age
            int calculate_max_heart_rate = 220 - get_age;
            Console.WriteLine(" ");
            Console.WriteLine("Based on the age you entered: " + get_age);
            Console.WriteLine("Your maximum heart rate during exercise should be " + calculate_max_heart_rate + " beats per minute.");

            return calculate_max_heart_rate;
        } // End of Max_Heart_Rate

        /*
        This static void method calculates your recommended exercise heart rates
        A static method cannot be instantiated with the key word "new".
        The accessor is private which means the method is limited to the
        containing class. 
        */
        private static void Recommend_Exercise(int get_heart_rate)
        {
            // Calculate the recommended lower target heart rate
            double lower_recommend_exercise = get_heart_rate * .55;
            // Calculate the recommended upper target heart rate
            double upper_recommend_exercise = get_heart_rate * .85;
            Console.WriteLine(" ");
            Console.WriteLine("Your target heart rate during exercise is within 55 and 85 percent of your maximum heart rate for at least 20 to 30 minutes.");
            Console.WriteLine(" ");
            Console.WriteLine("Your recommended lower target heart rate during exercise is " + lower_recommend_exercise + " beats per minute.");
            Console.WriteLine("Your recommended upper target heart rate during exercise is " + upper_recommend_exercise + " beats per minute.");
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to exit the program ...");
            // Pause the program and await the user to press a key to end the program
            Console.ReadKey(true);
        } // End of Recommend_Exercise
    } // End of class
} // End of namespace

