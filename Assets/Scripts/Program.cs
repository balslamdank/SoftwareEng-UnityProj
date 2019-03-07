using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice_roller
{
    public class roller
    {
        public int Work(string test)
        {
            string inputString = test + " ";
            string newString = "";
            int newRollTotal = 0;

            roller roll = new roller();

            newString = roll.StringParser(inputString) + " ";
            Console.WriteLine(newString);
            newRollTotal = roll.FindDiceRollTotal(newString);
            Console.WriteLine(newRollTotal);

            return newRollTotal;
            
        }

        //passing in the value that is read from the calculator pad dice roller input
        public string StringParser(string userEnteredString)
        {
            string newParsedString = "";
            char[] userEnteredArray = userEnteredString.ToCharArray();
            string numberOfDiceRolls = "";
            string valueOfDice = "";
            int diceRolls = 0;
         
            for (int i = 0; i < userEnteredString.Length-1; i++)
            {
                if (Char.IsDigit(userEnteredArray.ElementAt(i)) && 
                    userEnteredArray.ElementAt(i+1).Equals('d'))
                {
                    //record the number in front of the d portion
                    numberOfDiceRolls = userEnteredArray.ElementAt(i).ToString();
                    Int32.TryParse(numberOfDiceRolls, out diceRolls);
                }
                else
                {
                    switch (userEnteredArray.ElementAt(i))
                    {
                        case 'd':
                            valueOfDice = userEnteredArray.ElementAt(i + 1).ToString();
                            for (int j = 0; j < diceRolls; j++)
                            {
                                newParsedString += "d" + valueOfDice;
                            }
                            break;
                        case '+':
                            newParsedString += "+";
                            break;
                        case '-':
                            newParsedString += "-";
                            break;
                        case '*':
                            newParsedString += "*";
                            break;
                        case '/':
                            newParsedString += "-";
                            break;
                        default:
                            if (userEnteredArray.ElementAt(i - 1).Equals('d'))
                                break;
                            else
                                newParsedString += userEnteredArray.ElementAt(i);
                            break;
                    }
                }
            }
            return newParsedString;
        }

        public int FindDiceRollTotal(string newParsedString)
        {
            int diceRollTotal = 0;
            string valueOfDice = "";
            int diceValue = 0;
            string bonus = "";
            int bonusNum = 0;
            int randomlyGeneratedDiceRoll = 0;
            Random rand = new Random();

            for (int i = 0; i < newParsedString.Length - 1; i++)
            {
                switch (newParsedString.ElementAt(i))
                {
                    case 'd':
                        valueOfDice = newParsedString.ElementAt(i + 1).ToString();
                        Int32.TryParse(valueOfDice, out diceValue);
                        randomlyGeneratedDiceRoll = rand.Next(1, diceValue);
                        diceRollTotal += randomlyGeneratedDiceRoll;
                        break;
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                        break;
                    default:
                        if (newParsedString.ElementAt(i - 1).Equals('d'))
                            break;
                        else
                            bonus = newParsedString.ElementAt(i).ToString();
                            Int32.TryParse(bonus, out bonusNum);
                            if (newParsedString.ElementAt(i - 1).Equals('+'))
                                diceRollTotal += bonusNum;
                            else if (newParsedString.ElementAt(i - 1).Equals('-'))
                            {
                                diceRollTotal -= bonusNum;
                                Console.WriteLine("here");
                            }
                            else if (newParsedString.ElementAt(i - 1).Equals('*'))
                                diceRollTotal *= bonusNum;
                            else
                                diceRollTotal /= bonusNum;
                            break;
                }
            }

            return diceRollTotal;
        }
    }
}
