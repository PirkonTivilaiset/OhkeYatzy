public class Noppa
{
    public bool lukittu{get; set;}
    public int arvo{get; set;}

    public Noppa()
    {
        lukittu = false;
    }

    public void Heitto()
    {
        if(lukittu)
        {
            //ei tarvii tehdä mitään
            return;
        }
        Random arvonta = new Random();
        //Returns a random integer that is within a specified range.
        arvo = arvonta.Next(1,7);
    }
}