# Guess-the-Name-Game
Welcome to the Guess the Name repository! This project is a client/server application developed in C# for playing a word guessing game with multiple players over a network.

## About
Guess the Name is an interactive word guessing game where players connect to a central server, create or join game rooms, and compete to guess a randomly selected word. The game features turn-based gameplay, real-time updates, and the ability to watch ongoing games.

## Features
- **Client/Server Architecture**: Utilizes a client/server model for multiplayer gameplay.
- **Player Management**: Maintain a list of connected players and available game rooms on the server.
- **Game Room Creation/Joining**: Players can create new game rooms or join existing ones.
- **Game Configuration**: Customize game settings such as word categories and room size.
- **Real-time Gameplay**: Players take turns guessing letters, with the game state updated in real-time for all participants.
- **Game Watching**: Allow players to watch ongoing games in rooms they have joined.
- **Game Results**: Store game results in a text file on the server PC, including player names and game outcomes.

## How to Play
1. **Connect to the Server**: Run the server application to start hosting games. Players can connect to the server using the client application.
2. **Create or Join a Room**: Players can create new game rooms with custom settings or join existing rooms with available slots.
3. **Gameplay**: Once two players have joined a room, a word is randomly selected, and the game begins. Players take turns guessing letters until one player guesses the entire word.
4. **End of Game**: Results are displayed, and players can choose to play again or leave the room. Game results are stored on the server PC for future reference.

## Contributing
Contributions to Guess the Name are welcome! Whether you're interested in adding new features, fixing bugs, improving documentation, or suggesting ideas, your contributions are valuable. Follow the contribution guidelines in the repository to get started.

## Technologies Used
- C# for client and server applications
- .NET Framework for WinForms GUI development
- Socket programming for client-server communication
- File I/O for storing game results
