//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Linq;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
//using TDLib.Api.Types;

//namespace TDLib.Api
//{
//    public class TLObjectConverter : JsonConverter
//    {
//        private static Dictionary<string, Type> _tl_types;
//        static TLObjectConverter()
//        {
//            _tl_types = new Dictionary<string, Type>(StringComparer.Ordinal);
//            var asm = typeof(TLObject).Assembly;
//            var types = asm.GetExportedTypes()
//                .Select(t => (type: t, attrs: t.GetCustomAttributes(typeof(TLTypeAttribute), true)))
//                .Where(x => x.attrs.Length != 0)
//                .Select(x => (name: (x.attrs.FirstOrDefault() as TLTypeAttribute).TLType, type: x.type));
//            foreach (var (name, type) in types)
//            {
//                _tl_types.Add(name, type);
//            }

//        }

//        private static object ConvertFromJObject(JObject jObject)
//        {
//            var typeProp = jObject["@type"];
//            var typeName = "(unknwon)";
//            if (typeProp != null)
//            {
//                typeName = (string)typeProp;
//                if (typeName != null && _tl_types.TryGetValue(typeName, out var type))
//                {
//                    return jObject.ToObject(type);
//                }
//            }
//            throw new JsonException($"unknown type {typeName}");
//        }

//        private static object ConvertFromJToken(JToken token, Type objectType)
//        {
//            if (token.Type == JTokenType.Object)
//            {
//                var jObject = (JObject)token;
//                return ConvertFromJObject(jObject);

//            }
//            else if (token.Type == JTokenType.Array)
//            {
//                var et = objectType.GetElementType();
//                if (typeof(Array).IsAssignableFrom(objectType) && et != null && typeof(TLObject).IsAssignableFrom(et))
//                {
//                    var arr = (JArray)token;
//                    var result = Array.CreateInstance(et, arr.Count);
//                    for (int i = 0; i < arr.Count; i++)
//                    {
//                        result.SetValue(ConvertFromJToken(arr[i], et), i);
//                    }
//                    return result;
//                }
//                return Array.CreateInstance(objectType, 0);
//            }
//            else
//            {
//                return token.ToObject(objectType);
//            }
//        }

//        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
//        {
//            var jToken = JToken.Load(reader);
//            return ConvertFromJToken(jToken, objectType);
//        }

//        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
//        {
//            throw new NotImplementedException();
//        }

//        public override bool CanConvert(Type objectType)
//        {
//            return typeof(TLObject).IsAssignableFrom(objectType) || IsContainerOf(objectType, typeof(TLObject));
//        }

//        private static bool IsContainerOf(Type container, Type item)
//        {
//            var et = container.GetElementType();
//            if (et == null) return false;
//            Type eet;
//            if ((eet = et.GetElementType()) != null)
//                return IsContainerOf(eet, item);
//            return et == item || et.IsEquivalentTo(item) || item.IsAssignableFrom(et);
//        }

//        public override bool CanWrite => false;
//    }
//}
