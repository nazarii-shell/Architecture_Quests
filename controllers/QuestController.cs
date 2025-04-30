using lab4.services;

namespace lab4.controllers;

public class QuestController
{
    public static List<Quest> SearchQuests(string query)
    {
        var foundQuests = QuestService.SearchQuests(query);
        return foundQuests;
    }

    public static Quest BookQuest(int questId, int people_count, TimeOnly time, Boolean haveGiveCard)
    {
        var updatedQuest = QuestService.BookQuest(questId, people_count, time, haveGiveCard);
        return updatedQuest;
    }
}