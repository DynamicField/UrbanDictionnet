namespace UrbanDictionnet
{
    /// <summary>
    /// The response of a vote request.
    /// </summary>
    public class VoteResponse
    {
        /// <summary>
        /// The status of the vote
        /// </summary>
        public VoteStatus Status { get; set; }
        /// <summary>
        /// Upvotes on this definition
        /// </summary>
        /// <remarks>
        /// can be null if <see cref="Status"/> is <see cref="VoteStatus.Error"/>
        /// </remarks>
        public int? Up { get; set; }
        /// <summary>
        /// Downvotes on this definition
        /// </summary>
        /// <remarks>
        /// can be null if <see cref="Status"/> is <see cref="VoteStatus.Error"/>
        /// </remarks>
        public int? Down { get; set; }
    }
}
