// Classe scellée Audio
sealed class Audio : Document
{
    // Attributs privés de la classe Audio
    private string format;
    private int duree;

    // Propriétés de la classe Audio
    public string Format { get => format; set => format = value; }
    public int Duree { get => duree; set => duree = value; }

    // Constructeur de la classe Audio
    public Audio(string titre, string auteur, int annee, string format, int duree) : base(titre, auteur, annee)
    {
        this.format = format;
        this.duree = duree;
    }

    // Redéfinition de la méthode Afficher pour la classe Audio
    public override void Afficher()
    {
        Console.WriteLine("Audio :");
        Console.WriteLine($"Format : {format}");
        Console.WriteLine($"Durée : {duree} minutes");
    }
}