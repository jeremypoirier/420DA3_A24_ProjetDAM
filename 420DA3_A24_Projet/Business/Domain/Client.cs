namespace _420DA3_A24_Projet.Business.Domain;
/// <summary>
/// Classe représentant un client de l'application.
/// </summary>
public class Client {
    // Constantes pour les limites de validation
    public const int COMPANY_NAME_MIN_LENGTH = 2;
    public const int COMPANY_NAME_MAX_LENGTH = 128;
    public const int CONTACT_NAME_MAX_LENGTH = 64;
    public const int EMAIL_MAX_LENGTH = 128;
    public const int PHONE_MAX_LENGTH = 15;

    // Backing fields
    private int id;
    private string companyName = null!;
    private string contactFirstName = null!;
    private string contactLastName = null!;
    private string contactEmail = null!;
    private string contactPhone = null!;

    #region Propriétés de données

    /// <summary>
    /// Identifiant unique du client.
    /// </summary>
    public int Id {
        get { return this.id; }
        set {
            if (!ValidateId(value)) {
                throw new ArgumentOutOfRangeException(nameof(Id), "Id must be greater than or equal to 0.");
            }
            this.id = value;
        }
    }

    /// <summary>
    /// Nom de la compagnie.
    /// </summary>
    public string CompanyName {
        get { return this.companyName; }
        set {
            if (!ValidateCompanyName(value)) {
                throw new ArgumentOutOfRangeException(nameof(CompanyName), $"Company name length must be between {COMPANY_NAME_MIN_LENGTH} and {COMPANY_NAME_MAX_LENGTH} characters.");
            }
            this.companyName = value;
        }
    }

    /// <summary>
    /// Identifiant de l'entrepôt attitré.
    /// </summary>
    public int WarehouseId { get; set; }

    /// <summary>
    /// Prénom de la personne-contact.
    /// </summary>
    public string ContactFirstName {
        get { return this.contactFirstName; }
        set {
            if (string.IsNullOrWhiteSpace(value) || value.Length > CONTACT_NAME_MAX_LENGTH) {
                throw new ArgumentOutOfRangeException(nameof(ContactFirstName), $"Contact first name length must be less than or equal to {CONTACT_NAME_MAX_LENGTH} characters.");
            }
            this.contactFirstName = value;
        }
    }

    /// <summary>
    /// Nom de famille de la personne-contact.
    /// </summary>
    public string ContactLastName {
        get { return this.contactLastName; }
        set {
            if (string.IsNullOrWhiteSpace(value) || value.Length > CONTACT_NAME_MAX_LENGTH) {
                throw new ArgumentOutOfRangeException(nameof(ContactLastName), $"Contact last name length must be less than or equal to {CONTACT_NAME_MAX_LENGTH} characters.");
            }
            this.contactLastName = value;
        }
    }

    /// <summary>
    /// Adresse courriel de la personne-contact.
    /// </summary>
    public string ContactEmail {
        get { return this.contactEmail; }
        set {
            if (string.IsNullOrWhiteSpace(value) || value.Length > EMAIL_MAX_LENGTH) {
                throw new ArgumentOutOfRangeException(nameof(ContactEmail), $"Contact email length must be less than or equal to {EMAIL_MAX_LENGTH} characters.");
            }
            this.contactEmail = value;
        }
    }

    /// <summary>
    /// Téléphone de la personne-contact.
    /// </summary>
    public string ContactPhone {
        get { return this.contactPhone; }
        set {
            if (string.IsNullOrWhiteSpace(value) || value.Length > PHONE_MAX_LENGTH) {
                throw new ArgumentOutOfRangeException(nameof(ContactPhone), $"Contact phone length must be less than or equal to {PHONE_MAX_LENGTH} characters.");
            }
            this.contactPhone = value;
        }
    }

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
    /// Version de la ligne pour le suivi des modifications.
    /// </summary>
    public byte[] RowVersion { get; set; } = null!;

    #endregion

    #region Propriétés de navigation

    /// <summary>
    /// Entrepôt attitré au client.
    /// </summary>
    /// a modifier!!!!!!!!!!!!!!!!!!!!!
    // public virtual Entrepot AssignedWarehouse { get; set; } = null!;

    #endregion

    #region Constructeurs

    /// <summary>
    /// Constructeur principal.
    /// </summary>
    public Client(string companyName, string contactFirstName, string contactLastName, string contactEmail, string contactPhone, int warehouseId) {
        this.CompanyName = companyName;
        this.ContactFirstName = contactFirstName;
        this.ContactLastName = contactLastName;
        this.ContactEmail = contactEmail;
        this.ContactPhone = contactPhone;
        this.WarehouseId = warehouseId;
    }

    /// <summary>
    /// Constructeur pour Entity Framework.
    /// </summary>
    protected Client(int id, string companyName, int warehouseId, string contactFirstName, string contactLastName, string contactEmail, string contactPhone, DateTime dateCreated, DateTime? dateModified, DateTime? dateDeleted, byte[] rowVersion)
        : this(companyName, contactFirstName, contactLastName, contactEmail, contactPhone, warehouseId) {
        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    #endregion

    #region Méthodes de validation

    public static bool ValidateId(int id) => id >= 0;

    public static bool ValidateCompanyName(string companyName) =>
        !string.IsNullOrWhiteSpace(companyName) && companyName.Length >= COMPANY_NAME_MIN_LENGTH && companyName.Length <= COMPANY_NAME_MAX_LENGTH;

    #endregion

    #region Méthodes

    public override string ToString() {
        return $"{this.CompanyName} - Contact: {this.ContactFirstName} {this.ContactLastName}, Email: {this.ContactEmail}, Phone: {this.ContactPhone}";
    }

    #endregion
}






