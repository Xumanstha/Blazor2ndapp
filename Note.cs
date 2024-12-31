
public class NoteItem
{
    public string? Title{get;set;}
    public string? Descriptions{get;set;}
   public bool IsEdit{get;set;}=false;
    public NoteItem(string T,string D)
    {
        Title=T;
        Descriptions=D;
    }
}