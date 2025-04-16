using QuoteMachine_ExerciceGit;

Console.WriteLine("Bienvenue dans QuoteMachine!");
Console.WriteLine("Ce projet est collaboratif et utilise le GitHub Flow.");
Console.WriteLine("Développez une application console pour gérer et afficher des citations inspirantes.\n");
Console.WriteLine("Prochaines étapes : implémentez les fonctionnalités dans des branches distinctes.\n");
Console.WriteLine("\n=== Menu Principal ===");
Console.WriteLine("Implémentez le menu du programme dans feature/menu");
Console.ReadKey(true);
var manager = new QuoteManager();
string path = "citations.csv";
char choixMenu;


// Affichage de menu
Console.WriteLine("Menu principale");
Console.WriteLine("1) Générer une citation");
Console.WriteLine("2) Ajouter une citation");
Console.WriteLine("3) Charger les citation");
Console.WriteLine("4) Sortir");


// Saisie du choix de l'utilisateur
Console.Write("Votre choix ? ");
choixMenu = Console.ReadKey().KeyChar;
Console.WriteLine();
while (choixMenu != '4')
{
    if (choixMenu != '4')
    {
        string path = "citations.csv";
        manager.SaveToCSVFile(path);
        Console.WriteLine("Citations sauvegardées dans le fichier : " + path);
    }
    catch (QuoteFileException ex)
        if (choixMenu == '1')
            ShowRandomQuote(manager);
        else if (choixMenu == '2')
            AddNewQuote(manager);
        else if (choixMenu == '3')
			LoadQuotesFromFile(manager);

    }
    
    Console.WriteLine("Appuyez sur une touche pour continuer");
    Console.ReadKey();


    // Saisie du choix de l'utilisateur
    Console.Write("Votre choix ? ");
    choixMenu = Console.ReadKey().KeyChar;
    Console.WriteLine();

    static void ShowRandomQuote(QuoteManager manager)
    {
        Console.WriteLine("[Simulation] Une citation aléatoire s’afficherait ici.");
        // Exemple futur : Console.WriteLine(manager.GetRandomQuote());
    }

    static void AddNewQuote(QuoteManager manager)
    {
        Console.WriteLine("[Simulation] On ajouterait une nouvelle citation ici.");
        // Exemple futur :
        // Console.Write("Texte : ");
        // var texte = Console.ReadLine();
        // Console.Write("Auteur : ");
        // var auteur = Console.ReadLine();
        // manager.AddQuote(texte, auteur);
        // Console.WriteLine("Citation ajoutée !");
    }

    static void SaveQuotesToFile(QuoteManager manager)
    {
        try
        {
            Console.WriteLine("[Simulation] On sauvegarderait les citations ici.");
            // Exemple futur :
            // manager.SaveToFile("citations.txt");
            //Console.WriteLine("Citations sauvegardées !");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur : {ex.Message}");
        }
    }

    static void LoadQuotesFromFile(QuoteManager manager)
    {
        try
        {
            Console.WriteLine("[Simulation] On chargerait les citations ici.");
            // Exemple futur :
            // manager.LoadFromFile("citations.txt");
            //Console.WriteLine("Citations chargées !");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur : {ex.Message}");
        }
    }
}


