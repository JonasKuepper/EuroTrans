using EuroTrans;
using System;
using System.Net.Http.Headers;

internal class Program
{
    private string input;

    private static void Main(string[] args)
    {
        
        Spender spender = new Spender(1,"Küpper","Jonas",20,184.0,60.0,"A-",DateTime.Now);
        
        Herz h = new Herz(spender,90,"120/80",spender.getAlter(),true, true);
        Herz h2 = new Herz(spender, 155, "80/100", spender.getAlter(), false, false);

        Transporter t = new Transporter(1, "Rolf Müller", "Uniklinik Bonn");
        t.addHerz(h);
        t.addHerz(h2);

        t.printListe();
        Console.WriteLine(spender.getGroeße());
    }

    /*
    private static void Eingabe()
    {
        input = Console.ReadLine();

        switch (input.ToString())
        {
            case "H":
                Console.WriteLine("Yes");
                Eingabe();
                break;

        }
    }
    */
}