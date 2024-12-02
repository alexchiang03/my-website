public class Huurder
{
    public int HuurderId { get; set; }
    public string Type { get; set; } // 'Particulier' of 'Zakelijk'

    // Relatie: Een huurder kan meerdere aanvragen doen
    public ICollection<HuurAanvraag> HuurAanvragen { get; set; }
}
