
using System;
using System.Text;

/* Espace de noms est une structure hiérarchique groupant
des classes par utilité ou par contexte d'utilisation*/
namespace labo1; 


/*
 En c# deux grandes catégorie coexistent : les classes
 (permettant de construire des objets) et les structures
 (dont les valeurs sont générées en mémoire de manière différentes
 des objets). Le terme type est une application générique pour les classes
 et les structures.
 */

/*
 En c#, la comparaison des chaines de caractère se fait par égalité (==) et non via equals
 Par défaut les variables de type string sont initialisées à null.
 */

public class Player
{
        private const int MAX_SKILL_RATING = 5000;
        private const int MIN_SKILL_RATING = 1;
        // Par défaut les attributs standard sont initialisés au zéro du type.
        // La visibilité par défaut des attributs si on ne spécifie rien est privé.
        // Mais pour plus de clarté autant la spécifier par défaut.
        private string firstName;
        private string lastName;
        private DateTime birthday;
        private int skillRating;
        private bool sponsored;

        // Ceci est un constructeur et avec la visibilité en public pour qu'il soit accessible depuis l'extérieur
        public Player(string firstName, string lastName, DateTime birthday, bool isRanked)
        {
            // membre de gauche attribut et membre de droite paramètre.
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
            this.skillRating = isRanked ? 1 : 0; // Opération ternaire pour initialiser skillRating
        }
        
        // Création d'un deuxième constructeur qui utilise le premier constructeur
        // Cette façon d'écrire un deuxième constructeur permet de faire un point de modification unique.
        public Player(string firstName, string lastName, DateTime birthday) 
            : this(firstName,lastName,birthday,true){}

        
        /* il faut notez que tous les attributs n'auront pas forcément un modificateur (setter)
        ou et un acesseur (getter) : un programmeur prudent réfléchit à ce qu'il va rendre accessible
        et pour qui.
        */
        public string GetName()
        {
            return this.lastName + " " + this.firstName;
        }

        public string GetDate()
        {
            // Grâce à la class DateTime il est possible de récupérer le jours (.Day) le mois (.Month) et l'année (.Year)
            return this.birthday.Day + " " + this.birthday.Month + " " + this.birthday.Year;
        }

        public void SetRanked(int skillRating)
        {
            if (!IsRanked())
            {
                this.skillRating = skillRating;
            }
        }

        // Fonction uniquement accessible dans la class Player
        private bool IsRanked()
        {
            return this.skillRating > 0;
        }

        public void ModifySkillRating(int numberOfPoint)
        {
            int adjustedPoints;
            if (IsRanked())
            {
                adjustedPoints = this.skillRating + numberOfPoint;
                if (adjustedPoints > MAX_SKILL_RATING)
                {
                    adjustedPoints = MAX_SKILL_RATING;
                }else if (adjustedPoints < MIN_SKILL_RATING)
                {
                    adjustedPoints = MIN_SKILL_RATING;
                }

                this.skillRating = adjustedPoints;
            }
        }
        
        
        // Le mot clef override permet de réecrire (écrire par dessus une méthode déja existante)
        public override string ToString()
        {
            // String Builder permet de construire une chaine de caractère en c#
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nom et prénom : {this.lastName} {this.firstName}");
            // AppendLine permet de créer une nouvelle ligne et donc de passer à la ligne (\n).
            sb.AppendLine($"Date de naissance : {this.birthday.Day} {this.birthday.Month} {this.birthday.Year}");
            sb.AppendLine($"{((IsRanked()) ? "compétiteur" : "Non compétiteur")}");

            // Dans ce contexte .ToString permet de mettre en forme la chaine au moment de la renvoyer.
            return sb.ToString();
            // base.ToString() correspond à super.ToString() en Java.
        }
}

