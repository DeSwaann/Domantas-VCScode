using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class BigHomework
    {
        static void Main(string[] args)
        {
            bool ifNegative = false;
            bool ifNumber;
            var verbalForm = "";
            var min = -100;
            var max = 100;
            Console.Write($"Įveskite skaičių nuo {min} iki {max}: ");
            string stringValue = Convert.ToString(Console.ReadLine());

            if (int.TryParse(stringValue, out var parsedNumber))
            {
                ifNumber = true;
                Console.WriteLine($"Įvestas skaičius numatytuose rėžiuose: {ifNumber}");
            }

            if (parsedNumber < 0)
            {
                ifNegative = true;

                stringValue = stringValue.Substring(1, stringValue.Length - 1); // https://docs.microsoft.com/en-us/dotnet/api/system.string.substring?view=net-5.0

            }

            if (parsedNumber > min && parsedNumber < max)
            {
                verbalForm = TransfromIntoWords(stringValue);
            }

            else
            {
                Console.WriteLine("Skaičius nėra numatytuose rėžiuose");
            }
             
            
            if (ifNegative)
            {

                verbalForm = verbalForm.Insert(0, "Minus ");

            }

            Console.WriteLine(verbalForm);
        }

        static string TransfromIntoWords( string stringValue)
        {
            string firstNumber = "";
            string secondNumber = "";

                    if (stringValue.Length == 1)
                    {
                        switch (stringValue[0])
                        {
                            case '0':
                                secondNumber = "Nulis";
                                break;
                            case '1':
                                secondNumber = "Vienas";
                                break;
                            case '2':
                                secondNumber = "Du";
                                break;
                            case '3':
                                secondNumber = "Trys";
                                break;
                            case '4':
                                secondNumber = "Keturi";
                                break;
                            case '5':
                                secondNumber = "Penki";
                                break;
                            case '6':
                                secondNumber = "Šeši";
                                break;
                            case '7':
                                secondNumber = "Septyni";
                                break;
                            case '8':
                                secondNumber = "Aštuoni";
                                break;
                            case '9':
                                secondNumber = "Devyni";
                                break;
                        }
                    }
                    else if (stringValue.Length == 2)
                    {
                        if (stringValue[0] == '1')
                        {
                            switch (stringValue[1])
                            {
                                case '0':
                                    secondNumber = "Dešimt";
                                    break;
                                case '1':
                                    secondNumber = "Vienuolika";
                                    break;
                                case '2':
                                    secondNumber = "Dvylika";
                                    break;
                                case '3':
                                    secondNumber = "Trylika";
                                    break;
                                case '4':
                                    secondNumber = "Keturiolika";
                                    break;
                                case '5':
                                    secondNumber = "Penkiolika"; ;
                                    break;
                                case '6':
                                    secondNumber = "Šešiolika";
                                    break;
                                case '7':
                                    secondNumber = "Septyniolika";
                                    break;
                                case '8':
                                    secondNumber = "Aštuoniolika";
                                    break;
                                case '9':
                                    secondNumber = "Devyniolika";
                                    break;
                            }
                        }
                        else
                        {
                            switch (stringValue[0])
                            {
                                case '2':
                                    firstNumber = "Dvidešimt";
                                    break;
                                case '3':
                                    firstNumber = "Trisdešimt";
                                    break;
                                case '4':
                                    firstNumber = "Keturiasdešimt";
                                    break;
                                case '5':
                                    firstNumber = "Penkiasdešimt";
                                    break;
                                case '6':
                                    firstNumber = "Šešiasdešimt";
                                    break;
                                case '7':
                                    firstNumber = "Septyniasdešimt";
                                    break;
                                case '8':
                                    firstNumber = "Aštuoniasdešimt";
                                    break;
                                case '9':
                                    firstNumber = "Devyniasdešimt";
                                    break;

                            }
                            switch (stringValue[1])
                            {
                                case '1':
                                    secondNumber = " vienas";
                                    break;
                                case '2':
                                    secondNumber = " du";
                                    break;
                                case '3':
                                    secondNumber = " trys";
                                    break;
                                case '4':
                                    secondNumber = " keturi";
                                    break;
                                case '5':
                                    secondNumber = " penki";
                                    break;
                                case '6':
                                    secondNumber = " šeši";
                                    break;
                                case '7':
                                    secondNumber = " septyni";
                                    break;
                                case '8':
                                    secondNumber = " aštuoni";
                                    break;
                                case '9':
                                    secondNumber = " devyni";
                                    break;
                            }
                        }

                    }
                    /* else if (stringValue.Length == 3)
                     {

                     } */

                var answer = firstNumber + secondNumber;
                return answer;

        }


    }
}
