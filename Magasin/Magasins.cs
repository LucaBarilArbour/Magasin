using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Magasin;

internal class Magasins
{
    public string Nom{  get; set; }
    public List<Object> Inventaire { get; set; }
    public List<Object> ListeUtilisateurs { get; set; }

    /// <summary>
    /// Constructeur de la classe magasin
    /// </summary>
    /// <param name="Inventaire">L'inventaire des items dans le magasins</param>
    /// <param name="ListeUtilisateurs">La liste des utilisateurs dans le magasins</param>
    /// <param name="nom">Le nom du magasins</param>
    public Magasins(List<Object> Inventaire, List<Object> ListeUtilisateurs, string nom)
    {
        this.Inventaire = Inventaire;

        this.ListeUtilisateurs = ListeUtilisateurs;

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
    private Utilisateurs TrouverUtilisateurAvcNom(string nomUtilisateur)
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


    //public Utilisateurs Get

}
