namespace DanceFloor.Util
{
    using System.ComponentModel;

    /// <summary>
    ///     Расширения
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        ///     Получить значение атрибута <see cref="DescriptionAttribute" />
        /// </summary>
        /// <typeparam name="T">Тип</typeparam>
        /// <param name="value">Значение</param>
        public static string GetDescription<T>(this T value)
        {
            var enumType = typeof(T);
            var field = enumType.GetField(value.ToString());
            var attributes = field.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length == 0 ? value.ToString() : ((DescriptionAttribute) attributes[0]).Description;
        }
    }
}