public class Article : Document
{
    // Attributs privés
    private string nomDuJournal;
    private string domaine;

    // Constructeur
    public Article(string titre, string auteur, int annee, string nomDuJournal, string domaine) : base(titre, auteur, annee)
    {
        this.nomDuJournal = nomDuJournal;
        this.domaine = domaine;
    }
    
    // Constructeur par defaut
    public Article()
    {
        nomDuJournal = "";
        domaine = "";
    }
    
    // Propriétés publiques avec accesseurs et mutateurs pour accéder aux attributs privés
    public string NomDuJournal
    {
        get { return nomDuJournal; }
        set { nomDuJournal = value; }
    }

    public string Domaine
    {
        get { return domaine; }
        set { domaine = value; }
    }

    // Implémentation de la méthode Afficher de Document
    public override void Afficher()
    {
        Console.WriteLine("Article: {0}, publié par {1} en {2}, dans le journal {3}, dans le domaine {4}", titre, auteur, annee, nomDuJournal, domaine );
    }
}

