//Problem 3. Check for a Play Card
//Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write 
//a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.

using System;

class CheckForPlaycard
{
    static void Main()
    {
        Console.Write("Please enter a card sign: ");
        string sign = Console.ReadLine();

        string[] card = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        bool isInDeck = false;
        for (int i = 0; i < card.Length; i++)
        {
            if (sign == card[i])
                isInDeck = true;
        }
        Console.WriteLine("{0}", isInDeck ? "yes" : "no");
    }
}