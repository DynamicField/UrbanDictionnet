namespace UrbanDictionnet.Entities.Vote
{
    /// <summary>
    /// The vote status of a vote.
    /// </summary>
    public enum VoteStatus
    {
        /// <summary>
        /// Well it's an error.
        /// </summary>
        Error,
        /// <summary>
        /// A duplicate
        /// </summary>
        Duplicate,
        /// <summary>
        /// No but i have to documentate simple things ?
        /// </summary>
        Saved
    }
    /// <summary>
    /// The direction of a vote (used by <see cref="UrbanClient.VoteOnDefinition(int, VoteDirection)"/>)
    /// </summary>
    public enum VoteDirection
    {
        /// <summary>
        /// Thumbs up
        /// </summary>
        Up,
        /// <summary>
        /// Thumps down
        /// </summary>
        Down
    }
}
