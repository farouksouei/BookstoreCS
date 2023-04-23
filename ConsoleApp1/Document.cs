// Déclaration de la classe abstraite Document
public abstract class Document
{
    // Attributs privés
    public string titre;
    public string auteur;
    public int annee;

    // Constructeur par défaut de la classe Document
    protected Document()
    {
        titre = "";
        auteur = "";
        annee = 0;
    }

    // Constructeur surchargé de la classe Document
    protected Document(string titre, string auteur, int annee)
    {
        this.titre = titre;
        this.auteur = auteur;
        this.annee = annee;
    }
    // Propriétés publiques avec accesseurs et mutateurs pour accéder aux attributs privés
    public string Titre
    {
        get { return titre; }
        set { titre = value; }
    }

    public string Auteur
    {
        get { return auteur; }
        set { auteur = value; }
    }

    public int Annee
    {
        get { return annee; }
        set { annee = value; }
    }
    

    // Méthode abstraite qui sera implémentée dans les classes dérivées
    public abstract void Afficher();
}