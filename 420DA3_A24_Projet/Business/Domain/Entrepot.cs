using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;
internal class Entrepot {
    // Attributs de la classe Entrepot
    public int Id { get; set; } 
    public string Nom { get; set; } 
    public Adresse Adresse { get; set; } 
    public DateTime DateCreation { get; set; } = DateTime.Now; 
    public DateTime? DateModification { get; set; } 
    public DateTime? DateSuppression { get; set; } 

    // Constructeur par défaut
    public Entrepot() {
        DateCreation = DateTime.Now;
    }

    // Constructeur avec des paramètres
    public Entrepot(string nomEntrepot, string addEntrepot, string prenomContact) {
        nomEntrepot = this.Nom;
        addEntrepot = this.Adresse.ToString();
        prenomContact = prenomContact;
        DateCreation = DateTime.Now;
    }
}


