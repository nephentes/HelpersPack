using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System;

namespace HelpersPack
{

    public static class Extensions
    {

        public enum SerializeFormat
        {
            XML = 1,
            Json = 2
        }

        public static IEnumerable<TSource> DistinctBy<TSource, TKey>
    (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }

        public static string Truncate(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }

        public static object DeserializeObject<T>(this string toDeserialize, SerializeFormat format = SerializeFormat.XML)
        {
            switch (format)
            {
                case SerializeFormat.Json:
                    throw new NotImplementedException();

                default:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    StringReader textReader = new StringReader(toDeserialize);
                    return xmlSerializer.Deserialize(textReader);
            }

        }

        public static string SerializeObject<T>(this T toSerialize, SerializeFormat format = SerializeFormat.XML)
        {
            switch (format)
            {
                case SerializeFormat.Json:
                    throw new NotImplementedException();

                default:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    StringWriter textWriter = new StringWriter();
                    xmlSerializer.Serialize(textWriter, toSerialize);
                    return textWriter.ToString();
            }
        }

        public static bool ContainsOneOf(this string stringToCheck, string[] what)
        {
            foreach (var oneItem in what)
            {
                if (stringToCheck.ToLower().Contains(oneItem))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsOneOf<T>(this T element, params T[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Equals(element))
                    return true;
            }
            return false;
        }

        public static bool ContainsOneOf<T>(this List<T> list, params T[] items)
        {
            foreach (var oneItem in items)
            {
                if (list.Contains(oneItem))
                    return true;
            }
            return false;
        }


    }

}
