//
//  Copyright (C) 2019 Outlaw Games Studio.
//
//  This document is licensed under MIT License by Outlaw Games Studio.
//
using System;
namespace GameIdeaGenerator
{
    public class Genre
    {
        public enum GenreType
        {
            Puzzle,
            RPG,
            Simulation,
            Adventure,
            Shooter,
            Action,
            Strategy,
            FPS,
            Sport
        };

        public GenreType genre { get; private set; }

        public static void ShowGenres()
        {
            Console.WriteLine("\tPuzzle\n" +
                    "\tRPG\n" +
                    "\tSim\n" +
                    "\tAdventure\n" +
                    "\tAction\n" +
                    "\tStrategy\n" +
                    "\tFPS\n" +
                    "\tSport\n");
        }

        public void RandomGenre()
        {
            Random random = new Random();
            SetGenre((GenreType)random.Next(9));
        }

        public void SetGenre(GenreType genreType)
        {
            Console.WriteLine($"Genre set to {genreType.ToString()}");
            genre = genreType;
        }

        public void PickGenre(string item)
        {
            if (item.EndsWith("puzzle", StringComparison.OrdinalIgnoreCase))
            {
                SetGenre(Genre.GenreType.Puzzle);
            }
            else if (item.EndsWith("rpg", StringComparison.OrdinalIgnoreCase))
            {
                SetGenre(Genre.GenreType.RPG);
            }
            else if (item.EndsWith("sim", StringComparison.OrdinalIgnoreCase) || item.EndsWith("simulation", StringComparison.OrdinalIgnoreCase))
            {
                SetGenre(Genre.GenreType.Simulation);
            }
            else if (item.EndsWith("adventure", StringComparison.OrdinalIgnoreCase))
            {
                SetGenre(Genre.GenreType.Adventure);
            }
            else if (item.EndsWith("action", StringComparison.OrdinalIgnoreCase))
            {
                SetGenre(Genre.GenreType.Action);
            }
            else if (item.EndsWith("strategy", StringComparison.OrdinalIgnoreCase))
            {
                SetGenre(Genre.GenreType.Strategy);
            }
            else if (item.EndsWith("fps", StringComparison.OrdinalIgnoreCase))
            {
                SetGenre(Genre.GenreType.FPS);
            }
            else if (item.EndsWith("sport", StringComparison.OrdinalIgnoreCase))
            {
                SetGenre(Genre.GenreType.Sport);
            }
            else
            {
                Console.WriteLine("❗ ERROR ❗: Invalid genre specified:");
                ShowGenres();
                return;
            }
        }
    }
}
