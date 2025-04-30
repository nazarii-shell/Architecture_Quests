namespace lab4;

public class Quest
{
    public int id { get; set; }
    public string name { get; set; }

    public int partisipants_limit { get; set; }

    public int price { get; set; }

    public override string ToString()
    {
        return $"Id: {id}, Name: {name}, Price: {price}";
    }
}

