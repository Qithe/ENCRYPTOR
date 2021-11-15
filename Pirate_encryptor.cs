using System;
using System.Collections.Generic;

namespace ENCRYPTOR
{
    class Pirate_encryptor
    {
        private char filler = (char)111;
        public  string Encrypt(string input)
        {
            Char[] arr = MakeArray(input);
            Char[] newArr;
            List<char> workList = new List<char>();


            for (int i = 0; i < arr.Length; i++)
            {
                workList.Add((char)arr.GetValue(i));
                if (!IsVowel((char)arr.GetValue(i)))
                {
                    workList.Add(filler);
                    workList.Add((char)arr.GetValue(i));

                }
            }

            newArr = workList.ToArray();
            return (new string(newArr));
        }

        public  string Decrypt(string input)
        {
            Char[] arr = MakeArray(input);
            Char[] newArr;
            List<char> workList = new List<char>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!IsVowel((char)arr.GetValue(i)))
                {
                    if (i+1!=arr.Length)
                    {
                        if ((char)arr.GetValue(i + 1) == filler && (char)arr.GetValue(i + 2) == (char)arr.GetValue(i))
                        {
                            workList.Add((char)arr.GetValue(i));
                        }
                    }
                    
                }
                else
                {
                    if ((char)arr.GetValue(i) == filler)
                    {
                        if ((char)arr.GetValue(i + 1) != (char)arr.GetValue(i - 1))
                        {
                            workList.Add((char)arr.GetValue(i));
                        }
                    }
                    else
                    {
                        workList.Add((char)arr.GetValue(i));
                    }
                }
            }

            newArr = workList.ToArray();
            return (new string(newArr));
        }

        private Char[] MakeArray(string input)
        {
            return (input.ToCharArray());
        }

        private bool IsVowel(char c)
        {
            return "aeiouAEIOU".IndexOf(c) >= 0;
        }
    }
}