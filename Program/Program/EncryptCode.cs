using System;

namespace EncryptCode
{
    public class Program
    {
        private static char[] TextToUnicode(string text)
        {
            string codeString = "";
            char[] arr = text.ToCharArray();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                codeString += string.Format("{0:x4}", (int)arr[i]);
            }
            char[] code = codeString.ToCharArray();
            //Console.WriteLine("Length = {0}\n", code.GetLength(0));
            return code;
        }

        private static void ArrayList(char[,] array)
        {
            int length = array.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine("");
            }
        }

        private static void ArrayList2(char[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }

        private static void ArrayList3(int[] array)
        {
            int length = array.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }

        private static int ArrayLength(char[] codeString)
        {
            int textLength = codeString.GetLength(0);
            double arrayLengthDouble = Math.Sqrt(textLength);
            double arrayLengthDoubleRest = Math.Sqrt(textLength) % 1;
            if (arrayLengthDoubleRest > 0)
            {
                arrayLengthDouble = Math.Sqrt(textLength) + 1;
            }
            int arrayLength = (int)Math.Round(arrayLengthDouble) + 1;
            return arrayLength;
        }

        private static char[,] FillingOfArray(char[,] array, char[] code)
        {
            int textLength = code.Length;
            int arrayLength = array.GetLength(0);
            //Console.WriteLine("textLength = {0} \t arrayLength = {1}", textLength, arrayLength);
            int q = 0;
            for (int i = 1; i < arrayLength; i++)
            {
                if (q == textLength)
                {
                    continue;
                }
                for (int j = 1; j < arrayLength; j++)
                {
                    if (q == textLength)
                    {
                        array[i, j] = '0';
                        continue;
                    }
                    array[i, j] = code[q];
                    q++;
                }
            }

            NameOfLinesColumns(array);
            return array;
        }

        private static char[,] NameOfLinesColumns(char[,] a)
        {
            char letters = (char)65;
            int length = a.GetLength(0);
            int i = 1;
            while (letters < 91 && i < length)
            {
                a[0, i] = letters;
                i++;
                letters++;
            }

            letters = (char)97;
            while (letters < 123 && i < length)
            {
                a[0, i] = letters;
                i++;
                letters++;
            }

            letters = (char)65;
            i = 1;
            while (letters < 91 && i < length && a[i, 1] != 0x0000)
            {
                a[i, 0] = letters;
                i++;
                letters++;
            }

            letters = (char)97;
            while (letters < 123 && i < length && a[i, 1] != 0x0000)
            {
                a[i, 0] = letters;
                i++;
                letters++;

            }
            return a;
        }

        private static char[,] ChangeLines(char[,] array, int n, int m)
        {
            --n;
            --m;
            char t;
            int length = array.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                t = array[m, i];
                array[m, i] = array[n, i];
                array[n, i] = t;
            }
            return array;
        }

        private static char[,] ChangeColumns(char[,] array, int n, int m)
        {
            --n;
            --m;
            char t;
            int length = array.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                t = array[i, m];
                array[i, m] = array[i, n];
                array[i, n] = t;
            }
            return array;
        }

        private static char[,] ChangeColumnsByKey(char[,] mainArray)
        {
            int length = mainArray.GetLength(0);
            char[,] array = new char[length, length];
            int[] keyEnc = KeyForEncrypting(mainArray);
            //arrayList3(keyEnc);
            for (int i = 0, k = 1; i < keyEnc.GetLength(0); i++, k++)
            {
                for (int j = 0; j < length; j++)
                {
                    array[j, k] = mainArray[j, keyEnc[i]];
                }
            }
            for (int i = 0; i < length; i++)
            {
                array[i, 0] = mainArray[i, 0];
            }
            return array;
        }

        private static char[,] ChangeLinesByKey(char[,] mainArray)
        {
            int length = mainArray.GetLength(0);
            char[,] array = new char[length, length];
            int[] keyEnc = KeyForEncrypting(mainArray);
            //arrayList3(keyEnc);
            for (int i = 0, k = 1; i < keyEnc.GetLength(0); i++, k++)
            {
                for (int j = 0; j < length; j++)
                {
                    array[k, j] = mainArray[keyEnc[i], j];
                }
            }
            for (int i = 0; i < length; i++)
            {
                array[0, i] = mainArray[0, i];
            }
            return array;
        }

        private static int Random(int min, int max)
        {
            int diff = max - min;
            Random random = new Random();
            int i = random.Next(diff + 1);
            i += min;
            return i;
        }

        private static int[] KeyForEncrypting(char[,] mainArray)
        {
            int length = mainArray.GetLength(0) - 1;
            //Console.WriteLine("Length in method = {0}", length);
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                int r = Random(1, length);
                int k = 0;
                while (k < i)
                {
                    if (array[i] == 0)
                    {
                        if (array[k] != r)
                        {
                            k++;
                            continue;
                        }
                        r = Random(1, length);
                        k = 0;
                    }
                }
                array[i] = r;
            }
            //Console.WriteLine("Length in method = {0}", array.GetLength(0));
            //Console.Beep(500, 100);
            return array;
        }

        public static String Code(char[,] array)
        {
            String code = "";
            for(int i = 1; i < array.GetLength(0); i++)
            {
                for(int j = 1; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == '\0') break;
                    code += String.Format("{0}", array[i, j]);
                }
            }

            return code;
        }

        public static string Key(char[,] array)
        {
            String key = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, 0] == '\0') continue;
                key += String.Format("{0}", array[i, 0]);
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[0, i] == '\0') continue;
                key += String.Format("{0}", array[0, i]);
            }
            return key;
        }

        public static char[,] CodeInArray(String text)
        {
            char[] code = TextToUnicode(text);
            char[,] myArray = new char[ArrayLength(code), ArrayLength(code)];
            FillingOfArray(myArray, code);
            myArray = ChangeColumnsByKey(myArray);
            myArray = ChangeLinesByKey(myArray);
            //string txt = key(myArray);
            //string codeTxt = ArrayToString(myArray);
            return myArray;
            
        }
    }
}
