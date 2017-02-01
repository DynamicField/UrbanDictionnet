namespace UrbanDictionnet.Entities
{
    [System.Serializable]
    public class WordNotFoundException : System.Exception
    {
        public WordNotFoundException() { }
        public WordNotFoundException(string message) : base(message) { }
        public WordNotFoundException(string message, System.Exception inner) : base(message, inner) { }
        protected WordNotFoundException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
