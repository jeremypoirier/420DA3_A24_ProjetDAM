using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;
internal class OrdreExpeditions {


    public class OrderExpeditions {
        private static int _idCounter = 1;     // Compteur pour ID unique

        public int Id { get; private set; }         // Identifiant unique
        public string Status { get; private set; }    // Statut de l ordre
        public int ClientId { get; set; }          // Identifiant du client
        public int CreatedByUserId { get; set; }     // Identifiant de l utilisateur createur
        public List<ProductOrderLink> ProductOrderLinks { get; private set; } = new List<ProductOrderLink>();     // Liens produits

        public int AddressId { get; set; } // Adresse du destinataire final
        public int? AssignedWarehouseUserId { get; private set; } // Employe d entrepot assigne
        public int? AssignedExpeditionId { get; private set; } // Expedition assignee

        public DateTime? ShippingDate { get; private set; }                // Date d expedition
        public DateTime CreationDate { get; private set; } = DateTime.Now; // Date de cré\eation automatique
        public DateTime? ModificationDate { get; private set; }           // Date de modification
        public DateTime? DeletionDate { get; private set; }               // Date de suppression

        private static readonly string[] AllowedStatuses = { "new", "unassigned", "processing", "packaged", "shipped" };

        public OrderExpeditions(int clientId, int createdByUserId, int addressId) {
            Id = _idCounter++;
            ClientId = clientId;
            CreatedByUserId = createdByUserId;
            AddressId = addressId;
            Status = "new"; // Statut initial
        }

        // Methode pour ajouter un produit a l ordre d expedition

        public void AddProduct(int productId, int quantity) {
            ProductOrderLinks.Add(new ProductOrderLink(productId, quantity));
            UpdateStock(productId, quantity);
            ModificationDate = DateTime.Now;
        }

        // Methode pour assigner un employe d entrepot

        public void AssignWarehouseUser(int userId) {
            AssignedWarehouseUserId = userId;
            UpdateStatus("processing");
        }

        // Methode pour assigner une expedition a cet ordre

        public void AssignExpedition(int expeditionId) {
            AssignedExpeditionId = expeditionId;
            UpdateStatus("packaged");
        }

        // Methode pour marquer l ordre comme expedie

        public void MarkAsShipped() {
            UpdateStatus("shipped");
            ShippingDate = DateTime.Now;
        }

        // Methode pour annuler l ordre d expedition

        public void CancelOrder() {
            DeletionDate = DateTime.Now;
            Status = "canceled";
        }

        // Methode pour mettre a jour le statut et la date de modification

        private void UpdateStatus(string newStatus) {
            if (!IsValidStatus(newStatus))
                throw new ArgumentException("Statut invalide.");

            Status = newStatus;
            ModificationDate = DateTime.Now;
        }

        // Verifie si le statut est valide

        private bool IsValidStatus(string status) {
            return Array.Exists(AllowedStatuses, s => s.Equals(status, StringComparison.OrdinalIgnoreCase));
        }

        // Simule la reduction du stock pour chaque produit dans la commande

        private void UpdateStock(int productId, int quantity) {
            // Logique simulée pour réduire le stock
            // Par exemple : ProductStock[productId] -= quantity;
        }
    }

    // Classe pour gerer le lien produit ordre d expedition avec quantite

    public class ProductOrderLink {
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public ProductOrderLink(int productId, int quantity) {
            ProductId = productId;
            Quantity = quantity;
        }
    }
}


