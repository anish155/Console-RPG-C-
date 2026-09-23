namespace myGamme;

class Program
{
    static string Character_class()
    {
        Console.WriteLine("classes of heroes");
        Console.WriteLine("1. Warrior");
        Console.WriteLine("2. Mage");
        Console.WriteLine("3. Marksman");
        Console.WriteLine("4. Tank");
        Console.WriteLine("5. Assassin");
        Console.WriteLine("6.Healer");
        return Console.ReadLine();
    }
    static Dictionary<string, (string Class, int HP, int ATK, int DEF, int SPD, int Mana, string Ability)> Character_stats()
    {
        return new Dictionary<string, (string Class, int HP, int ATK, int DEF, int SPD, int Mana, string Ability)>(StringComparer.OrdinalIgnoreCase)
        {
            // =========================
        // WARRIORS
        // =========================

        ["Lucifer"] = ("Warrior", 150, 50, 40, 60, 80, "Cleave"),
        ["Darius"] = ("Warrior", 170, 55, 45, 50, 70, "War Cry"),
        ["Kael"] = ("Warrior", 140, 65, 35, 70, 75, "Blade Storm"),
        ["Ragnar"] = ("Warrior", 190, 45, 55, 45, 60, "Berserker Rage"),


        // =========================
        // MAGES
        // =========================

        ["Merina"] = ("Mage", 100, 70, 30, 50, 120, "Fireball"),
        ["Elara"] = ("Mage", 90, 85, 25, 60, 140, "Lightning Strike"),
        ["Zephyr"] = ("Mage", 110, 65, 35, 75, 110, "Wind Burst"),
        ["Nyx"] = ("Mage", 80, 95, 20, 65, 150, "Shadow Blast"),


        // =========================
        // MARKSMEN
        // =========================

        ["Lark"] = ("Marksman", 120, 60, 20, 70, 60, "Piercing Shot"),
        ["Raven"] = ("Marksman", 110, 75, 25, 80, 70, "Rain of Arrows"),
        ["Kira"] = ("Marksman", 100, 85, 15, 90, 65, "Rapid Fire"),
        ["Vex"] = ("Marksman", 130, 55, 30, 65, 80, "Explosive Arrow"),


        // =========================
        // TANKS
        // =========================

        ["Goaliath"] = ("Tank", 200, 30, 80, 40, 40, "Shield Bash"),
        ["Borin"] = ("Tank", 230, 25, 90, 30, 35, "Fortify"),
        ["Thorne"] = ("Tank", 210, 40, 75, 45, 50, "Earth Slam"),
        ["Brutus"] = ("Tank", 250, 35, 70, 25, 30, "Taunt"),


        // =========================
        // ASSASSINS
        // =========================

        ["Spencer"] = ("Assassin", 80, 90, 25, 85, 50, "Backstab"),
        ["Shade"] = ("Assassin", 75, 100, 20, 100, 60, "Shadow Strike"),
        ["Zane"] = ("Assassin", 90, 85, 30, 95, 55, "Deadly Dash"),
        ["Viper"] = ("Assassin", 70, 110, 15, 105, 65, "Venom Strike"),


        // =========================
        // HEALERS
        // =========================

        ["Arc"] = ("Healer", 110, 40, 35, 65, 100, "Heal"),
        ["Luna"] = ("Healer", 130, 30, 45, 55, 130, "Holy Light"),
        ["Seraph"] = ("Healer", 120, 45, 40, 70, 120, "Divine Blessing"),
        ["Eira"] = ("Healer", 100, 50, 30, 80, 140, "Regeneration")
    
        };
    }

