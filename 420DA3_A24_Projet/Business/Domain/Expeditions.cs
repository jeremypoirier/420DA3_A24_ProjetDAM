namespace _420DA3_A24_Projet.Business.Domain;
/// <summary>
/// Classe représentant une expédition.
/// </summary>
public class Expedition {
    // Constantes pour les services de livraison
    public const string PUROLATOR = "Purolator";
    public const string POSTES_CANADA = "PostesCanada";
    public const string FEDEX = "FedEx";

    /// <summary>
    /// Liste des services de livraison valides.
    /// </summary>
    public static readonly string[] DeliveryServices = { PUROLATOR, POSTES_CANADA, FEDEX };

    #region Propriétés de données

    /// <summary>
    /// Identifiant unique de l'expédition.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Service de livraison utilisé pour l'expédition.
    /// </summary>
    public string DeliveryService { get; set; } = PUROLATOR;

    /// <summary>
    /// Code de suivi généré automatiquement par le service de livraison.
    /// </summary>
    public string TrackingCode { get; set; } = string.Empty;

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
    public Expedition(string deliveryService, string trackingCode) {
        if (!ValidateDeliveryService(deliveryService)) {
            throw new ArgumentOutOfRangeException(nameof(deliveryService), "Invalid delivery service.");
        }

        if (string.IsNullOrWhiteSpace(trackingCode)) {
            throw new ArgumentException("Tracking code cannot be null or empty.", nameof(trackingCode));
        }

        DeliveryService = deliveryService;
        TrackingCode = trackingCode;
    }

    /// <summary>
    /// Constructeur pour Entity Framework.
    /// </summary>
    protected Expedition(int id, string deliveryService, string trackingCode, DateTime dateCreated, DateTime? dateModified, DateTime? dateDeleted, byte[] rowVersion)
        : this(deliveryService, trackingCode) {
        Id = id;
        DateCreated = dateCreated;
        DateModified = dateModified;
        DateDeleted = dateDeleted;
        RowVersion = rowVersion;
    }

    #endregion

    #region Méthodes de validation

    /// <summary>
    /// Valide si le service de livraison est valide.
    /// </summary>
    public static bool ValidateDeliveryService(string deliveryService) {
        return DeliveryServices.Contains(deliveryService);
    }

    #endregion

    #region Méthodes

    /// <summary>
    /// Retourne une chaîne représentant les informations de l'expédition.
    /// </summary>
    public override string ToString() {
        return $"Expédition #{Id}: Service={DeliveryService}, TrackingCode={TrackingCode}, DateCreated={DateCreated:yyyy-MM-dd}";
    }

    #endregion
}
