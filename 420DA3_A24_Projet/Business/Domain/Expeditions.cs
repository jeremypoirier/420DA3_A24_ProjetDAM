/// <summary>
/// TODO @YASSINE: documenter
/// </summary>
public class Expedition {

    // TODO @YASSINE: retirer cette ligne et toute la logique qui s'y rapporte.
    // L'Id est déterminé par la base de données, JAMAIS par le code.
    private static int _idCounter = 1;                   // Compteur d ID unique pour chaque instance

    public int Id { get; private set; }                 // Identifiant interne unique


    // TODO @YASSINE: changer le type de DeliveryService pour ShippingProvidersEnum (fourni dans Project_Utilities.Enums )
    public string DeliveryService { get; private set; } // Service de livraison
    public string TrackingCode { get; private set; }    // Code de suivi genere automatiquement


    // TODO @YASSINE: ajouter propriétés de données:
    // - ShippingOrderId de type int
    // - RowVersion de type byte[]

    public DateTime CreationDate { get; private set; } = DateTime.Now; // Date de création automatique
    public DateTime? ModificationDate { get; private set; } // Date de modification automatique
    public DateTime? DeletionDate { get; private set; } // Date de suppression automatique



    // TODO @YASSINE: ajouter propriété de navigation (avec modificateur 'virtual'):
    // - ShippingOrder de type ShippingOrder



    // TODO @YASSINE: supprimer cette ligne; l'enum ShippingProvidersEnum va faire le travail
    private static readonly string[] AllowedServices = { "Purolator", "PostesCanada", "FedEx" };

    // Constructeur par defaut (non utilise ici mais peut etre utile)

    public Expedition() { }

    // Constructeur principal avec un service de livraison (code de suivi genere automatiquement)

    // TODO @YASSINE: changer le type du paramètre pour ShippingProvidersEnum
    public Expedition(string deliveryService) {
        // TODO @YASSINE: supprimer le check, l'enum fait le travail
        if (!IsValidService(deliveryService))
            throw new ArgumentException("Service de livraison invalide.");

        // TODO @YASSINE: supprimer cette ligne; l'Id est géré par la base de données
        Id = _idCounter++; // Genere un ID unique


        DeliveryService = deliveryService;


        // TODO @YASSINE: utiliser le code déjà fourni pour générer le code de suivi:
        // TrackingCode = TrackingNumberFactory.GetInstance().GetNewTrackingNumber(ShippingProvidersEnum shipmentProvider)
        TrackingCode = GenerateTrackingCode(); // Genere automatiquement le code de suivi
    }


    // TODO @YASSINE: supprimer cette méthode, de par les requis un shipment ne peut pas être modifié ou supprimé
    // Methode pour mettre a jour le service de livraison
    public void UpdateDeliveryService(string newService) {
        if (!IsValidService(newService))
            throw new ArgumentException("Service de livraison invalide.");

        DeliveryService = newService;
        ModificationDate = DateTime.Now; // Date de modification automatique
    }

    // Methode pour annuler l expedition

    // TODO @YASSINE: supprimer cette méthode, de par les requis un shipment ne peut pas être modifié ou supprimé
    public void CancelExpedition() {
        DeletionDate = DateTime.Now; // Date de suppression automatique
    }

    // Methode pour verifier si le service est valide

    // TODO @YASSINE: supprimer cette méthode, inutile: l'utilisation de ShippingProvidersEnum va faire le travail
    private bool IsValidService(string service) {
        return Array.Exists(AllowedServices, s => s.Equals(service, StringComparison.OrdinalIgnoreCase));
    }

    // Methode pour generer un faux code de suivi

    // TODO @YASSINE: supprimer cette méthode, inutile: code de génération de tracking number déjà fourni
    // dans TrackingNumberFactory (service)
    private string GenerateTrackingCode() {

        // Genere un code aleatoire de type alphanumerique pour simuler un code de suivi

        Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(chars, 10)
          .Select(s => s[random.Next(s.Length)]).ToArray());
    }
}
