public class Abonnement
{
    public int AbonnementId { get; set; }
    public string Type { get; set; } // 'Pay-as-you-go' of 'Prepaid'
    public DateTime StartDatum { get; set; }
    public DateTime EindDatum { get; set; }

    // Relatie: Een abonnement hoort bij één klant
    public int KlantId { get; set; }
    public Klant Klant { get; set; }

    // Relatie: Een abonnement heeft meerdere medewerkers
    public ICollection<Medewerker> Medewerkers { get; set; }
}
