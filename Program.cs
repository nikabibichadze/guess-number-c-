using System;


namespace NumberGuesser
{
    class Program
    {
        
        static void Main(string[] args)
        {
            while (true)
            {

                Random random = new Random();
                int correctNumber = random.Next(1, 50);

         
                int guess = 0;

                
                Console.WriteLine("Guess a number between 1 and 50");

              
                while (guess != correctNumber)
                {
                    
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                   
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number");

          
                        continue;
                    }

                 
                    guess = Int32.Parse(input);


                    if (guess != correctNumber)
                    {
                        if  (guess> correctNumber)
                        PrintColorMessage(ConsoleColor.Red, "Too much");
                        else
                        PrintColorMessage(ConsoleColor.Red, "Too small");

                    }
                }

                PrintColorMessage(ConsoleColor.Green, "CORRECT!! You guessed it!");
                
                Console.WriteLine("Play Again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
              
            }

        }

        
       

       
        static void PrintColorMessage(ConsoleColor color, string message)
        {
      
            Console.ForegroundColor = color;

            
            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}