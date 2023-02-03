public class Noppapurkki
{
    private Noppa[] nopat;

    public Noppapurkki()
    {
        // Luodaan nopat eli kutsutaan niiden rakentajia
        nopat = new Noppa[5];
        for (int i = 0; i < 5; i++)
        {
            nopat[i]=new Noppa();
        }
    }

    public int[] HeitaNopat()
    {
        // Taulukko nopan heiton tuloksille
        int[] tulos = new int[5];

        //Ensimmäiset kaksi heittoa
        for (int i = 0; i < 2; i++)
        {
            // Heitetään kaikki nopat
            foreach (Noppa noppa in nopat)
            {
                noppa.Heitto();
            }
            // Tulos näkyville
            Console.WriteLine("Nopan heiton tulos:");
            for (int j = 1; j <= 5; j++)
            {
                Console.WriteLine("Noppa " + j + ": " + nopat[j-1].arvo);
            }
            Console.WriteLine("Haluatko lopettaa vuoron tähän? (K/E)");
            if (Console.ReadLine()== "k")
            {
                for(int j = 0; j < 5; j++)
                {
                    tulos[j] = nopat[j].arvo;
                }
                return tulos;
            }
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("Haluatko lukita nopan " + (j+1) + "?");
                if(Console.ReadLine()== "k")
                {
                    nopat[j].lukittu = true;
                }
                else
                {
                    nopat[j].lukittu = false;
                }
            }
            
        }
        // Viimeinen eli kolmas heitto
        foreach (Noppa noppa in nopat)
        {
            noppa.Heitto();
        }
        Console.WriteLine("Nopan heiton tulos:");
        for (int j = 1; j <= 5; j++)
        {
            Console.WriteLine("Noppa " + j + ": " + nopat[j-1].arvo);
        }
        // Tulos talteen
        for(int i = 0; i < 5; i++)
        {
            tulos[i] = nopat[i].arvo;
        }
        return tulos;
        


    }
}