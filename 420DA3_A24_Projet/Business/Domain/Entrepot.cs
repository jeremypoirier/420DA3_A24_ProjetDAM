using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace _420DA3_A24_Projet.Business.Domain;

/// <summary>
/// Classe représentant un entrepôt
/// </summary>
public class Entrepot { 
    // Attributs de la classe Entrepot
    public int Id { get; set; }


    // Validation du nom avec des annotations de données
    [Required(ErrorMessage = "Le nom est requis.")]
    [StringLength(100, ErrorMessage = "Le nom ne doit pas dépasser 100 caractères.")]
    public string Nom { get; set; }

    // Clé étrangère pour l'adresse de l'entrepôt
    public int AdresseId { get; set; }

    // TODO @JEREMY: voir commentaires ci-dessous
    // propriétés de données:
    // - AddresseId de type int, pour la clé étrangère de l'adresse de l'entrepôt
    // - RowVersion de type byte[]

    // Dates de gestion (création, modification, suppression)
    public DateTime DateCreation { get; set; } = DateTime.Now;
    public DateTime? DateModification { get; set; }
    public DateTime? DateSuppression { get; set; }
    public byte[] RowVersion { get; }


    // Propriété de navigation pour l'adresse (avec modificateur 'virtual')
    public virtual Adresse Adresse { get; set; }


    // TODO @JEREMY: voir commentaires ci-dessous
    // propriétés de navigation (avec modificateur 'virtual'):
    // - Clients de type List<Client>
    // - OrdresRestockage de type List<OrdreRestockage>
    // - EmployesEntrepot de type List<User>
    // Propriétés de navigation (avec modificateur 'virtual')
    public virtual List<Client> Clients { get; set; } = new List<Client>();
    public virtual List<OrdreRestockage> OrdreRestockage { get; set; } = new List<OrdreRestockage>();
    public virtual List<User> EmployesEntrepot { get; set; } = new List<User>();


    // Constructeur par défaut
    public Entrepot() {
        // La DateCreation doit être définie par la base de données via GETDATE()
    }

    // TODO @JEREMY: le second constructeur doit avoir des paramètres pour
    // TOUTES les propriétés de données (mais pas celles de navigation) de la classe:
    // - dateCreation
        
    // Constructeur avec des paramètres pour toutes les propriétés de données
    public Entrepot(int id, string nom, int adresseId, DateTime? dateModification = null, DateTime? dateSuppression = null, byte[] rowVersion = null) {
        Id = id;
        Nom = nom;
        AdresseId = adresseId;
        DateModification = dateModification;
        DateSuppression = dateSuppression;
        RowVersion = rowVersion;
    }
}

