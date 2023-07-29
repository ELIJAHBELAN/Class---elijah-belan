using System;
using System.Collections.Generic;

class WatchLaterList
{
    private List<string> animeList;

    public WatchLaterList()
    {
        animeList = new List<string>();
    }

    public void AddAnimeToWatchLater(string genre)
    {
        Console.Write("Enter the number of the anime you want to save and watch later (5 to exit): ");
        int animeChoice = Convert.ToInt32(Console.ReadLine());

        if (animeChoice == 5)
            return;

        if (animeChoice >= 1 && animeChoice <= 3)
        {
            animeList.Add(genre + " - Anime " + animeChoice);
            Console.WriteLine("Added to your watch later list.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid anime number.");
        }
    }

    public List<string> GetAnimeList()
    {
        return animeList;
    }
}