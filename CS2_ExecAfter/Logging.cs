using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Modules.Utils;

namespace CS2_ExecAfter
{
	public partial class CS2_ExecAfter
	{

		private void Log(string message)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"[{this.ModuleName}] {message}");
			Console.ResetColor();
		}

		private void ReplyToCommand(string message, CCSPlayerController? player = null, bool chat = false)
		{
			if (player != null)
			{
				player.PrintToConsole($"[{ChatColors.Green}{this.ModuleName}{ChatColors.White}]: {message}");
				if (chat)
				{
					player.PrintToChat($"[{ChatColors.Green}{this.ModuleName}{ChatColors.White}]: {message}");
				}
			}
			else
			{
				this.Log(message);
			}
		}

	}
}