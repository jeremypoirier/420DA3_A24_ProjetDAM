using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;
public class Client {

    /// <summary>
    /// Longueur maximale du prénom du client.
    /// </summary>
    public const int FIRSTNAME_MAX_LENGTH = 64;
    /// <summary>
    /// Longueur maximale du nom de famille du client.
    /// </summary>
    public const int LASTNAME_MAX_LENGTH = 64;
    /// <summary>
    /// Longueur maximale du numéro de téléphone du client.
    /// </summary>
    public const int PHONE_MAX_LENGTH = 16;
    /// <summary>
    /// Longueur maximale de l'adresse email du client.
    /// </summary>
    public const int EMAIL_MAX_LENGTH = 128;

    private string nom = null!;
    private string prenom = null!;
    private string numeroTelephone = null!;
    private string email = null!;

    // Propriétés des clients
    public int Id { get; set; }
    public string Nom {
        get { return this.nom; }
        set {
            if (value.Length > LASTNAME_MAX_LENGTH) {
                throw new ArgumentException($"Le nom du client ne peut pas dépasser {LASTNAME_MAX_LENGTH} caractères.");
            }
            this.nom = value;
        }
    }
    public string Prenom {
        get { return this.prenom; }
        set {
            if (value.Length > FIRSTNAME_MAX_LENGTH) {
                throw new ArgumentException($"Le prénom du client ne peut pas dépasser {FIRSTNAME_MAX_LENGTH} caractères.");
            }
            this.prenom = value;
        }
    }
    public string NumeroTelephone {
        get { return this.numeroTelephone; }
        set {
            if (value.Length > PHONE_MAX_LENGTH) {
                throw new ArgumentException($"Le numéro de téléphone du client ne peut pas dépasser {PHONE_MAX_LENGTH} caractères.");
            }
            this.numeroTelephone = value;
        }
    }
    public string Email {
        get { return this.email; }
    }
}





    
