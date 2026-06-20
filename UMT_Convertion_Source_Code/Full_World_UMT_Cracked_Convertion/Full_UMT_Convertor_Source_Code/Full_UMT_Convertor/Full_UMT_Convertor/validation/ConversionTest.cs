using System;
using System.IO;
using System.Linq;
using Full_UMT_Convertor.MCSBCode;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.utils;

namespace Full_UMT_Convertor.validation
{
	// Token: 0x0200014C RID: 332
	public class ConversionTest
	{
		// Token: 0x06000E10 RID: 3600 RVA: 0x0005DDF4 File Offset: 0x0005BFF4
		public void DoConversionTest(byte[] chunk, string path)
		{
			byte[] byte_ = this.method_1(chunk, path);
			byte[] byte_2 = this.method_2(byte_, path);
			MemoryStream memoryStream = Class46.smethod_69(byte_2);
			this.method_0(memoryStream.ToArray(), path);
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x000425B0 File Offset: 0x000407B0
		private void method_0(byte[] byte_0, string string_0)
		{
			string path = string_0 + "chunkDebugConverted.dat";
			FileUtils.smethod_9(string_0);
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Create)))
			{
				binaryWriter.Write(byte_0, 0, byte_0.Length);
			}
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x0005DE28 File Offset: 0x0005C028
		private byte[] method_1(byte[] byte_0, string string_0)
		{
			ConvertParameters convertParameters = new ConvertParameters();
			convertParameters.ConvertEntities = true;
			convertParameters.ConvertOverworld = true;
			convertParameters.ReplaceBiomes = false;
			convertParameters.ReplaceBlocks = false;
			convertParameters.DataValidation = false;
			ConvertToPC convertToPC = new ConvertToPC();
			return convertToPC.method_0(byte_0, convertParameters);
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x0005DE6C File Offset: 0x0005C06C
		private byte[] method_2(byte[] byte_0, string string_0)
		{
			ChunkData chunkData_ = new ChunkData();
			ConvertParameters convertParameters = new ConvertParameters();
			convertParameters.ConvertEntities = true;
			convertParameters.ConvertOverworld = true;
			convertParameters.ReplaceBiomes = false;
			convertParameters.ReplaceBlocks = false;
			convertParameters.DataValidation = false;
			if (Working.WorldVersionMinor > 7)
			{
				convertParameters.ChunkFormat = ConsoleChunkFormat.TU17;
				if (Working.WorldVersionMinor != 8 && Working.WorldVersionMinor != 9 && Working.WorldVersionMinor != 10)
				{
					if (Working.WorldVersionMinor != 11)
					{
						if (Working.WorldVersionMinor == 9)
						{
							convertParameters.TU17VersionType_0 = TU17VersionType.VERSION_9;
							goto IL_A9;
						}
						if (Working.WorldVersionMinor == 10)
						{
							convertParameters.TU17VersionType_0 = TU17VersionType.VERSION_10;
							goto IL_A9;
						}
						if (Working.WorldVersionMinor == 11)
						{
							convertParameters.TU17VersionType_0 = TU17VersionType.VERSION_11;
							goto IL_A9;
						}
						goto IL_A9;
					}
				}
				convertParameters.TU17VersionType_0 = TU17VersionType.VERSION_8;
			}
			IL_A9:
			ConvertFromPC convertFromPC = new ConvertFromPC();
			new MemoryStream();
			byte_0 = Class46.smethod_64(byte_0.Skip(5).ToArray<byte>());
			return convertFromPC.method_4(chunkData_, byte_0, convertParameters);
		}
	}
}
