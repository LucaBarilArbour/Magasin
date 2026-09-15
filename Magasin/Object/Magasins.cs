using System.Text.Json;

namespace Magasin.Object;

internal class Magasins
{
    private static JsonSerializerOptions options = new JsonSerializerOptions
    {
        WriteIndented = true,
    };
    public string Nom { get; set; }
    public Compte Compte = new Compte(0);
    public Inventaire Inventaire { get; set; }
    public List<Utilisateurs> ListeUtilisateurs { get; set; }

    /// <summary>
    /// Constructeur de la classe magasin
    /// </summary>
    /// <param name="inventaire">L'inventaire des items dans le magasins</param>
    /// <param name="listeUtilisateurs">La liste des utilisateurs dans le magasins</param>
    /// <param name="nom">Le nom du magasins</param>
    public Magasins(Inventaire inventaire, List<Utilisateurs> listeUtilisateurs, string nom)
    {
        this.Inventaire = inventaire;

        this.ListeUtilisateurs = listeUtilisateurs;

        this.Nom = nom;
    }

    /// <summary>
    /// Ajoute un utilisateur donné dans la liste des utilisateurs
    /// </summary>
    /// <param name="utilisateurs">Utilisateur à ajouter dans le magasins</param>
    public void AjoutUtilisateur(Utilisateurs utilisateurs)
    {
        this.ListeUtilisateurs.Add(utilisateurs);
    }

    /// <summary>
    /// Trouve un utilisateur dans la liste d'utilisateurs du magasins
    /// </summary>
    /// <param name="nomUtilisateur">Le nom de l'utilisateur recherché</param>
    /// <returns>Retourne l'objet de l'utilisateur trouvé</returns>
    /// <exception cref="Exception">Fait une exeption si le nom n'est pas trouvé dans la liste</exception>
    public Utilisateurs TrouverUtilisateurAvcNom(string nomUtilisateur)
    {
        foreach (Utilisateurs utilisateur in this.ListeUtilisateurs)
        {
            if (utilisateur.Nom == nomUtilisateur)
            {
                return utilisateur;
            }
        }

        throw new Exception("Le nom n'est pas dans la liste de ce magasin");
    }

    public void SaveInventaire(string nomFichier)
    {
        string? basePath = Directory
            .GetParent(Directory.GetCurrentDirectory())
            ?.Parent?.Parent?.FullName;

        if (basePath is null)
        {
            throw new InvalidOperationException(
                "Could not resolve base path: directory tree is not deep enough."
            );
        }

        string fichier = Path.Combine(basePath, "Data", "Inventaire.json");

        string? dossier = Path.GetDirectoryName(fichier);

        if (dossier is null)
        {
            throw new InvalidOperationException($"Could not resolve directory for path: {fichier}");
        }

        Directory.CreateDirectory(dossier);

        List<Item> inventaire = new List<Item>(this.Inventaire.ListeItem);

        string inventaireJson = JsonSerializer.Serialize(inventaire, options);

        File.WriteAllText(nomFichier, inventaireJson);
    }
}
