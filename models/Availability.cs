namespace lab4;

public class Availability
{
    public int id { get; set; }

    public int quest_id { get; set; }

    public string weekday { get; set; }

    public TimeOnly start_time { get; set; }

    public TimeOnly end_time { get; set; }
}
