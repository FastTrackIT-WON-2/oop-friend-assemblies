namespace FriendAssemblies.Library
{
    internal static class StringToIntConverter
    {
        internal static int ConvertStringToInt(string str, int defaultValue)
        {
            if (string.IsNullOrEmpty(str))
            {
                return defaultValue;
            }

            bool canConvert = int.TryParse(str, out int convertedValue);
            if (!canConvert)
            {
                return defaultValue;
            }

            return convertedValue;
        }
    }
}
