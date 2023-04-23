using System;

class Program
{
    static void Main(string[] args)
    {
        // Création d'un livre
        Livre livre = new Livre("Le Seigneur des Anneaux", "J.R.R. Tolkien", 1954, "81/525/66-0", "Hachette", 117);
        livre.Afficher();

        Console.WriteLine("--------------------------");

        // Création d'une revue
        //Revue revue = new Revue("National Geographic", "National Geographic Society", 2022, 4, "Science et Nature");
        Revue revue = new Revue("National Geographic", "National Geographic Society", 2022,
            "National Geographic Society",
            "81/525/66-0");
        revue.Afficher();

        Console.WriteLine("--------------------------");

        // Création d'un article
        Article article = new Article("La théorie des cordes", "Lisa Randall", 2005, "Scientific American", "Science");
        article.Afficher();

        Console.WriteLine("--------------------------");

        // Création d'un audio book
        Audio audio = new Audio("Le nom du vent", "Patrick Rothfuss", 2007, "MP3", 180);
        audio.Afficher();
    }
}