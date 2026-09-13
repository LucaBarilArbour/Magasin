namespace Magasin.Object;

public class Compte
{
    private decimal Solde{get;set;}
    
    public Compte(decimal solde)
    {
        this.Solde = solde;
    }
    
    public void Depot(decimal argent)
        {
        this.Solde =+ argent;
        }

    public void Retraite(decimal argent)
    {
        this.Solde =- argent;
    }

    public override string ToString()
    {
        return "Le solde du compte est de : " + this.Solde;
    }
}