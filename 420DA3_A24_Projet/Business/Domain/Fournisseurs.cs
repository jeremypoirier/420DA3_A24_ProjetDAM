namespace _420DA3_A24_Projet.Business.Domain;
/// <summary>
/// Classe représentant un fournisseur associé à des produits pour le restockage.
/// </summary>
public class Fournisseur {
    // Constantes pour les limites de validation
    public const int SUPPLIER_NAME_MAX_LENGTH = 128;
    public const int CONTACT_NAME_MAX_LENGTH = 64;
    public const int EMAIL_MAX_LENGTH = 128;
    public const int PHONE_MAX_LENGTH = 15;

    #region Propriétés de données

    /// <summary>
    /// Identifiant unique du fournisseur.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Nom du fournisseur.
    /// </summary>
    public string SupplierName { get; set; } = null!;

    /// <summary>
    /// Prénom de la personne-contact du fournisseur.
    /// </summary>
    public string ContactFirstName { get; set; } = null!;

    /// <summary>
    /// Nom de famille de la personne-contact du fournisseur.
    /// </summary>
    public string ContactLastName { get; set; } = null!;

    /// <summary>
    /// Courriel de la personne-contact du fournisseur.
    /// </summary>
    public string ContactEmail { get; set; } = null!;

    /// <summary>
    /// Téléphone de la personne-contact du fournisseur.
    /// </summary>
    public string ContactPhone { get; set; } = null!;

    /// <summary>
    /// Date de création automatique.
    /// </summary>
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Date de modification automatique.
    /// </summary>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Date de suppression automatique.
    /// </summary>
    public DateTime? DateDeleted { get; set; }

    /// <summary>
    /// Version de la ligne pour la gestion des conflits.
    /// </summary>
    public byte[] RowVersion { get; set; } = null!;

    #endregion

    #region Propriétés de navigation

    /// <summary>
    /// Liste des produits associés à ce fournisseur.
    /// </summary>
    public virtual ICollection<Produits> Produits { get; set; } = new HashSet<Produits>();

    #endregion

    #region Constructeurs

    /// <summary>
    /// Constructeur principal.
    /// </summary>
    public Fournisseur(string supplierName, string contactFirstName, string contactLastName, string contactEmail, string contactPhone) {
        SupplierName = supplierName;
        ContactFirstName = contactFirstName;
        ContactLastName = contactLastName;
        ContactEmail = contactEmail;
        ContactPhone = contactPhone;
    }

    /// <summary>
    /// Constructeur pour Entity Framework.
    /// </summary>
    protected Fournisseur(int id, string supplierName, string contactFirstName, string contactLastName, string contactEmail, string contactPhone, DateTime dateCreated, DateTime? dateModified, DateTime? dateDeleted, byte[] rowVersion)
        : this(supplierName, contactFirstName, contactLastName, contactEmail, contactPhone) {
        Id = id;
        DateCreated = dateCreated;
        DateModified = dateModified;
        DateDeleted = dateDeleted;
        RowVersion = rowVersion;
    }

    #endregion

    #region Méthodes

    /// <summary>
    /// Retourne une chaîne représentant les informations du fournisseur.
    /// </summary>
    public override string ToString() {
        return $"{SupplierName} - Contact: {ContactFirstName} {ContactLastName}, Email: {ContactEmail}, Phone: {ContactPhone}";
    }

    #endregion
}
