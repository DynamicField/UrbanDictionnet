
namespace UrbanDictionnet
{
    /// <summary>
    /// A defintion (i had to rename it to definition data because of <see cref="DefinitionData.Definition"/>)
    /// </summary>
    public class DefinitionData
    {
        /// <summary>
        /// Converts this instance to a simplfied string
        /// </summary>
        /// <returns>A description of the definition</returns>
        public override string ToString()
        {
            return $"Definition of {Word} by {Author} : \n" +
                   $"{Definition}\n" +
                   $"Example : \n" +
                   $"{Example}\n" +
                   $"👍 : {ThumbsUp} / 👎 : {ThumbsDown}";

        }
        /// <summary>
        /// The definition.
        /// </summary>
        public string Definition { get; set; }
        /// <summary>
        /// The number of thumbs up.
        /// </summary>
        public int ThumbsUp { get; set; }
        /// <summary>
        /// The author. (His name)
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// The target word of the definition.
        /// </summary>
        public string Word { get; set; }
        /// <summary>
        /// The definiton id of this definiton.
        /// </summary>
        public int DefId { get; set; }
        /// <summary>
        /// The example for the usage of this word following the definiton.
        /// </summary>
        public string Example { get; set; }
        /// <summary>
        /// The numbers of thumbs down.
        /// </summary>
        public int ThumbsDown { get; set; }
        /// <summary>
        /// The permalink of the definition <example>For "ayy" : ayy.urbanup.com/[defid]</example>
        /// </summary>
        public string Permalink { get; set; }
        /// <summary>
        /// The current vote attributed to this definition
        /// </summary>
        public VoteDirection? CurrentVote { get; set; }
    }
}
