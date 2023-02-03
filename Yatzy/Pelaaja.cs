public class Pelaaja
{
    public string nimi {get; set;}

    private Pistetaulukko pisteet;

    public Pelaaja(string nimi)
    {
        this.nimi = nimi;
        this.pisteet = new Pistetaulukko();
    }

    public void KaytaVuoro()
    {
        Noppapurkki noppapurkki = new Noppapurkki();
        int[] tulos = noppapurkki.HeitaNopat();
        pisteet.KirjaaTulos(tulos);
    }
}