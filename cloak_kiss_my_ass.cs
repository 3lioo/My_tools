using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cloak_kiss_my_ass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Directory Path:");
            string dirr = Console.ReadLine();
            string[] fileName = System.IO.Directory.GetFiles(dirr);
            for (int i = 0; i < 54; i++)
            {
                try
                {
                    string b = "FF0003060C1204121212000100C40307";
                    BinaryReader expr_3D = new BinaryReader(new FileStream(fileName[i], FileMode.Open, FileAccess.Read, FileShare.None));
                    expr_3D.BaseStream.Position = 0L;
                    byte[] p = expr_3D.ReadBytes(256);
                    expr_3D.Close();
                    string a = string.Concat(new string[]
			{
				HexStr(p).Substring(2, 2),
				HexStr(p).Substring(34, 2),
				HexStr(p).Substring(66, 2),
				HexStr(p).Substring(98, 2),
				HexStr(p).Substring(130, 2),
				HexStr(p).Substring(162, 2),
				HexStr(p).Substring(194, 2),
				HexStr(p).Substring(226, 2),
				HexStr(p).Substring(258, 2),
				HexStr(p).Substring(290, 2),
				HexStr(p).Substring(322, 2),
				HexStr(p).Substring(354, 2),
				HexStr(p).Substring(386, 2),
				HexStr(p).Substring(418, 2),
				HexStr(p).Substring(450, 2),
				HexStr(p).Substring(482, 2)
			});
                    string str = string.Concat(new string[]
			{
				HexStr(p).Substring(4, 2),
				HexStr(p).Substring(36, 2),
				HexStr(p).Substring(68, 2),
				HexStr(p).Substring(100, 2),
				HexStr(p).Substring(132, 2),
				HexStr(p).Substring(164, 2),
				HexStr(p).Substring(196, 2),
				HexStr(p).Substring(228, 2),
				HexStr(p).Substring(260, 2),
				HexStr(p).Substring(292, 2),
				HexStr(p).Substring(324, 2),
				HexStr(p).Substring(356, 2),
				HexStr(p).Substring(388, 2),
				HexStr(p).Substring(420, 2),
				HexStr(p).Substring(452, 2),
				HexStr(p).Substring(484, 2)
			});
                    if (a == b)
                    {
                        Console.Write("Flag is: " + str);
                    }

                }
                catch (IOException)
                {
                }
            }
                
        }

        public static string HexStr(byte[] p)
        {
            char[] array = new char[p.Length * 2 + 2];
            array[0] = '0';
            array[1] = 'x';
            int i = 0;
            int num = 2;
            while (i < p.Length)
            {
                byte b = (byte)(p[i] >> 4);
                array[num] = (char)((b > 9) ? (b + 55) : (b + 48));
                b = (byte)(p[i] & (15));
                array[++num] = (char)((b > 9) ? (b + 55) : (b + 48));
                i++;
                num++;
            }
            return new string(array);
        }

    }
}
