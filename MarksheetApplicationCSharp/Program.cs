//cSharp basic marksheet calc
namespace MarksheetApplicationCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter your roll no");
            int Rollno = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your class");
            int std = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your english marks");
            int marksEng = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your maths marks");
            int marksMaths = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your physics marks");
            int marksPhysics = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your chem marks");
            int marksChem = int.Parse(Console.ReadLine());

            int obtMarks = marksMaths + marksChem + marksEng + marksPhysics;
            int perc = obtMarks * 100 / 400;

            Console.WriteLine("-------------MARKSHEET-------------");
            Console.WriteLine("Your name is {0}", Name);
            Console.WriteLine("The obtained marks is: {0}", obtMarks);
            Console.WriteLine("The obtained percentage is: {0}", perc,"%");

            // if else if for grade 

            if(perc >= 80)
            {
                Console.WriteLine("Grade: A");
            }
            else if (perc >= 70)
            {
                Console.WriteLine("Grade: B");
            }
            else if (perc >= 60)
            {
                Console.WriteLine("Grade: B");
            }
            else if (perc >= 50)
            {
                Console.WriteLine("Grade: C");
            }
            else if (perc >= 40)
            {
                Console.WriteLine("Grade: B");
            }
            else 
            {
                Console.WriteLine("Fail");
            }

            ///////if..else..if to calculate supplementary

            int supply = 0;

            if (marksEng<40) 
               {
                   supply++;
               }
            if(marksMaths < 40)
                {
                supply++;
                }
            if (marksChem < 40)
            {
                supply++;
            }
            if (marksPhysics < 40)
            {
                supply++;
            }

            Console.WriteLine("You failed in {0} subjects", supply);


            Console.ReadLine();


        }
    }
}