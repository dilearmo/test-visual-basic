namespace Exame2_CS
{
    public static class ExtensionMethods
    {
        public static bool IsNotNullOrEmpty(this string value) {
            return !string.IsNullOrEmpty(value);
        }
    }
}
