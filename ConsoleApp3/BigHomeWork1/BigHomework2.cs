using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class BigHomework2
    {
        static void Main()
        {
            for (int number = 100000; number <= 999999; number++)
            {
                var array = ConvertToArray(number);
                var arrayDoubled = ConvertToArray(number * 2);
                var arrayTripled = ConvertToArray(number * 3);
                var arrayQuadrupled = ConvertToArray(number * 4);
                var arrayQuintupled = ConvertToArray(number * 5);
                var arraySextupled = ConvertToArray(number * 6);

                if (TestArrayValues(array) == true && CompareArrays(array, arrayDoubled) == true)
                {
                    if (TestArrayValues(arrayDoubled) == true && CompareArrays(arrayDoubled, arrayTripled) == true)
                    {
                        if (TestArrayValues(arrayTripled) == true && CompareArrays(arrayTripled, arrayQuadrupled) == true)
                        {
                            if (TestArrayValues(arrayQuadrupled) == true && CompareArrays(arrayQuadrupled, arrayQuintupled) == true)
                            {
                                if (TestArrayValues(arrayQuintupled) == true && CompareArrays(arrayQuintupled, arraySextupled) == true)
                                {
                                    if (TestArrayValues(arraySextupled) == true)
                                    {
                                        Console.WriteLine(number);

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        static int[] ConvertToArray(int magicN1)
        {
            int[] magicArray1 = new int[6];

            for (int i = 0; i < magicArray1.Length; i++)
            {
                magicArray1[i] = magicN1 % 10;
                magicN1 /= 10;
            }
            return magicArray1;
        }

        static bool TestArrayValues(int[] magicA1)
        {
            int temp;

            for (int k = 0; k < magicA1.Length - 1; k++)
            {
                temp = magicA1[k];

                for (int l = k + 1; l < 6; l++)
                {
                    if (temp == magicA1[l])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static bool CompareArrays(int[] magicA1, int[] magicA2)
        {
            foreach (var element1 in magicA1)
            {
                var match = false;

                foreach (var element2 in magicA2)
                {
                    if (element1 == element2)
                    {
                        match = true;
                    } 
                }
                if (!match)
                {
                    return false;
                }
            }
            return true;
        }
    }
}