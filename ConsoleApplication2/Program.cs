namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // writing your name, I kept forgetting the semicolon after tehe parenthesiss

            System.Console.Write(" What is your first name? ");

            string firstName;

            firstName = System.Console.ReadLine();


            System.Console.Write(" What is your middle initial? ");

            string middleInitial;

            middleInitial = System.Console.ReadLine();

            System.Console.Write(" What is your last name? ");

            string lastName;

            lastName = System.Console.ReadLine();


            System.Console.WriteLine(" Your full name is " + firstName + " " + middleInitial + " " + lastName + " ");

            // height time!   System.Console.Write(" Your Height is " + (((heightFeet) * 12 + heightInch) * 2.54) + " "); tried doing it this way but couldnt figure it out
            

            System.Console.Write(" What is your height in feet? ");

            int heightFeet;

            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write(" And how many inches are you inaddition to your hieght in feet? ");

            int heightInch;

            heightInch = int.Parse(System.Console.ReadLine());

            int totalHeightIN = 0;

            totalHeightIN += (heightFeet * 12 );
            totalHeightIN += (heightInch);

            // voting time

            System.Console.Write(" What is your age? ");

            int ageUser;

            ageUser = int.Parse(System.Console.ReadLine());
            if (ageUser >= 18)
                System.Console.WriteLine(" You are the voting age. ");
            else
                System.Console.WriteLine(" You are below the voting age. ");

            System.Console.Write(" True or False. Are you a Citizen of the United States of America? ");

            bool  citizenTrue;

            citizenTrue = bool.Parse(System.Console.ReadLine());
            if (citizenTrue && true) 
                System.Console.WriteLine(" You have voting rights. ");
            else
                System.Console.WriteLine(" You do not have voting rights. ");
            
          
            System.Console.WriteLine(" Can you vote? ");
            if ((citizenTrue && true) & (ageUser >= 18))
                System.Console.WriteLine(" You CAN vote, do your duty! ");
            else
                System.Console.WriteLine(" You are unable to vote. ");






            bool canVote;
            
            if (ageUser >= 18) ;
           

            
            if (citizenTrue = false) ;
            
            if (ageUser < 18) ;
            
            

         


            // this is the final read out

            System.Console.WriteLine(" Your full name is " + firstName + " " + middleInitial + " " + lastName + " ");
            System.Console.WriteLine(" Your height in CM is " + ((totalHeightIN) * 2.54) + " ");
            System.Console.WriteLine(" Press any key to continue... ");
            System.Console.ReadKey();

        }
    }
}
