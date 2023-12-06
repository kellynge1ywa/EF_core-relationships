using Many_to_Many.MDbContext;
using Many_to_Many.Many_Models;
try{
    // Create an instance of the context class
     using ManyDbContext DBcontext= new ManyDbContext();

    var Bookk=new List<Book>(){
        new Book(){Title="Intro to LLM", Description="Large Language Model"},
        new Book (){Title="Machine Learning", Description="Introduction to machine learning"}

    };
    DBcontext.Mbooks.AddRange(Bookk);
    DBcontext.SaveChanges();
    Console.WriteLine($"Books added successful");
    

    var Kelvin= new Author(){
        Name="Kelvin",
        Email="kelvin@gmail.com",
        Books=Bookk
    };
    DBcontext.MAuthors.Add(Kelvin);
    

    var Linton= new Author(){
        Name="Linton",
        Email="linton@gmail.com",
        Books=Bookk
    };
    DBcontext.MAuthors.Add(Linton);

    DBcontext.SaveChanges();
    Console.WriteLine($"Authors added successful");
    

}
catch (Exception ex){
    Console.WriteLine(ex.Message);
    

}