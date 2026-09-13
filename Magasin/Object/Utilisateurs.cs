using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Magasin.Object;

namespace Magasin;

public class Utilisateurs
{

    public string Nom { get; set; }

    private static int currentID;

    public int Id;

    private int MotDePasse { get; set; }

    public string Role { get; set; }

    private List<Item> Inventaire { get; set; }

    private List<Item> AchatItem { get; }


    /// <summary>
    /// COnstructeur de la classe des utilisateurs
    /// </summary>
    /// <param name="nom">Nom de l'utilisateur</param>
    /// <param name="motDePasse">Mot de passe de connection</param>
    /// <param name="role">Le rôle de l'utilisateur dans le magasin</param>
    /// <param name="achatItem">Les items acheté </param>
    public Utilisateurs(string nom, int motDePasse, string role, List<Item> achatItem)
    {
        this.Nom = nom;
        this.Id = currentID++;
        this.MotDePasse = motDePasse;
        this.Role = role;
        List<Item> inventaire = new List<Item>();
        List<Item> achatitem = achatItem;



    }

    public void AfficherItem()
    {
        for (int i = 0; i < Inventaire.Count; i++)
        {
            Console.WriteLine((i + 1) + Inventaire[i].Nom);
        }
    }

    public string AfficherUnItem(string nomItem)
    {
        foreach (Item item in this.Inventaire)
        {
            if (Item.nom == nomItem) //TODO:Problème
            {

                return item.Description;
            }
        }

        throw new Exception("L'item n'est pas dans la liste de ce magasin");
    }

    //TODO: Faire les méthodes de classes suivante : acheterItem, afficherInventaire
}
