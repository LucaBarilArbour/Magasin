using System.Text.RegularExpressions;

namespace Magasin.Object;

public class Item
{
    private string id;
    private readonly Regex regexValidationId = new Regex(@"^[A-Z]{3}\d{4}$");
    public string Type { get; set; }

    public string Description { get; set; }
    private string nom;
    private decimal prix;
    private short quantite;

    public string Nom
    {
        get { return this.nom; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Le nom ne peut pas être vide");
            }
            this.nom = value;
        }
    }

    public decimal Prix
    {
        get { return this.prix; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Le prix ne peut pas être négatif");
            }
            this.prix = value;
        }
    }

    public string Id
    {
        get { return this.id; }
        set
        {
            if (!regexValidationId.IsMatch(value))
            {
                throw new ArgumentException("Le id ne match le format ABCXXXX");
            }
            this.id = value;
        }
    }

    public short Quantite
    {
        get { return this.quantite; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Le prix peut pas être négatif");
            }
            this.quantite = value;
        }
    }

    public Item(string id, string type, short quantite, decimal prix, string description)
    {
        this.id = id;
        this.Type = type;
        this.quantite = quantite;
        this.prix = prix;
        this.Description = description;
    }

    public override string ToString()
    {
        return string.Format(
            """
            Nom : {0}
            Quantité : {1:D)}
            Prix : {2:C}
            """,
            this.nom,
            this.quantite,
            this.prix
        );
    }
}