    static void DisplayHeroStats(string selectedHero, Dictionary<string, (string Class, int HP, int ATK, int DEF, int SPD, int Mana, string Ability)> heroes)
    {
        if (selectedHero is null)
        {
            Console.WriteLine("Invalid hero choice.");
            return;
        }

        if (heroes.TryGetValue(selectedHero, out var stats))
        {
            Console.WriteLine("Hero: " + selectedHero);
            Console.WriteLine("Class: " + stats.Class);
            Console.WriteLine("HP: " + stats.HP);
            Console.WriteLine("ATK: " + stats.ATK);
            Console.WriteLine("DEF: " + stats.DEF);
            Console.WriteLine("SPD: " + stats.SPD);
            Console.WriteLine("Mana: " + stats.Mana);
            Console.WriteLine("Ability: " + stats.Ability);
        }
    }

    static void Character_Selection()
    {
        Console.WriteLine("==========HERO SELECTION==========");
        Console.WriteLine("1.Warrior");
        Console.WriteLine("2.Mage");
        Console.WriteLine("3.Marksman");
        Console.WriteLine("4.Tank");
        Console.WriteLine("5.Assassin");
        Console.WriteLine("6.Healer");
        Console.WriteLine("Please select your hero class:");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
    {
        // =========================
        // WARRIOR
        // =========================

        case 1:
            Console.WriteLine("You have selected Warrior class.");

            Console.WriteLine("Available Warriors:");
            Console.WriteLine("1. Lucifer");
            Console.WriteLine("2. Darius");
            Console.WriteLine("3. Kael");
            Console.WriteLine("4. Ragnar");
            Console.WriteLine("Please select your hero:");

            int warriorChoice = int.Parse(Console.ReadLine());

            string selectedWarrior = warriorChoice switch
            {
                1 => "Lucifer",
                2 => "Darius",
                3 => "Kael",
                4 => "Ragnar",
                _ => null
            };

            Console.WriteLine("You selected: " + selectedWarrior);
            DisplayHeroStats(selectedWarrior, Character_stats());
            break;


        // =========================
        // MAGE
        // =========================

        case 2:
            Console.WriteLine("You have selected Mage class.");

            Console.WriteLine("Available Mages:");
            Console.WriteLine("1. Merina");
            Console.WriteLine("2. Elara");
            Console.WriteLine("3. Zephyr");
            Console.WriteLine("4. Nyx");
            Console.WriteLine("Please select your hero:");

            int mageChoice = int.Parse(Console.ReadLine());

            string selectedMage = mageChoice switch
            {
                1 => "Merina",
                2 => "Elara",
                3 => "Zephyr",
                4 => "Nyx",
                _ => null
            };

            Console.WriteLine("You selected: " + selectedMage);
            DisplayHeroStats(selectedMage, Character_stats());
            break;


        // =========================
        // MARKSMAN
        // =========================

        case 3:
            Console.WriteLine("You have selected Marksman class.");

            Console.WriteLine("Available Marksmen:");
            Console.WriteLine("1. Lark");
            Console.WriteLine("2. Raven");
            Console.WriteLine("3. Kira");
            Console.WriteLine("4. Vex");
            Console.WriteLine("Please select your hero:");

            int marksmanChoice = int.Parse(Console.ReadLine());

            string selectedMarksman = marksmanChoice switch
            {
                1 => "Lark",
                2 => "Raven",
                3 => "Kira",
                4 => "Vex",
                _ => null
            };

            Console.WriteLine("You selected: " + selectedMarksman);
            DisplayHeroStats(selectedMarksman, Character_stats());
            break;


        // =========================
        // TANK
        // =========================

        case 4:
            Console.WriteLine("You have selected Tank class.");

            Console.WriteLine("Available Tanks:");
            Console.WriteLine("1. Goaliath");
            Console.WriteLine("2. Borin");
            Console.WriteLine("3. Thorne");
            Console.WriteLine("4. Brutus");
            Console.WriteLine("Please select your hero:");

            int tankChoice = int.Parse(Console.ReadLine());

            string selectedTank = tankChoice switch
            {
                1 => "Goaliath",
                2 => "Borin",
                3 => "Thorne",
                4 => "Brutus",
                _ => null
            };

            Console.WriteLine("You selected: " + selectedTank);
            DisplayHeroStats(selectedTank, Character_stats());
            break;


        // =========================
        // ASSASSIN
        // =========================

        case 5:
            Console.WriteLine("You have selected Assassin class.");

            Console.WriteLine("Available Assassins:");
            Console.WriteLine("1. Spencer");
            Console.WriteLine("2. Shade");
            Console.WriteLine("3. Zane");
            Console.WriteLine("4. Viper");
            Console.WriteLine("Please select your hero:");

            int assassinChoice = int.Parse(Console.ReadLine());

            string selectedAssassin = assassinChoice switch
            {
                1 => "Spencer",
                2 => "Shade",
                3 => "Zane",
                4 => "Viper",
                _ => null
            };

            Console.WriteLine("You selected: " + selectedAssassin);
            DisplayHeroStats(selectedAssassin, Character_stats());
            break;


        // =========================
        // HEALER
        // =========================

        case 6:
            Console.WriteLine("You have selected Healer class.");

            Console.WriteLine("Available Healers:");
            Console.WriteLine("1. Arc");
            Console.WriteLine("2. Luna");
            Console.WriteLine("3. Seraph");
            Console.WriteLine("4. Eira");
            Console.WriteLine("Please select your hero:");

            int healerChoice = int.Parse(Console.ReadLine());

            string selectedHealer = healerChoice switch
            {
                1 => "Arc",
                2 => "Luna",
                3 => "Seraph",
                4 => "Eira",
                _ => null
            };

            Console.WriteLine("You selected: " + selectedHealer);
            DisplayHeroStats(selectedHealer, Character_stats());
            break;


        // =========================
        // INVALID
        // =========================

        default:
            Console.WriteLine("Invalid choice. Please select a valid hero class.");
            Character_Selection();
            break;
    }

    }

