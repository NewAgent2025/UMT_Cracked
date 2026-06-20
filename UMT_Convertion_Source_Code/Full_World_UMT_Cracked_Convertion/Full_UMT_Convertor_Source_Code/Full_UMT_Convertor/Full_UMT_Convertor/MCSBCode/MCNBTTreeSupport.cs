using System;
using System.IO;
using System.Windows.Forms;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.utils;
using Full_UMT_Convertor.validation;
using Substrate.Nbt;

namespace Full_UMT_Convertor.MCSBCode
{
	// Token: 0x020000B9 RID: 185
	public class MCNBTTreeSupport
	{
		// Token: 0x060007BF RID: 1983 RVA: 0x00042448 File Offset: 0x00040648
		public MemoryStream ConvertChunk(ChunkData chunkData, string filepath)
		{
			byte[] array = null;
			if (Working.GameType == (Enum2)1)
			{
				array = Class46.smethod_52(chunkData.method_0(), chunkData.Path);
			}
			else if (Working.GameType == (Enum2)2)
			{
				array = Class46.smethod_55(chunkData.method_0(), chunkData.Path);
			}
			else if (Working.GameType == (Enum2)3)
			{
				array = Class46.smethod_58(chunkData.method_0(), chunkData.Path);
			}
			if (array != null)
			{
				MemoryStream memoryStream = Class46.smethod_69(array);
				TagNodeCompound tree = this.method_3(memoryStream);
				NbtTree nbtTree = new NbtTree(tree);
				memoryStream = new MemoryStream();
				nbtTree.WriteTo(memoryStream);
				return memoryStream;
			}
			return null;
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x000424DC File Offset: 0x000406DC
		private void method_0(byte[] byte_0, string string_0)
		{
			string path = string_0 + "chunkDebug.dat";
			FileUtils.smethod_9(string_0);
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Create)))
			{
				binaryWriter.Write(byte_0, 0, byte_0.Length);
			}
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00042530 File Offset: 0x00040730
		private void method_1(byte[] byte_0, string string_0)
		{
			ConversionTest conversionTest = new ConversionTest();
			conversionTest.DoConversionTest(byte_0, string_0);
			FileCompare fileCompare = new FileCompare();
			CompareResult compareResult = fileCompare.CompareChunkResults(string_0);
			if (compareResult.ErrorPosition >= 0 && compareResult.ErrorPosition <= 9648)
			{
				MessageBox.Show("Error: Converted chunk does not match original chunk." + Environment.NewLine + string.Format("Error Position : {0} File 1 length : {1}  File 2 length : {2}", compareResult.ErrorPosition, compareResult.Int32_0, compareResult.Int32_1));
			}
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x000425B0 File Offset: 0x000407B0
		private void method_2(byte[] byte_0, string string_0)
		{
			string path = string_0 + "chunkDebugConverted.dat";
			FileUtils.smethod_9(string_0);
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Create)))
			{
				binaryWriter.Write(byte_0, 0, byte_0.Length);
			}
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00042604 File Offset: 0x00040804
		private TagNodeCompound method_3(MemoryStream memoryStream_0)
		{
			TagNodeCompound result;
			if (Working.WorldVersionMajor < 11 || Working.WorldVersionMinor < 11)
			{
				if (Working.WorldVersionMajor < 9 || Working.WorldVersionMinor < 8)
				{
					result = this.method_4(memoryStream_0);
				}
				else
				{
					result = this.method_5(memoryStream_0);
				}
			}
			else
			{
				result = this.method_6(memoryStream_0);
			}
			return result;
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00042654 File Offset: 0x00040854
		private TagNodeCompound method_4(MemoryStream memoryStream_0)
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

		// Token: 0x060007C5 RID: 1989 RVA: 0x0004268C File Offset: 0x0004088C
		private TagNodeCompound method_5(MemoryStream memoryStream_0)
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

		// Token: 0x060007C6 RID: 1990 RVA: 0x000426C4 File Offset: 0x000408C4
		private TagNodeCompound method_6(MemoryStream memoryStream_0)
		{
			TagNodeCompound result = null;
			if (memoryStream_0 != null)
			{
				try
				{
					AquaticConverter aquaticConverter = new AquaticConverter();
					result = aquaticConverter.ConvertFromAquatic(memoryStream_0);
				}
				catch (Exception)
				{
				}
			}
			return result;
		}
	}
}
