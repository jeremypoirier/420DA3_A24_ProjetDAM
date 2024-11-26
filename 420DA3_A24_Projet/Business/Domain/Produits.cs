namespace _420DA3_A24_Projet.Business.Domain;

/// <summary>
/// TODO @JEREMY: documenter
/// </summary>
internal class Produits { // TODO @JEREMY: renommer pour être au singulier

    // TODO @JEREMY: ajouter des constantes publiques de type int pour les longueur des strings

    public int Id { get; set; }

    // TODO @JEREMY: valider toutes les propriétés string (longueur)
    public string Nom { get; set; }
    public string Description { get; set; }
    public string CodeUPC { get; set; }
    public string? ImageFileName { get; set; }
    public string CodeProduitFournisseur { get; set; }
    public int QuantiteEnStock { get; set; }
    public int QuantiteStockVisee { get; set; }
    public double PoidsKg { get; set; }

    // TODO @JEREMY: enlever l'assignation de DateTime.Now; laisser vide, c'est la base de données
    // qui donne automatiquement une valeur à cette propriété
    public DateTime DateCreation { get; set; } = DateTime.Now;
    public DateTime? DateModification { get; set; }
    public DateTime? DateSuppression { get; set; }

    // TODO @JEREMY: ajouter propriétés de données:
    // - ClientId de type int, pour la clé étrangère du client
    // - FournisseurId de type int, pour la clé étrangère du fournisseur
    // - RowVersion de type byte[] (propriété de contrôle de concurrence)



    // TODO @JEREMY: ajouter modificateur 'virtual' aux propriétés de navigation
    public Client Client { get; set; }
    // TODO @JEREMY: changer le type à Fournisseur
    public string Fournisseur { get; set; }

    // TODO @JEREMY: ajouter propriétés de navigation (avec modificateur 'virtual'):
    // - ProductOrderLinks de type List<ProductOrderLink> (discuter avec hachem + moi pour la logique de ceci)
    // - OrdresRestockage de type List<OrdreRestockage>


    // Constructeur par défaut
    public Produits() {
        // TODO @JEREMY: supprimer cette ligne. La Date de création doit se faire par la base de donnée elle-même
        // via une valeur par défaut GETDATE() dans la colonne appropriée
        DateCreation = DateTime.Now;
    }

    // Constructeur avec des paramètres
    public Produits(string nomProduit, string description, string codeUpc, string fournisseur, string codeProduitFournisseur) {

        // TODO @JEREMY: Inversion!
        // vous assignez les propriétés de la classe aux paramètres du constructeur
        // au lieu des paramètres aux propriétés de la classe
        // faire: this.Nom = nomProduit etc...
        nomProduit = this.Nom;
        description = this.Description;
        codeUpc = this.CodeUPC;
        fournisseur = this.Fournisseur;
        codeProduitFournisseur = CodeProduitFournisseur;
        //Reste des paramètres a instancier mais questions ?


        // TODO @JEREMY: supprimer cette ligne. La Date de création doit se faire par la base de donnée elle-même
        // via une valeur par défaut GETDATE() dans la colonne appropriée
        DateCreation = DateTime.Now;
    }

    // TODO @JEREMY: Entity Framework a besoin d'un constructeur avec des paramètres
    // pour TOUTES les propriétés de données, incluant l'id, les dates de création,
    // modification et suppression et la version de ligne etc...
    // ATTENTION: le nom des paramètres DOIT être exactement le même que les noms des propriétés
    // sauf pour la première lettre qui peut être minuscule pour les paramètres
}
