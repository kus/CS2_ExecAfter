# CS2_ExecAfter  
  
A plugin for CS2 built on [CounterStrikeSharp](https://docs.cssharp.dev/) that allows you to schedule commands to run on server events (i.e. after a map change) or with a delay.

## Requirements

In order for the plugin to work, you must have [CounterStrikeSharp](https://docs.cssharp.dev/guides/getting-started/) installed.

## Why

I run an [open source modded multi-mod dedicated CS2 server](https://github.com/kus/cs2-modded-server) and need a way to set configs to load on map changes dynamically. So when you change the mod to surf for example, every map load it will ensure the correct surf settings are loaded. Then if you change it to wingman it will make sure the wingman settings are loaded on every map.

## Installation

1) [Download](https://github.com/kus/CS2_ExecAfter/releases/) and open the zip file.
2) Extract the `addons` folder into your server's `game/csgo/` directory (this file should now exist `game/csgo/addons/counterstrikesharp/plugins/CS2_ExecAfter/CS2_ExecAfter.dll`)
3) Restart your server or from the server console run `css_plugins load "plugins/CS2_ExecAfter/CS2_ExecAfter.dll"`

## Commands

### exec_after

List commands for the plugin.

### exec_after_map_start

Executes a command after every map start.

`exec_after_map_start "<command>"` where `command` is a string i.e. `exec_after_map_start "exec surf_settings.cfg"`.

### exec_after_map_start_once

Executes a command after the next map start. This will only happen once and not on the subsequent map start.

`exec_after_map_start_once "<command>"` where `command` is a string i.e. `exec_after_map_start_once "exec surf_settings.cfg"`.

### exec_after_map_end

Executes a command every time the map ends.

`exec_after_map_end "<command>"` where `command` is a string i.e. `exec_after_map_end "exec surf_settings.cfg"`.

### exec_after_map_end_once

Executes a command when the map ends. This will only happen once and not on the subsequent map end.

`exec_after_map_end_once "<command>"` where `command` is a string i.e. `exec_after_map_end_once "exec surf_settings.cfg"`.

### exec_after_round_start

Executes a command after every round start.

`exec_after_round_start "<command>"` where `command` is a string i.e. `exec_after_round_start "exec surf_settings.cfg"`.

### exec_after_round_start_once

Executes a command the next time the round starts. This will only happen once and not on the subsequent round start.

`exec_after_round_start_once "<command>"` where `command` is a string i.e. `exec_after_round_start_once "exec surf_settings.cfg"`.

### exec_after_delay

`exec_after_delay <delay> "<command>"` where `delay` is a positive `int` or `float` and `command` is a string i.e. `exec_after_delay 10.5 "say Hello from the past!"`.
  
## Required Permissions

Permissions using CounterStrikeSharp's [admin framework](https://docs.cssharp.dev/admin-framework/defining-admins/) can be granted by adding the permission `@css/rcon` to the user in the `admins.json`.

| Command                       | Parameter               | Description                                      | Permissions |
|-------------------------------|-------------------------|--------------------------------------------------|-------------|
| `exec_after`                  |                         | List commands for the plugin                     |             |
| `exec_after_map_start`        | `"<command>"`           | Executes a command after every map start         | @css/rcon   |
| `exec_after_map_start_once`   | `"<command>"`           | Executes a command after the next map start      | @css/rcon   |
| `exec_after_map_end`          | `"<command>"`           | Executes a command every time the map ends       | @css/rcon   |
| `exec_after_map_end_once`     | `"<command>"`           | Executes a command when the map ends             | @css/rcon   |
| `exec_after_round_start`      | `"<command>"`           | Executes a command after every round start       | @css/rcon   |
| `exec_after_round_start_once` | `"<command>"`           | Executes a command after the next round start    | @css/rcon   |
| `exec_after_delay`            | `<delay>` `"<command>"` | Execute a command after a delay | @css/rcon      | @css/rcon   |

## Roadmap

- [ ] Add more server events if requested by the community

## License

Distributed under the GPL-3.0 License. See `LICENSE.txt` for more information.