    static Dictionary<string, (string AttackType, string Race, string Tier, int Hp, int Atk, int Def, int Spd, string Ability)> Monster_stats()
{
    return new Dictionary<string, (string AttackType, string Race, string Tier, int Hp, int Atk, int Def, int Spd, string Ability)>(StringComparer.OrdinalIgnoreCase)
    {
        // ==================== BEASTS ====================

        ["Goblin"] = ("Melee", "Beast", "Low", 80, 20, 10, 30, "Slash"),
        ["Orc"] = ("Melee", "Beast", "Mid", 120, 30, 20, 25, "Smash"),
        ["Troll"] = ("Melee", "Beast", "Mid", 150, 40, 30, 20, "Regenerate"),
        ["Dire Wolf"] = ("Melee", "Beast", "Low", 90, 30, 10, 45, "Savage Bite"),
        ["Ogre"] = ("Melee", "Beast", "Mid", 200, 45, 35, 15, "Ground Slam"),
        ["Werebear"] = ("Melee", "Beast", "Mid", 220, 50, 40, 20, "Feral Roar"),

        // ==================== UNDEAD ====================

        ["Skeleton"] = ("Melee", "Undead", "Low", 60, 15, 5, 20, "Bone Throw"),
        ["Zombie"] = ("Melee", "Undead", "Low", 90, 20, 10, 15, "Infectious Bite"),
        ["Vampire"] = ("Melee", "Undead", "Mid", 100, 25, 15, 40, "Life Drain"),
        ["Ghoul"] = ("Melee", "Undead", "Low", 75, 25, 8, 35, "Claw Rend"),
        ["Wraith"] = ("Ranged", "Undead", "Mid", 110, 40, 15, 45, "Soul Drain"),
        ["Lich"] = ("Ranged", "Undead", "Boss", 280, 65, 35, 30, "Death Bolt"),

        // ==================== ELEMENTALS ====================

        ["Fire Elemental"] = ("Ranged", "Elemental", "Mid", 130, 45, 20, 35, "Flame Burst"),
        ["Ice Elemental"] = ("Ranged", "Elemental", "Mid", 140, 35, 30, 25, "Frost Nova"),
        ["Storm Elemental"] = ("Ranged", "Elemental", "Mid", 120, 50, 15, 50, "Lightning Strike"),
        ["Earth Golem"] = ("Melee", "Elemental", "Mid", 250, 35, 60, 10, "Rock Smash"),

        // ==================== DEMONS ====================

        ["Imp"] = ("Ranged", "Demon", "Low", 70, 25, 8, 40, "Fire Bolt"),
        ["Hellhound"] = ("Melee", "Demon", "Mid", 140, 45, 20, 45, "Infernal Bite"),
        ["Demon"] = ("Melee", "Demon", "Mid", 180, 50, 30, 30, "Demonic Strike"),
        ["Demon Lord"] = ("Ranged", "Demon", "Boss", 400, 60, 50, 45, "Hellfire Blast"),

        // ==================== DRAGONS ====================

        ["Drake"] = ("Melee", "Dragon", "Mid", 180, 45, 30, 35, "Dragon Claw"),
        ["Wyvern"] = ("Ranged", "Dragon", "Mid", 200, 55, 25, 45, "Poison Breath"),
        ["Ancient Dragon"] = ("Ranged", "Dragon", "Boss", 500, 80, 60, 40, "Ancient Flame"),

        // ==================== SPECIAL ====================

        ["Minotaur"] = ("Melee", "Mythic", "Mid", 230, 55, 40, 25, "Axe Charge"),
        ["Gargoyle"] = ("Melee", "Mythic", "Mid", 180, 35, 50, 20, "Stone Skin"),
        ["Cyclops"] = ("Ranged", "Mythic", "Boss", 350, 70, 45, 20, "Eye Beam")
    };
}
static string GetMonsterForStage(
        int stage,
        Random random,
        Dictionary<string, (string AttackType, string Race, string Tier, int Hp, int Atk, int Def, int Spd, string Ability)> monsters)
    {
        if (stage < 1 || stage > 50)
        {
            throw new ArgumentOutOfRangeException(nameof(stage), "Stages must be between 1 and 50.");
        }

        var lowMonsters = monsters
            .Where(monster => monster.Value.Tier == "Low")
            .Select(monster => monster.Key)
            .ToList();

        var midMonsters = monsters
            .Where(monster => monster.Value.Tier == "Mid")
            .Select(monster => monster.Key)
            .ToList();

        var strongMidMonsters = monsters
            .Where(monster => monster.Value.Tier == "Mid" &&
                              (monster.Value.Hp >= 180 || monster.Value.Atk >= 50 || monster.Value.Def >= 40))
            .Select(monster => monster.Key)
            .ToList();

        var bossMonsters = monsters
            .Where(monster => monster.Value.Tier == "Boss")
            .Select(monster => monster.Key)
            .ToList();

        List<string> pool;

        if (stage == 50)
        {
            pool = bossMonsters;
        }
        else if (stage <= 10)
        {
            pool = lowMonsters.Concat(lowMonsters).Concat(lowMonsters).Concat(midMonsters).ToList();
        }
        else if (stage <= 20)
        {
            pool = lowMonsters.Concat(midMonsters).ToList();
        }
        else if (stage <= 30)
        {
            pool = lowMonsters.Concat(midMonsters).Concat(midMonsters).Concat(midMonsters).ToList();
        }
        else if (stage <= 40)
        {
            pool = midMonsters.Concat(strongMidMonsters).ToList();
        }
        else
        {
            pool = strongMidMonsters;
        }

        return pool[random.Next(pool.Count)];
    }

    static void Stages()
    {
        Random random = new Random();
        var monsters = Monster_stats();

        for (int stage = 1; stage <= 50; stage++)
        {
            string monster = GetMonsterForStage(stage, random, monsters);
            string stageLabel = stage == 50 ? "Final Boss" : $"Stage {stage}";

            Console.WriteLine($"{stageLabel}: {monster}");
        }
    }
}