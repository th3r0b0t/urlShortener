namespace urlShortner.Models
{
    public class urlData
    {
        public string longUrl {get; set;}
        
        [LiteDB.BsonId]
        public string shortUrl {get; set;}
        public int hitTimes {get; set;} = 0;
        public string creationTimeStamp {get; set;} = new System.DateTimeOffset(System.DateTime.UtcNow).ToUnixTimeSeconds().ToString();
    }
}