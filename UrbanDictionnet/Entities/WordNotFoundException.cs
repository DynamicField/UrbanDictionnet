namespace UrbanDictionnet.Entities
{
    /// <summary>
    /// An exception thrown when a word isn't found
    /// </summary>
    [System.Serializable]
    public class WordNotFoundException : System.Exception
    {
        // public WordNotFoundException() { }
        public WordNotFoundException(string message = "An error occured while voting") : base(message) { }
        // public WordNotFoundException(string message, System.Exception inner) : base(message, inner) { }
        /* protected WordNotFoundException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { } */
    }
}
