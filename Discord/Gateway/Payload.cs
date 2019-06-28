using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway
{
    public class Payload
    {
        public static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore
        };

        [JsonProperty(PropertyName = "op")]
        public int? OpcodeRaw;

        [JsonProperty(PropertyName = "d")]
        public object EventDataRaw;
        
        [JsonProperty(PropertyName = "t")]
        public string EventName = null;

        [JsonProperty(PropertyName = "s")]
        public int? Sequence = null;

        public OpCode.Gateway? Opcode
        {
            get => (OpCode.Gateway?) OpcodeRaw;
            set => OpcodeRaw = (int?) value;
        }

        public T EventData<T>() => JsonConvert.DeserializeObject<T>(EventDataRaw as string, SerializerSettings);

        public static Payload Parse(string data) => JsonConvert.DeserializeObject<Payload>(data);

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}