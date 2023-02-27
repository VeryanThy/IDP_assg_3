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
        }
        public static void Main(string[] args)
        {
            Element oxygen = new Element()
            {
                name = "Oxygen",
                Z = 8,
                type = "Non Metal",
                meltPoint = 54.36,
                boilPoint = 90.188,
            };

            Element iron = new Element()
            {
                name = "Iron",
                Z = 26,
                type = "Metal",
                meltPoint = 1811,
                boilPoint = 3243,
            };

            Element gold = new Element()
            {
                name = "Gold",
                Z = 79,
                type = "Metal",
                meltPoint = 1337.33,
                boilPoint = 3243,
            };

        }
    }
}



