using System;
using System.IO;
using Substrate.Nbt;
using UMT_PC_To_Console_Convertor.model;
using UMT_PC_To_Console_Convertor.utils;

namespace UMT_PC_To_Console_Convertor.MCSBCode
{
	// Token: 0x0200007C RID: 124
	public class MCNBTTreeSupport
	{
		// Token: 0x06000559 RID: 1369 RVA: 0x000290D8 File Offset: 0x000272D8
		public MemoryStream ConvertChunk(ChunkData chunkData, string filepath)
		{
			byte[] array = null;
			if (Working.GameType == (Enum2)1)
			{
				array = Class36.smethod_44(chunkData.method_0(), chunkData.Path);
			}
			else if (Working.GameType == (Enum2)2)
			{
				array = Class36.smethod_47(chunkData.method_0(), chunkData.Path);
			}
			else if (Working.GameType == (Enum2)3)
			{
				array = Class36.smethod_50(chunkData.method_0(), chunkData.Path);
			}
			if (array != null)
			{
				MemoryStream memoryStream = Class36.smethod_61(array);
				TagNodeCompound tree = this.method_1(memoryStream);
				NbtTree nbtTree = new NbtTree(tree);
				memoryStream = new MemoryStream();
				nbtTree.WriteTo(memoryStream);
				return memoryStream;
			}
			return null;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0002916C File Offset: 0x0002736C
		private void method_0(byte[] byte_0, string string_0)
		{
			string path = string_0 + "chunkDebug.dat";
			FileUtils.smethod_9(string_0);
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Create)))
			{
				binaryWriter.Write(byte_0, 0, byte_0.Length);
			}
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x000291C0 File Offset: 0x000273C0
		private TagNodeCompound method_1(MemoryStream memoryStream_0)
		{
			TagNodeCompound result;
			if (Working.WorldVersionMajor < 9 || Working.WorldVersionMinor < 8)
			{
				result = this.method_2(memoryStream_0);
			}
			else
			{
				result = this.method_3(memoryStream_0);
			}
			return result;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x000291F4 File Offset: 0x000273F4
		private TagNodeCompound method_2(MemoryStream memoryStream_0)
		{
			TagNodeCompound result = null;
			if (memoryStream_0 != null)
			{
				try
				{
					NbtTree nbtTree = new NbtTree(memoryStream_0);
					result = nbtTree.Root;
				}
				catch (Exception)
				{
				}
			}
			return result;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0002922C File Offset: 0x0002742C
		private TagNodeCompound method_3(MemoryStream memoryStream_0)
		{
			TagNodeCompound result = null;
			if (memoryStream_0 != null)
			{
				try
				{
					TU17Converter tu17Converter = new TU17Converter();
					result = tu17Converter.ConvertFromTU17(memoryStream_0);
				}
				catch (Exception)
				{
				}
			}
			return result;
		}
	}
}
