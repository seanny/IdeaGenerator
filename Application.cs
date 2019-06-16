﻿//
// 	Copyright (C) 2019 Outlaw Games Studio. All Rights Reserved.
//
// 	This document is the property of Outlaw Games Studio.
// 	It is considered confidential and proprietary.
//
// 	This document may not be reproduced or transmitted in any form
// 	without the consent of Outlaw Games Studio.
//
using System;

namespace GameIdeaGenerator
{
    public class Application
    {
        private Genre m_Genre;
        private Setting m_Setting;
        private Niche m_Niche;

        public bool genreRandom { get; private set; }
        public bool settingRandom { get; private set; }
        public bool nicheRandom { get; private set; }

        private void ShowHelp()
        {
            Console.WriteLine($"Usage: {AppDomain.CurrentDomain.FriendlyName} [(optional) options]");
            Console.WriteLine($"\nOptions:");
            Console.WriteLine($"\t--genre=GENRE    \t\tSet the genre of the idea");
            Console.WriteLine($"\t--setting=SETTING\t\tSet the setting of the idea");
            Console.WriteLine($"\t--niche=SETTING  \t\tSet the niche of the idea");
            Console.WriteLine($"\nViewing:");
            Console.WriteLine($"\t--genres         \t\tShow all genre's");
            Console.WriteLine($"\t--settings       \t\tShow all setting's");
            Console.WriteLine($"\t--niches         \t\tShow all niche's");
        }

        public void StartApplication(string[] args)
        {
            m_Genre = new Genre();
            m_Setting = new Setting();
            m_Niche = new Niche();

            genreRandom = true;
            settingRandom = true;
            nicheRandom = true;
            foreach (string item in args)
            {
                if (item.StartsWith("--help"))
                {
                    ShowHelp();
                    return;
                }
                else if (item.StartsWith("--genres"))
                {
                    Console.WriteLine($"\nGenre's:");
                    Genre.ShowGenres();
                    return;
                }
                else if (item.StartsWith("--settings"))
                {
                    Console.WriteLine($"\nSettings:");
                    Setting.ShowSettings();
                    return;
                }
                else if (item.StartsWith("--niches"))
                {
                    Console.WriteLine($"\nNiche's:");
                    Niche.ShowNiche();
                    return;
                }
                else if(item.StartsWith("--genre="))
                {
                    genreRandom = false;
                    m_Genre.PickGenre(item);
                }
                else if (item.StartsWith("--setting="))
                {
                    settingRandom = false;
                    m_Setting.PickSetting(item);
                }
                else if (item.StartsWith("--niche="))
                {
                    nicheRandom = false;
                    m_Niche.PickNiche(item);
                }
            }

            if(genreRandom == true)
            {
                m_Genre.RandomGenre();
            }
            if (settingRandom == true)
            {
                m_Setting.RandomSetting();
            }
            if (nicheRandom == true)
            {
                m_Niche.RandomNiche();
            }
        }
    }
}