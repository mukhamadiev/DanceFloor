namespace DanceFloor.Domain.Impl
{
    using System.Linq;
    using Enum;

    /// <summary>
    ///     Поведение
    /// </summary>
    public class Behavior : IBehavior
    {
        /// <inheritdoc />
        public string Name => "Обычное поведение";

        /// <inheritdoc />
        public void Apply(IBehaviorContext behaviorContext, IDancer dancer)
        {
            var context = behaviorContext as BehaviorContext;

            var availableDance = dancer.AvailableDances
                .FirstOrDefault(d => d.AvailableGenres.Any(g => g == context.Genre));

            if (availableDance == null)
            {
                dancer.State = State.DrinkVodka;
                dancer.CurrentDance = null;
            }
            else
            {
                dancer.State = State.Dance;
                dancer.CurrentDance = availableDance;
            }
        }
    }
}