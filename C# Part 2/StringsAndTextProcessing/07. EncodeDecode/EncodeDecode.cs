//Problem 7. Encode/decode
/*Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
 */

using System;
using System.Text;

class EncodeDecode
{
    static void Main()
    {
        Console.WriteLine("Please enter a text to Encode/Decode: ");
        string inputText = Console.ReadLine();
        Console.Write("Please enter the cipher key: ");
        string cipher = Console.ReadLine();

        Console.WriteLine("\nEncrypted: {0}\n", Encrypt(inputText, cipher));
        Console.WriteLine("\nDecrypted: {0}\n", Decrypt(Encrypt(inputText, cipher), cipher));
    }

    static string Encrypt(string word, string key)
    {
        StringBuilder cipher = new StringBuilder();

        for (int i = 0; i < word.Length; i++)
            cipher.Append((char)(word[i] ^ key[i % key.Length]));

        return cipher.ToString();
    }
    static string Decrypt(string word, string key)
    {
        return Encrypt(word, key);
    }
}

