using System;

public class Expedition {
    private static int _idCounter = 1;                   // Compteur d ID unique pour chaque instance

    public int Id { get; private set; }                 // Identifiant interne unique
    public string DeliveryService { get; private set; } // Service de livraison
    public string TrackingCode { get; private set; }    // Code de suivi genere automatiquement

    public DateTime CreationDate { get; private set; } = DateTime.Now; // Date de création automatique
    public DateTime? ModificationDate { get; private set; } // Date de modification automatique
    public DateTime? DeletionDate { get; private set; } // Date de suppression automatique

    // Valeurs possibles pour le service de livraison
    private static readonly string[] AllowedServices = { "Purolator", "PostesCanada", "FedEx" };

    // Constructeur par defaut (non utilise ici mais peut etre utile)

    public Expedition() { }

    // Constructeur principal avec un service de livraison (code de suivi genere automatiquement)

    public Expedition(string deliveryService) {
        if (!IsValidService(deliveryService))
            throw new ArgumentException("Service de livraison invalide.");

        Id = _idCounter++; // Genere un ID unique
        DeliveryService = deliveryService;
        TrackingCode = GenerateTrackingCode(); // Genere automatiquement le code de suivi
    }

    // Methode pour mettre a jour le service de livraison
    public void UpdateDeliveryService(string newService) {
        if (!IsValidService(newService))
            throw new ArgumentException("Service de livraison invalide.");

        DeliveryService = newService;
        ModificationDate = DateTime.Now; // Date de modification automatique
    }

    // Methode pour annuler l expedition

    public void CancelExpedition() {
        DeletionDate = DateTime.Now; // Date de suppression automatique
    }

    // Methode pour verifier si le service est valide

    private bool IsValidService(string service) {
        return Array.Exists(AllowedServices, s => s.Equals(service, StringComparison.OrdinalIgnoreCase));
    }

    // Methode pour generer un faux code de suivi

    private string GenerateTrackingCode() {

        // Genere un code aleatoire de type alphanumerique pour simuler un code de suivi

        Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(chars, 10)
          .Select(s => s[random.Next(s.Length)]).ToArray());
    }
}
