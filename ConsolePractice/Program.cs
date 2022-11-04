﻿using ConsolePractice.Evil;
using Game;

Console.WriteLine("     #########################");
Console.WriteLine("     ## ULTRA DUNGEON QUEST ##");
Console.WriteLine("     #########################");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.Write("What is your name, sire? Please enter: ");
string playerName = Console.ReadLine();
Player player = new Player(playerName);
Console.WriteLine(player.GetPlayerStatus());
Console.WriteLine();
Monster monster = new Monster();
Console.WriteLine("You begin your quest by delving into the first floor of the ultra dungeon...");
Console.ReadKey();
Console.WriteLine($"Ah! You encounter {monster.Name}! It is the {monster.Description} you were hired to slay");
Console.ReadKey();
Console.WriteLine();
monster.MonsterEncounter(player, monster);
Console.WriteLine($"Game over! You attained a score of {player.Score}");
Console.ReadKey();
return;

//Thinking a while loop for player hp
//
//while (player.HP > 0)
//{Do one loop of the adventure}