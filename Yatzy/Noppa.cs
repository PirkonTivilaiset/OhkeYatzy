public class Noppa
{
    public bool lukittu { get; set; }
    public int arvo { get; set; }
    private static readonly Random arvonta = new Random();

    public void Heitto()
    {
        if (!lukittu)
        {
            //Sets arvo to a random integer that is within specified range.
            arvo = arvonta.Next(1, 7);
        }
    }
}