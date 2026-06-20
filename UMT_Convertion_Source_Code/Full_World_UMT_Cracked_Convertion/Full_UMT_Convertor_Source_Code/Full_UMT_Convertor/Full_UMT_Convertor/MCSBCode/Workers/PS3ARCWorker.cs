using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.utils;

namespace Full_UMT_Convertor.MCSBCode.Workers
{
	// Token: 0x0200009C RID: 156
	public class PS3ARCWorker
	{
		// Token: 0x06000678 RID: 1656 RVA: 0x0003C998 File Offset: 0x0003AB98
		public void ExtractArchive(string arcPath, string workingPath)
		{
			List<ArcEntry> list = new List<ArcEntry>();
			byte[] array = FileUtils.smethod_0(arcPath);
			MemoryStream memoryStream = null;
			if (array != null)
			{
				memoryStream = new MemoryStream(array);
				int num = this.class47_0.method_4(memoryStream);
				for (int i = 0; i < num; i++)
				{
					string name = this.method_0(memoryStream);
					int pos = this.class47_0.method_4(memoryStream);
					int size = this.class47_0.method_4(memoryStream);
					ArcEntry item = new ArcEntry(name, size, pos);
					list.Add(item);
				}
			}
			this.method_1(workingPath, list, memoryStream);
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0003CA20 File Offset: 0x0003AC20
		private string method_0(MemoryStream memoryStream_0)
		{
			byte[] array = new byte[2];
			memoryStream_0.Read(array, 0, 2);
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse(array);
			}
			short num = BitConverter.ToInt16(array, 0);
			byte[] array2 = new byte[(int)num];
			memoryStream_0.Read(array2, 0, (int)num);
			Encoding utf = Encoding.UTF8;
			return utf.GetString(array2);
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0003CA78 File Offset: 0x0003AC78
		private void method_1(string string_0, List<ArcEntry> list_0, MemoryStream memoryStream_0)
		{
			foreach (ArcEntry arcEntry in list_0)
			{
				byte[] array = new byte[arcEntry.Size];
				memoryStream_0.Read(array, 0, arcEntry.Size);
				string text = string_0 + arcEntry.Name;
				string directoryName = Path.GetDirectoryName(text);
				Directory.CreateDirectory(directoryName);
				FileUtils.WriteFile(array, text);
			}
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0003CB00 File Offset: 0x0003AD00
		public void BuildArchive(string arcPath, string workingPath)
		{
			MemoryStream memoryStream = new MemoryStream();
			List<ArcEntry> list = new List<ArcEntry>();
			List<string> list2 = this.method_4(workingPath);
			foreach (string text in list2)
			{
				byte[] array = FileUtils.smethod_0(text);
				int size = array.Length;
				int pos = (int)memoryStream.Position;
				string name = text.Substring(workingPath.Length);
				memoryStream.Write(array, 0, array.Length);
				ArcEntry item = new ArcEntry(name, size, pos);
				list.Add(item);
			}
			MemoryStream memoryStream2 = this.method_3(list);
			int num = (int)memoryStream2.Length;
			foreach (ArcEntry arcEntry in list)
			{
				arcEntry.Pos += num;
			}
			memoryStream2 = this.method_3(list);
			this.method_2(arcPath, memoryStream2, memoryStream);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0003CC14 File Offset: 0x0003AE14
		private void method_2(string string_0, MemoryStream memoryStream_0, MemoryStream memoryStream_1)
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(string_0, FileMode.Create)))
			{
				binaryWriter.Write(memoryStream_0.ToArray());
				binaryWriter.Write(memoryStream_1.ToArray());
			}
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0003CC64 File Offset: 0x0003AE64
		private MemoryStream method_3(List<ArcEntry> list_0)
		{
			Class47 @class = new Class47();
			MemoryStream memoryStream = new MemoryStream();
			@class.method_10(list_0.Count, memoryStream);
			foreach (ArcEntry arcEntry in list_0)
			{
				@class.method_12(arcEntry.Name, memoryStream);
				@class.method_10(arcEntry.Pos, memoryStream);
				@class.method_10(arcEntry.Size, memoryStream);
			}
			return memoryStream;
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0003CCF0 File Offset: 0x0003AEF0
		private List<string> method_4(string string_0)
		{
			List<string> list = new List<string>();
			foreach (string item in Directory.GetFiles(string_0))
			{
				list.Add(item);
			}
			foreach (string string_ in Directory.GetDirectories(string_0))
			{
				list.AddRange(this.method_4(string_));
			}
			return list;
		}

		// Token: 0x040004C9 RID: 1225
		private Class47 class47_0 = new Class47();
	}
}
