using System;
using System.Collections.Generic;
using System.Linq;

namespace GuestBook2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> PartyDic = new Dictionary<string, int>();
            WelcomeMessage();                   //WelcomeMessage

            do
            {       
                string partyName = GetPartyName(); // GetPartyName
                int size = GetPartySize();         // GetPartySize
                PartyDic.Add(partyName, size);      // fill up the dictionary

            } while (KeepGoing());

            GetALLParty(PartyDic);

        }
        public static void WelcomeMessage ()
        {
            Console.WriteLine("Welcome to the Guest Book App");
            Console.WriteLine("*****************************");
            Console.WriteLine();           
        }
        public static string GetPartyName()
        {
            Console.Write("What is your party/Group name: ");
            string output = Console.ReadLine();

            return output;
        }
        public static int GetPartySize()
        {
            bool isValidNumber;
            int partySize;
            do
            {
                Console.Write("How many people are in your party: ");
                string partySizeText = Console.ReadLine();
                isValidNumber = int.TryParse(partySizeText, out partySize);

            } while (isValidNumber == false);

            return partySize;
        } 

        public static void GetALLParty(Dictionary<string, int> myDic)
        {
            int total = 0;
            foreach(KeyValuePair<string, int> guest in myDic) //search for keyValuePair, displace key and value
            {
                System.Console.WriteLine($"\nWe have guest family {guest.Key}.");
                total += guest.Value;
            }
            System.Console.WriteLine($"\nWelcome! We have {total} guests at the party.");
            Console.ReadKey();
        }

        public static bool KeepGoing()
        {
            Console.Write("Are there any more guest family(yes or no): ");
            string answer = Console.ReadLine();
            if(answer.ToLower() == "yes")
            {
                return true;
            }
            return false;
        }


    }
}
