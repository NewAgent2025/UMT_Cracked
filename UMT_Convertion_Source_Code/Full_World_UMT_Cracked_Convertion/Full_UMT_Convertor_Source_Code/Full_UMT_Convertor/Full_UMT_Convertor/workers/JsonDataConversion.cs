using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Full_UMT_Convertor.workers
{
	// Token: 0x02000150 RID: 336
	public class JsonDataConversion
	{
		// Token: 0x06000E28 RID: 3624 RVA: 0x0005E31C File Offset: 0x0005C51C
		public static string Serialize(object obj)
		{
			if (obj == null)
			{
				return null;
			}
			DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(obj.GetType());
			MemoryStream memoryStream = new MemoryStream();
			dataContractJsonSerializer.WriteObject(memoryStream, obj);
			string @string = Encoding.Default.GetString(memoryStream.ToArray());
			memoryStream.Dispose();
			return @string;
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x0005E360 File Offset: 0x0005C560
		public static T Deserialize<T>(string json)
		{
			T result = Activator.CreateInstance<T>();
			MemoryStream memoryStream = new MemoryStream(Encoding.Unicode.GetBytes(json));
			DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(result.GetType());
			result = (T)((object)dataContractJsonSerializer.ReadObject(memoryStream));
			memoryStream.Close();
			memoryStream.Dispose();
			return result;
		}
	}
}
