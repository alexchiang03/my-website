public class Voertuig
{
    public int VoertuigId { get; set; }
    public string Type { get; set; } // 'Auto', 'Caravan', 'Camper'
    public string Merk { get; set; }
    public string Model { get; set; }
    public string Kenteken { get; set; }
    public string Kleur { get; set; }
    public string Status { get; set; } // 'Beschikbaar', 'Verhuurd', 'In reparatie'

    // Relatie: Een voertuig kan meerdere schades hebben
    public ICollection<Schade> Schades { get; set; }
}
