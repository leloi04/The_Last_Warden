# ⚔️ The Last Warden

<p align="center">
  <strong>A 3D Action RPG set in a mysterious techno-fantasy dungeon.</strong>
  <br />
  Explore ancient ruins, battle mechanical enemies, and uncover the secrets hidden within the Nexus.
</p>

<p align="center">
  <img src="https://img.shields.io/badge/Unity-6-black?style=for-the-badge&logo=unity" alt="Unity 6" />
  <img src="https://img.shields.io/badge/Language-C%23-blue?style=for-the-badge&logo=csharp" alt="C Sharp" />
  <img src="https://img.shields.io/badge/Platform-Windows%20%7C%20Android-green?style=for-the-badge" alt="Windows and Android" />
  <img src="https://img.shields.io/badge/3D-Blender-orange?style=for-the-badge&logo=blender" alt="Blender" />
</p>

---

## 🎮 About The Game

**The Last Warden** is a 3D Action RPG developed with Unity 6. Set in a mysterious techno-fantasy world, the game combines action-oriented combat, exploration, and atmospheric environmental design.

Players venture through ancient ruins and technologically advanced dungeons, fight mechanical enemies, collect resources, and uncover the secrets of a forgotten civilization.

This project has been expanded from its original PC-focused version to support **both Windows PC and Android**, bringing the dungeon adventure to desktop and mobile players.

## ✨ Features

- **⚔️ Action RPG Combat** — Engage in real-time battles against mechanical enemies.
  - Melee enemies that pursue and attack at close range.
  - Ranged enemies that attack from a distance.
  - Dash and dodge mechanics to avoid incoming attacks.

- **🧭 Exploration** — Explore stylized environments, navigate dungeon areas, and discover paths through ancient ruins.

- **💚 Collectibles and Survival** — Collect health packs and coins while progressing through dangerous areas.

- **🎬 Animated Main Menu** — A 3D main menu featuring atmospheric environments, camera movement, and lighting.

- **🌌 Immersive Environments** — Techno-fantasy landscapes, ruins, environmental lighting, and atmospheric effects.

- **🖥️ Windows PC Support** — Play using keyboard and mouse controls.

- **📱 Android Support** — Play on compatible Android devices with mobile input controls.

## 🕹️ Platforms

| Platform | Support |
|---|---|
| Windows PC | Supported |
| Android | Supported |

> **Note:** Android compatibility and performance may vary depending on the device. Use a packaged Android build to install the game on a compatible device.

## 📸 Gallery

### Main Menu

Features a 3D background with atmospheric lighting and animated elements.

<img width="100%" src="https://github.com/user-attachments/assets/c47ae4aa-f465-4984-bf3e-089ba2b541ae" alt="The Last Warden - Main Menu" />

### Dungeon Combat

Fight mechanical enemies in the depths of the dungeon.

<img width="100%" src="https://github.com/user-attachments/assets/8bf5b7e5-2062-4f2f-9a2e-bdfc2c6f822e" alt="The Last Warden - Dungeon Combat" />

### Exploration and Collectibles

Explore the environment, defeat enemies, and collect resources.

<img width="100%" src="https://github.com/user-attachments/assets/3c8caacc-f104-49dc-9285-9ca0068960be" alt="The Last Warden - Exploration and Collectibles" />

### Environment Design

Explore stylized 3D environments featuring ruins, structures, and atmospheric lighting.

<img width="100%" src="https://github.com/user-attachments/assets/7710555b-dcad-4b70-8b42-c4bfbfef6df5" alt="The Last Warden - Environment Design" />

## 🎮 Controls

### Windows PC

| Key | Action |
|---|---|
| `W` `A` `S` `D` | Move the character |
| Left Mouse Button | Attack / Slash |
| `Space` | Dash / Dodge |
| `E` | Interact / Pick Up |
| `Esc` | Open or close the pause menu |

### Android

The Android version uses on-screen touch controls where available.

- Use the movement control to navigate the environment.
- Use the attack button to fight enemies.
- Use the dash/dodge control to evade attacks.
- Use interaction controls when available.

*Mobile control availability and layout depend on the current Android build.*

## 🛠️ Built With

| Technology | Purpose |
|---|---|
| Unity 6 | Game engine |
| C# | Gameplay programming |
| Blender | 3D modeling and asset creation |
| Unity Animator | Character animation |
| Unity UI | Menus and in-game interface |
| Android Build Support | Android deployment |

## 🚀 Getting Started

### Prerequisites

To open and edit the project, install:

- [Unity Hub](https://unity.com/download)
- A compatible Unity 6 Editor version
- Visual Studio or another compatible C# IDE
- Android Build Support, Android SDK & NDK Tools, and OpenJDK if you intend to build the Android version

### Clone the Repository

```bash
git clone https://github.com/leloi04/The_Last_Warden.git
```

### Open the Project

1. Open Unity Hub.
2. Select **Add** or **Add project from disk**.
3. Choose the cloned `The_Last_Warden` folder.
4. Open the project using a compatible Unity Editor version.
5. Wait for Unity to import the project assets.
6. Locate and open the main menu scene in the Project window.
7. Press **Play** to run the game in the Unity Editor.

### Build for Windows

1. Open **File → Build Profiles**.
2. Select the Windows desktop platform.
3. Ensure the required game scenes are included in the build.
4. Configure the Player Settings if necessary.
5. Build the game and run the generated executable.

### Build for Android

1. Open **File → Build Profiles**.
2. Select the Android platform.
3. Switch to the Android build profile.
4. Ensure the required scenes are included in the build.
5. Check the Android Player Settings, including package name and target architecture.
6. Connect a compatible Android device with USB debugging enabled, or build an APK for installation.
7. Select **Build** or **Build and Run**.

For Android distribution, configure the package identifier and signing settings appropriate to your release.

## 📂 Project Structure

The project is organized around Unity assets, scenes, gameplay components, and project settings.

```text
The_Last_Warden/
├── Assets/
│   ├── Animators/
│   ├── Game/
│   │   ├── GameLevel01/
│   │   ├── GameLevel02/
│   │   ├── GameLevel03/
│   │   ├── Prefabs/
│   │   └── asset-collect/
│   ├── Scenes/
│   ├── Scripts/
│   └── ...
├── Packages/
├── ProjectSettings/
└── README.md
```

*The folder names above illustrate the project organization; exact locations may differ between project versions.*

## 🎯 Project Goals

The project focuses on:

- Developing a playable 3D action RPG.
- Implementing character movement, combat, and dodge mechanics.
- Integrating character animations and gameplay interactions.
- Designing immersive 3D environments.
- Extending the game to support both desktop and mobile platforms.
- Exploring cross-platform deployment using Unity.

## 📄 License and Credits

This project is maintained by **leloi04**.

The game is a remake and extension of an existing Unity project. Original code, assets, and third-party resources may remain subject to their respective licenses and attribution requirements.

- **Project repository:** [The Last Warden](https://github.com/leloi04/The_Last_Warden)
- **Original project reference:** [MYTHICAL_DUNGEON](https://github.com/Priyanksolanki9853/MYTHICAL_DUNGEON)

Please review the applicable licenses before redistributing the project or its assets.

---

<p align="center">
  <strong>THE LAST WARDEN</strong>
  <br />
  <em>The dungeon is only the beginning.</em>
</p>
