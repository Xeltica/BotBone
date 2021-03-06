using System.Threading.Tasks;
using BotBone.Core.Api;

namespace BotBone.Core
{
	/// <summary>
	/// これを実装することで、コマンドとして使用できます。
	/// </summary>
	public interface ICommand
	{
		string Name { get; }
		string[] Aliases { get; }
		bool IgnoreCase { get; }
		PermissionFlag Permission { get; }
		string Usage { get; }
		string Description { get; }

		Task<string> OnActivatedAsync(ICommandSender sender, Server core, IShell shell, string[] args, string body);
	}
}
