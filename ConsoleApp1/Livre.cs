// Déclaration de la classe Livre, héritant de Document
public class Livre : Document
{
    // Attribut privé
    private string isbn;
    private string editeur;
    private int nbPages;
    
    // Constructeur
    public Livre(string titre, string auteur, int annee, string isbn, string editeur, int nbPages) : base(titre, auteur, annee)
    {
        this.isbn = isbn;
        this.editeur = editeur;
        this.nbPages = nbPages;
    }
    
    // Constructeur par defaut
    public Livre()
    {
        isbn = "";
        editeur = "";
        nbPages = 0;
    }

    // Propriété publique avec accesseur et mutateur pour accéder à l'attribut privé
    public string ISBN
    {
        get { return isbn; }
        set { isbn = value; }
    }
    
    public string EDITEUR
    {
        get { return editeur; }
        set { editeur = value; }
    }

    // Propriété publique pour calculer le nombre de pages du livre en fonction du nombre de caractères du titre
    public int NombreDePages
    {
        get { return Titre.Length / 10; }
    }

    // Implémentation de la méthode Afficher de Document
    public override void Afficher()
    {
        Console.WriteLine("Livre: {0}, écrit par {1}, publié en {2}, {3} pages, ISBN : {4}, de l'editeur {5}", Titre, Auteur, Annee, NombreDePages, ISBN, EDITEUR);
    }
}