using lab4.controllers;

namespace lab4;

public class Pages
{
    static public void SearchQuests()
    {
        Console.WriteLine("Enter your search query: ");
        var query = Console.ReadLine();
        var quests = QuestController.SearchQuests(query);
        foreach (var quest in quests)
        {
            Console.WriteLine(quest);
        }
    }

    static public void BookQuest()
    {
        Console.WriteLine("Enter quest ID: ");
        var id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter people count: ");
        var people_count = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your time: ");
        var time = TimeOnly.Parse(Console.ReadLine());

        Console.WriteLine("Do you have gitf card: y/n");
        var haveGiveCard = Console.ReadLine().ToLower() == "y" ? true : false;

        try
        {
            var quest = QuestController.BookQuest(id, people_count, time, haveGiveCard);

            if (quest.price == 0)
            {
                Console.WriteLine($"Quest {quest.name} was booked. Cost is ${quest.price}");
            }
            else
            {
                Console.WriteLine($"Quest {quest.name} was booked. Cost is $0");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}