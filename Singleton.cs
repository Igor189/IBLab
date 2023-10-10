namespace IBLab1
{
    public static class Singleton<T> where T : new()
    {
        private static T? value;
        public static T GetValue()
        {
            if (value == null)
            {
                value = new T();
            }

            return value;
        }
    }
}
