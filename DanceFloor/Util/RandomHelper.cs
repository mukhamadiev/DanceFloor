namespace DanceFloor.Util
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     Помощник для получения случайных значений
    /// </summary>
    public static class RandomHelper
    {
        private static readonly Random random = new Random();

        /// <summary>
        ///     Получить случайный элемент списка
        /// </summary>
        /// <typeparam name="T">Тип</typeparam>
        /// <param name="list">Список</param>
        public static T GetRandomElement<T>(List<T> list)
        {
            var index = random.Next(list.Count - 1);

            return list[index];
        }
    }
}