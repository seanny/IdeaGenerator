//
//  Copyright (C) 2019 Outlaw Games Studio.
//
//  This document is licensed under MIT License by Outlaw Games Studio.
//
using System;
namespace GameIdeaGenerator
{
    public class Niche
    {
        public enum NicheType
        {
            Fantasy,
            Drama,
            Comedy,
            Romantic,
            Western,
            Detective,
            SciFi,
            Cartoon,
            Horror,
            Thriller,
            Action,
            Adventure
        };

        public NicheType niche { get; private set; }

        public static void ShowNiche()
        {
            Console.WriteLine("\tFantasy\n" +
                    "\tDrama\n" +
                    "\tComedy\n" +
                    "\tRomantic\n" +
                    "\tWestern\n" +
                    "\tDetective\n" +
                    "\tSciFi\n" +
                    "\tCartoon\n" +
                    "\tHorror\n" +
                    "\tThriller\n" +
                    "\tAction\n" +
                    "\tAdventure\n");
        }

        public void PickNiche(string item)
        {
            if (item.EndsWith("Fantasy", StringComparison.OrdinalIgnoreCase))
            {
                SetNiche(NicheType.Fantasy);
            }
            else if (item.EndsWith("Drama", StringComparison.OrdinalIgnoreCase))
            {
                SetNiche(NicheType.Drama);
            }
            else if (item.EndsWith("Comedy", StringComparison.OrdinalIgnoreCase))
            {
                SetNiche(NicheType.Comedy);
            }
            else if (item.EndsWith("Romantic", StringComparison.OrdinalIgnoreCase))
            {
                SetNiche(NicheType.Romantic);
            }
            else if (item.EndsWith("Western", StringComparison.OrdinalIgnoreCase))
            {
                SetNiche(NicheType.Western);
            }
            else if (item.EndsWith("Detective", StringComparison.OrdinalIgnoreCase))
            {
                SetNiche(NicheType.Detective);
            }
            else if (item.EndsWith("SciFi", StringComparison.OrdinalIgnoreCase))
            {
                SetNiche(NicheType.SciFi);
            }
            else if (item.EndsWith("Cartoon", StringComparison.OrdinalIgnoreCase))
            {
                SetNiche(NicheType.Cartoon);
            }
            else if (item.EndsWith("Horror", StringComparison.OrdinalIgnoreCase))
            {
                SetNiche(NicheType.Horror);
            }
            else if (item.EndsWith("Thriller", StringComparison.OrdinalIgnoreCase))
            {
                SetNiche(NicheType.Thriller);
            }
            else if (item.EndsWith("Action", StringComparison.OrdinalIgnoreCase))
            {
                SetNiche(NicheType.Action);
            }
            else if (item.EndsWith("Adventure", StringComparison.OrdinalIgnoreCase))
            {
                SetNiche(NicheType.Adventure);
            }
            else
            {
                Console.WriteLine("❗ ERROR ❗: Invalid niche specified:");
                ShowNiche();
                return;
            }
        }

        public void RandomNiche()
        {
            Random random = new Random();
            SetNiche((NicheType)random.Next(12));
        }

        public void SetNiche(NicheType nicheType)
        {
            Console.WriteLine($"Niche set to {nicheType.ToString()}");
            niche = nicheType;
        }
    }
}
