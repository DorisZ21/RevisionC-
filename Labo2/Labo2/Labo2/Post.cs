using System.IO.Compression;

namespace labo2;

public class Post
{
    private const int INC_LIKEDBY_SIZE = 3;
    private User author;
    private string contents;
    private DateTime date;
    private User[] likedBy = new User[INC_LIKEDBY_SIZE];
    private int nbLikes;

    public Post(User author, string contents, DateTime date)
    {
        this.author = author;
        this.contents = contents;
        this.date = date;
        this.author.AddPost();
    }
    
    public Post(User author,string contents) : this(author,contents,DateTime.Today){}

    public override string ToString()
    {
        return $"{author.ToString()} {this.contents} {this.date.Day} {this.date.Month} {this.date.Month}";
    }
    
    
}