public class Klant {
    public int KlantId {get; set;}
    public string Naam {get; set;}
    public string Adres {get; set;}
    public string Email {get; set;}
    public string Telefoonnummer {get; set;}

    public ICollection<Abonnement> Abonnementen {get; set;} //Relatie: klant kan meerdere abonnementen hebben
}