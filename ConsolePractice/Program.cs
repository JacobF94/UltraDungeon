using ConsolePractice.Evil;
using Game;

Console.WriteLine("     ############################");
Console.WriteLine("     ## ULTIMATE DUNGEON QUEST ##");
Console.WriteLine("     ############################");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.Write("What is your name, sire? Please enter: ");
string name = Console.ReadLine();
while(string.IsNullOrEmpty(name))
{
    Console.Write("Please enter a valid name: ");
    name = Console.ReadLine();
}
Player player = new(name);
player.Spells.Add(new Spell());
Console.WriteLine(player.GetPlayerStatus());
Console.WriteLine();
int turnCounter = 0;
while (player.Health > 0)
{
    turnCounter++;
    Monster monster = new Monster();
    monster.HP = player.Level * 10;
    monster.Str = player.Level * 3;
    monster.Speed = player.Level * 2;
    Random rnd = new();
    int PlayerHealth = player.Health;
    foreach (var item in player.Armors)
    {
        PlayerHealth += item.Value;
    }
    Console.WriteLine($"{player.Name}'s total health is {PlayerHealth}");
    Console.WriteLine($"{player.Name} readies his/her weapon and spells, and approaches {monster.Name}...");
    int diceroll = rnd.Next(1, 6);
    if (diceroll == 6)
    {
        Console.WriteLine("Aha! You manage to sneak up on the monster and launch a sneak attack!");
        Console.WriteLine($"You deal roughly 10% damage to {monster.Name}...");
        double sneak = monster.HP * .9;
        monster.HP = (int)Math.Round(sneak);
    }
    while (monster.HP > 0)
    {
        BeginPhase:
        if (player.Spells.Count > 0)
        {
            int attack = 0;
            Console.WriteLine("Do you cast a spell, or use your melee weapon?");
            Console.WriteLine("[1] Weapon  [2] Spell");
            try
            {
                bool v = new int[] { 1, 2 }.Contains(Convert.ToInt32(Console.ReadLine()));
                attack = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("please enter either 1 or 2");
                goto BeginPhase;
            }
            if (attack == 1)
            {

            }
        }
        else
        {
            Console.Write("");
        }
    }
    DeathCheck:
    if (player.Health <= 0)
    {
        Console.WriteLine($"Game over! You attained a score of {player.Score}");
        Console.ReadKey();
        return;
    }
    else
    {
        Console.WriteLine("This is the post combat section to go to town and shop");
    }
}