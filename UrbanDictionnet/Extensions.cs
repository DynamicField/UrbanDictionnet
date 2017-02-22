namespace UrbanDictionnet
{
    public static class Extensions
    {
        /// <summary>
        /// Converts the <see cref="VoteDirection"/> into an emoji
        /// </summary>
        /// <param name="direction">The direction (Up,Down) </param>
        /// <returns>An emoji :D</returns>
        public static string ToEmoji(this VoteDirection direction)
        {
            return direction == VoteDirection.Up ? "👍" : "👎";
        }
    }
}