namespace labo2;

public class User
{
    private string login;
    private int password;
    private DateTime joinDate;
    private int postCount;

    public User(string login, string password, DateTime joinDate)
    {
        this.login = login;
        this.Password = password; // Cette écriture permet d'utiliser le setter dans le constructeur
        this.joinDate = joinDate;
    }

    public User(string login, string password) : this(login, password, DateTime.Today){}
    
    public void AddPost() // Par convention le nom des méthode doit commencer par une majuscule.
    {
        this.postCount++;
    }
    
    public override string ToString()
    {
        return
            $"{this.login} (password : {this.password}), {this.joinDate.Day}-{this.joinDate.ToString("MMM")}-" +
            $"{this.joinDate.ToString("yy")} - {this.postCount} post";
    }
    
    /*
     * Dans les conventions propre au C# reposent sur un autre mécanisme que les getter et les setter pour protéger
     * l'accès aux données privées (c'est à dire pour l'encapsulation) => L'utilisation de propriétés
     * On peut voir les propriétés comme un mécanisme permettant d'utiliser les donnée privée comme si elle était publique
     */

    
    /*
     * Par convention le nom est le nom de l'attribut avec une majuscule
     */
    public string Login
    {
        get
        {
            return this.login;
        }
        set
        {
            if (ForumUtils.ValidLogin(value))
            {
                this.login = value; // L'identificateur value est utilisé pour représenter la valeur qu'on tente d'attribuer à la propriété
            }
        }
    }
    
    // Il est possible de créé une propriété que pour get ou set 

    public int PostCount
    {
        get
        {
            return postCount;
        }
    }

    private bool ValidePassword(int password)
    {
        return password == this.password;
    }

    public int Encode(string password)
    {
        int somme = 0;
        
        foreach (var letter in password)
        {
            somme += (int)letter;
        }

        somme %= 997;
        
        Console.WriteLine(somme);

        return somme;

    }
    public string Password
    {
        set
        {
            if (ValidePassword(Encode(value)))
            {
                this.password = Encode(value);
            }
        }
    }
    
    
    
}