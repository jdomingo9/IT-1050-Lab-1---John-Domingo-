namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("What is your first name?");
            string firstName;
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your middle initial?");
            string middleInitial;
            middleInitial = System.Console.ReadLine();

            System.Console.Write("What is your last name?");
            string lastName;
            lastName = System.Console.ReadLine();

            string fullName;
            fullName = firstName + middleInitial + lastName;

             System.Console.Write("What is your base height in feet?");
            int heightFeet;
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many inches after your base height?");
            double heightInches;
            heightInches = int.Parse(System.Console.ReadLine());

            double totalHeightCM;
            totalHeightCM = (heightFeet * 12 + heightInches) * 2.54; 

            System.Console.Write("How old are you?");
            int age;
            age = int.Parse(System.Console.ReadLine());
            bool old;
            old = age > 17;

            System.Console.WriteLine("Are you a citizen of the United States? True or False");
            bool isCitizen = true;
            isCitizen = bool.Parse(System.Console.ReadLine());

            bool canVote;
            canVote = isCitizen && old;

            System.Console.WriteLine("Full Name:" + "" + fullName);

            System.Console.WriteLine("Height in centimeters:" + "" + totalHeightCM);


            System.Console.WriteLine("Are you allowed to vote?" + "" + canVote);
         

            System.Console.ReadKey();











            /////
        }
    }
}
