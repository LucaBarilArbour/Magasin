namespace Magasin.Object;

public class Inventaire
{
    public List<Item> ListeItem = new List<Item>();


    public Inventaire()
    {
        this.ListeItem = ListeItem;
    }
    
    public void AjouterItem(Item item)
    {
        ListeItem.Add(item);
    }
    
    public void AjouterItems(List<Item> items)
    {
        foreach (Item item in items)
        {
            ListeItem.Add(item);
        }
    }

    public void SupprimerItem(Item item)
    {
        ListeItem.Remove(item);
    }

    public Item? TrouverItems(Item item)
    {
        foreach (Item itemInventaire in this.ListeItem)
        {
            if (item == itemInventaire)
            {
                return itemInventaire;
            }

            throw new Exception("L'item n'est pas dans la liste.");
        }

        return null;
    }

    public void ExporterInventaire()
    {
        foreach (Item item in ListeItem)
        {
            Console.WriteLine(item.Description + "\n");
        }
    }

    public override string ToString()
    {
        string LeToString = "";
        for (int i = 0; i < ListeItem.Count; i++)
        {
            LeToString += (i + ListeItem[i].Description + "\n");
        }
        return LeToString;
    }
    
    

}