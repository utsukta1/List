using ArrayL;
using System.Collections.Generic;

internal class Program
{
    public static void Main(string[] args)
    {
        List<Salesmen> salesmens = new List<Salesmen>();
        salesmens.Add(new Salesmen("Jones", "Boston", 34));
        salesmens.Add(new Salesmen("Kivell", "NewYork", 23));
        salesmens.Add(new Salesmen("Jardin", "London", 54));
        salesmens.Add(new Salesmen("Gill", "London", 23));
        salesmens.Add(new Salesmen("Sorvino", "NewYork", 41));
        salesmens.Add(new Salesmen("Andrews", "Boston", 27));
        salesmens.Add(new Salesmen("Thompson", "London", 32));
        salesmens.Add(new Salesmen("Howard", "NewYork", 22));
        salesmens.Add(new Salesmen("Parent", "Boston", 31));
        salesmens.Add(new Salesmen("Smith", "London", 40));


        //foreach (Salesmen s in salesmens)
        //{

        //    Console.WriteLine("Name: " + s.Name);
        //    Console.WriteLine("City: " + s.City);
        //    Console.WriteLine("Age: " + s.Age);


        // }

        //foreach (Salesmen s in salesmens)
        //{
        //    if(s.City == "London")
        //    {
        //        Console.WriteLine("Name: " + s.Name);
        //        Console.WriteLine("City: " + s.City);
        //        Console.WriteLine("Age: " + s.Age);

        //    }


        //}


        //int c = 0;
        //foreach (Salesmen s in salesmens)
        //{

        //    if (s.City == "London")
        //    {
        //        c++;
        //    }
        //    else
        //    {
        //        continue;
        //    }

        //}
        //Console.WriteLine("The number of salesmen living in london are: " + c);


        //Console.WriteLine("The salesmen living in London are: ");
        //foreach (Salesmen s in salesmens)
        //{

        //    if(s.City == "London")
        //    {
        //        Console.WriteLine( s.Name);
        //    }
        //}


        double avg;
        int c = 0; double temp = 0;
        foreach (Salesmen s in salesmens)
        {

            if (s.City == "London")
            {
                c++;
                temp = temp + s.Age;

            }
            else
            {
                continue;
            }


        }
        avg = temp / c;
        Console.WriteLine("The average age of salesmen living in London is: " + avg);








        Console.ReadLine();
    }
}