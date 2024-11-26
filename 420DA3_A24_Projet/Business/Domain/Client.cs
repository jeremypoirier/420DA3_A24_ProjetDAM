namespace _420DA3_A24_Projet.Business.Domain;

/// <summary>
/// TODO @MOATAZ: documenter
/// </summary>
public class Client {

    /// <summary>
    /// Longueur maximale du prénom du client.
    /// </summary>
    public const int FIRSTNAME_MAX_LENGTH = 64;
    /// <summary>
    /// Longueur maximale du nom de famille du client.
    /// </summary>
    public const int LASTNAME_MAX_LENGTH = 64;
    /// <summary>
    /// Longueur maximale du numéro de téléphone du client.
    /// </summary>
    public const int PHONE_MAX_LENGTH = 16;
    /// <summary>
    /// Longueur maximale de l'adresse email du client.
    /// </summary>
    public const int EMAIL_MAX_LENGTH = 128;

    private string nom = null!;
    private string prenom = null!;
    private string numeroTelephone = null!;
    private string email = null!;

    // Propriétés des clients
    public int Id { get; set; }

    public string Nom {
        get { return this.nom; }
        set {
            if (value.Length > LASTNAME_MAX_LENGTH) {
                throw new ArgumentException($"Le nom du client ne peut pas dépasser {LASTNAME_MAX_LENGTH} caractères.");
            }
            this.nom = value;
        }
    }
    public string Prenom {
        get { return this.prenom; }
        set {
            if (value.Length > FIRSTNAME_MAX_LENGTH) {
                throw new ArgumentException($"Le prénom du client ne peut pas dépasser {FIRSTNAME_MAX_LENGTH} caractères.");
            }
            this.prenom = value;
        }
    }
    public string NumeroTelephone {
        get { return this.numeroTelephone; }
        set {
            if (value.Length > PHONE_MAX_LENGTH) {
                throw new ArgumentException($"Le numéro de téléphone du client ne peut pas dépasser {PHONE_MAX_LENGTH} caractères.");
            }
            this.numeroTelephone = value;
        }
    }
    public string Email {
        get { return this.email; }
    }

    // TODO @MOATAZ: voir commentaires ci-dessous
    // propriétés de données:
    // - Ajouter une propriété NomClient de type string.
    //      Les clients de l'application ne sont pas des individus, mais des entreprises.
    //      Ils n'ont donc pas de nom de famille/prénom, juste un nom d'entreprise.
    //      Cependant, nous sauvegardons le nom d'une personne-contact pour chaque entreprise-cliente.
    //      Donc, aussi TODO modifier les propriétés existantes pour rendre ça plus clair:
    //          - Nom -> NomContact
    //          - Prenom -> PrenomContact
    //          - Email -> EmailContact
    //          - Telephone -> TelephoneContact
    // - EntrepotAssigneId de type int, pour la clé étrangère de l'entrepôt assigné
    // - DateCreated de type DateTime
    // - DateModified de type DateTime nullable
    // - DateDeleted de type DateTime nullable
    // - RowVersion de type byte[]


    // TODO @MOATAZ: voir commentaires ci-dessous
    // propriétés de navigation (avec midificateur 'virtual'):
    // - EntrepotAssigne de type Entrepot
    // - Produits de type List<Produit>
    // - OrdresExpedition de type List<OrdreExpedition>



    // TODO @MOATAZ: voir commentaires ci-dessous
    // 2 constructeurs:
    // - 1 orienté création depuis interface utilisateur, sans paramètres
    // - 1 orienté création depuis base de données via EF Core, avec paramètres:
    //   + id de type int
    //   + nomClient de type string
    //   + nomContact de type string
    //   + prenomContact de type string
    //   + emailContact de type string
    //   + telephoneContact de type string
    //   + entrepotAssigneId de type int
    //   + dateCreated de type DateTime
    //   + dateModified de type DateTime nullable
    //   + dateDeleted de type DateTime nullable
    //   + rowVersion de type byte[]
}






