namespace UrbanDictionnet.Entities.Vote
{
    /// <summary>
    /// An exception thrown when a vote is errored.
    /// </summary>
    [System.Serializable]
    public class VoteException : System.Exception
    {
        // public VoteException() { }
        public VoteException(string message = "Word not found") : base(message) { }
        // public VoteException(string message, System.Exception inner) : base(message, inner) { }
        /* protected VoteException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { } */
    }
}
