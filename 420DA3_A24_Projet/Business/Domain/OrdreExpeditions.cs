namespace _420DA3_A24_Projet.Business.Domain;
/// <summary>
/// Classe représentant un ordre d'expédition.
/// </summary>
public class OrdreExpedition {
    // Constantes pour les valeurs possibles de statut
    public const string STATUS_NEW = "new";
    public const string STATUS_UNASSIGNED = "unassigned";
    public const string STATUS_PROCESSING = "processing";
    public const string STATUS_PACKAGED = "packaged";
    public const string STATUS_SHIPPED = "shipped";

    #region Propriétés de données

    /// <summary>
    /// Identifiant unique de l'ordre d'expédition.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Statut de l'ordre d'expédition.
    /// </summary>
    public string Status { get; set; } = STATUS_NEW;

    /// <summary>
    /// Identifiant du client associé à l'ordre d'expédition.
    /// </summary>
    public int ClientId { get; set; }

    /// <summary>
    /// Client associé à l'ordre d'expédition.
    /// </summary>
    public virtual Client Client { get; set; } = null!;

    /// <summary>
    /// Identifiant de l'utilisateur employé de bureau ou administrateur (créateur de l'ordre).
    /// </summary>
    public int CreatedById { get; set; }

    /// <summary>
    /// Utilisateur employé de bureau ou administrateur (créateur de l'ordre).
    /// </summary>
    public virtual User CreatedBy { get; set; } = null!;

    /// <summary>
    /// Liste des liens produits-ordre d'expédition avec quantités.
    /// </summary>
    public virtual ICollection<Produit> ProduitOrdreExpedition { get; set; } = new HashSet<Produit>();

    /// <summary>
    /// Adresse enregistrée pour l'expédition (destinataire final).
    /// </summary>
    public string Address { get; set; } = null!;

    /// <summary>
    /// Identifiant de l'employé d'entrepôt attitré (nullable).
    /// </summary>
    public int? WarehouseEmployeeId { get; set; }

    /// <summary>
    /// Employé d'entrepôt attitré à cet ordre d'expédition (nullable).
    /// </summary>
    public virtual User? WarehouseEmployee { get; set; }

    /// <summary>
    /// Identifiant de l'expédition attitrée (nullable).
    /// </summary>
    public int? ShipmentId { get; set; }

    /// <summary>
    /// Expédition attitrée une fois les produits emballés (nullable).
    /// </summary>
    public virtual Expedition? Shipment { get; set; }

    /// <summary>
    /// Date d'expédition (remplie lorsque le colis est récupéré par un service externe, nullable).
    /// </summary>
    public DateTime? ShipmentDate { get; set; }

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

    #region Constructeurs

    /// <summary>
    /// Constructeur principal.
    /// </summary>
    public OrdreExpedition(int clientId, int createdById, string address) {
        ClientId = clientId;
        CreatedById = createdById;
        Address = address;
    }

    /// <summary>
    /// Constructeur pour Entity Framework.
    /// </summary>
    protected OrdreExpedition(
        int id,
        string status,
        int clientId,
        int createdById,
        string address,
        int? warehouseEmployeeId,
        int? shipmentId,
        DateTime? shipmentDate,
        DateTime dateCreated,
        DateTime? dateModified,
        DateTime? dateDeleted,
        byte[] rowVersion)
        : this(clientId, createdById, address) {
        Id = id;
        Status = status;
        WarehouseEmployeeId = warehouseEmployeeId;
        ShipmentId = shipmentId;
        ShipmentDate = shipmentDate;
        DateCreated = dateCreated;
        DateModified = dateModified;
        DateDeleted = dateDeleted;
        RowVersion = rowVersion;
    }

    #endregion

    #region Méthodes

    /// <summary>
    /// Retourne une chaîne représentant les informations de l'ordre d'expédition.
    /// </summary>
    public override string ToString() {
        return $"Ordre #{Id}: Status={Status}, Client={ClientId}, CreatedBy={CreatedById}, Address={Address}, ShipmentDate={ShipmentDate?.ToString("yyyy-MM-dd") ?? "Not shipped"}";
    }

    #endregion
}
}

