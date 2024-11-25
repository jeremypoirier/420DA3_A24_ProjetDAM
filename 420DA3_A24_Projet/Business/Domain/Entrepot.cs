namespace _420DA3_A24_Projet.Business.Domain;
/// <summary>
/// Classe représentant un produit stocké dans les entrepôts.
/// </summary>
public class Produit {
    // Constantes pour les limites de validation
    public const int PRODUCT_NAME_MAX_LENGTH = 128;
    public const int PRODUCT_DESCRIPTION_MAX_LENGTH = 512;
    public const int UPC_CODE_LENGTH = 12;
    public const int SUPPLIER_CODE_MAX_LENGTH = 64;
    public const int IMAGE_FILE_NAME_MAX_LENGTH = 256;

    #region Propriétés de données

    /// <summary>
    /// Identifiant unique du produit.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Nom du produit.
    /// </summary>
    public string ProductName { get; set; } = null!;

    /// <summary>
    /// Description du produit.
    /// </summary>
    public string ProductDescription { get; set; } = null!;

    /// <summary>
    /// Code UPC du produit.
    /// </summary>
    public string UpcCode { get; set; } = null!;

    /// <summary>
    /// Nom de fichier de l'image du produit.
    /// Peut être null si aucune image n'est associée.
    /// </summary>
    public string? ImageFileName { get; set; }

    /// <summary>
    /// Identifiant du client propriétaire du produit.
    /// </summary>
    public int ClientId { get; set; }

    /// <summary>
    /// Client propriétaire du produit.
    /// </summary>
    public virtual Client Client { get; set; } = null!;

    /// <summary>
    /// Nom du fournisseur.
    /// </summary>
    public string SupplierName { get; set; } = null!;

    /// <summary>
    /// Code produit attribué par le fournisseur.
    /// </summary>
    public string SupplierCode { get; set; } = null!;

    /// <summary>
    /// Quantité actuelle en stock.
    /// </summary>
    public int StockQuantity { get; set; }

    /// <summary>
    /// Quantité visée en stock.
    /// </summary>
    public int TargetStockQuantity { get; set; }

    /// <summary>
    /// Poids du produit en kilogrammes.
    /// </summary>
    public decimal WeightKg { get; set; }

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
    /// Entrepôt où est stocké le produit.
    /// </summary>
    public int EntrepotId { get; set; }

    /// <summary>
    /// Entrepôt associé au produit.
    /// </summary>
    public virtual Entrepot Entrepot { get; set; } = null!;

    #endregion

    #region Constructeurs

    /// <summary>
    /// Constructeur principal.
    /// </summary>
    public Produit(string productName, string productDescription, string upcCode, string? imageFileName, int clientId, string supplierName, string supplierCode, int stockQuantity, int targetStockQuantity, decimal weightKg, int entrepotId) {
        ProductName = productName;
        ProductDescription = productDescription;
        UpcCode = upcCode;
        ImageFileName = imageFileName;
        ClientId = clientId;
        SupplierName = supplierName;
        SupplierCode = supplierCode;
        StockQuantity = stockQuantity;
        TargetStockQuantity = targetStockQuantity;
        WeightKg = weightKg;
        EntrepotId = entrepotId;
    }

    /// <summary>
    /// Constructeur pour Entity Framework.
    /// </summary>
    protected Produit(int id, string productName, string productDescription, string upcCode, string? imageFileName, int clientId, string supplierName, string supplierCode, int stockQuantity, int targetStockQuantity, decimal weightKg, int entrepotId, DateTime dateCreated, DateTime? dateModified, DateTime? dateDeleted, byte[] rowVersion)
        : this(productName, productDescription, upcCode, imageFileName, clientId, supplierName, supplierCode, stockQuantity, targetStockQuantity, weightKg, entrepotId) {
        Id = id;
        DateCreated = dateCreated;
        DateModified = dateModified;
        DateDeleted = dateDeleted;
        RowVersion = rowVersion;
    }

    #endregion

    #region Méthodes

    public override string ToString() {
        return $"{ProductName} (UPC: {UpcCode}) - Stock: {StockQuantity}/{TargetStockQuantity}, Poids: {WeightKg}kg, Entrepôt: {EntrepotId}";
    }

    #endregion
}
}


