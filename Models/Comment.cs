namespace api.Models;

public class Comment
{


    public int Id { get; set; }
    public String Title { get; set; } = String.Empty;

    public String Content { get; set; } = String.Empty;

    public DateTime DateCreated { get; set; } 
    public int? StockId { get; set; }
    //navgation
    public Stock? Stock { get; set; } 



}
