namespace ExoBataille
{
    public class arme
    {
        private string nomArme;
        private int cout;

        // get et set nomArme
        public string getNomArme()
        {
            return nomArme;
        }
        public void setNomArme(string uneArme)
        {
            if (uneArme != "")
            {
                nomArme = uneArme;
            }
        }


        // get et set cout
        public int getCout()
        {
            return cout;
        }
        public void setCout(int unCout)
        {
            if (unCout > 0)
            {
                cout = unCout;
            }
        }
    }
}