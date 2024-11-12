using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;
public class Fournisseurs {

    // Attributs de la classe Fournisseur
    public int Id { get; set; }
    public string NomFournisseur { get; set; } = null!;
    public string NomContact { get; set; } = null!;
    public string PrenomContact { get; set; } = null!;
    public string CourrielContact { get; set; } = null!;
    public string TelephoneContact { get; set; } = null!;
    public DateTime DateCreation { get; set; }
    public DateTime DateModification { get; set; }
    public DateTime? DateSuppression { get; set; }

    // Constructeur par défaut
    public Fournisseurs() {
        DateCreation = DateTime.Now;
    }

    // Constructeur avec des paramètres
    public Fournisseurs(string nomFournisseur, string nomContact, string prenomContact, string courrielContact, string telephoneContact) {
        NomFournisseur = nomFournisseur;
        NomContact = nomContact;
        PrenomContact = prenomContact;
        CourrielContact = courrielContact;
        TelephoneContact = telephoneContact;
        DateCreation = DateTime.Now;
    }
}
