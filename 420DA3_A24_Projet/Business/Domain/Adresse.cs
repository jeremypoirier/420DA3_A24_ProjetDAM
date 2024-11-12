using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;


public class Adresse {

    /// <summary>
    /// Longueur maximale du nom du destinataire.
    /// </summary>
    public const int DESTINATAIRE_MAX_LENGTH = 64;
    /// <summary>
    /// Longueur maximale du numéro civique.
    /// </summary>
    public const int NUMERO_CIVIQUE_MAX_LENGTH = 16;
    /// <summary>
    /// Longueur maximale de la rue.
    /// </summary>
    public const int RUE_MAX_LENGTH = 64;
    /// <summary>
    /// Longueur maximale de la ville.
    /// </summary>
    public const int VILLE_MAX_LENGTH = 64;
    /// <summary>
    /// Longueur maximale de la province.
    /// </summary>
    public const int PROVINCE_MAX_LENGTH = 64;
    /// <summary>
    /// Longueur maximale du pays.
    /// </summary>
    public const int PAYS_MAX_LENGTH = 64;
    /// <summary>
    /// Longueur maximale du code postal.
    /// </summary>
    public const int CODE_POSTAL_MAX_LENGTH = 16;

    private string destinataire = null!;
    private string numeroCivique = null!;
    private string rue = null!;
    private string ville = null!;
    private string province = null!;
    private string pays = null!;
    private string codePostal = null!;

    // Propriétés des adresses
    public int Id { get; set; }
    public string Destinataire {
        get { return this.destinataire; }
        set {
            if (value.Length > DESTINATAIRE_MAX_LENGTH) {
                throw new ArgumentException($"Le nom du destinataire ne peut pas dépasser {DESTINATAIRE_MAX_LENGTH} caractères.");
            }
            this.destinataire = value;
        }
    }

    public string NumeroCivique {
        get { return this.numeroCivique; }
        set {
            if (value.Length > 10) {
                throw new ArgumentException($"Le numéro civique ne peut pas dépasser 10 caractères.");
            }
            this.numeroCivique = value;
        }
    }
    public string Rue {
        get { return this.rue; }
        set {
            if (value.Length > 50) {
                throw new ArgumentException($"Le nom de la rue ne peut pas dépasser 50 caractères.");
            }
            this.rue = value;
        }
    }
    public string Ville {
        get { return this.ville; }
        set {
            if (value.Length > 50) {
                throw new ArgumentException($"Le nom de la ville ne peut pas dépasser 50 caractères.");
            }
            this.ville = value;
        }
    }
    public string Province {
        get { return this.province; }
        set {
            if (value.Length > 50) {
                throw new ArgumentException($"Le nom de la province ne peut pas dépasser 50 caractères.");
            }
            this.province = value;
        }
    }
    public string Pays {
        get { return this.pays; }
    }

    public string CodePostal {
        get { return this.codePostal; }
    }
} 





    
