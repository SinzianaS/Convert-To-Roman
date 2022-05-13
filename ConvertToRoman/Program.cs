using System;

namespace ConvertToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
           int tens, units;
           string romanTens, romanUnits;
           int givenNumber = Convert.ToInt32(Console.ReadLine());
          
                if (givenNumber == 100)
                {
                    Console.WriteLine("C");
                }

                else
                {
                    units = givenNumber % 10;
                    tens = givenNumber - units;
                    romanTens = "";
                    romanUnits = "";
                    switch(units)
                    {
                        case 0:
                            romanUnits = "";
                            break;
                        case 1:
                            romanUnits = "I";
                            break;

                        case 2:
                            romanUnits = "II";
                            break;
                        case 3:
                            romanUnits = "III";
                            break;

                        case 4:
                            romanUnits = "IV";
                            break;
                        case 5:
                            romanUnits = "V";
                            break;

                        case 6:
                            romanUnits = "VI";
                            break;
                        case 7:
                            romanUnits = "VII";
                            break;

                        case 8:
                            romanUnits = "VIII";
                            break;
                        case 9:
                            romanUnits = "IX";
                            break;

                    }
                    switch (tens)
                    {
                        case 0:
                            romanTens = "";
                            break;
                        case 10:
                            romanTens = "X";
                            break;

                        case 20:
                            romanTens = "XX";
                            break;
                        case 30:
                            romanTens = "XXX";
                            break;

                        case 40:
                            romanTens = "XL";
                            break;
                        case 50:
                            romanTens = "L";
                            break;

                        case 60:
                            romanTens = "LX";
                            break;
                        case 70:
                            romanTens = "LXX";
                            break;

                        case 80:
                            romanTens = "LXXX";
                            break;
                        case 90:
                            romanTens = "XC";
                            break;
                    }

                    Console.WriteLine(romanTens + romanUnits);

                }
            }
        }
        
    }


