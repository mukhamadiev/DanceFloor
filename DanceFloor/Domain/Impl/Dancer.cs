namespace DanceFloor.Domain.Impl
{
    using System.Collections.Generic;
    using System.Text;
    using Enum;

    /// <summary>
    ///     Посетитель
    /// </summary>
    public class Dancer : IDancer
    {
        /// <inheritdoc />
        public string Name { get; set; }

        /// <inheritdoc />
        public Sex Sex { get; set; }

        /// <inheritdoc />
        public IList<IDance> AvailableDances { get; set; }

        /// <inheritdoc />
        public State State { get; set; } = State.NotSet;

        /// <inheritdoc />
        public IDance CurrentDance { get; set; }

        /// <inheritdoc />
        public override string ToString()
        {
            var state = string.Empty;
            switch (this.State)
            {
                case State.NotSet:
                    state = "потерян";
                    break;
                case State.Dance:
                    var textBuilder = new StringBuilder();
                    textBuilder.Append($"танцует {this.CurrentDance.Name}. Его движения: ");

                    foreach (var motion in this.CurrentDance.Motions)
                        textBuilder.Append($"{motion} ");

                    state = textBuilder.ToString();
                    break;
                case State.DrinkVodka:
                    state = "пьет водку у бара";
                    break;
                default:
                    state = "потерян";
                    break;
            }
            return $"Посетитель {this.Name} {state}";
        }
    }
}