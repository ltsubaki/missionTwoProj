using System.Threading;
using System.Xml.Linq;
using missionTwoProj;

internal class Program
{
    private static void Main(string[] args)
    {
        //initialize variables
        int numRolls = 0;
        diceRoll dr = new diceRoll();

        //ask the user how many times they want to roll the dice
        System.Console.WriteLine("Please enter the number of times you want to roll two dice: ");
        numRolls = int.Parse(System.Console.ReadLine());

        //call the doDiceRoll class to execute the rolling
        dr.doDiceRoll(numRolls);

        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}