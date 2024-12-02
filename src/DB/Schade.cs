public class Schade
{
    public int SchadeId { get; set; }
    public string Beschrijving { get; set; }
    public DateTime Datum { get; set; }
    public string Status { get; set; } // 'In behandeling', 'Afgehandeld'

    // Relatie: Elke schade hoort bij één voertuig
    public int VoertuigId { get; set; }
    public Voertuig Voertuig { get; set; }
}
