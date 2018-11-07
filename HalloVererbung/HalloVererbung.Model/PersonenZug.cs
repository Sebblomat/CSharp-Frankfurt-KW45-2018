namespace HalloVererbung.Model
{
    public class PersonenZug : Schienenfahrzeug
    {
        public int Sitzplaetze { get; set; }
        public int Toiletten { get; set; }
        public bool Klimaanlage { get; set; }
    }
}
