public class Pistetaulukko
{
    public Dictionary<string, int> tulokset;

    public Pistetaulukko()
    {
        tulokset = new Dictionary<string, int>();
    }

    public void KirjaaTulos(int[] arvot)
    {
        Console.WriteLine("Mihin tulos kirjataan?");
        Console.WriteLine("Ykköset, Kakkoset, Kolmoset, Neloset, Viitoset, Kuutoset");
        Console.WriteLine("Yksi pari, Kolmoisluku, Neloisluku, Pieni suora, Suuri suora, Täyskäsi, Sattuma, Yatzy)");
        Console.WriteLine("Olet jo käyttänyt: ");

        foreach (var item in tulokset)
        {
            Console.WriteLine(item);
        }

        string vastaus = Console.ReadLine();

        switch (vastaus)
        {
            case "Ykköset":
            int pisteet = 0;
            foreach (int item in arvot)
            {
                if(item == 1)
                {
                    pisteet = pisteet + item;
                }
            }
            tulokset.Add("Ykköset", pisteet);

            break;

            case "Kakkoset":
            pisteet = 0;
            foreach (int item in arvot)
            {
                if(item == 2)
                {
                    pisteet = pisteet + item;
                }
            }
            tulokset.Add("Kakkoset", pisteet);
            break;
            
            default:
            break;
        }
    }

    public int LaskePisteet()
    {
        int loppupisteet = 0;
        foreach (KeyValuePair<string, int> yhdistelma in tulokset)
        {
            loppupisteet = loppupisteet + yhdistelma.Value;
        }
        return loppupisteet;
    }
}