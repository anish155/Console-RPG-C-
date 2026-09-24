# Console RPG (C#)

A console-based role-playing game written in C#. This project is being developed incrementally, beginning with hero selection and progressing toward a complete RPG experience.

> **Project status:** Hero selection, hero and monster data, stage generation, a prototype battle arena, player movement, monster movement, spawn points, and map boundaries are currently implemented. The project is still a prototype and will be refactored into a more object-oriented structure as development continues.

## Current Progress

### ✅ Heroes — Completed

The current version includes a hero selection flow with:

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
- Invalid class selections handled by prompting the player again.

### ✅ Monster Stats — Completed

The project includes a foundation for enemies and monsters:

- Monster names and data
- Monster statistics
- Monster abilities
- Attack types, races, and tiers
- Monster encounters prepared for combat

### ✅ Stage System — Completed

A stage system has been added to organize game progression:

- Stages from 1 to 50
- Different monster pools based on stage difficulty
- Low-tier, mid-tier, strong mid-tier, and boss monsters
- A final boss encounter at Stage 50
- Random monster selection for each stage

### 🚧 Battle Arena Prototype — In Progress

A first prototype of the battle and movement system has been added. The current arena includes:

- A player spawn point
- A monster spawn point
- A bounded play area represented as a grid
- Player movement using `W`, `A`, `S`, and `D`
- Boundary checking so the player cannot leave the map
- Automatic monster movement toward the player
- A movement delay for the monster
- Player dash and dodge prototypes
- Left mouse button attack input on Windows
- Visual map symbols for the player, monster, shared positions, and boundaries

Current controls:

| Input | Action |
| --- | --- |
| `W` / `A` / `S` / `D` | Move the player |
| `Shift` | Dash prototype |
| `Ctrl` | Dodge prototype |
| Left mouse button | Attack prototype |
| `Esc` | Exit the battle arena |

The current battle implementation is an early prototype. The attack action currently detects input but still needs to be connected to health, damage, range, and combat results.

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

### Near-Term Goals

The next development session will focus on completing the current prototype and connecting the systems together:

- Add the application's `Main` entry point and complete the game flow.
- Connect hero selection to the battle arena.
- Connect stage monster selection to each battle.
- Add real player and monster health tracking.
- Make attacks apply damage.
- Add attack range and collision checks.
- Trigger combat when the player and monster meet.
- Add victory and defeat conditions.
- Allow the player to progress to the next stage after winning.
- Improve input handling and prevent invalid input from crashing the game.

### Combat Features

- Hero-versus-monster combat
- Turn order and speed-based actions
- Basic attacks
- Defending and healing
- Special abilities and mana costs
- Damage calculation using attack and defence statistics
- Monster AI and attack behaviour
- Battle messages and combat feedback
- Stage completion and progression

### Object-Oriented Refactor

The current implementation is intentionally being built as a single-file prototype for learning and experimentation. After the prototype is further completed, the code will be refactored into an object-oriented structure, potentially including:

- `Hero` and hero subclasses or class data
- `Monster` and monster subclasses or class data
- `BattleSystem`
- `Player`
- `Stage`
- `Map` or `BattleArena`
- `Ability`
- Separate files for game flow, input handling, movement, and combat

This refactor should make the project easier to maintain, extend, and test.

### Future Features

- Multiple battles within each stage
- More maps and arena layouts
- Obstacles and map terrain
- Improved movement and collision detection
- Better dash and dodge behaviour
- Ranged attacks and attack directions
- More heroes, monsters, abilities, and stages
- Save and load functionality
- Improved console presentation
- Cross-platform input support
- Audio or graphical improvements if the project later moves beyond the console

## Project Structure

```text
Console-RPG-C-/
└── RPG.cs       # Current prototype implementation
```

The project currently uses a single C# file while the core systems are being developed. The structure will be separated into multiple classes and files during the planned object-oriented refactor.

## Getting Started

### Requirements

- [.NET SDK](https://dotnet.microsoft.com/download) compatible with the project
- A C# development environment such as Visual Studio, Visual Studio Code, or JetBrains Rider
- Windows is currently recommended for the mouse input prototype because it uses `user32.dll`

### Run the Project

1. Clone the repository:

   ```bash
   git clone https://github.com/anish155/Console-RPG-C-.git
   ```

2. Open the project in your preferred C# development environment.
3. Build and run the application.
4. Choose a hero class and then select a hero from the available options.
5. Review the selected hero's statistics and ability in the console.
6. Enter the battle prototype and use the movement controls to explore the bounded arena.
7. Test the player and monster movement systems.

## Development Notes

This project is being built as a learning-focused C# console application. The current implementation focuses on practising:

- Methods
- Dictionaries
- Tuples
- Switch expressions
- Console input and output
- Basic validation and control flow
- Random monster selection
- Stage progression
- Grid-based movement
- Spawn points and map boundaries
- Basic real-time input handling
- Windows mouse input through platform interop

The current single-file design is temporary. As the game expands, heroes, monsters, combat, stages, maps, input, and game flow will be maintained independently through an object-oriented project structure.

## License

No license has been added yet. Add a license when the project is ready to define how others may use, modify, and distribute the code.
