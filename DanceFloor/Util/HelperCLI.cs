using static System.Console;

namespace DanceFloor.Util
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Executor;
    using Executor.Impl;
    using Executor.Impl.Command;

    /// <summary>
    ///     Помощник для работы с консолью
    /// </summary>
    public class HelperCLI
    {
        private readonly List<Tuple<string, string, Action>> availableCommands;
        private readonly IClient client;
        private readonly Emulator emulator;

        /// <summary>
        ///     .ctor
        /// </summary>
        public HelperCLI()
        {
            this.client = new Client();
            this.emulator = Emulator.GetInstance();

            this.availableCommands = new List<Tuple<string, string, Action>>
            {
                new Tuple<string, string, Action>("help", "Помощь", this.Help),
                new Tuple<string, string, Action>("start", "Запустить клуб", this.StartClub),
                new Tuple<string, string, Action>("next", "Следующий трек", this.Next),
                new Tuple<string, string, Action>("dancers", "Получить информацию о посетителях", this.Dancers),
                new Tuple<string, string, Action>("track", "Получить информацию о текущем треке", this.Track)
            };
        }

        /// <summary>
        ///     Запустить
        /// </summary>
        public void Start()
        {
            this.Help();

            this.Input();
        }

        private void Help()
        {
            var textBuilder = new StringBuilder();
            textBuilder.AppendLine("Список доступных команд: ");

            foreach (var command in this.availableCommands)
                textBuilder.AppendLine($"{command.Item1} - {command.Item2}");

            WriteLine(textBuilder.ToString());
        }

        private void StartClub()
        {
            this.client.SetCommand(new ClubInitCommand(this.emulator));

            var result = this.client.Execute();
            WriteLine(result.Message);

            this.client.SetCommand(new ClubStartCommand(this.emulator));

            result = this.client.Execute();
            WriteLine(result.Message);
        }

        private void Dancers()
        {
            this.client.SetCommand(new DancersReportCommand(this.emulator.Reporter));

            var result = this.client.Execute();
            WriteLine(result.Message);
        }

        private void Track()
        {
            this.client.SetCommand(new TrackReportCommand(this.emulator.Reporter));

            var result = this.client.Execute();
            WriteLine(result.Message);
        }

        private void Next()
        {
            this.client.SetCommand(new NextTrackCommand(this.emulator));

            var result = this.client.Execute();
            WriteLine(result.Message);
        }

        private void Input()
        {
            Write("Введите команду: ");

            var input = ReadLine();
            var command = this.availableCommands
                .FirstOrDefault(c => c.Item1 == input);

            if (command == null)
            {
                WriteLine("Команда не распознана");
                this.Input();
            }
            else
            {
                if (command.Item1 != "start" && command.Item1 != "help")
                {
                    if (this.emulator.Club == null)
                    {
                        WriteLine("Необходимо запустить клуб");
                        this.Input();
                    }
                }

                command.Item3();
                this.Input();
            }
        }
    }
}