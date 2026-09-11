using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Magasin;

public class Utilisateurs
{

    string Nom {get; set; }

    private static int currentID;

    public int ID;

    int Mot_de_passe { get; set; }

    string Role { get; set; }

    List<Object> Inventaire { get; set; }

    List<Object> Achat_item { get; }



    public Utilisateurs(string nom, int mot_de_passe, string role)
    {
        this.Nom = nom;
        this.ID = currentID++;
        this.Mot_de_passe = mot_de_passe;
        this.Role = role;
        List<Object> inventaire = new List<Object>();
        List<Object> achat_item = new List<Object>();



    }

}
