// Déclaration de la classe Revue, héritant de Document
public class Revue : Document
{
    // Attributs privés de la classe Revue
    private string nomDeLaRevue;
    private string issn;

    // Propriétés publiques avec accesseurs et mutateurs pour accéder aux attributs privés
    public string NomDeLaRevue
    {
        get { return nomDeLaRevue; }
        set { nomDeLaRevue = value; }
    }

    public string ISSN
    {
        get { return issn; }
        set { issn = value; }
    }

    // Constructeur par défaut de la classe Revue
    public Revue() : base()
    {
        nomDeLaRevue = "";
        ISSN = "";
    }

    // Constructeur surchargé de la classe Revue
    public Revue(string titre, string auteur, int annee, string nomDeLaRevue, string issn) : base(titre, auteur, annee)
    {
        this.nomDeLaRevue = nomDeLaRevue;
        this.issn = issn;
    }
    
    // Implémentation de la méthode Afficher de Document
    public override void Afficher()
    {
        Console.WriteLine("Revue: {0}, publiée par {1} en {2}, revue {3}, avec ISSN {4}", Titre, Auteur, Annee, NomDeLaRevue, ISSN);
    }
}