using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Password_Encryption_and_Authentication
{
    public class Encrypt
    {
        //Algorithm
        // (P+(P-7))*2)
        //P = position


        public List<int> CrossMix(string password)
        {
            
            char[] pass = password.ToCharArray();
            string[] pass01 = pass.Select(c => c.ToString()).ToArray();
            int[] intPass = { 65,45,1588,326,44526,12,54,-51,115,5,11,98,247,14,30};
            for( int u=0; u< pass.Length; u++)
            {
                intPass[u] = (Translation(pass01[u].ToUpper())+(Translation(pass01[u].ToUpper())-7)*2);
            }

            //return intPass;
            List<int> numbers = new List<int> { 65, 45, 1588, 326, 44526, 12, 54, -51, 115, 5, 11, 98, 247, -14, 30,1253,156,1531,87,96,-4,68,1635,4186,468,351,78454,8561,5,64,8964,98,
                -615,63,685,4896,1865,468,-7486,153,487,4865,5474,8,46,158,-47,84,96,1,544,86,413,9,76, -4, 68, 1635, 4186, 468, 351, 78454, 8561, 5, 64, 8964, 98, -615, 63, 685, 4896, 1865, 468, 
                -7486, 153, 487, 4865, 5474, 8, 46, 158, -47, 84, 96, 1, 544, 86, 413, 9, 76 };
            int i = 0;
            foreach (int number in intPass)
            {
                numbers.Insert(numbers.Count -i,number);
                i += 3;
                i++;
            }
            
            return numbers;
           
        }
        public int Translation(string letter)
        {

            if (letter == "A") return 1;
            else if (letter == "B") return 2;
            else if (letter == "C") return 3;
            else if (letter == "D") return 4;
            else if (letter == "E") return 5;
            else if (letter == "F") return 6;
            else if (letter == "G") return 7;
            else if (letter == "H") return 8;
            else if (letter == "I") return 9;
            else if (letter == "J") return 10;
            else if (letter == "K") return 11;
            else if (letter == "L") return 12;
            else if (letter == "M") return 13;
            else if (letter == "N") return 14;
            else if (letter == "O") return 15;
            else if (letter == "P") return 16;
            else if (letter == "Q") return 17;
            else if (letter == "R") return 18;
            else if (letter == "S") return 19;
            else if (letter == "T") return 20;
            else if (letter == "U") return 21;
            else if (letter == "V") return 22;
            else if (letter == "W") return 23;
            else if (letter == "X") return 24;
            else if (letter == "Y") return 25;
            else if (letter == "Z") return 26;
            else if (letter == "1") return 1;
            else if (letter == "2") return 2;
            else if (letter == "3") return 3;
            else if (letter == "4") return 4;
            else if (letter == "5") return 5;
            else if (letter == "6") return 6;
            else if (letter == "7") return 7;
            else if (letter == "8") return 8;
            else if (letter == "9") return 9;
            else if (letter == "0") return 10;
            else if (letter == "!") return 11;
            else if (letter == "@") return 12;
            else if (letter == "#") return 13;
            else if (letter == "$") return 14;
            else if (letter == "%") return 15;
            else if (letter == "&") return 16;
            else if (letter == "*") return 17;
            else if (letter == "?") return 18;
            else return 0;
        }
    }
}
