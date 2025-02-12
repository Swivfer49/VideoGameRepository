﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameRepository.Classes
{
    internal class VideoGameRepository
    {
        public HashSet<VideoGame> VideoGames { get; set; } = new();
        public HashSet<VideoGameConsole> Consoles { get; set; } = new();
        public HashSet<Publisher> Publishers { get; set; } = new();
        public HashSet<Studio> Studios { get; set; } = new();

        public VideoGameRepository()
        {
            Studio coffeeStainStudio = new("Coffee Stain Studios", 1_000_000);
            Studio monolithSoft = new("Monolith Soft", 1_000_000);
            Studio halLabs = new("HAL Laboratories", 1_000_000);

            Studios.Add(coffeeStainStudio);
            Studios.Add(monolithSoft);
            Studios.Add(halLabs);
            
            Publisher coffeeStainPublishing = new("Coffee Stain Publishing", 1_000_000);
            Publisher nintendo = new("Nintendo", 100_000_000);

            Publishers.Add(coffeeStainPublishing);
            Publishers.Add(nintendo);

            VideoGameConsole pc = new("PC", 1500, 20, true);
            VideoGameConsole wiiU = new("Wii U", 400, 8, true);
            VideoGameConsole nSwitch = new("Switch", 400, 8, true);

            Consoles.Add(pc);
            Consoles.Add(wiiU);
            Consoles.Add(nSwitch);

            VideoGame satisfactory = new(
                title: "Satisfactory",
                category: "Simulation",
                year: 2018,
                playerCount: 4,
                price: 40f,
                studio: coffeeStainStudio,
                consoles: new() { pc },
                publisher: coffeeStainPublishing,
                ageRating: 10
            );
            VideoGames.Add(satisfactory);

            coffeeStainStudio.AddGame(satisfactory);
            coffeeStainPublishing.AddStudio(coffeeStainStudio);
            pc.AddGame(satisfactory);

            VideoGame xenoblade = new(
                title: "Xenoblade Chronicles: Definitive Edition",
                category: "JRPG",
                year: 2020,
                playerCount: 1,
                price: 80f,
                studio: monolithSoft,
                consoles: new() { nSwitch },
                publisher: nintendo,
                ageRating: 12
            );

            VideoGame xenoblade2 = new(
                title: "Xenoblade Chronicles 2",
                category: "JRPG",
                year: 2017,
                playerCount: 1,
                price: 80f,
                studio: monolithSoft,
                consoles: new() { nSwitch },
                publisher: nintendo,
                ageRating: 12
            );

            VideoGame xenoblade3 = new(
                title: "Xenoblade Chronicles 3",
                category: "JRPG",
                year: 2022,
                playerCount: 1,
                price: 80f,
                studio: monolithSoft,
                consoles: new() { nSwitch },
                publisher: nintendo,
                ageRating: 12
            );

            VideoGame xenobladeX = new(
                title: "Xenoblade Chronicles X",
                category: "JRPG",
                year: 2015,
                playerCount: 1,
                price: 80f,
                studio: monolithSoft,
                consoles: new() { wiiU },
                publisher: nintendo,
                ageRating: 12
            );

            VideoGame forgottenLand = new(
                title: "Kirby and the Forgotten Land",
                category: "3D Platformer",
                year: 2022,
                playerCount: 1,
                price: 80f,
                studio: halLabs,
                consoles: new() { nSwitch },
                publisher: nintendo,
                ageRating: 7
            );

            VideoGames.Add(xenoblade);
            VideoGames.Add(xenoblade2);
            VideoGames.Add(xenoblade3);
            VideoGames.Add(xenobladeX);
            VideoGames.Add(forgottenLand);

            monolithSoft.AddGame(xenoblade);
            monolithSoft.AddGame(xenoblade2);
            monolithSoft.AddGame(xenoblade3);
            monolithSoft.AddGame(xenobladeX);

            halLabs.AddGame(forgottenLand);

            nSwitch.AddGame(xenoblade);
            nSwitch.AddGame(xenoblade2);
            nSwitch.AddGame(xenoblade3);
            nSwitch.AddGame(forgottenLand);

            wiiU.AddGame(xenobladeX);

        }
    }
}
