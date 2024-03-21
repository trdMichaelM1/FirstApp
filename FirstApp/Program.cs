using System;

namespace CSharpEssentials
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = ~a;
            int c = b + 1;
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");

            Console.WriteLine();

            // Conjunction
            byte port = 0b_0000_1111; // 0F Hex = 15 Dec
            Console.WriteLine($"port = {port:X2} = {port}");

            byte mask = 0b_1111_1011; // FB Hex = 251 Dec
            Console.WriteLine($"mask = {mask:X2} = {mask}");

            port = (byte)(port & mask); // 0B Hex = 11 Dec
            Console.WriteLine($"port = {port:X2} = {port}");

            Console.WriteLine();

            //Disjunction
            port = 0b_0000_1011; // 0B Hex = 11 Dec
            Console.WriteLine($"port = {port:X2} = {port}");

            mask = 0b_0000_0100; // 04 Hex = 4 Dec
            Console.WriteLine($"mask = {mask:X2} = {mask}");

            port = (byte)(port | mask); // 0F Hex = 15 Dec
            Console.WriteLine($"port = {port:X2} = {port}");

            Console.WriteLine();

            //ExclusiveOr
            char originalValue = 'A';
            Console.WriteLine($"originalValue = {originalValue}");

            ushort key = 55;
            Console.WriteLine($"key = {key}");

            char encryptedValue = (char)(originalValue ^ key);
            Console.WriteLine($"encryptedValue = {encryptedValue}");

            char decryptedValue = (char)(encryptedValue ^ key);
            Console.WriteLine($"decryptedValue = {decryptedValue}");

            Console.WriteLine();

            //Shift
            port = 0b_0000_1111;

            byte value = (byte)(port << 5);

            value >>= 7;

            Console.WriteLine($"value = {value}");

            Console.WriteLine();

            //NegativeShift
            short value1 = short.MinValue; // -32768 Dec = 80 00 Hex = 10000000 00000000 Bin
            Console.WriteLine($"1. value = {value1,6} Dec = {Convert.ToString(value1, 2)} Bin");

            value1 >>= 14; // 11111111 11111110 Bin
            Console.WriteLine($"2. value = {value1,6} Dec = {Convert.ToString(value1, 2)} Bin");

            // Delay
            Console.ReadKey();
        }

    }
}