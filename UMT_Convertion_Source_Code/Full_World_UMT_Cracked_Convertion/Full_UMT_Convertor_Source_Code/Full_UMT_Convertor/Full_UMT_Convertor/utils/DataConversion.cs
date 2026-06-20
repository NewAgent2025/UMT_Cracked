using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Full_UMT_Convertor.utils
{
	// Token: 0x0200013A RID: 314
	public class DataConversion
	{
		// Token: 0x06000D1F RID: 3359 RVA: 0x0005A79C File Offset: 0x0005899C
		public static string Serialize(object obj)
		{
			if (obj == null)
			{
				return null;
			}
			XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());
			MemoryStream memoryStream = new MemoryStream();
			xmlSerializer.Serialize(memoryStream, obj);
			string @string = Encoding.Default.GetString(memoryStream.ToArray());
			memoryStream.Dispose();
			return @string;
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x0005A7E0 File Offset: 0x000589E0
		public static T Deserialize<T>(string xml)
		{
			T result = Activator.CreateInstance<T>();
			MemoryStream memoryStream = new MemoryStream(Encoding.Unicode.GetBytes(xml));
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
			result = (T)((object)xmlSerializer.Deserialize(memoryStream));
			memoryStream.Close();
			memoryStream.Dispose();
			return result;
		}
	}
}
