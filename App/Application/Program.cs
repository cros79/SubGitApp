namespace Cros.SubRepoApp.Application {
    using System;
    using Cros.SubRepoLib.Utilities;

    class Program {
        static void Main(string[] args) {
            Console.WriteLine(General.SerializeJson(new {Hejkon = "Bacon"}));
            Console.ReadLine();
        }
    }
}
