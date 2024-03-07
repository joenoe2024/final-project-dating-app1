/*
 * author: joseph sandoval
 * purpose: Dating app for final project.
 */

namespace final_project_dating_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Visual Studio dating pool, Please fill out the info below");

            Console.WriteLine("Please enter your desired first name: ");// takes user input
            string firstName = Console.ReadLine();//stores userinput

            Console.WriteLine("Please enter desired last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter your birth year:");// takes user input and stores it in a variable, then does a loop to calculate appropriate user resonse. 
            int birthYear;
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out birthYear))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid birth year:");
                }
            }
            Console.WriteLine("Please enter your gender (M/F/O): ");
            char gender;
            while (!char.TryParse(Console.ReadLine(), out gender) || !IsValidGender(gender))
            {
                Console.WriteLine("Invalid input! Please enter a valid gender (M/F/O");
            }
            
            bool IsValidGender(char gender)
            {
                return gender =='M' || gender == 'F' || gender == 'O';
            }

            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;

            Console.WriteLine($"Thank you, {firstName}! Heres your information:");
            Console.WriteLine($"First and last name:{firstName}{lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");

            List<string> questions = new List<string>()
            {
                "Whats your favotire color?:",
                "Whats your favorite food?:",
                "Whats your favorite tvshow?:",
                "Whats your favorite candy?:",
                "Whats your origin of birth?:",
                "Whats your dream?: ",
                "What kind of animals do you have, write none if none:",
                "Do you partake in the devils lettuce?:,",
                "Do you prefer indoors or outdoors?:",
                "playstation or xbox? (warning: answer is susceptible to deal breakers:)",
            
            };

            List<string> responses = new List<string>();

            foreach (var question in questions)
            {
                Console.WriteLine(question);
                string response = Console.ReadLine();
                responses.Add(response);
            }

        }
    }
}




