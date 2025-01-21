namespace labo2;

public class User
{
    private string login;
    private string password;
    private DateTime joinDate;
    private int postCount;

    public User(string login, string password, DateTime joinDate)
    {
        this.login = login;
        this.password = password;
        this.joinDate = joinDate;
    }

    public User(string login, string password) : this(login, password, DateTime.Today){}

    public string GetLogin()
    {
        return this.login;
    }

    public void SetLogin(string newLogin)
    {
        if (ForumUtils.ValidLogin(newLogin))
        {
            this.login = newLogin;   
        }
    }
    
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
}