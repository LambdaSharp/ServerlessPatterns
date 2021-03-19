using System.Threading.Tasks;
using LambdaSharp;
using LambdaSharp.SimpleNotificationService;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Bitcoin.Event.PublishBitcoinPriceFunction {

    public sealed class Function : ALambdaTopicFunction<JObject> {

        //--- Constructors ---
        public Function() : base(new LambdaSharp.Serialization.LambdaNewtonsoftJsonSerializer()) { }

        //--- Methods ---
        public override async Task InitializeAsync(LambdaConfig config) { }

        public override async Task ProcessMessageAsync(JObject message)
            => LogEvent("Bitcoin.Event::PublishBitcoinPriceFunction", "BitcoinPrice", message.ToString(Formatting.None));
    }
}
