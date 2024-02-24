namespace Task8;

public class Post
{ 
public string Title { get; set; } 
public string Description { get; set; } 
public int LikeCount = 0; 
List<string>_comments=new List<string>(); 
public bool IsPublished { get; set; }  
public void Publish() 
{ 
    System.Console.WriteLine("The post is published."); 
    IsPublished=true;

}
public void Like()
{
    LikeCount++;
} 
public void Comment(string message)
{
    _comments.Add(message);
} 
public string GetInfo()
{
    return $"{Title}  {Description}  number of Likes: {LikeCount}";
}
}
