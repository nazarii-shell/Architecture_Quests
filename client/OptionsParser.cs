namespace lab4;

public class OptionsParser
{
    static public void ParseOption(Option request)
    {
        Console.Clear();
        switch (request.Method)
        {
            case "GET":
                switch (request.URl)
                {
                    case "quest":
                        Pages.SearchQuests();
                        break;
                }

                break;
            case "PUT":
                switch (request.URl)
                {
                    case "bookQuest":
                        Pages.BookQuest();
                        break;
                }
                break;
        }
    }
}