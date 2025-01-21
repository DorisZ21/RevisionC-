namespace labo2;

public static class ForumUtils
{
    // Ceci est la déclaration d'une constante public donc accessible partout en c#
    public static string[] FORBIDDEN_LOGINS = new [] { "", "fart","dodo"};

    // Il est interdit d'avoir des methodes autres que static dans une classe statique.
    public static bool ValidLogin(string login)
    {
        // Mettre en minuscule aussi non c# fait la différence entre les minuscules et les majuscules 
        login = login.ToLower();
        return !Array.Exists(FORBIDDEN_LOGINS, element => element == login);
    }
}