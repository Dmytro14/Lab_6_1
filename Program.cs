using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_6_1
{
    public class Program
    {
        interface Meteo
        {
            void Pressure(List<MeteData> Days, int s, int sr);
        }
        //Класс
        public class MeteData : Meteo
        {
            public string Data { get; set; }
            public float Tempreture { get; set; }
            public int AtmospherePressure { get; set; }
            public MeteData(string Data, float Temp, int Atmosphere)
            {
                this.Data = Data;
                Tempreture = Temp;
                AtmospherePressure = Atmosphere;
            }
            public MeteData()
            {
                this.Data = "";
                Tempreture = 0;
                AtmospherePressure = 0;
            }
            public void Pressure(List<MeteData> Days, int s, int sr)
            {
                
                Console.WriteLine("\nДнi, з тиском вище середнього: ");
                for (int i = 0; i < Days.Count; i++)
                {

                    s += Days[i].AtmospherePressure;
                    sr = s / Days.Count;
                    Console.WriteLine("\nДнi, з тиском вище середнього: ");
                    for (int k = 0; k < Days.Count; k++)
                    {
                        if (Days[k].AtmospherePressure > sr)
                            Console.WriteLine(Days[k].AtmospherePressure.ToString() + " | " + Days[k].Data);
                    }
                }
            }
        }

        //Программа
        static void Main()
        {
            Console.Clear();
            MeteData Day1 = new MeteData("01.05.2020", 16, 737);
            MeteData Day2 = new MeteData("02.05.2020", 19, 730);
            MeteData Day3 = new MeteData("03.05.2020", 16, 748);
            MeteData Day4 = new MeteData("04.05.2020", 17, 747);
            MeteData Day5 = new MeteData("05.05.2020", 14, 735);
            MeteData Day6 = new MeteData("06.05.2020", 10, 737);
            MeteData Day7 = new MeteData("07.05.2020", 11, 730);
            MeteData Day8 = new MeteData("08.05.2020", 14, 707);
            MeteData Day9 = new MeteData("09.05.2020", 15, 732);
            MeteData Day10 = new MeteData("10.05.2020", 20, 750);
            MeteData Day11 = new MeteData("11.05.2020", 16, 737);
            MeteData Day12 = new MeteData("12.05.2020", 19, 729);
            MeteData Day13 = new MeteData("13.05.2020", 16, 748);
            MeteData Day14 = new MeteData("14.05.2020", 17, 777);
            MeteData Day15 = new MeteData("15.05.2020", 14, 741);
            MeteData Day16 = new MeteData("16.05.2020", 10, 737);
            MeteData Day17 = new MeteData("17.05.2020", 09, 730);
            MeteData Day18 = new MeteData("18.05.2020", 08, 717);
            MeteData Day19 = new MeteData("19.05.2020", 05, 732);
            MeteData Day20 = new MeteData("20.05.2020", 10, 752);
            MeteData Day21 = new MeteData("21.05.2020", 13, 737);
            MeteData Day22 = new MeteData("22.05.2020", 17, 720);
            MeteData Day23 = new MeteData("23.05.2020", 18, 748);
            MeteData Day24 = new MeteData("24.05.2020", 17, 749);
            MeteData Day25 = new MeteData("25.05.2020", 14, 740);
            MeteData Day26 = new MeteData("26.05.2020", 14, 734);
            MeteData Day27 = new MeteData("27.05.2020", 13, 730);
            MeteData Day28 = new MeteData("28.05.2020", 16, 707);
            MeteData Day29 = new MeteData("29.05.2020", 15, 738);
            MeteData Day30 = new MeteData("30.05.2020", 19, 754);
            MeteData Day31 = new MeteData("31.05.2020", 20, 750);
            List<MeteData> Days = new List<MeteData>();
            Days.Add(Day1); Days.Add(Day2); Days.Add(Day3); Days.Add(Day4); Days.Add(Day5);
            Days.Add(Day6); Days.Add(Day7); Days.Add(Day8); Days.Add(Day9); Days.Add(Day10);
            Days.Add(Day11); Days.Add(Day12); Days.Add(Day13); Days.Add(Day14); Days.Add(Day15);
            Days.Add(Day16); Days.Add(Day17); Days.Add(Day18); Days.Add(Day19); Days.Add(Day20);
            Days.Add(Day21); Days.Add(Day22); Days.Add(Day23); Days.Add(Day24); Days.Add(Day25);
            Days.Add(Day26); Days.Add(Day27); Days.Add(Day28); Days.Add(Day29); Days.Add(Day30);
            Days.Add(Day31);
            int s = 0, sr = 0;
            Days[0].Pressure(Days, s, sr);
            Console.WriteLine("Дата      |Температура  | Атмосферний тиск");
            for (int i = 0; i < Days.Count; i++)
            {
                Console.WriteLine(Days[i].Data + "|\t" + Days[i].Tempreture + "\t|" + Days[i].AtmospherePressure);
            }
            
        }

    }
}
