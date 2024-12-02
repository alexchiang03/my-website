public class HuurAanvraag
{
    public int HuurAanvraagId { get; set; }
    public DateTime StartDatum { get; set; }
    public DateTime EindDatum { get; set; }
    public string Status { get; set; } // 'In behandeling', 'Goedgekeurd', 'Afgewezen'

    // Relatie: Elke aanvraag is van een huurder
    public int HuurderId { get; set; }
    public Huurder Huurder { get; set; }

    // Relatie: Elke aanvraag is voor één voertuig
    public int VoertuigId { get; set; }
    public Voertuig Voertuig { get; set; }
}
