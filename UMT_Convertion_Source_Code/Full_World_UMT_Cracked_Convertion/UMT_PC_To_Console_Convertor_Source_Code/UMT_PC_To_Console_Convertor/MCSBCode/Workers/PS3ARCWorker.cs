using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UMT_PC_To_Console_Convertor.model;
using UMT_PC_To_Console_Convertor.utils;

namespace UMT_PC_To_Console_Convertor.MCSBCode.Workers
{
	// Token: 0x02000069 RID: 105
	public class PS3ARCWorker
	{
		// Token: 0x060004A2 RID: 1186 RVA: 0x00024FEC File Offset: 0x000231EC
		public void ExtractArchive(string arcPath, string workingPath)
		{
			List<ArcEntry> list = new List<ArcEntry>();
			byte[] array = FileUtils.smethod_0(arcPath);
			MemoryStream memoryStream = null;
			if (array != null)
			{
				memoryStream = new MemoryStream(array);
				int num = this.class37_0.method_2(memoryStream);
				for (int i = 0; i < num; i++)
				{
					string name = this.method_0(memoryStream);
					int pos = this.class37_0.method_2(memoryStream);
					int size = this.class37_0.method_2(memoryStream);
					ArcEntry item = new ArcEntry(name, size, pos);
					list.Add(item);
				}
			}
			this.method_1(workingPath, list, memoryStream);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00025074 File Offset: 0x00023274
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

		// Token: 0x060004A4 RID: 1188 RVA: 0x000250CC File Offset: 0x000232CC
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

		// Token: 0x060004A5 RID: 1189 RVA: 0x00025154 File Offset: 0x00023354
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

		// Token: 0x060004A6 RID: 1190 RVA: 0x00025268 File Offset: 0x00023468
		private void method_2(string string_0, MemoryStream memoryStream_0, MemoryStream memoryStream_1)
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(string_0, FileMode.Create)))
			{
				binaryWriter.Write(memoryStream_0.ToArray());
				binaryWriter.Write(memoryStream_1.ToArray());
			}
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x000252B8 File Offset: 0x000234B8
		private MemoryStream method_3(List<ArcEntry> list_0)
		{
			Class37 @class = new Class37();
			MemoryStream memoryStream = new MemoryStream();
			@class.method_7(list_0.Count, memoryStream);
			foreach (ArcEntry arcEntry in list_0)
			{
				@class.method_8(arcEntry.Name, memoryStream);
				@class.method_7(arcEntry.Pos, memoryStream);
				@class.method_7(arcEntry.Size, memoryStream);
			}
			return memoryStream;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00025344 File Offset: 0x00023544
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

		// Token: 0x0400034E RID: 846
		private Class37 class37_0 = new Class37();
	}
}
