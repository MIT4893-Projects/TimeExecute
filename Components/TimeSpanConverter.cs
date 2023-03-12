namespace TimeExecute.Components
{
    /// <summary>
    /// Provides convert functions for converting TimeSpans into human-readable strings.
    /// </summary>
    static class TimeSpanConverter
    {
        /// <summary>
        /// Convert TimeSpan object into string with M:SS.FFF time format.
        /// </summary>
        /// <param name="time">TimeSpan object to be convert.</param>
        /// <returns>Human-readable M:SS.FFF time format string.</returns>
        public static string ToMinuteSecond(TimeSpan time)
        {
            return time.ToString(@"m\:ss\.fff");
        }

        /// <summary>
        /// Convert TimeSpan object into string with S.FFF time format.
        /// </summary>
        /// <param name="time">TimeSpan object to be convert.</param>
        /// <returns>Human-readable S.FFF time format string.</returns>
        public static string ToSecond(TimeSpan time)
        {
            return time.ToString(@"s\.fff");
        }
    }
}
