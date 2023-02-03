// Yatzy peli

//Tervetoa ja montako pelaajaa
Console.WriteLine("Tervetuloa pelaamaan! Montako pelaajaa? (1-6)");

int pelaajaMaara = Convert.ToInt32(Console.ReadLine());
 while (pelaajaMaara > 6 | pelaajaMaara < 1)
 {
    Console.WriteLine("Pelaajia saa olla 1-6. Anna sallittu määrä.");
    pelaajaMaara = Convert.ToInt32(Console.ReadLine());
 }

 Pelaaja[] pelaajat = new Pelaaja[pelaajaMaara];

// Looppi jossa kysytään käyttäjältä pelaajien nimet ja luodaan
// pelaaja oliot
// Käyttäjältä: Anna pelaajan 1 nimi

for (int i = 1; i <= pelaajaMaara; i++)
{
    Console.WriteLine("Anna pelaajan " + i + " nimi");
    string nimi = Console.ReadLine();
    pelaajat[i-1] = new Pelaaja(nimi);
}

/*foreach (Pelaaja item in pelaajat)
{
    Console.WriteLine(item.nimi);
}*/

// Varsinainen peli alkaa alkaa
// Yatzy peli kestää 15 kierrosta
// eli looppi joka käydään 15 kertaa

for (int i = 0; i < 15; i++)
{
    Console.WriteLine("Kierros: " + (i+1));
    
    //Jokaisella kierroksella käydään läpi
    foreach (Pelaaja pelaaja in pelaajat)
    {
        Console.WriteLine("Pelaaja" + pelaaja.nimi);
        pelaaja.KaytaVuoro();
    }
}