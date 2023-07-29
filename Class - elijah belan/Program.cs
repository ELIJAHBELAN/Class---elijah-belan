using System;

class MyAnime
{
    static void Main()
    {
        Console.WriteLine("Welcome to Anime Selector\n");

        AnimeSelector animeSelector = new AnimeSelector();
        WatchLaterList watchLaterList = new WatchLaterList();

        animeSelector.SelectAnime(watchLaterList);

        Console.WriteLine("Your Watch Later List:");
        foreach (string anime in watchLaterList.GetAnimeList())
        {
            Console.WriteLine(anime);
        }

        Console.WriteLine("\nThank you for using Anime Selector!");
    }
}