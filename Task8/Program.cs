using Task8; 


var post1=new Post();
    post1.Title="Memories from tarvel";
    post1.Description="Travel in Pamir";   
      
    
     
 
 var post2=new Post();
    post2.Title="Memories from tarvel";
    post2.Description="Travel in Hisor";   
    

    var post3=new Post();
    post3.Title="Memories from tarvel";
    post3.Description="Travel in Khujand";   
    

    var post4=new Post();
    post4.Title="Memories from tarvel";
    post4.Description="Travel in Kulob";   
    

     var post5=new Post();
    post5.Title="Memories from tarvel";
    post5.Description="Travel in Dushanbe";   
    
    List<Post>_post=new List<Post>();  

    _post.Add(post1); 
     post1.Publish(); 
    post1.Comment("Wonderful");  
    post1.Like(); 
    post1.Like(); 
    post1.Like(); 
    post1.Like(); 


    _post.Add(post2);  
    post2.Publish(); 
    post2.Comment("Wonderful");   
    post2.Like(); 

    _post.Add(post3); 
    post3.Publish(); 
    post3.Comment("Wonderful");   
    post3.Like(); 

    _post.Add(post4); 
    post4.Publish(); 
    post4.Comment("Wonderful");   
    post4.Like();
     post4.Like(); 

    _post.Add(post5); 
    post5.Publish(); 
    post5.Comment("Wonderful");  
    post5.Like();  
    post5.Like(); 
    post5.Like(); 
 foreach (var item in _post)
    {
        System.Console.WriteLine($"{item.Title} – {item.Description} – number of Likes: {item.LikeCount}"); 
        System.Console.WriteLine("---------------------------------------------------------------");
    }

     