public class Noppa
{
    public bool lukittu { get; set; }
    public int arvo { get; set; }
    private readonly Random arvonta = new Random();

    public void Heitto()
    {
        if (!lukittu)
        {
            arvo = arvonta.Next(1, 7);
        }
    }
}