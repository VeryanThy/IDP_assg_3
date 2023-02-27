using System;
namespace IDP_assg_3
{
    class MainClass
    {
        class Element
        {
            public string name, type;
            public int Z;
            public double meltPoint, boilPoint;
            public Element(string A, int B, string C, double D, double E)
            {
                name = A; Z = B; type = C; meltPoint = D; boilPoint = E;
            }

            public void Print()
            {
                Console.WriteLine($"Element: {name} ");
                Console.WriteLine($"    type: {type}");
                Console.WriteLine($"    melting point: {meltPoint}K");
                Console.WriteLine($"    boiling point: {boilPoint}K");
            }
        }
        public static void Main(string[] args)
        {
            Element oxygen = new Element("Oxygen", 8, "Non Metal", 54.36, 90.188);


            Element iron = new Element("Iron", 26, "Metal", 1811, 3243);

            Element gold = new Element("Gold", 79, "Metal", 1337.33, 3243);

            Element[] elements = new Element[6]
            {oxygen, iron, gold,
            new Element("Hydrogen", 1, "Non Metal", 13.99, 20.271),
            new Element("Bromine", 35, "Non Metal", 265.8, 332.0),
            new Element("Mercury", 80, "Metal", 234.3210, 629.88),
            };

            foreach (Element I in elements)
            {
                I.Print();
            }
            foreach (Element I in elements)
            {
                if (I.type == "Metal")
                {
                    Console.WriteLine(I.name);
                }
            }
        }
    }
}



