namespace Iths_csharp_uppgifter_del_6_klassmetoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console
            //Exercise 1: Ask the user for their name and favorite color, then change the console's
            //text color to their favorite color and greet them with their name.

            //Console.WriteLine("What is your name?");
            //string userName = Console.ReadLine();
            //Console.WriteLine("What is your favourite color?");
            //string color = Console.ReadLine();
            //color = color.ToLower();

            //if (color == "blue")
            //{
            //    Console.ForegroundColor = ConsoleColor.Blue;
            //    Console.WriteLine($"Hello {userName}!");
            //}
            //else if (color == "red")
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine($"Hello {userName}!");
            //}
            //else if (color == "pink")
            //{
            //    Console.ForegroundColor = ConsoleColor.Magenta;
            //    Console.WriteLine($"Hello {userName}!");
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine($"Hello {userName}! I hope you like yellow too!");
            //}




            //Console Exercise 2: Prompt the user for two numbers, add them together, and display the result.

            //Console.Write("Choose a number: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Choose another number: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int sum = number1 + number2;

            //Console.WriteLine($"\n{number1} + {number2} = {sum}!");





            //Console Exercise 3: Create a simple loop that continually asks the user for input until they
            //enter "exit" or "quit".

            //bool isAsking = true;

            //while (isAsking)
            //{
            //    Console.WriteLine("\nWrite something here. Write exit or quit if you want to stop.\n");
            //    string input = Console.ReadLine();
            //    if (input.ToLower() == "exit" || input.ToLower() == "quit")
            //    {
            //        isAsking = false;
            //        Console.WriteLine("Program is finished.");
            //    }
            //}





            //Math
            //Exercise 1: Ask the user for a number and display its square root.

            //Console.WriteLine("Write a number: ");
            //double number = double.Parse(Console.ReadLine());
            //double sqrt = Math.Sqrt(number);
            //Console.WriteLine("The squareroot is " + sqrt);




            // Math Exercise 2: Get two numbers from the user and display the smallest number and the
            //difference between them.

            //Console.WriteLine("Write a number: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Write another number: ");
            //int number2 = int.Parse(Console.ReadLine());
            //int diff = 0;

            //int min = Math.Min(number1, number2);

            //{
            //    diff = number1 - number2;
            //    Console.WriteLine(number1 + " is the largest number och differensen mellan talen är " + diff);
            //}






            //Math Exercise 3: Calculate the area of a circle, given user input for the radius.

            //Console.WriteLine("Input r: ");
            //double radius = double.Parse(Console.ReadLine());
            //double area = radius * radius * Math.PI;
            //Console.WriteLine("Cirlel area is: " + area);





            //Random
            //Exercise 1: Generate a random number between 1 and 6, simulating the roll of a dice,
            //and display the result.

            //Random random = new Random();
            //int dice = random.Next(1, 7);
            //Console.WriteLine();
            //Console.WriteLine("Dice: " + dice);






            // Random Exercise 2: Create a simple lottery simulation where the user has to guess a number
            //between 1 and 10, and tell them if they guessed correctly.

            //Random random = new Random();

            //int randomNumber = random.Next(1, 11);

            //Console.WriteLine("Guess the random number.");
            //int userGuess = int.Parse(Console.ReadLine());  

            //bool isWrong = true;

            //while (isWrong)
            //{
            //    if (userGuess != randomNumber)
            //    {
            //        Console.WriteLine("Wrong, guess again!\n");
            //        userGuess = int.Parse(Console.ReadLine());
            //    }
            //    else
            //    {
            //        Console.WriteLine("Correct! You win!");
            //        isWrong = false;
            //    }
            //}






            // Random Exercise 3: Generate three random colors(using RGB values) and display their values.

            //Random randomColor = new Random();

            //int alpha = randomColor.Next(256);
            //int red = randomColor.Next(256);
            //int green = randomColor.Next(256);
            //int blue = randomColor.Next(256);

            //Console.WriteLine($"Alpha: {alpha}, Red: {red}, Green: {green}, Blue: {blue}");







            //DateTime
            //Exercise 1: Ask the user for their birthdate and calculate their age.

            //Console.WriteLine("Enter your birthyear: åååå-mm-dd.");
            //string birthday = Console.ReadLine();

            //DateTime dateTime = DateTime.Now;

            //DateTime födelsedag;
            //if (DateTime.TryParse(birthday, out födelsedag))
            //{
            //    DateTime idag = DateTime.Today;
            //    int age = idag.Year - födelsedag.Year;

            //    if (idag < födelsedag.AddYears(age))
            //    {
            //        age--;
            //    }

            //Console.WriteLine($"You are {age} years old.");

            //}




            // DateTime Exercise 2: Display the current day of the week and ask the user to enter an event.
            //Store and remind them of the event the next time the program runs.

            //Console.WriteLine("Please enter an appointment. ");
            //string newAppointment = Console.ReadLine();

            //DateTime today  = DateTime.Today; 

            //Console.WriteLine("Today is " + today);
            //Console.WriteLine("In how many days should I remind you?");
            //int remind = int.Parse(Console.ReadLine());

            //DateTime reminder = DateTime.Now.AddDays(remind);

            //Console.WriteLine($"I will remind you about {newAppointment} {reminder}.");






            //DateTime Exercise 3: Calculate the difference in days between today and the next holiday
            //provided by the user

            //DateTime today = DateTime.Today;
            //DayOfWeek currentDayOfWeek = today.DayOfWeek;

            //int daysUntilWeekend = 0;

            //switch (currentDayOfWeek)
            //{
            //    case DayOfWeek.Sunday:
            //        daysUntilWeekend = 5;
            //        break;

            //    case DayOfWeek.Monday:
            //        daysUntilWeekend = 4;
            //        break;

            //    case DayOfWeek.Tuesday:
            //        daysUntilWeekend = 3;
            //        break;

            //    case DayOfWeek.Wednesday:
            //        daysUntilWeekend = 2;
            //        break;

            //    case DayOfWeek.Thursday:
            //        daysUntilWeekend = 1;
            //        break;

            //}

            //Console.WriteLine($"It is {daysUntilWeekend} days until weekend.");







            // String
            //Exercise 1: Ask the user for a sentence and then display it in reverse order.

            //Console.WriteLine("Enter a word: ");
            //string word = Console.ReadLine();
            //char[] myArray = word.ToCharArray();
            //Array.Reverse(myArray);
            //string reversedWord = new string(myArray);
            //Console.WriteLine(reversedWord);






            //String Exercise 2: Check if the user's input string is a palindrome (reads the same backward
            //as forward).

            //Console.WriteLine("Enter a word");
            //string input = Console.ReadLine();
            //char[] charArray = input.ToCharArray();
            //Array.Reverse(charArray);
            //string reversName = new string(charArray);

            //if (reversName == input)
            //{
            //    Console.WriteLine("Det är ett palindrom");
            //}
            //else
            //{
            //    Console.WriteLine("Det är inte ett palindrom!");
            //}
            //Console.WriteLine(charArray);






            //String Exercise 3: Ask the user for a paragraph and count how many times a specific word
            //appears in it.

            //Console.WriteLine("Write a paragraph and this program will tell you how many times you wrote the word 'en'.");
            //string text = Console.ReadLine();
            //string[] ord = text.Split(' ');

            //int numberOfEnInText = 0;

            //foreach (string word in ord)
            //{
            //    if (word.ToLower() == "en")
            //    {
            //        numberOfEnInText++;
            //    }
            //}
            //Console.WriteLine($"You wrote the word en {numberOfEnInText} times.");






            //Arrays
            //Exercise 1: Create an application that accepts 5 numbers from the user, stores them
            //in an array, then prints out each number in reverse order.

            //int[] userNumbers = new int[5];

            //for (int i = 0; i < userNumbers.Length; i++)
            //{
            //    Console.Write("Add a number to list: ");
            //    userNumbers[i] = Convert.ToInt32(Console.ReadLine());

            //}
            //for (int i = 4; i >= 0; i--)
            //{
            //    Console.WriteLine(userNumbers[i]);
            //}





            //Arrays Exercise 2: Ask the user for a string.Convert this string into a character array and
            //count how many vowels(a, e, i, o, u) are in the string.

            //Console.WriteLine("Input a word:");
            //string input = Console.ReadLine();
            //char[] myArray = input.ToCharArray();
            //int numberOfVowels = 0;

            //foreach (char c in myArray)
            //{
            //    char lowerC = char.ToLower(c);

            //    if (lowerC == 'a' || lowerC == 'e' || lowerC == 'i' || lowerC == 'o' || lowerC == 'u' || lowerC == 'y')
            //    {
            //        numberOfVowels++;

            //    }

            //}
            //Console.WriteLine($"In word {input} there are {numberOfVowels} vowels.");






            //Arrays Exercise 3: Create a program where the user can continually add names into an array
            //until they decide to stop.After they stop, display all names entered and count how
            //many names are in the array

            //string name = "";
            //string nameLower = "";
            //int numberOfNames = 0;

            //List<string> namesList = new List<string>();

            //while (nameLower != "exit")
            //{
            //    Console.WriteLine("Add a name to this list. Input exit to stop and se all names in list.");
            //    name = Console.ReadLine();
            //    nameLower = name.ToLower();
            //    namesList.Add(name);
            //    numberOfNames++;

            //}
            //Console.WriteLine("Here are the persons in list: \n");

            //foreach (string person in namesList)
            //{
            //    if (person.ToLower() != "exit")

            //        Console.WriteLine(person);
            //}


            Console.ReadKey();


        }
    }
}