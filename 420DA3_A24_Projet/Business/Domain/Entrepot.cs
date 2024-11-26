namespace _420DA3_A24_Projet.Business.Domain;

/// <summary>
/// TODO @JEREMY: documenter
/// </summary>
internal class Entrepot { // TODO @JEREMY: marquer public au lieu de internal. les entités sont utilisés cross-assemblies
    // Attributs de la classe Entrepot
    public int Id { get; set; }


    // TODO @JEREMY: validation du nom
    public string Nom { get; set; }

    // TODO @JEREMY: voir commentaires ci-dessous
    // propriétés de données:
    // - AddresseId de type int, pour la clé étrangère de l'adresse de l'entrepôt
    // - RowVersion de type byte[]

    public DateTime DateCreation { get; set; } = DateTime.Now;
    public DateTime? DateModification { get; set; }
    public DateTime? DateSuppression { get; set; }


    // TODO @JEREMY: ajouter le modificateur 'virtual' à la propriété Adresse
    public Adresse Adresse { get; set; }


    // TODO @JEREMY: voir commentaires ci-dessous
    // propriétés de navigation (avec midificateur 'virtual'):
    // - Clients de type List<Client>
    // - OrdresRestockage de type List<OrdreRestockage>
    // - EmployesEntrepot de type List<User>



    // Constructeur par défaut
    public Entrepot() {
        // TODO @JEREMY: supprimer cette ligne. La Date de création doit se faire par la base de donnée elle-même
        // via une valeur par défaut GETDATE() dans la colonne appropriée
        DateCreation = DateTime.Now;
    }

    // Constructeur avec des paramètres
    public Entrepot(string nomEntrepot, string addEntrepot, string prenomContact) {
        // TODO @JEREMY: le second constructeur doit avoir des paramètres pour
        // TOUTES les propriétés de données (mais pas celles de navigation) de la classe:
        // - id
        // - nom
        // - adresseId
        // - dateCreation
        // - dateModification
        // - dateSuppression
        // - rowVersion

        nomEntrepot = this.Nom;
        addEntrepot = this.Adresse.ToString();
        prenomContact = prenomContact;

        // TODO @JEREMY: supprimer cette ligne. La Date de création doit se faire par la base de donnée elle-même
        DateCreation = DateTime.Now;
    }
}
