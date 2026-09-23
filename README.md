# Console RPG (C#)

A console-based role-playing game written in C#. This project is being developed incrementally, beginning with the hero system and expanding toward a complete turn-based RPG experience.

> **Project status:** Hero selection, hero data, monster stats, and the stage system are implemented. The battle system is planned for the next development session.

## Current Progress

### ✅ Heroes — Completed

The current version includes a complete hero selection flow:

- Six hero classes:
  - Warrior
  - Mage
  - Marksman
  - Tank
  - Assassin
  - Healer
- Four selectable heroes for each class, for a total of **24 heroes**.
- Individual hero statistics:
  - Health Points (`HP`)
  - Attack (`ATK`)
  - Defence (`DEF`)
  - Speed (`SPD`)
  - Mana
  - Special ability
- Class-based hero selection through the console.
- Hero stat display after a selection is made.
- Case-insensitive hero data lookup using a dictionary.
- Invalid class selections are handled by prompting the player again.

### ✅ Monster Stats — Completed

The project now includes the foundation for enemies and monsters:

- Monster data and names
- Monster statistics
- Monster abilities
- Monster encounters prepared for future combat

### ✅ Stage System — Completed

A stage system has been added to organize the game's progression:

- Structured stages for monster encounters
- Progression through multiple stages
- A foundation for connecting stages to the future battle system

## Hero Classes

| Class | Playstyle | Example Abilities |
| --- | --- | --- |
| Warrior | Strong frontline fighters with balanced offensive and defensive stats. | Cleave, War Cry |
| Mage | Powerful spellcasters with high mana and magical abilities. | Fireball, Lightning Strike |
| Marksman | Ranged attackers focused on speed and precision. | Piercing Shot, Rain of Arrows |
| Tank | Durable defenders with high health and defence. | Shield Bash, Fortify |
| Assassin | Fast, high-damage heroes designed to strike quickly. | Backstab, Shadow Strike |
| Healer | Support heroes with healing-focused abilities and high mana. | Heal, Holy Light |

## Planned Development

### 🔜 Battle System — Next

The next development session will focus on integrating the battle system, including:

- Hero-versus-monster combat
- Turn order and speed-based actions
- Attack, defend, healing, and ability actions
- Mana and ability costs
- Damage calculation using hero and monster stats
- Monster AI
- Victory and defeat conditions
- Stage completion and progression after battles

### Future Features

- Multiple battles or adventure stages
- Improved input validation
- Better project structure using separate classes and files
- Additional heroes, monsters, abilities, and stages

## Project Structure

```text
Console-RPG-C-/
└── RPG.cs       # Current console RPG implementation
```

## Getting Started

### Requirements

- [.NET SDK](https://dotnet.microsoft.com/download) compatible with the project
- A C# development environment such as Visual Studio, Visual Studio Code, or JetBrains Rider

### Run the Project

1. Clone the repository:

   ```bash
   git clone https://github.com/anish155/Console-RPG-C-.git
   ```

2. Open the project in your preferred C# development environment.
3. Build and run the application.
4. Choose a hero class and then select a hero from the available options.
5. Review the selected hero's statistics and ability in the console.
6. Progress through the available stages and review the monster encounters.

## Development Notes

This project is being built as a learning-focused C# console application. The current implementation focuses on practising:

- Methods
- Dictionaries
- Tuples
- Switch expressions
- Console input and output
- Basic validation and control flow
- Organizing monsters and encounters into stages

The codebase will be refactored as the game expands so that heroes, monsters, combat, stages, and game flow can be maintained independently.

## License

No license has been added yet. Add a license when the project is ready to define how others may use, modify, and distribute the code.
