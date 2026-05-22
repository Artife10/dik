namespace Doga2
{
    internal class Program
    {
        class Diak
        {
            public string Nev;
            public int Osztaly;
            public string szak;
            public double attlag;

            public Diak(string name, int osztaly, string szak, double attlag)
            {
                this.Nev = name;
                this.Osztaly = osztaly;
                this.szak = szak;
                this.attlag = attlag;
            }
        }
        static void Main(string[] args)
        {
            List<Diak> diakok = new List<Diak>()
                {
                    new Diak("Anna",11,"Informatika",4.7),
                    new Diak("Béla",12,"Gazdasági",3.8),
                    new Diak("Csaba",11,"Informatika",4.2),
                    new Diak("Dóra",13,"Egészségügy",4.9),
                    new Diak("Emma",12,"Informatika",3.5),
                    new Diak("Ferenc",13,"Gazdasági",4.1),
                    new Diak("Gergő",12,"Informatika",4.8),
                    new Diak("Hanna",11,"Egészségügy",4.4)
                };



            Console.WriteLine();
            Console.WriteLine("2. feladat");

            Console.WriteLine($"Informatika szakos diákok száma: {
                
                diakok.Where(x=> x.szak == "Informatika").Count()
            
                }");



            Console.WriteLine();
            Console.WriteLine("3. feladat");

            var jodeakok = diakok.Where(x => x.attlag > 4);

            jodeakok.ToList().ForEach(x =>
            {
                Console.WriteLine($"Név: {x.Nev}, Szak: {x.szak}, Atlag: {x.attlag}");
            });


            Console.WriteLine();
            Console.WriteLine("4. feladat");

            Diak legjobbdeak = diakok.OrderByDescending(x=> x.attlag).ToArray()[0];

            Console.WriteLine($"Név: {legjobbdeak.Nev}, Szak: {legjobbdeak.szak}, Atlag: {legjobbdeak.attlag}");


            Console.WriteLine();
            Console.WriteLine("5. feladat");

            var groupedszakok = diakok.GroupBy(x => x.szak);

            groupedszakok.OrderBy(x=> x.ToArray()[0].szak).ToList().ForEach(x => { 
                
                double szum = 0;

                x.ToList().ForEach(x => { szum += x.attlag; });

                Console.WriteLine($"{x.ToArray()[0].szak}: {szum / x.ToArray().Count()}");
            
            });

        }
    }
}
