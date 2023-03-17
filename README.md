# Roblox Websocket Executor

A Roblox "executor", created using the Synapse X websocket library and a C# websocket server.

## How to use

> The URLs are still unavailable, I will upload a release on GitHub on March 17th.

To use the client, place the [script]() in your exploit's (I have only tested this using Synapse X) "autoexec" directory, and whenever you join a game in Roblox, it will start the client, which will try to connect to the server.

To use the server, download the [executor's ZIP]() onto your computer, extract it, and run the executable. It will start the server, and it will allow you to execute scripts.

### Demonstration

> Demonstration will also be available March 17th.

## Further explanation

There is a WebSocket server in C# user interface. When the user executes a script, it broadcasts to connected clients with the script they want to execute.

The client is written in Lua, on first execution, it will tell the server to execute files in the "autoexec" directory of the executor, it will also hook into the print, warn, and error function, and it will broadcast each output, to allow for an external console.

This isn't useful, and this serves as a proof of concept. However, this does have some advantages over using an API like [SXLib](https://github.com/XarienC/Synapse-X-Open-Source-UI) (Synapse X's library), such as being able to hook outputs like print or warn, for an external console in a custom UI, however you could probably do a combination of SXLib and websockets, as you wouldn't need to include the client in "autoexec", as SXLib could automatically execute that for you.

## Attribution

Here are a list of open-source libraries used by this project.

- [sta/websocket-sharp](https://github.com/sta/websocket-sharp): WebSocket library used
- [PavelTorgashov/FastColoredTextBox](https://github.com/PavelTorgashov/FastColoredTextBox): Syntax highlighted textbox used
