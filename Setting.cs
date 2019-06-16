//
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
    public class Setting
    {
        public enum SettingType
        {
            StoneAge,
            Ancient,
            Medieval,
            PostMedieval, // Around start of colonialism to start of 1700's
            Gunpowder, // 18th and 19th Century (1700's and 1800's)
            WorldWarOne,
            WorldWarTwo,
            Fifties, // 1950's
            Sixties, // 1960's
            Seventies, // 1970's
            Eigties, // 1980's
            Ninties, // 1990's
            Modern, // Our time period
            Futuristic,
        };

        public SettingType setting { get; private set; }

        public static void ShowSettings()
        {
            Console.WriteLine("\tStoneAge\n" +
                    "\tAncient\n" +
                    "\tMedieval\n" +
                    "\tPostMedieval\n" +
                    "\tGunPowder\n" +
                    "\tWorldWar1\n" +
                    "\tWorldWar2\n" +
                    "\t1950\n" +
                    "\t1960\n" +
                    "\t1970\n" +
                    "\t1980\n" +
                    "\t1990\n" +
                    "\tModern\n" +
                    "\tFuturistic\n");
        }

        public void PickSetting(string item)
        {
            if (item.EndsWith("StoneAge", StringComparison.OrdinalIgnoreCase))
            {
                SetSetting(SettingType.StoneAge);
            }
            else if (item.EndsWith("Ancient", StringComparison.OrdinalIgnoreCase))
            {
                SetSetting(SettingType.Ancient);
            }
            else if (item.EndsWith("Medieval", StringComparison.OrdinalIgnoreCase))
            {
                SetSetting(SettingType.Medieval);
            }
            else if (item.EndsWith("PostMedieval", StringComparison.OrdinalIgnoreCase))
            {
                SetSetting(SettingType.PostMedieval);
            }
            else if (item.EndsWith("GunPowder", StringComparison.OrdinalIgnoreCase))
            {
                SetSetting(SettingType.Gunpowder);
            }
            else if (item.EndsWith("WorldWar1", StringComparison.OrdinalIgnoreCase))
            {
                SetSetting(SettingType.WorldWarOne);
            }
            else if (item.EndsWith("WorldWar2", StringComparison.OrdinalIgnoreCase))
            {
                SetSetting(SettingType.WorldWarTwo);
            }
            else if (item.EndsWith("1950", StringComparison.OrdinalIgnoreCase))
            {
                SetSetting(SettingType.Fifties);
            }
            else if (item.EndsWith("1960", StringComparison.OrdinalIgnoreCase))
            {
                SetSetting(SettingType.Sixties);
            }
            else if (item.EndsWith("1970", StringComparison.OrdinalIgnoreCase))
            {
                SetSetting(SettingType.Seventies);
            }
            else if (item.EndsWith("1980", StringComparison.OrdinalIgnoreCase))
            {
                SetSetting(SettingType.Eigties);
            }
            else if (item.EndsWith("1990", StringComparison.OrdinalIgnoreCase))
            {
                SetSetting(SettingType.Ninties);
            }
            else if (item.EndsWith("Modern", StringComparison.OrdinalIgnoreCase))
            {
                SetSetting(SettingType.Modern);
            }
            else if (item.EndsWith("Futuristic", StringComparison.OrdinalIgnoreCase))
            {
                SetSetting(SettingType.Futuristic);
            }
            else
            {
                Console.WriteLine("❗ ERROR ❗: Invalid setting specified:");
                ShowSettings();
                return;
            }
        }

        public void RandomSetting()
        {
            Random random = new Random();
            SetSetting((SettingType)random.Next(12));
        }

        public void SetSetting(SettingType nicheType)
        {
            Console.WriteLine($"Setting set to {nicheType.ToString()}");
            setting = nicheType;
        }
    }
}
