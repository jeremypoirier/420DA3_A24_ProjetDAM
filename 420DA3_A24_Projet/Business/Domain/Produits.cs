using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;
internal class Produits {
    public int Id { get; set; } 
    public string Nom { get; set; } 
    public string Description { get; set; } 
    public string CodeUPC { get; set; } 
    public string? ImageFileName { get; set; } 
    public Client Client { get; set; }
    public string Fournisseur { get; set; } 
    public string CodeProduitFournisseur { get; set; } 
    public int QuantiteEnStock { get; set; } 
    public int QuantiteStockVisee { get; set; } 
    public double PoidsKg { get; set; } 
    public DateTime DateCreation { get; set; } = DateTime.Now; 
    public DateTime? DateModification { get; set; } 
    public DateTime? DateSuppression { get; set; }

    // Constructeur par défaut
    public Produits() {
        DateCreation = DateTime.Now;
    }

    // Constructeur avec des paramètres
    public Produits(string nomProduit, string description, string codeUpc, string fournisseur, string codeProduitFournisseur) {
        nomProduit = this.Nom;
        description = this.Description;
        codeUpc = this.CodeUPC;
        fournisseur = this.Fournisseur;
        codeProduitFournisseur = CodeProduitFournisseur;
        //Reste des paramètres a instancier mais questions ?
        DateCreation = DateTime.Now;
    }
}
