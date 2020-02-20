﻿using System;
using System.Threading.Tasks;
using BotBone.Core;

namespace BotBone.Discord
{
	class Program
    {
        static async Task Main(string[] args)
        {
			Console.WriteLine("BotBont version " + Server.Version);
			var logger = new Logger("Bootstrap");
			logger.Info("BotBone.Discord " + Shell.Version);
			var sh = await Shell.InitializeAsync();
			logger.Info("シェルを初期化しました！");
			logger.Info("起動しました！");

			await Task.Delay(-1);
        }
    }
}
