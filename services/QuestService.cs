using lab4.data;
using Microsoft.EntityFrameworkCore;

namespace lab4.services;

public class QuestService
{
    private static AppDbContext db = new AppDbContext();

    public static List<Quest> SearchQuests(string query)
    {
        var quests = db.Quest.Where(q => q.name.Contains(query)).ToList();
        return quests;
    }

    public static Quest BookQuest(int questId, int people_count, TimeOnly time, Boolean haveGiveCard)
    {
        var availabilities = db.Availability.Where(a => a.quest_id == questId).ToList();
        var outOfTimeRangeExist = availabilities.Any(a => a.start_time > time || a.end_time < time);
        var quest = db.Quest.Where(q => q.id == questId).ToList()[0];

        if (outOfTimeRangeExist)
        {
            var availableTime = "";

            foreach (var availability in availabilities)
            {
                availableTime += $"{availability.start_time} - {availability.end_time}; ";
            }

            throw new Exception($"Time is invalid. Available timer is {availableTime}");
        } else if (quest.partisipants_limit < people_count)
        {
            throw new Exception($"People count is not supported. Quest supports limit of {quest.partisipants_limit}.");
        }
        else if (haveGiveCard)
        {
            quest.price = 0;
            return quest;
        }
        else
        {
            return quest;
        }
    }
}