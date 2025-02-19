using System;

namespace CeasarCipher
{
    internal class Program
    {
        // Encoding method
        static string encode(string message, int[] key)
        {
            char[] encodedMessage = new char[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                int keyIndex = i % key.Length;
                int asciiValue = (int)message[i];
                int newAsciiValue = asciiValue + key[keyIndex];
                encodedMessage[i] = (char)newAsciiValue;
            }

            return new string(encodedMessage);
        }

        static string decode(string message, int[] key)
        {
            char[] decodedMessage = new char[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                int keyIndex = i % key.Length;
                int asciiValue = (int)message[i];
                int newAsciiValue = asciiValue - key[keyIndex];
                decodedMessage[i] = (char)newAsciiValue;
            }

            return new string(decodedMessage);
        }


        static void Main(string[] args)
        {
            int[] key = { 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine("Enter message to encode here:");
            string message = Console.ReadLine();
            string encodedMessage = encode(message, key);
            Console.WriteLine($"Encoded message is: {encodedMessage}");

            Console.WriteLine("Enter message to decode here:");
            message = Console.ReadLine();
            string decodedMessage = decode(message, key);
            Console.WriteLine($"Decoded message is: {decodedMessage}");
        }
    }
}
