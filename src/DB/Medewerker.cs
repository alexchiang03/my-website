public class Medewerker
{
    public int MedewerkerId { get; set; }
    public string Naam { get; set; }
    public string Email { get; set; }
    public string Rol { get; set; } // 'Backoffice' of 'Frontoffice'

    // Relatie: Een medewerker hoort bij een abonnement
    public int AbonnementId { get; set; }
    public Abonnement Abonnement { get; set; }

    // Relatie: Medewerker verwerkt meerdere huur aanvragen
    public ICollection<HuurAanvraag> HuurAanvragen { get; set; }
}
