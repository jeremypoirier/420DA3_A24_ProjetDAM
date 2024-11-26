namespace _420DA3_A24_Projet.Business.Domain;

// TODO @ YASSINE & MOATAZ: attention! y'a quelqu'un ici qui fait le travail de l'autre!
// M. Gourar, vous ne devriez pas avoir réalisé trois classes-entité; seulement deux!

/// <summary>
/// TODO @YASSINE: documenter
/// </summary>
public class Fournisseurs { // TODO: renommer la classe pour avoir le nom au singulier

    // TODO: ajouter des constantes publiques de type int pour les longueur des strings
    // à utiliser pour la validation et pour la configuration des colonnes dans la classe de
    // contexte.

    // Attributs de la classe Fournisseur
    public int Id { get; set; }

    // TODO: Validation des strings
    public string NomFournisseur { get; set; } = null!;
    public string NomContact { get; set; } = null!;
    public string PrenomContact { get; set; } = null!;
    public string CourrielContact { get; set; } = null!;
    public string TelephoneContact { get; set; } = null!;
    public DateTime DateCreation { get; set; }
    public DateTime DateModification { get; set; }
    public DateTime? DateSuppression { get; set; }

    // TODO: Ajouter propriété de données anti-concurrence:
    // - RowVersion de type byte[]


    // TODO: Ajouter propriété de navigation (avec modificateur 'virtual'):
    // - Produits de type List<Produit>

    // Constructeur par défaut
    public Fournisseurs() {
        // TODO: supprimer cette ligne, c'est la base de donnée qui fournira la date de création
        // à l'aide d'une valeur par défaut GETDATE()
        DateCreation = DateTime.Now;
    }

    // Constructeur avec des paramètres
    public Fournisseurs(string nomFournisseur, string nomContact, string prenomContact, string courrielContact, string telephoneContact) {
        NomFournisseur = nomFournisseur;
        NomContact = nomContact;
        PrenomContact = prenomContact;
        CourrielContact = courrielContact;
        TelephoneContact = telephoneContact;


        // TODO: supprimer cette ligne, c'est la base de donnée qui fournira la date de création
        DateCreation = DateTime.Now;
    }


    // TODO: Entity Framework a besoin d'un constructeur avec des paramètres
    // pour TOUTES les propriétés de données, incluant l'id, les dates de création,
    // modification et suppression et la version de ligne.
}
