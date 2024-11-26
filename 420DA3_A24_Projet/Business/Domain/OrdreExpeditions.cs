namespace _420DA3_A24_Projet.Business.Domain;

// TODO @HACHEM: Classes imbriquées: supprimer cette classe englobante inutile et
// ne garder que celle actuellement interne.
internal class OrdreExpeditions {


    /// <summary>
    /// // TODO @HACHEM: documenter
    /// </summary>
    public class OrderExpeditions { // TODO @HACHEM: renommer la classe pour être au singulier

        // TODO @HACHEM: supprimer cette ligne et toute la logique qui s'y rattache.
        // C'est la base de données qui gère les Ids, JAMAIS l'application.
        private static int _idCounter = 1;     // Compteur pour ID unique

        public int Id { get; private set; }         // Identifiant unique

        // TODO @HACHEM: changer le type pour ShippingOrderStatusEnum (fourni dans Project_Utilities.Enums)
        public string Status { get; private set; }    // Statut de l ordre
        public int ClientId { get; set; }          // Identifiant du client
        public int CreatedByUserId { get; set; }     // Identifiant de l utilisateur createur
        public int AddressId { get; set; } // Adresse du destinataire final
        public int? AssignedWarehouseUserId { get; private set; } // Employe d entrepot assigne
        public int? AssignedExpeditionId { get; private set; } // Expedition assignee

        public DateTime? ShippingDate { get; private set; }                // Date d expedition

        // TODO @HACHEM: retirer la valeur initiale DateTime.Now . C'est la base de données
        // qui doit générera la date et heure d'insertion via valeur par défaut GETDATE().
        public DateTime CreationDate { get; private set; } = DateTime.Now; // Date de cré\eation automatique
        public DateTime? ModificationDate { get; private set; }           // Date de modification
        public DateTime? DeletionDate { get; private set; }               // Date de suppression

        // TODO @HACHEM: ajouter propriétés de données:
        // - RowVersion de type byte[]



        // TODO @HACHEM: ajouter modificateur 'virtual' à ProductOrderLinks
        public List<ProductOrderLink> ProductOrderLinks { get; private set; } = new List<ProductOrderLink>();     // Liens produits
        // TODO @HACHEM: ajouter propriétés de navigation (avec modificateur 'virtual'):
        // - Client de type Client
        // - CreatedByUser de type User
        // - Adresse de type Adresse
        // - AssignedWarehouseUser de type User nullable
        // - AssignedExpedition de type Expedition nullable



        // TODO @HACHEM: supprimer cette ligne.
        private static readonly string[] AllowedStatuses = { "new", "unassigned", "processing", "packaged", "shipped" };



        public OrderExpeditions(int clientId, int createdByUserId, int addressId) {

            // TODO @HACHEM: supprimer cette ligne.
            Id = _idCounter++;

            ClientId = clientId;
            CreatedByUserId = createdByUserId;
            AddressId = addressId;

            // TODO @HACHEM: remplacer par l'utilisation de l'enum fournie ShippingOrderStatusEnum
            Status = "new"; // Statut initial
        }


        // TODO @HACHEM: Entity Framework a besoin d'un constructeur avec des paramètres
        // pour TOUTES les propriétés de données, incluant l'id, les dates de création,
        // modification et suppression et la version de ligne etc...


        // Methode pour ajouter un produit a l ordre d expedition



        // TODO @HACHEM: Mauvaise place. Ceci est de la logique métier.
        // Cela devrait être dans une classe de service ou de gestionnaire d'ordres.
        public void AddProduct(int productId, int quantity) {
            ProductOrderLinks.Add(new ProductOrderLink(productId, quantity));
            UpdateStock(productId, quantity);

            // TODO @HACHEM: supprimer ceci, on va setter la date de modification
            // directement dans la méthode d'update du DAO
            ModificationDate = DateTime.Now;
        }

        // Methode pour assigner un employe d entrepot

        public void AssignWarehouseUser(int userId) {
            AssignedWarehouseUserId = userId;

            // TODO @HACHEM: remplacer par l'utilisation de l'enum fournie ShippingOrderStatusEnum
            UpdateStatus("processing");
        }

        // Methode pour assigner une expedition a cet ordre

        public void AssignExpedition(int expeditionId) {
            AssignedExpeditionId = expeditionId;

            // TODO @HACHEM: remplacer par l'utilisation de l'enum fournie ShippingOrderStatusEnum
            UpdateStatus("packaged");
        }

        // Methode pour marquer l ordre comme expedie

        public void MarkAsShipped() {

            // TODO @HACHEM: remplacer par l'utilisation de l'enum fournie ShippingOrderStatusEnum
            UpdateStatus("shipped");
            ShippingDate = DateTime.Now;
        }

        // Methode pour annuler l ordre d expedition

        public void CancelOrder() {
            // TODO @HACHEM: supprimer ceci, on va setter la date de modification
            // directement dans la méthode de delete du DAO
            DeletionDate = DateTime.Now;

            // TODO @HACHEM: remplacer par l'utilisation de l'enum fournie ShippingOrderStatusEnum
            Status = "canceled";
        }

        // Methode pour mettre a jour le statut et la date de modification

        private void UpdateStatus(string newStatus) {
            // TODO @HACHEM: supprimer le check; inutile par l'utilisation de l'enum fournie ShippingOrderStatusEnum
            if (!IsValidStatus(newStatus))
                throw new ArgumentException("Statut invalide.");

            Status = newStatus;

            // TODO @HACHEM: supprimer ceci, on va setter la date de modification
            // directement dans la méthode d'update du DAO
            ModificationDate = DateTime.Now;
        }

        // Verifie si le statut est valide

        // TODO @HACHEM: supprimer la méthode; inutile par l'utilisation de l'enum fournie ShippingOrderStatusEnum
        private bool IsValidStatus(string status) {
            return Array.Exists(AllowedStatuses, s => s.Equals(status, StringComparison.OrdinalIgnoreCase));
        }

        // Simule la reduction du stock pour chaque produit dans la commande

        // TODO @HACHEM: Mauvaise place. Ceci est de la logique métier.
        // Et c'est en rapport avec les produits, pas les ordres d'expédition.
        private void UpdateStock(int productId, int quantity) {
            // Logique simulée pour réduire le stock
            // Par exemple : ProductStock[productId] -= quantity;
        }
    }

    // Classe pour gerer le lien produit ordre d expedition avec quantite



    // TODO @HACHEM: Mauvaise place. Crééer une nouvelle classe-entité dans son propre fichier
    // pour représenter les associations Produits - Ordres d'expédition.
    public class ProductOrderLink {

        // TODO @HACHEM: Ajouter propriété de donnée OrderId de type int
        public int ProductId { get; set; }

        // TODO @HACHEM: validation de la quantité ( > 0 )
        public int Quantity { get; set; }

        // TODO @HACHEM: ajouter propriétés de navigation (avec modificateur 'virtual'):
        // - Product de type Product
        // - Order de type Order


        // TODO @HACHEM: ajouter paramètre orderId au constructeur et l'assigner à la propriété OrderId
        public ProductOrderLink(int productId, int quantity) {
            ProductId = productId;
            Quantity = quantity;
        }
    }
}


