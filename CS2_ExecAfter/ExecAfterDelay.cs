using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes.Registration;
using CounterStrikeSharp.API.Modules.Commands;
using CounterStrikeSharp.API.Modules.Admin;

namespace CS2_ExecAfter
{
	public partial class CS2_ExecAfter
	{

		[ConsoleCommand("exec_after_delay", "Execute a command after a delay")]
		[RequiresPermissions("@css/rcon")]
		public void ConVarExecAfterDelay(CCSPlayerController? player, CommandInfo command)
		{
			if (command.ArgCount >= 3)
			{
				string delayArgs = command.ArgByIndex(1);
				if (!float.TryParse(delayArgs, out float delayValue) || delayValue < 0)
				{
					ReplyToCommand($"Invalid value for exec_after_delay. Please specify a valid non-negative number. exec_after_delay <delay> \"<command>\"", player);
					return;
				}
				string args = command.ArgString.Trim();
				int trimChars = delayArgs.ToString().Length + 1;
				string commandToExecute = StripQuotes(args.Substring(trimChars, args.Length - trimChars));
				if (string.IsNullOrWhiteSpace(commandToExecute))
				{
					ReplyToCommand($"Invalid value for exec_after_delay. Please specify a valid command to execute. exec_after_delay <delay> \"<command>\"", player);
					return;
				}
				ReplyToCommand($"Executing \"{commandToExecute}\" in {delayValue} seconds.", player);
				AddTimer(delayValue, () => {
					ReplyToCommand($"Executing \"{commandToExecute}\"", player);
					Server.ExecuteCommand(commandToExecute);
				});
			}
			else
			{
				ReplyToCommand($"exec_after_delay <delay> \"<command>\"", player);
			}
		}

	}
}