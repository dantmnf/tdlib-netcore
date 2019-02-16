//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Linq;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;

//namespace TDLib.Api
//{
//    public class Int64Converter : JsonConverter
//    {

//        public override bool CanRead => true;

//        public override bool CanWrite => true;

//        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
//        {
//            var token = JToken.ReadFrom(reader);
//            if (token.Type == JTokenType.Array)
//            {
//                var arr = (JArray)token;
//                var res = new long[arr.Count];

//                for (int i = 0; i < arr.Count; i++)
//                {
//                    res[i] = arr[i].Value<long>();
//                }

//                return res;
//            }

//            if (token.Type == JTokenType.Integer || token.Type == JTokenType.String)
//            {
//                return token.Value<long>();
//            }

//            return null;
//        }

//        public override bool CanConvert(Type objectType)
//        {
//            return objectType == typeof(long)
//                || objectType == typeof(long[]);
//        }

//        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
//        {
//            if (value is long val)
//            {
//                serializer.Serialize(writer, val.ToString());
//            }
//            else if (value is long[] arr)
//            {
//                serializer.Serialize(writer, arr.Select(v => v.ToString()).ToArray());
//            }
//        }
//    }
//}

