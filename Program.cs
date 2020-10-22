using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace home_work_regex
{
    class Program
    {
        static void Main(string[] args)
        {

            //--------1-----------

            //string file1 = @"C:\Users\Kolotyuk\source\repos\home_work_regex\home_work_regex\file3.txt";
            //string file2 = @"C:\Users\Kolotyuk\source\repos\home_work_regex\home_work_regex\file4.txt";

            //using (StreamReader fout = new StreamReader(file1))
            //{
            //    while (!fout.EndOfStream)
            //    {
            //        string str = fout.ReadLine();
            //        Regex regex = new Regex(@"\w+[^ ]");
            //        MatchCollection matches = regex.Matches(str);

            //        string[] str2 = new string[matches.Count];
            //        if (matches.Count > 0)
            //        {
            //            int i = 0;
            //            foreach (Match match in matches)
            //            {
            //                str2[i] = match.Value;
            //                i++;
            //            }
            //            using (StreamWriter sw = new StreamWriter(file2, true))
            //            {
            //                for (int j = 0; j < str2.Length; j++)
            //                {
            //                    char[] chararr = new char[str2[j].Length];

            //                    for (int l = 0; l < str2[j].Length; l++)
            //                    {
            //                        chararr[l] = str2[j][l];
            //                    }
            //                    if (chararr[0] >= 97 && chararr[0] <= 122)
            //                    {
            //                        int a = chararr[0];
            //                        chararr[0] = (char)(a - 32);
            //                    }
            //                    string s = "";
            //                    for (int k = 0; k < chararr.Length; k++)
            //                    {
            //                        s += chararr[k];
            //                    }
            //                    str2[j] = s;
            //                    str2[j] += '.';
            //                    sw.WriteLine(str2[j]);
            //                }
            //            }
            //        }
            //    }
            //}


            //--------2-----------

            //string file2 = @"C:\Users\Kolotyuk\source\repos\home_work_regex\home_work_regex\file2.txt";
            //string data = null;
            //Regex regex = new Regex(@"\d+(\.|,)\d+");
            //using (StreamReader fout = new StreamReader(file2))
            //{
            //    while (!fout.EndOfStream)
            //    {
            //        data = fout.ReadLine();                 
            //        while (!fout.EndOfStream)
            //        {
            //            data = fout.ReadLine();
            //            MatchCollection matches = regex.Matches(data);

            //            foreach (Match item in matches)
            //            {
            //                Console.WriteLine(item.Value);
            //            }

            //        }

            //    }
            //}

            //--------3-----------

            //string file1 = @"C:\Users\Kolotyuk\source\repos\home_work_regex\home_work_regex\file6.txt";
            //string file2 = @"C:\Users\Kolotyuk\source\repos\home_work_regex\home_work_regex\file7.txt";
            //using (StreamReader fout = new StreamReader(file1))
            //{
            //    while (!fout.EndOfStream)
            //    {
            //        string str = fout.ReadLine();
            //        Regex regex = new Regex(@"(?i)(xyesos|syka|pidar|chlen|xyi|lox)");

            //        MatchCollection matches = regex.Matches(str);               
            //        string[] str2 = str.Split(new char[] { ' ', '\n', }, StringSplitOptions.RemoveEmptyEntries);
            //        foreach (Match match in matches)
            //        {
            //            for (int i = 0; i < str2.Length; i++)
            //            {
            //                if (str2[i] == match.Value)
            //                {
            //                    str2[i] = "*";
            //                }
            //            }
            //        }
            //        String strnew = String.Join(" ", str2);
            //        using (StreamWriter fin = new StreamWriter(file2, true))
            //        {
            //            fin.WriteLine(strnew);
            //        }
            //    }
            //}

            //--------4-----------


            //string file2 = @"C:\Users\Kolotyuk\source\repos\home_work_regex\home_work_regex\file2.txt";
            //string data = null;
            //List<int> numbers = new List<int>();
            //Regex regex = new Regex(@"\d+");
            //using (StreamReader fout = new StreamReader(file2))
            //{
            //    while (!fout.EndOfStream)
            //    {
            //        data = fout.ReadLine();
            //        MatchCollection matches = regex.Matches(data);

            //        foreach (Match item in matches)
            //        {
            //            Console.WriteLine(item.Value);
            //        }

            //    }
            //}


            //------5----------

            //Console.WriteLine(" enter mail for new registration");
            //Console.Write("->");
            //string Email = Console.ReadLine();
            //Regex regex = new Regex(@"^([a-z]|[A-Z]|\.|_|-|\d){4,}@([a-z]|[A-Z]|\d){1,}\.([a-z]|[A-Z]|\d){1,}");
            //MatchCollection matches = regex.Matches(Email);
            //if (matches.Count > 0)
            //{
            //    Console.WriteLine("ok");
            //}

            //Console.WriteLine(" enter Password for new registration");
            //Console.Write("->");
            //string Password = Console.ReadLine();

            //regex = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*(_|-))(?=.*[a-zA-Z]).{6,}$");
            //matches = regex.Matches(Password);
            //if (matches.Count > 0)
            //{
            //    Console.WriteLine("ok");
            //}


            //--------6-----------

            //string file2 = @"C:\Users\Kolotyuk\source\repos\home_work_regex\home_work_regex\file5.txt";
            //string data = null;
            //List<int> numbers = new List<int>();
            //Regex regex = new Regex(@"(\d{4}[\/]\d{2}[\/]\d{2} \d{2}[:]\d{2}[(][:]\d{2}[)]|\d{4}[\/]\d{2}[\/]\d{2} \d{2}[:]\d{2})");
            //using (StreamReader fout = new StreamReader(file2))
            //{
            //    while (!fout.EndOfStream)
            //    {
            //        data = fout.ReadLine();
            //        MatchCollection matches = regex.Matches(data);

            //        foreach (Match item in matches)
            //        {
            //            Console.WriteLine(item.Value);
            //        }

            //    }
            //}

            //------7----------

            //string file1 = @"C:\Users\Kolotyuk\source\repos\home_work_regex\home_work_regex\file8.txt";
            //string file2 = @"C:\Users\Kolotyuk\source\repos\home_work_regex\home_work_regex\file9.txt";
            //using (StreamReader sr = new StreamReader(file1))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        string str = sr.ReadLine();
            //        Regex regex = new Regex(@"\d{9}");
            //        MatchCollection matches = regex.Matches(str);

            //        string[] str2 = str.Split(new char[] { ' ', '\n', }, StringSplitOptions.RemoveEmptyEntries);
            //        foreach (Match match in matches)
            //        {
            //            for (int i = 0; i < str2.Length; i++)
            //            {
            //                if (str2[i] == match.Value)
            //                {
            //                    char[] chararr = new char[17];
            //                    chararr[0] = '+';
            //                    chararr[1] = '3';
            //                    chararr[2] = '8';
            //                    chararr[3] = '(';
            //                    chararr[4] = '0';
            //                    chararr[5] = str2[i][0];
            //                    chararr[6] = str2[i][1];
            //                    chararr[7] = ')';
            //                    chararr[8] = str2[i][2];
            //                    chararr[9] = str2[i][3];
            //                    chararr[10] = str2[i][4];
            //                    chararr[11] = '_';
            //                    chararr[12] = str2[i][5];
            //                    chararr[13] = str2[i][6];
            //                    chararr[14] = '_';
            //                    chararr[15] = str2[i][7];
            //                    chararr[16] = str2[i][8];
            //                    string newstr = null;
            //                    for (int k = 0; k < chararr.Length; k++)
            //                    {
            //                        newstr += chararr[k];
            //                    }
            //                    str2[i] = newstr;
            //                }
            //            }

            //        }

            //        String strnew = String.Join(" ", str2);
            //        using (StreamWriter sw = new StreamWriter(file2, true))
            //        {
            //            sw.WriteLine(strnew);
            //        }
            //    }
            //}


        }
    }
}
