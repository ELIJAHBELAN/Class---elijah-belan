using System;

class AnimeSelector
{
    public void SelectAnime(WatchLaterList watchLaterList)
    {
        while (true)
        {
            Console.WriteLine("Select Your Preferred Genre\n");
            Console.WriteLine("Select 1 to watch Shounen");
            Console.WriteLine("Select 2 to watch Isekai");
            Console.WriteLine("Select 3 to watch Sports");
            Console.WriteLine("Select 4 to watch Rom Com\n");

            Console.WriteLine("Enter Genre: ");
            int choiceNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            string genre = "";
            string[] animeList = null;

            switch (choiceNum)
            {
                case 1:
                    genre = "Shounen";
                    animeList = new string[]
                    {
                        "Hunter x Hunter",
                        "One Piece",
                        "Naruto"
                    };
                    break;
                case 2:
                    genre = "Isekai";
                    animeList = new string[]
                    {
                        "Dr. Stone",
                        "Mushoku Tensei",
                        "That Time I Got Reincarnated As A Slime"
                    };
                    break;
                case 3:
                    genre = "Sports";
                    animeList = new string[]
                    {
                        "Haikyu!",
                        "Kuroko No Basket",
                        "Blue Lock"
                    };
                    break;
                case 4:
                    genre = "Rom Com";
                    animeList = new string[]
                    {
                        "Kaguya-Sama Love Is War",
                        "Horimiya",
                        "Fruit Basket"
                    };
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a valid genre number.\n");
                    continue;
            }

            Console.WriteLine(genre + "\n");
            Console.WriteLine("These Are The Top 3 " + genre + " Anime You Can Watch\n");

            for (int i = 0; i < animeList.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + animeList[i]);
            }

            Console.WriteLine();
            watchLaterList.AddAnimeToWatchLater(genre);
            Console.WriteLine();

            Console.Write("Would you like to pick another genre? (yes/no): ");
            string pickAnotherGenre = Console.ReadLine();
            Console.WriteLine();

            if (pickAnotherGenre.ToLower() != "yes")
                break;
        }
    }
}