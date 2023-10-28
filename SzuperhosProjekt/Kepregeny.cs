using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public static class Kepregeny
    {
        public static List<ISzuperhos> szuperhosok = new List<ISzuperhos>();

        public static void Szereplok(string file)
        {
            using (StreamReader fileReader = new StreamReader(file))
            {
                while (!fileReader.EndOfStream)
                {
                    string[] sor = fileReader.ReadLine()!.Split(' ');
                    if (sor[0] == "Vasember")
                    {
                        Vasember vasember = new Vasember();

                        for (int i = 0; i < int.Parse(sor[1]); i++)
                        {
                            vasember.KutyutKeszit();
                        }

                        szuperhosok.Add(vasember);
                    }
                    else if (sor[0] == "Batman")
                    {
                        Batman batman = new Batman();

                        for (int i = 0; i < int.Parse(sor[1]); i++)
                        {
                            batman.KutyutKeszit();
                        }

                        szuperhosok.Add(batman);
                    }
                }

                fileReader.Close();
            }
        }

        public static void Szuperhosok()
        {
            foreach (var item in szuperhosok)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}