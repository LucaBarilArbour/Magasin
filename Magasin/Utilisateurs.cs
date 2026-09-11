using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Magasin;

public class Utilisateurs
{

    public string Nom { get; set; }

    private static int currentID;

    public int ID;

    private int Mot_de_passe { get; set; }

    public string Role { get; set; }

    private List<Object> Inventaire { get; set; }

    private List<Object> Achat_item { get; }


    /// <summary>
    /// COnstructeur de la classe des utilisateurs
    /// </summary>
    /// <param name="nom">Nom de l'utilisateur</param>
    /// <param name="mot_de_passe">Mot de passe de connection</param>
    /// <param name="role">Le rôle de l'utilisateur dans le magasin</param>
    public Utilisateurs(string nom, int mot_de_passe, string role)
    {
        this.Nom = nom;
        this.ID = currentID++;
        this.Mot_de_passe = mot_de_passe;
        this.Role = role;
        List<Object> inventaire = new List<Object>();
        List<Object> achat_item = new List<Object>();



    }

    //TODO: Faire les méthodes de classes suivante : afficherItems, afficherUnItem, acheterItem, afficherInventaire
}
