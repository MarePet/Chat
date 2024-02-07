namespace Domen
{
    public class Admin
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
