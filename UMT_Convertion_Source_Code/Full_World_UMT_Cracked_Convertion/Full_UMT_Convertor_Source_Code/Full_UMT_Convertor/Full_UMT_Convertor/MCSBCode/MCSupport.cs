using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Full_UMT_Convertor.MCSBCode.Workers;
using Full_UMT_Convertor.model;
using Full_UMT_Convertor.PECode;
using Full_UMT_Convertor.Properties;
using Full_UMT_Convertor.utils;
using MCPELevelDBI.workers;
using NBTExplorer.Model;
using Substrate;
using Substrate.Core;
using Substrate.Nbt;

namespace Full_UMT_Convertor.MCSBCode
{
	// Token: 0x0200008B RID: 139
	public class MCSupport
	{
		// Token: 0x06000581 RID: 1409 RVA: 0x000339E4 File Offset: 0x00031BE4
		internal ConvertStatus method_0(string string_1, ConvertParameters convertParameters_0)
		{
			ConvertStatus convertStatus = new ConvertStatus();
			string text = Path.Combine(string_1, Guid.NewGuid().ToString());
			try
			{
				this.method_51(convertParameters_0);
				BlockConversionWorker.BuildBlockConversionTable(PlatformType.PE);
				this.method_1(convertParameters_0.ProcessWorldFolder, text, convertParameters_0);
				this.InitBedrockFromConsoleConversion(string_1, text, convertParameters_0, convertStatus);
				if (convertParameters_0.UpdateLevelData)
				{
					this.method_2(string_1, text, convertParameters_0);
				}
				if (convertParameters_0.SetPlayPosition)
				{
					this.method_3(string_1, text, convertParameters_0);
				}
				this.method_56("Conversion Completed", 100);
				Thread.Sleep(500);
			}
			catch (Exception)
			{
			}
			convertStatus.WorkingFolder = text;
			convertStatus.SourceFolder = convertParameters_0.ProcessWorldFolder;
			return convertStatus;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00033A98 File Offset: 0x00031C98
		private void method_1(string string_1, string string_2, ConvertParameters convertParameters_0)
		{
			Directory.CreateDirectory(Path.Combine(string_2, "db"));
			if (convertParameters_0.ConvertInto != ConvertIntoType.EmptyWorld)
			{
				try
				{
					FileUtils.CopyFoldersAndFiles(Path.Combine(string_1, "db"), Path.Combine(string_2, "db"));
				}
				catch (Exception ex)
				{
					throw new Exception("Staging db failed with following error : " + Environment.NewLine + ex.Message);
				}
			}
			try
			{
				byte[] array = FileUtils.smethod_0(Path.Combine(string_1, "level.dat"));
				array = array.Skip(8).ToArray<byte>();
				FileUtils.WriteFile(array, Path.Combine(string_2, "level.dat"));
			}
			catch (Exception ex2)
			{
				throw new Exception("Staging level.dat failed with following error : " + Environment.NewLine + ex2.Message);
			}
			if (convertParameters_0.ConvertInto == ConvertIntoType.EmptyDimension)
			{
				PEProcessWorker peprocessWorker = new PEProcessWorker();
				Working.PEDimensions = peprocessWorker.GetAvailableChunks(string_2);
				if (convertParameters_0.ConvertOverworld)
				{
					peprocessWorker.DeleteAllRegionsInDimension("region", string_2);
				}
				if (convertParameters_0.ConvertNether)
				{
					peprocessWorker.DeleteAllRegionsInDimension("DIM-1", string_2);
				}
				if (convertParameters_0.ConvertTheEnd)
				{
					peprocessWorker.DeleteAllRegionsInDimension("DIM1", string_2);
				}
			}
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00033BB8 File Offset: 0x00031DB8
		public void InitBedrockFromConsoleConversion(string consolePath, string bedrockPath, ConvertParameters convertParameters, ConvertStatus convertStatus)
		{
			string[] dimensionFolderNames = Constants.dimensionFolderNames;
			int i = 0;
			while (i < dimensionFolderNames.Length)
			{
				string text = dimensionFolderNames[i];
				if ((text.ToLower() == "region" && convertParameters.ConvertOverworld) || (text.ToLower() == "dim-1" && convertParameters.ConvertNether))
				{
					goto IL_46;
				}
				if (text.ToLower() == "dim1" && convertParameters.ConvertTheEnd)
				{
					goto IL_46;
				}
				IL_52:
				i++;
				continue;
				IL_46:
				this.InitBedrockFromConsoleConversion(text, consolePath, bedrockPath, convertParameters, convertStatus);
				goto IL_52;
			}
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00033C3C File Offset: 0x00031E3C
		public void InitBedrockFromConsoleConversion(string dimensionName, string consolePath, string bedrockPath, ConvertParameters convertParameters, ConvertStatus convertStatus)
		{
			string path = Path.Combine(bedrockPath, "db");
			string text = Path.Combine(consolePath, Working.smethod_0(), dimensionName);
			LevelDBWorker levelDBWorker = new LevelDBWorker();
			levelDBWorker.OpenDB(path, true);
			if (FileUtils.CheckFolderExists(text))
			{
				ConvertToBedrockFromConsole.activeChests = new List<ConversionChest>();
				string[] files = Directory.GetFiles(text, "*.mcr");
				List<ManualResetEvent> list = new List<ManualResetEvent>();
				List<ConvertToPEFromConsoleParameters> list2 = new List<ConvertToPEFromConsoleParameters>();
				List<ConvertToPEFromConsoleParameters> list3 = new List<ConvertToPEFromConsoleParameters>();
				List<ConvertToPEFromConsoleParameters> list4 = new List<ConvertToPEFromConsoleParameters>();
				List<ConvertToPEFromConsoleParameters> list5 = new List<ConvertToPEFromConsoleParameters>();
				ConvertToPEFromConsoleParameters convertToPEFromConsoleParameters = null;
				foreach (string path2 in files)
				{
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path2);
					ManualResetEvent manualResetEvent = new ManualResetEvent(false);
					list.Add(manualResetEvent);
					ConvertToPEFromConsoleParameters item = new ConvertToPEFromConsoleParameters(dimensionName, fileNameWithoutExtension, text, bedrockPath, convertParameters, levelDBWorker, manualResetEvent);
					list2.Add(item);
				}
				bool flag = false;
				while (!flag)
				{
					if (convertToPEFromConsoleParameters == null && list4.Count > 0)
					{
						ConvertToPEFromConsoleParameters convertToPEFromConsoleParameters2 = list4[0];
						list4.RemoveAt(0);
						convertToPEFromConsoleParameters2.Done = false;
						convertToPEFromConsoleParameters = convertToPEFromConsoleParameters2;
						ConvertToBedrockFromConsole @object = new ConvertToBedrockFromConsole();
						ThreadPool.QueueUserWorkItem(new WaitCallback(@object.WritePEBatch), convertToPEFromConsoleParameters2);
					}
					if (list2.Count > 0 && list3.Count < 3)
					{
						ConvertToPEFromConsoleParameters convertToPEFromConsoleParameters3 = list2[0];
						list2.RemoveAt(0);
						list3.Add(convertToPEFromConsoleParameters3);
						ConvertToBedrockFromConsole object2 = new ConvertToBedrockFromConsole();
						ThreadPool.QueueUserWorkItem(new WaitCallback(object2.ConvertRegionFileToBedrock), convertToPEFromConsoleParameters3);
					}
					int num = 0;
					for (int j = list3.Count - 1; j >= 0; j--)
					{
						ConvertToPEFromConsoleParameters convertToPEFromConsoleParameters4 = list3[j];
						if (!convertToPEFromConsoleParameters4.Done || list4.Count >= 3)
						{
							num += convertToPEFromConsoleParameters4.ProcessedChunkCount;
						}
						else
						{
							list3.RemoveAt(j);
							list4.Add(convertToPEFromConsoleParameters4);
							this.int_0 += convertToPEFromConsoleParameters4.ProcessedChunkCount;
						}
					}
					int int_ = (int)((float)(num + this.int_0) / (float)this.int_1 * 100f);
					this.method_56("Processing chunk " + (num + this.int_0), int_);
					Thread.Sleep(50);
					if (convertToPEFromConsoleParameters != null && convertToPEFromConsoleParameters.Done)
					{
						list5.Add(convertToPEFromConsoleParameters);
						convertToPEFromConsoleParameters = null;
					}
					flag = (list3.Count == 0 && list2.Count == 0 && list4.Count == 0 && convertToPEFromConsoleParameters == null);
				}
				BedrockChestConnections bedrockChestConnections = new BedrockChestConnections();
				int dimension = 0;
				if (Constants.bedrockDimensionByName.ContainsKey(dimensionName.ToLower()))
				{
					dimension = Constants.bedrockDimensionByName[dimensionName.ToLower()];
				}
				bedrockChestConnections.ProcessChests(dimension, ConvertToBedrockFromConsole.activeChests, levelDBWorker);
				levelDBWorker.CloseDB();
				for (int k = 0; k < list.Count; k++)
				{
					list[k].WaitOne();
				}
				for (int l = 0; l < list5.Count; l++)
				{
					ConvertToPEFromConsoleParameters convertToPEFromConsoleParameters5 = list5[l];
					convertStatus.ProcessedChunkCount += convertToPEFromConsoleParameters5.ProcessedChunkCount;
					convertStatus.MissingChunkCount += convertToPEFromConsoleParameters5.MissingChunkCount;
					convertStatus.InvalidChunkCount += convertToPEFromConsoleParameters5.InvalidChunkCount;
				}
			}
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00033F88 File Offset: 0x00032188
		private void method_2(string string_1, string string_2, ConvertParameters convertParameters_0)
		{
			TagNodeCompound tagNodeCompound = convertParameters_0.ModifiedLevelNode;
			if (tagNodeCompound == null)
			{
				TagNodeCompound tagNodeCompound2 = PEUtility.smethod_0(string_2);
				TagNodeCompound tagNodeCompound_ = PEUtility.LoadConsoleLevel(Path.Combine(Working.smethod_5(), Working.smethod_0()));
				tagNodeCompound = MCSupport.smethod_0((TagNodeCompound)tagNodeCompound2.Copy(), tagNodeCompound_, convertParameters_0.ConvertInto);
			}
			string levelPath = Path.Combine(string_2, "level.dat");
			PEUtility.smethod_1(tagNodeCompound, levelPath);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00033FE8 File Offset: 0x000321E8
		internal static TagNodeCompound smethod_0(TagNodeCompound tagNodeCompound_0, TagNodeCompound tagNodeCompound_1, ConvertIntoType convertIntoType_0)
		{
			TagNodeCompound tagNodeCompound = null;
			if (tagNodeCompound_1 != null)
			{
				tagNodeCompound = (tagNodeCompound_1["Data"] as TagNodeCompound);
			}
			if (tagNodeCompound_0 != null && tagNodeCompound != null)
			{
				tagNodeCompound_0["LevelName"] = tagNodeCompound["LevelName"].Copy();
				if (tagNodeCompound.ContainsKey("generatorName"))
				{
					int d = 1;
					string text = tagNodeCompound["generatorName"] as TagNodeString;
					if (text.ToLower() == "flat" && convertIntoType_0 == ConvertIntoType.EmptyWorld)
					{
						d = 2;
					}
					tagNodeCompound_0["Generator"] = new TagNodeInt(d);
				}
				if (tagNodeCompound.ContainsKey("allowCommands"))
				{
					tagNodeCompound_0["hasBeenLoadedInCreative"] = tagNodeCompound["allowCommands"].Copy();
					tagNodeCompound_0["commandsEnabled"] = tagNodeCompound["allowCommands"].Copy();
				}
				if (tagNodeCompound.ContainsKey("GameType"))
				{
					int num = tagNodeCompound["GameType"] as TagNodeInt;
					if (num > 1)
					{
						num = 0;
					}
					tagNodeCompound_0["GameType"] = new TagNodeInt(num);
				}
				if (tagNodeCompound.ContainsKey("Time"))
				{
					tagNodeCompound_0["Time"] = tagNodeCompound["Time"].Copy();
				}
				long d2 = Utils.DateTimeToUnixTimestamp() / 1000L;
				tagNodeCompound_0["LastPlayed"] = new TagNodeLong(d2);
				if (tagNodeCompound.ContainsKey("raining"))
				{
					byte b = tagNodeCompound["raining"] as TagNodeByte;
					tagNodeCompound_0["rainLevel"] = new TagNodeFloat((float)b);
				}
				if (tagNodeCompound.ContainsKey("rainTime"))
				{
					tagNodeCompound_0["rainTime"] = tagNodeCompound["rainTime"].Copy();
				}
				if (tagNodeCompound.ContainsKey("thundering"))
				{
					byte b2 = tagNodeCompound["thundering"] as TagNodeByte;
					tagNodeCompound_0["lightningLevel"] = new TagNodeFloat((float)b2);
				}
				if (tagNodeCompound.ContainsKey("thunderTime"))
				{
					tagNodeCompound_0["lightningTime"] = tagNodeCompound["thunderTime"].Copy();
				}
				int d3 = tagNodeCompound["SpawnX"] as TagNodeInt;
				int d4 = tagNodeCompound["SpawnY"] as TagNodeInt;
				int d5 = tagNodeCompound["SpawnZ"] as TagNodeInt;
				tagNodeCompound_0["SpawnX"] = new TagNodeInt(d3);
				tagNodeCompound_0["SpawnY"] = new TagNodeInt(d4);
				tagNodeCompound_0["SpawnZ"] = new TagNodeInt(d5);
			}
			return tagNodeCompound_0;
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0003428C File Offset: 0x0003248C
		private void method_3(string string_1, string string_2, ConvertParameters convertParameters_0)
		{
			TagNodeCompound tagNodeCompound = this.method_4(string_2);
			if (tagNodeCompound != null)
			{
				tagNodeCompound["Pos"] = new TagNodeList(TagType.TAG_FLOAT)
				{
					new TagNodeFloat((float)convertParameters_0.PlayerPosition.X),
					new TagNodeFloat((float)convertParameters_0.PlayerPosition.Y),
					new TagNodeFloat((float)convertParameters_0.PlayerPosition.Z)
				};
				tagNodeCompound["Rotation"] = new TagNodeList(TagType.TAG_FLOAT)
				{
					new TagNodeFloat(convertParameters_0.PlayerPosition.RotBody),
					new TagNodeFloat(convertParameters_0.PlayerPosition.RotHead)
				};
				this.method_5(string_2, tagNodeCompound);
			}
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00034348 File Offset: 0x00032548
		private TagNodeCompound method_4(string string_1)
		{
			TagNodeCompound result = null;
			LevelDBWorker levelDBWorker = PEUtility.OpenDBWorker(string_1);
			byte[] array = levelDBWorker.ReadDbValue("~local_player");
			if (array != null)
			{
				MemoryStream s = new MemoryStream(array);
				NbtTree.IsFileBigEndian = false;
				NbtTree nbtTree = new NbtTree(s);
				NbtTree.IsFileBigEndian = true;
				if (nbtTree.Root != null)
				{
					result = nbtTree.Root;
				}
			}
			levelDBWorker.CloseDB();
			return result;
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x000343A0 File Offset: 0x000325A0
		private void method_5(string string_1, TagNodeCompound tagNodeCompound_0)
		{
			NbtTree nbtTree = new NbtTree(tagNodeCompound_0);
			nbtTree.UseBigEndian = false;
			MemoryStream memoryStream = new MemoryStream();
			nbtTree.WriteTo(memoryStream);
			byte[] value = memoryStream.ToArray();
			LevelDBWorker levelDBWorker = PEUtility.OpenDBWorker(string_1);
			levelDBWorker.Put(Encoding.ASCII.GetBytes("~local_player"), value);
			levelDBWorker.CloseDB();
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x000343F4 File Offset: 0x000325F4
		private int method_6(int int_2, int int_3, ConvertParameters convertParameters_0)
		{
			int item = 0;
			if (convertParameters_0.ReplaceBlocks)
			{
				int i = 0;
				while (i < convertParameters_0.BlockChanges.Count)
				{
					if (convertParameters_0.BlockChanges[i].FromBlock == -1)
					{
						goto IL_36;
					}
					if (int_2 == convertParameters_0.BlockChanges[i].FromBlock)
					{
						goto IL_36;
					}
					IL_68:
					i++;
					continue;
					IL_36:
					if ((!convertParameters_0.BlockChanges[i].Layers.Contains(int_3) && !convertParameters_0.BlockChanges[i].Layers.Contains(-1)) || (!convertParameters_0.BlockChanges[i].FromData.Contains(-1) && !convertParameters_0.BlockChanges[i].FromData.Contains(item)))
					{
						goto IL_68;
					}
					int_2 = (int)((byte)convertParameters_0.BlockChanges[i].ToBlock);
					if (convertParameters_0.BlockChanges[i].ToData != -1)
					{
						item = convertParameters_0.BlockChanges[i].ToData;
						break;
					}
					break;
				}
			}
			return int_2;
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x000344F4 File Offset: 0x000326F4
		public void method_7(string srcFile, string dstFile)
		{
			byte[] array = FileUtils.smethod_0(srcFile);
			byte[] array2 = Class46.smethod_63(array);
			FileUtils.WriteFile(array2, dstFile);
			Class47 @class = new Class47();
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(dstFile, FileMode.Create)))
			{
				@class.method_10(0, binaryWriter.BaseStream);
				@class.method_10(array.Length, binaryWriter.BaseStream);
				binaryWriter.Write(array2);
			}
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00034568 File Offset: 0x00032768
		internal ConvertStatus method_8(string string_1, ConvertParameters convertParameters_0)
		{
			ConvertStatus convertStatus = new ConvertStatus();
			try
			{
				this.InitConsoleConversion(string_1, convertParameters_0, convertStatus);
				this.method_9(string_1, convertParameters_0);
				this.method_19(string_1, convertParameters_0.ProcessWorldFolder, convertParameters_0.method_0());
				Thread.Sleep(500);
			}
			catch (Exception)
			{
			}
			return convertStatus;
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x000345C0 File Offset: 0x000327C0
		public void InitConsoleConversion(string workingFolder, ConvertParameters convertParameters, ConvertStatus convertStatus)
		{
			string[] regionFolderNames = Constants.regionFolderNames;
			int i = 0;
			while (i < regionFolderNames.Length)
			{
				string text = regionFolderNames[i];
				if ((text.ToLower() == "region" && convertParameters.ConvertOverworld) || (text.ToLower() == "dim-1" && convertParameters.ConvertNether))
				{
					goto IL_46;
				}
				if (text.ToLower() == "dim1" && convertParameters.ConvertTheEnd)
				{
					goto IL_46;
				}
				IL_58:
				i++;
				continue;
				IL_46:
				this.method_52(text, false);
				this.DoConsoleConversion(text, workingFolder, convertParameters, convertStatus);
				goto IL_58;
			}
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00034648 File Offset: 0x00032848
		public void DoConsoleConversion(string regionfolder, string workingFolder, ConvertParameters convertParameters, ConvertStatus convertStatus)
		{
			string text = Working.WorkFolders[(int)convertParameters.method_0()];
			string text2 = Working.smethod_4();
			text = FileUtils.CheckFolderSep(workingFolder) + FileUtils.CheckFolderSep(text) + regionfolder;
			text2 = FileUtils.CheckFolderSep(workingFolder) + FileUtils.CheckFolderSep(text2) + regionfolder;
			Directory.CreateDirectory(text2);
			Directory.CreateDirectory(text);
			ManualResetEvent[] array = new ManualResetEvent[4];
			ConvertConsoleParameters[] array2 = new ConvertConsoleParameters[4];
			int num = 0;
			foreach (string regionName in Constants.getRegionFileNames(convertParameters.ConvertNewGen))
			{
				array[num] = new ManualResetEvent(false);
				ConvertConsoleParameters convertConsoleParameters = new ConvertConsoleParameters(regionName, regionfolder, text2, text, convertParameters, array[num]);
				ConvertConsole @object = new ConvertConsole();
				ThreadPool.QueueUserWorkItem(new WaitCallback(@object.ConvertConsoleRegion), convertConsoleParameters);
				array2[num] = convertConsoleParameters;
				num++;
			}
			bool flag = false;
			bool flag2 = false;
			while (!flag2)
			{
				bool flag3 = true;
				if (!flag)
				{
					this.int_0 = 0;
				}
				flag2 = true;
				for (int j = 0; j < 4; j++)
				{
					if (!flag)
					{
						this.int_0 += array2[j].Count;
					}
					if (!array2[j].Done)
					{
						flag2 = false;
					}
					if (!array2[j].ProcessingCompleted)
					{
						flag3 = false;
					}
				}
				if (!flag && (flag = flag3))
				{
					this.int_0 = 0;
				}
				if (flag)
				{
					this.int_0++;
					if (this.int_0 > 100)
					{
						this.int_0 = 0;
					}
					this.method_56("Compressing " + regionfolder + " chunks", this.int_0);
				}
				else
				{
					this.method_55(string.Concat(new object[]
					{
						"Converting ",
						regionfolder,
						" chunk ",
						this.int_0,
						" of ",
						this.int_1
					}));
				}
				Thread.Sleep(100);
			}
			WaitHandle.WaitAll(array);
			foreach (ConvertConsoleParameters convertConsoleParameters2 in array2)
			{
				convertStatus.ProcessedChunkCount += convertConsoleParameters2.ProcessedChunkCount;
				convertStatus.MissingChunkCount += convertConsoleParameters2.MissingChunkCount;
				convertStatus.InvalidChunkCount += convertConsoleParameters2.InvalidChunkCount;
			}
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00034898 File Offset: 0x00032A98
		private void method_9(string string_1, ConvertParameters convertParameters_0)
		{
			string text = Working.WorkFolders[(int)convertParameters_0.method_0()];
			string text2 = Working.smethod_4();
			text = FileUtils.CheckFolderSep(string_1) + FileUtils.CheckFolderSep(text);
			text2 = FileUtils.CheckFolderSep(string_1) + FileUtils.CheckFolderSep(text2);
			Directory.CreateDirectory(text);
			File.Copy(text2 + "level.dat", text + "level.dat", true);
			if (File.Exists(text2 + "requiredGameRules.grf"))
			{
				this.method_10(string_1, text, convertParameters_0);
			}
			text += "data";
			text2 += "data";
			if (Directory.Exists(text2))
			{
				Directory.CreateDirectory(text);
				foreach (string text3 in Directory.GetFiles(text2, "*.*", SearchOption.TopDirectoryOnly))
				{
					File.Copy(text3, text3.Replace(text2, text), true);
				}
			}
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00034974 File Offset: 0x00032B74
		private void method_10(string string_1, string string_2, ConvertParameters convertParameters_0)
		{
			string text = string_2 + "requiredGameRules.grf";
			byte[] byte_ = GRFUtils.LoadGRF(string_1);
			GRFUtils.smethod_4(byte_, text, convertParameters_0.method_0());
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00004E61 File Offset: 0x00003061
		internal void method_11(string string_1, List<ModifiedFile> list_0, bool bool_0 = false)
		{
			if (!string.IsNullOrWhiteSpace(string_1))
			{
				string_1 = FileUtils.CheckFolderSep(string_1);
				this.method_12(string_1, list_0, bool_0);
				this.method_56("Process completed...", 0);
			}
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x000349A4 File Offset: 0x00032BA4
		private void method_12(string string_1, List<ModifiedFile> list_0, bool bool_0)
		{
			string text = string_1 + Working.smethod_1();
			string text2 = string_1 + Working.smethod_3();
			string text3 = string_1 + Working.smethod_2();
			byte[] array = new byte[12];
			List<IndexEntry> list = null;
			if (File.Exists(text))
			{
				using (BinaryReader binaryReader = new BinaryReader(File.Open(text, FileMode.Open)))
				{
					binaryReader.Read(array, 0, array.Length);
					list = Class46.smethod_1(binaryReader);
				}
			}
			if (list_0 != null)
			{
				list = this.method_14(list, list_0);
				list = this.method_13(list, list_0);
			}
			if (bool_0)
			{
				array[9] = 7;
				array[11] = 9;
			}
			if (list != null)
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(text2, FileMode.Create)))
				{
					binaryWriter.Write(array, 0, array.Length);
				}
				for (int i = 0; i < list.Count; i++)
				{
					IndexEntry indexEntry = list[i];
					int int_ = (int)((float)(i + 1) / (float)list.Count * 100f);
					this.method_56("Processing file - " + indexEntry.FilePath, int_);
					if (indexEntry.FilePath.EndsWith(".mcr"))
					{
						this.method_27(indexEntry, string_1);
					}
					else
					{
						this.method_25(indexEntry, string_1);
					}
				}
				long long_ = this.method_23(list, string_1);
				this.method_21(long_, array, list, string_1);
				if (Working.GameType == (Enum2)1)
				{
					ProcessCaller processCaller = new ProcessCaller();
					this.method_56("Compressing savegame.dat", 0);
					processCaller.CallCompressSaveGame(text2, text3);
				}
				if (Working.GameType == (Enum2)3)
				{
					this.method_56("Compressing savegame.wii", 0);
					this.method_7(text2, text3);
				}
				if (Settings.Default.ArchiveGameFile)
				{
					this.method_54(Working.smethod_7());
				}
				if (Working.GameType != (Enum2)1)
				{
					if (Working.GameType != (Enum2)3)
					{
						File.Copy(text2, Working.smethod_7(), true);
						goto IL_12E;
					}
				}
				File.Copy(text3, Working.smethod_7(), true);
			}
			IL_12E:
			FileUtils.smethod_10(text);
			FileUtils.smethod_11(text2, text);
			if (Working.GameType == (Enum2)2)
			{
				FileUtils.smethod_12(text, text3);
				if (Working.IsPS3Compressed || FileUtils.smethod_13(Working.smethod_7()) > 10485760L)
				{
					this.method_58(Working.smethod_7());
				}
				this.method_57(Path.GetDirectoryName(Working.smethod_7()));
			}
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00034C18 File Offset: 0x00032E18
		private List<IndexEntry> method_13(List<IndexEntry> list_0, List<ModifiedFile> list_1)
		{
			foreach (ModifiedFile modifiedFile in list_1)
			{
				if (modifiedFile.FileState == FileStateType.ADDED)
				{
					modifiedFile.FileState = FileStateType.PINNED;
					list_0.Add(modifiedFile.Tag as IndexEntry);
				}
			}
			return list_0;
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00034C84 File Offset: 0x00032E84
		private List<IndexEntry> method_14(List<IndexEntry> list_0, List<ModifiedFile> list_1)
		{
			List<IndexEntry> list = new List<IndexEntry>();
			foreach (IndexEntry indexEntry in list_0)
			{
				bool flag = false;
				foreach (ModifiedFile modifiedFile in list_1)
				{
					if (modifiedFile.Tag is IndexEntry && modifiedFile.FileState == FileStateType.DELETED && indexEntry.FileName == ((IndexEntry)modifiedFile.Tag).FileName)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					list.Add(indexEntry);
				}
			}
			return list;
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00034D54 File Offset: 0x00032F54
		public void UpdatedRegionFile(string dimension, string region, List<ModifiedFile> modifiedChunks, string workingFolder)
		{
			List<ChunkIndexEntry> list = null;
			string string_ = string.Concat(new string[]
			{
				workingFolder,
				Working.smethod_4(),
				FileUtils.CheckFolderSep(dimension),
				region,
				".mcr"
			});
			string path = string.Concat(new string[]
			{
				workingFolder,
				Working.smethod_4(),
				FileUtils.CheckFolderSep(dimension),
				region,
				".new"
			});
			list = Class46.smethod_5(string_);
			int num = 0;
			if (list != null && list.Count > 0)
			{
				IEnumerable<ChunkIndexEntry> source = list;
				if (MCSupport.func_0 == null)
				{
					MCSupport.func_0 = new Func<ChunkIndexEntry, int>(MCSupport.smethod_6);
				}
				list = source.OrderBy(MCSupport.func_0).ToList<ChunkIndexEntry>();
				IEnumerable<ModifiedFile> source2 = modifiedChunks;
				if (MCSupport.func_1 == null)
				{
					MCSupport.func_1 = new Func<ModifiedFile, int>(MCSupport.smethod_7);
				}
				modifiedChunks = source2.OrderBy(MCSupport.func_1).ToList<ModifiedFile>();
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Create)))
				{
					Class46.smethod_25(binaryWriter);
					foreach (ChunkIndexEntry chunkIndexEntry in list)
					{
						this.method_56("Updating Region - " + region + " Chunk - " + chunkIndexEntry.ChunkIndex.ToString(), 0);
						byte[] byte_ = null;
						if (chunkIndexEntry.OldChunkOffset > 0U)
						{
							if (num < modifiedChunks.Count && ((ChunkData)modifiedChunks[num].Tag).method_0().ChunkIndex == chunkIndexEntry.ChunkIndex)
							{
								if (((ChunkData)modifiedChunks[num].Tag).method_0().OldChunkOffset > 0U)
								{
									ModifiedFile modifiedFile_ = modifiedChunks[num];
									byte_ = this.method_15(modifiedFile_);
								}
								else
								{
									chunkIndexEntry.OldChunkOffset = 0U;
									chunkIndexEntry.OldChunkLength = 0;
									chunkIndexEntry.NewChunkOffset = 0U;
									chunkIndexEntry.NewChunkLength = 0;
								}
								num++;
							}
							else
							{
								byte_ = Class46.smethod_10(string_, chunkIndexEntry);
							}
							if (chunkIndexEntry.OldChunkOffset > 0U)
							{
								Class46.smethod_13(byte_, chunkIndexEntry, binaryWriter);
							}
						}
					}
					Class46.smethod_31(binaryWriter, list);
				}
				FileUtils.smethod_10(string_);
				FileUtils.smethod_11(path, string_);
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00034FBC File Offset: 0x000331BC
		private byte[] method_15(ModifiedFile modifiedFile_0)
		{
			byte[] result = null;
			if (modifiedFile_0 != null)
			{
				NbtFileDataNode nbtFileDataNode = modifiedFile_0.FileNode as NbtFileDataNode;
				if (nbtFileDataNode != null)
				{
					MemoryStream memoryStream;
					if (Working.WorldVersionMajor < 9 || Working.WorldVersionMinor < 8)
					{
						memoryStream = new MemoryStream();
						nbtFileDataNode.Tree.WriteTo(memoryStream);
					}
					else
					{
						TagNodeCompound root = nbtFileDataNode.Tree.Root;
						TU17Converter tu17Converter = new TU17Converter();
						memoryStream = tu17Converter.ConvertToTU17(root);
					}
					ChunkData chunkData = modifiedFile_0.Tag as ChunkData;
					chunkData.NewFileSize = (int)memoryStream.Length;
					memoryStream = Class46.smethod_70(memoryStream.ToArray());
					int num = (int)memoryStream.Length;
					byte[] array = null;
					if (Working.GameType == (Enum2)1)
					{
						XBOXCompression xboxcompression = new XBOXCompression();
						array = xboxcompression.DoCompress(memoryStream.ToArray(), 8);
						Class46.smethod_27(array.Length - 8, array);
						Class46.smethod_28(chunkData.NewFileSize, array);
					}
					else if (Working.GameType == (Enum2)2)
					{
						array = Class46.smethod_66(memoryStream.ToArray());
						byte[] first = new byte[12];
						array = first.Concat(array).ToArray<byte>();
						Class46.smethod_27(array.Length - 8, array);
						Class46.smethod_28(chunkData.NewFileSize, array);
						Class46.smethod_29(num, array);
					}
					else if (Working.GameType == (Enum2)3)
					{
						array = Class46.smethod_63(memoryStream.ToArray());
						byte[] first2 = new byte[8];
						array = first2.Concat(array).ToArray<byte>();
						Class46.smethod_27(array.Length - 8, array);
						Class46.smethod_28(chunkData.NewFileSize, array);
					}
					result = array;
				}
			}
			return result;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00004E88 File Offset: 0x00003088
		internal void method_16(string string_1, bool bool_0 = false, bool bool_1 = false)
		{
			if (!string.IsNullOrWhiteSpace(string_1))
			{
				string_1 = FileUtils.CheckFolderSep(string_1);
				this.method_17(string_1, bool_0, bool_1);
				this.method_56("Process completed...", 0);
			}
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00035154 File Offset: 0x00033354
		private void method_17(string string_1, bool bool_0, bool bool_1)
		{
			string text = string_1 + Working.smethod_1();
			string text2 = string_1 + Working.smethod_3();
			string text3 = string_1 + Working.smethod_2();
			byte[] array = new byte[12];
			List<IndexEntry> list = null;
			if (File.Exists(text))
			{
				using (BinaryReader binaryReader = new BinaryReader(File.Open(text, FileMode.Open)))
				{
					binaryReader.Read(array, 0, array.Length);
					list = Class46.smethod_1(binaryReader);
				}
			}
			if (bool_0)
			{
				array[9] = 7;
				array[11] = 9;
			}
			if (list != null)
			{
				if (bool_1)
				{
					this.method_18(list);
				}
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(text2, FileMode.Create)))
				{
					binaryWriter.Write(array, 0, array.Length);
				}
				for (int i = 0; i < list.Count; i++)
				{
					IndexEntry indexEntry = list[i];
					int int_ = (int)((float)(i + 1) / (float)list.Count * 100f);
					this.method_56("Processing file - " + indexEntry.FilePath, int_);
					if (indexEntry.FilePath.EndsWith(".mcr"))
					{
						this.method_27(indexEntry, string_1);
					}
					else
					{
						this.method_25(indexEntry, string_1);
					}
				}
				long long_ = this.method_23(list, string_1);
				this.method_21(long_, array, list, string_1);
				if (Working.GameType == (Enum2)1)
				{
					ProcessCaller processCaller = new ProcessCaller();
					this.method_56("Compressing savegame.dat", 0);
					processCaller.CallCompressSaveGame(text2, text3);
				}
				if (Working.GameType == (Enum2)3)
				{
					this.method_56("Compressing savegame.wii", 0);
					this.method_7(text2, text3);
				}
				if (Settings.Default.ArchiveGameFile)
				{
					this.method_54(Working.smethod_7());
				}
				if (Working.GameType != (Enum2)1)
				{
					if (Working.GameType != (Enum2)3)
					{
						File.Copy(text2, Working.smethod_7(), true);
						goto IL_120;
					}
				}
				File.Copy(text3, Working.smethod_7(), true);
			}
			IL_120:
			FileUtils.smethod_10(text);
			FileUtils.smethod_11(text2, text);
			if (Working.GameType == (Enum2)2)
			{
				FileUtils.smethod_12(text, text3);
				if (Working.IsPS3Compressed || FileUtils.smethod_13(Working.smethod_7()) > 10485760L)
				{
					this.method_58(Working.smethod_7());
				}
				this.method_57(Path.GetDirectoryName(Working.smethod_7()));
			}
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x000353BC File Offset: 0x000335BC
		private void method_18(List<IndexEntry> list_0)
		{
			foreach (string str in Constants.regionFileNamesExt)
			{
				bool flag = false;
				foreach (IndexEntry indexEntry in list_0)
				{
					if (indexEntry.FileName == str + ".mcr")
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					string text = str + ".mcr";
					string filePath = Path.Combine("region", text);
					string fileExt = "mcr";
					string parentName = "region";
					IndexEntry item = new IndexEntry(filePath, text, fileExt, parentName, true, 0, 0);
					list_0.Add(item);
				}
			}
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00035488 File Offset: 0x00033688
		internal void method_19(string string_1, string string_2, Enum2 enum2_0)
		{
			string text = "";
			string string_3 = "";
			string string_4 = "";
			if (!string.IsNullOrWhiteSpace(string_1))
			{
				if (enum2_0 == (Enum2)1)
				{
					text = "savegame_working.dat";
					string_3 = "savegame_new.dat";
					string_4 = "savegame.dat";
				}
				else if (enum2_0 == (Enum2)2)
				{
					text = "gamedata_working";
					string_3 = "gamedata_new";
					string_4 = "GAMEDATA";
				}
				else if (enum2_0 == (Enum2)3)
				{
					text = "savegame_working.wii";
					string_3 = "savegame_new.wii";
					string_4 = "savegame.wii";
				}
				string_1 = FileUtils.CheckFolderSep(string_1);
				FileUtils.smethod_12(string_1 + Working.smethod_1(), string_1 + text);
				this.method_20(string_1, text, string_3, string_4, string_2, enum2_0);
				this.method_56("Creation completed...", 0);
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0003553C File Offset: 0x0003373C
		private void method_20(string string_1, string string_2, string string_3, string string_4, string string_5, Enum2 enum2_0)
		{
			string string_6 = Working.WorkFolders[(int)enum2_0];
			string path = string_1 + string_2;
			string text = string_1 + string_3;
			string text2 = string_1 + string_4;
			byte[] array = new byte[12];
			List<IndexEntry> list = null;
			List<IndexEntry> list2 = new List<IndexEntry>();
			if (File.Exists(path))
			{
				using (BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open)))
				{
					binaryReader.Read(array, 0, array.Length);
					list = Class46.smethod_1(binaryReader);
				}
			}
			if (list != null)
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(text, FileMode.Create)))
				{
					binaryWriter.Write(array, 0, array.Length);
				}
				for (int i = 0; i < list.Count; i++)
				{
					IndexEntry indexEntry = list[i];
					if ((indexEntry.ParentName == null || indexEntry.ParentName.ToLower() != "players") && !indexEntry.FileName.StartsWith("P_") && !indexEntry.FileName.StartsWith("N_") && indexEntry.FileName != "mapDataMappings.dat" && indexEntry.FileName != "largeMapDataMappings.dat")
					{
						int int_ = (int)((float)(i + 1) / (float)list.Count * 100f);
						this.method_56("Processing file - " + indexEntry.FilePath, int_);
						if (indexEntry.FilePath.EndsWith(".mcr"))
						{
							this.method_28(indexEntry, string_1, string_3, string_6);
						}
						else
						{
							this.method_26(indexEntry, string_1, string_3, string_6);
						}
						list2.Add(indexEntry);
					}
				}
				list = list2;
				long long_ = this.method_24(list, string_1, string_3);
				this.method_22(long_, array, list, string_1, string_3);
				if (enum2_0 == (Enum2)1)
				{
					ProcessCaller processCaller = new ProcessCaller();
					this.method_56("Compressing savegame.dat", 0);
					processCaller.CallCompressSaveGame(text, text2);
				}
				if (enum2_0 == (Enum2)3)
				{
					this.method_56("Compressing savegame.wii", 0);
					this.method_7(text, text2);
				}
				if (Settings.Default.ArchiveGameFile)
				{
					this.method_54(string_5);
				}
				if (enum2_0 != (Enum2)1)
				{
					if (enum2_0 != (Enum2)3)
					{
						File.Copy(text, string_5, true);
						goto IL_10C;
					}
				}
				File.Copy(text2, string_5, true);
			}
			IL_10C:
			FileUtils.smethod_10(text2);
			FileUtils.smethod_10(text);
			FileUtils.smethod_10(path);
			if (enum2_0 == (Enum2)2)
			{
				if (Working.IsPS3Compressed || FileUtils.smethod_13(Working.smethod_7()) > 10485760L)
				{
					this.method_58(string_5);
				}
				this.method_57(Path.GetDirectoryName(string_5));
			}
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00004EAF File Offset: 0x000030AF
		private void method_21(long long_0, byte[] byte_0, List<IndexEntry> list_0, string string_1)
		{
			this.method_22(long_0, byte_0, list_0, string_1, Working.smethod_3());
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0003580C File Offset: 0x00033A0C
		private void method_22(long long_0, byte[] byte_0, List<IndexEntry> list_0, string string_1, string string_2)
		{
			string path = string_1 + string_2;
			if (File.Exists(path))
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Open)))
				{
					binaryWriter.Seek(0, SeekOrigin.Begin);
					FileUtils.smethod_7(binaryWriter, (uint)long_0, FileUtils.ByteOrder.BigEndian);
					FileUtils.smethod_7(binaryWriter, (uint)list_0.Count, FileUtils.ByteOrder.BigEndian);
					binaryWriter.Write(byte_0[8]);
					binaryWriter.Write(byte_0[9]);
					binaryWriter.Write(byte_0[10]);
					binaryWriter.Write(byte_0[11]);
				}
			}
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00004EC1 File Offset: 0x000030C1
		private long method_23(List<IndexEntry> list_0, string string_1)
		{
			return this.method_24(list_0, string_1, Working.smethod_3());
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0003589C File Offset: 0x00033A9C
		private long method_24(List<IndexEntry> list_0, string string_1, string string_2)
		{
			string path = string_1 + string_2;
			long result = 0L;
			if (File.Exists(path))
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Append)))
				{
					binaryWriter.Seek(0, SeekOrigin.End);
					result = binaryWriter.BaseStream.Position;
					foreach (IndexEntry indexEntry in list_0)
					{
						indexEntry.UpdateRawData();
						binaryWriter.Write(indexEntry.RawData, 0, indexEntry.RawData.Length);
					}
				}
			}
			return result;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00004ED0 File Offset: 0x000030D0
		private void method_25(IndexEntry indexEntry_0, string string_1)
		{
			this.method_26(indexEntry_0, string_1, Working.smethod_3(), Working.smethod_4());
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00035958 File Offset: 0x00033B58
		private void method_26(IndexEntry indexEntry_0, string string_1, string string_2, string string_3)
		{
			string path = string_1 + string_2;
			string path2 = string_1 + string_3 + indexEntry_0.FilePath;
			if (File.Exists(path))
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Append)))
				{
					binaryWriter.Seek(0, SeekOrigin.End);
					indexEntry_0.FileOffset = (uint)binaryWriter.BaseStream.Position;
					using (BinaryReader binaryReader = new BinaryReader(File.Open(path2, FileMode.Open)))
					{
						long length = binaryReader.BaseStream.Length;
						indexEntry_0.FileLength = (uint)length;
						binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
						int num = 0;
						while ((long)num < length)
						{
							binaryWriter.Write(binaryReader.ReadByte());
							num++;
						}
					}
				}
			}
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00004EE4 File Offset: 0x000030E4
		private void method_27(IndexEntry indexEntry_0, string string_1)
		{
			this.method_28(indexEntry_0, string_1, Working.smethod_3(), Working.smethod_4());
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00035A3C File Offset: 0x00033C3C
		private void method_28(IndexEntry indexEntry_0, string string_1, string string_2, string string_3)
		{
			string path = string_1 + string_2;
			string path2 = string_1 + string_3 + indexEntry_0.FilePath;
			if (File.Exists(path))
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Open)))
				{
					binaryWriter.Seek(0, SeekOrigin.End);
					indexEntry_0.FileOffset = (uint)binaryWriter.BaseStream.Position;
					if (File.Exists(path2))
					{
						using (BinaryReader binaryReader = new BinaryReader(File.Open(path2, FileMode.Open)))
						{
							long length = binaryReader.BaseStream.Length;
							indexEntry_0.FileLength = (uint)length;
							binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
							int num = 0;
							while ((long)num < length)
							{
								binaryWriter.Write(binaryReader.ReadByte());
								num++;
							}
						}
					}
				}
			}
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00035B28 File Offset: 0x00033D28
		internal List<IndexEntry> method_29(string string_1, string string_2, bool bool_0 = false)
		{
			List<IndexEntry> result = null;
			if (!string.IsNullOrWhiteSpace(string_1) && !string.IsNullOrWhiteSpace(string_2))
			{
				this.method_56("Extraction started.", 0);
				string_2 = FileUtils.CheckFolderSep(string_2);
				this.method_30(string_1, string_2);
				result = this.method_31(string_2, bool_0);
				this.method_56("Extraction completed...", 100);
			}
			return result;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00035B7C File Offset: 0x00033D7C
		private void method_30(string string_1, string string_2)
		{
			if (File.Exists(string_1))
			{
				FileUtils.smethod_9(string_2);
				string outFolderPath = string_2 + Working.smethod_1();
				ProcessCaller processCaller = new ProcessCaller();
				processCaller.CallExtractSaveGame(string_1, outFolderPath);
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00035BB4 File Offset: 0x00033DB4
		private List<IndexEntry> method_31(string string_1, bool bool_0)
		{
			List<IndexEntry> list = new List<IndexEntry>();
			string path = string_1 + Working.smethod_1();
			if (File.Exists(path))
			{
				using (BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open)))
				{
					IEnumerable<IndexEntry> source = Class46.smethod_1(binaryReader);
					if (MCSupport.func_2 == null)
					{
						MCSupport.func_2 = new Func<IndexEntry, string>(MCSupport.smethod_8);
					}
					List<IndexEntry> list2 = source.OrderBy(MCSupport.func_2).ToList<IndexEntry>();
					for (int i = 0; i < list2.Count; i++)
					{
						IndexEntry indexEntry = list2[i];
						int int_ = (int)((float)(i + 1) / (float)list2.Count * 100f);
						this.method_56("Extracting file - " + indexEntry.FilePath, int_);
						this.method_32(binaryReader, indexEntry, string_1 + Working.smethod_4());
						if (indexEntry.FilePath.EndsWith(".mcr"))
						{
							list.Add(indexEntry);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00035CB4 File Offset: 0x00033EB4
		private void method_32(BinaryReader binaryReader_0, IndexEntry indexEntry_0, string string_1)
		{
			string text = string_1 + indexEntry_0.FilePath;
			MCSupport.smethod_4(text);
			binaryReader_0.BaseStream.Seek((long)((ulong)indexEntry_0.FileOffset), SeekOrigin.Begin);
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(text, FileMode.Create)))
			{
				int num = 0;
				while ((long)num < (long)((ulong)indexEntry_0.FileLength))
				{
					binaryWriter.Write(binaryReader_0.ReadByte());
					num++;
				}
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00035D30 File Offset: 0x00033F30
		internal ConvertStatus method_33(string string_1, ConvertParameters convertParameters_0)
		{
			ConvertStatus convertStatus = new ConvertStatus();
			try
			{
				this.method_51(convertParameters_0);
				this.method_35(string_1, convertParameters_0, convertStatus);
				this.method_38(convertParameters_0.ProcessWorldFolder, string_1, convertParameters_0);
				Thread.Sleep(500);
			}
			catch (Exception)
			{
			}
			return convertStatus;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00035D84 File Offset: 0x00033F84
		private void method_34(string string_1)
		{
			TagNodeCompound tagNodeCompound = Class46.smethod_49(string_1 + Working.smethod_4());
			if (tagNodeCompound != null)
			{
				int spawnX = tagNodeCompound["SpawnX"] as TagNodeInt;
				int spawnY = tagNodeCompound["SpawnY"] as TagNodeInt;
				int spawnZ = tagNodeCompound["SpawnZ"] as TagNodeInt;
				Working.SpawnX = spawnX;
				Working.SpawnY = spawnY;
				Working.SpawnZ = spawnZ;
				Working.smethod_11(Class46.smethod_47(spawnX));
				Working.smethod_13(Class46.smethod_47(spawnZ));
			}
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00035E10 File Offset: 0x00034010
		private void method_35(string string_1, ConvertParameters convertParameters_0, ConvertStatus convertStatus_0)
		{
			List<IndexEntry> list = null;
			string path = string_1 + Working.smethod_1();
			this.method_36(convertParameters_0);
			if (File.Exists(path))
			{
				using (BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open)))
				{
					Class38.smethod_0(binaryReader);
					list = Class46.smethod_1(binaryReader);
				}
				if (list != null)
				{
					this.method_40(list, string_1, convertParameters_0, convertStatus_0);
				}
			}
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00035E80 File Offset: 0x00034080
		private void method_36(ConvertParameters convertParameters_0)
		{
			if (!convertParameters_0.ConvertOverworld)
			{
				goto IL_65;
			}
			if (convertParameters_0.ConvertInto != ConvertIntoType.EmptyDimension)
			{
				goto IL_65;
			}
			IL_13:
			this.method_37(Constants.dimensionFolderNames[0], convertParameters_0);
			IL_21:
			if (!convertParameters_0.ConvertNether)
			{
				goto IL_6F;
			}
			if (convertParameters_0.ConvertInto != ConvertIntoType.EmptyDimension)
			{
				goto IL_6F;
			}
			IL_34:
			this.method_37(Constants.dimensionFolderNames[1], convertParameters_0);
			IL_42:
			if (!convertParameters_0.ConvertTheEnd)
			{
				goto IL_79;
			}
			if (convertParameters_0.ConvertInto != ConvertIntoType.EmptyDimension)
			{
				goto IL_79;
			}
			IL_55:
			this.method_37(Constants.dimensionFolderNames[2], convertParameters_0);
			return;
			IL_79:
			if (convertParameters_0.ConvertInto == ConvertIntoType.EmptyWorld)
			{
				goto IL_55;
			}
			return;
			IL_6F:
			if (convertParameters_0.ConvertInto != ConvertIntoType.EmptyWorld)
			{
				goto IL_42;
			}
			goto IL_34;
			IL_65:
			if (convertParameters_0.ConvertInto != ConvertIntoType.EmptyWorld)
			{
				goto IL_21;
			}
			goto IL_13;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00035F10 File Offset: 0x00034110
		private void method_37(string string_1, ConvertParameters convertParameters_0)
		{
			string text = Path.Combine(convertParameters_0.ProcessWorldFolder, string_1);
			FileUtils.smethod_9(text);
			FileUtils.smethod_8(text);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00035F38 File Offset: 0x00034138
		internal void method_38(string string_1, string string_2, ConvertParameters convertParameters_0)
		{
			string path = string_1 + "level.dat";
			TagNodeCompound tagNodeCompound = convertParameters_0.ModifiedLevelNode;
			if (tagNodeCompound == null)
			{
				TagNodeCompound tagNodeCompound2 = MCSupport.smethod_2(string_1);
				if (tagNodeCompound2 == null)
				{
					tagNodeCompound2 = MCSupport.smethod_3();
				}
				TagNodeCompound tagNodeCompound_ = Class46.smethod_49(string_2 + Working.smethod_4());
				tagNodeCompound = MCSupport.smethod_1(tagNodeCompound2, tagNodeCompound_, string_1, convertParameters_0);
			}
			this.method_41(tagNodeCompound, path);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00035F90 File Offset: 0x00034190
		internal static TagNodeCompound smethod_1(TagNodeCompound tagNodeCompound_0, TagNodeCompound tagNodeCompound_1, string string_1, ConvertParameters convertParameters_0)
		{
			if (tagNodeCompound_0 != null)
			{
				TagNodeCompound tagNodeCompound = tagNodeCompound_0["Data"] as TagNodeCompound;
				string fileName = Path.GetFileName(string_1.Substring(0, string_1.Length - 1));
				tagNodeCompound["LevelName"] = new TagNodeString(fileName);
				if (tagNodeCompound_1.ContainsKey("generatorName"))
				{
					tagNodeCompound["generatorName"] = tagNodeCompound_1["generatorName"].Copy();
				}
				if (tagNodeCompound_1.ContainsKey("generatorVersion"))
				{
					tagNodeCompound["generatorVersion"] = tagNodeCompound_1["generatorVersion"].Copy();
				}
				if (tagNodeCompound_1.ContainsKey("hasBeenInCreative"))
				{
					tagNodeCompound["allowCommands"] = (((TagNodeByte)tagNodeCompound_1["hasBeenInCreative"] == 0) ? 0 : 1);
				}
				if (tagNodeCompound_1.ContainsKey("GameType"))
				{
					tagNodeCompound["GameType"] = tagNodeCompound_1["GameType"].Copy();
				}
				if (tagNodeCompound_1 != null)
				{
					if (tagNodeCompound_1.ContainsKey("DayTime"))
					{
						tagNodeCompound["DayTime"] = tagNodeCompound_1["DayTime"].Copy();
					}
					else
					{
						tagNodeCompound["DayTime"] = new TagNodeLong(100L);
					}
					if (tagNodeCompound_1.ContainsKey("Time"))
					{
						tagNodeCompound["Time"] = tagNodeCompound_1["Time"].Copy();
					}
					tagNodeCompound["LastPlayed"] = new TagNodeLong(MCSupport.HxwMctKoOx());
					if (tagNodeCompound_1.ContainsKey("clearWeatherTime"))
					{
						tagNodeCompound["clearWeatherTime"] = tagNodeCompound_1["clearWeatherTime"].Copy();
					}
					if (tagNodeCompound_1.ContainsKey("raining"))
					{
						tagNodeCompound["raining"] = tagNodeCompound_1["raining"].Copy();
					}
					if (tagNodeCompound_1.ContainsKey("rainTime"))
					{
						tagNodeCompound["rainTime"] = tagNodeCompound_1["rainTime"].Copy();
					}
					if (tagNodeCompound_1.ContainsKey("thundering"))
					{
						tagNodeCompound["thundering"] = tagNodeCompound_1["thundering"].Copy();
					}
					if (tagNodeCompound_1.ContainsKey("thunderTime"))
					{
						tagNodeCompound["thunderTime"] = tagNodeCompound_1["thunderTime"].Copy();
					}
					tagNodeCompound["SpawnX"] = tagNodeCompound_1["SpawnX"].Copy();
					tagNodeCompound["SpawnY"] = tagNodeCompound_1["SpawnY"].Copy();
					tagNodeCompound["SpawnZ"] = tagNodeCompound_1["SpawnZ"].Copy();
				}
				if (convertParameters_0.SetPlayPosition && tagNodeCompound.ContainsKey("Player"))
				{
					TagNodeCompound tagNodeCompound2 = tagNodeCompound["Player"] as TagNodeCompound;
					tagNodeCompound2["Pos"] = new TagNodeList(TagType.TAG_DOUBLE)
					{
						new TagNodeDouble(convertParameters_0.PlayerPosition.X),
						new TagNodeDouble(convertParameters_0.PlayerPosition.Y),
						new TagNodeDouble(convertParameters_0.PlayerPosition.Z)
					};
					tagNodeCompound2["Rotation"] = new TagNodeList(TagType.TAG_FLOAT)
					{
						new TagNodeFloat(convertParameters_0.PlayerPosition.RotBody),
						new TagNodeFloat(convertParameters_0.PlayerPosition.RotHead)
					};
				}
			}
			return tagNodeCompound_0;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00036300 File Offset: 0x00034500
		private int method_39(List<IndexEntry> list_0, ConvertParameters convertParameters_0)
		{
			int num = 0;
			for (int i = 0; i < list_0.Count; i++)
			{
				IndexEntry indexEntry = list_0[i];
				if (indexEntry.FilePath.EndsWith(".mcr"))
				{
					if ((!(indexEntry.ParentName.ToLower() == "region") || !convertParameters_0.ConvertOverworld) && (!(indexEntry.ParentName.ToLower() == "dim-1") || !convertParameters_0.ConvertNether))
					{
						if (!(indexEntry.ParentName.ToLower() == "dim1") || !convertParameters_0.ConvertTheEnd)
						{
							goto IL_4D;
						}
					}
					num++;
				}
				IL_4D:;
			}
			return num;
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x000363A4 File Offset: 0x000345A4
		private void method_40(List<IndexEntry> list_0, string string_1, ConvertParameters convertParameters_0, ConvertStatus convertStatus_0)
		{
			int num = this.method_39(list_0, convertParameters_0);
			ManualResetEvent[] array = new ManualResetEvent[num];
			ConvertToPCParameters[] array2 = new ConvertToPCParameters[num];
			int num2 = 0;
			for (int i = 0; i < list_0.Count; i++)
			{
				IndexEntry indexEntry = list_0[i];
				if (indexEntry.FilePath.EndsWith(".mcr"))
				{
					if ((!(indexEntry.ParentName.ToLower() == "region") || !convertParameters_0.ConvertOverworld) && (!(indexEntry.ParentName.ToLower() == "dim-1") || !convertParameters_0.ConvertNether))
					{
						if (!(indexEntry.ParentName.ToLower() == "dim1") || !convertParameters_0.ConvertTheEnd)
						{
							goto IL_142;
						}
					}
					string regionName = indexEntry.FileName.Substring(0, indexEntry.FileName.LastIndexOf('.'));
					array[num2] = new ManualResetEvent(false);
					ConvertToPCParameters convertToPCParameters = new ConvertToPCParameters(indexEntry, regionName, indexEntry.ParentName, string_1, convertParameters_0, array[num2]);
					ConvertToPC @object = new ConvertToPC();
					ThreadPool.QueueUserWorkItem(new WaitCallback(@object.ConvertRegionFileToPC), convertToPCParameters);
					array2[num2] = convertToPCParameters;
					num2++;
				}
				IL_142:;
			}
			bool flag = false;
			while (!flag)
			{
				flag = true;
				this.int_0 = 0;
				for (int j = 0; j < array2.Length; j++)
				{
					this.int_0 += array2[j].Count;
					if (!array2[j].Done)
					{
						flag = false;
					}
				}
				this.method_55(string.Concat(new object[]
				{
					"Converting chunk ",
					this.int_0,
					" of ",
					this.int_1
				}));
				Thread.Sleep(100);
			}
			WaitHandle.WaitAll(array);
			this.method_56("Conversion completed.", 100);
			foreach (ConvertToPCParameters convertToPCParameters2 in array2)
			{
				convertStatus_0.ProcessedChunkCount += convertToPCParameters2.ProcessedChunkCount;
				convertStatus_0.MissingChunkCount += convertToPCParameters2.MissingChunkCount;
				convertStatus_0.InvalidChunkCount += convertToPCParameters2.InvalidChunkCount;
			}
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x000365D8 File Offset: 0x000347D8
		public bool method_41(TagNodeCompound level, string path)
		{
			bool result;
			try
			{
				NBTFile nbtfile = new NBTFile(path);
				Stream dataOutputStream = nbtfile.GetDataOutputStream();
				if (dataOutputStream == null)
				{
					NbtIOException ex = new NbtIOException("Failed to initialize compressed NBT stream for output");
					ex.Data["Level"] = level;
					throw ex;
				}
				new NbtTree(level)
				{
					UseBigEndian = true
				}.WriteTo(dataOutputStream);
				dataOutputStream.Close();
				result = true;
			}
			catch (Exception innerException)
			{
				LevelIOException ex2 = new LevelIOException("Could not save level file.", innerException);
				ex2.Data["Level"] = level;
				throw ex2;
			}
			return result;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0003666C File Offset: 0x0003486C
		internal static TagNodeCompound smethod_2(string string_1)
		{
			TagNodeCompound result = null;
			string path = Path.Combine(string_1, "level.dat");
			if (File.Exists(path))
			{
				NBTFile nbtfile = new NBTFile(path);
				Stream dataInputStream = nbtfile.GetDataInputStream();
				if (dataInputStream != null)
				{
					NbtTree nbtTree = new NbtTree();
					nbtTree.UseBigEndian = true;
					nbtTree.ReadFrom(dataInputStream);
					result = nbtTree.Root;
				}
			}
			return result;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x000366C0 File Offset: 0x000348C0
		internal static TagNodeCompound smethod_3()
		{
			TagNodeCompound result = null;
			string fileName = "MCFiles.level_1_14_4.dat";
			byte[] array = EmbeddedUtils.GetResourceBytes(fileName);
			if (array != null)
			{
				array = Class46.smethod_65(array);
				MemoryStream memoryStream = new MemoryStream(array);
				NbtTree nbtTree = new NbtTree();
				nbtTree.UseBigEndian = true;
				nbtTree.ReadFrom(memoryStream);
				result = nbtTree.Root;
				memoryStream.Close();
			}
			return result;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00036714 File Offset: 0x00034914
		private static long HxwMctKoOx()
		{
			double totalMilliseconds = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
			return (long)totalMilliseconds;
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00036748 File Offset: 0x00034948
		private int method_42()
		{
			DateTime now = DateTime.Now;
			return (int)((DateTime.UtcNow - now).Ticks / 10000000L);
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0003677C File Offset: 0x0003497C
		internal ConvertStatus method_43(string string_1, string string_2, ConvertParameters convertParameters_0)
		{
			ConvertStatus convertStatus = new ConvertStatus();
			try
			{
				this.InitBedrockFromConsoleConversion(string_1, string_2, convertParameters_0, convertStatus);
				this.method_46(string_1, string_2, convertParameters_0);
				this.method_16(string_2, false, convertParameters_0.ConvertNewGen);
				Thread.Sleep(500);
			}
			catch (Exception)
			{
			}
			return convertStatus;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x000367D0 File Offset: 0x000349D0
		private void method_44(string string_1)
		{
			TagNodeCompound tagNodeCompound = MCSupport.smethod_2(string_1);
			if (tagNodeCompound != null)
			{
				int num = tagNodeCompound["SpawnX"] as TagNodeInt;
				int spawnY = tagNodeCompound["SpawnY"] as TagNodeInt;
				int num2 = tagNodeCompound["SpawnZ"] as TagNodeInt;
				if (num > 431 || num < -432)
				{
					num = 0;
				}
				if (num2 > 431 || num2 < -432)
				{
					num2 = 0;
				}
				Working.SpawnX = num;
				Working.SpawnY = spawnY;
				Working.SpawnZ = num2;
				Working.smethod_11(Class46.smethod_47(num));
				Working.smethod_13(Class46.smethod_47(num2));
				return;
			}
			Working.SpawnX = 0;
			Working.SpawnY = 64;
			Working.SpawnZ = 0;
			Working.smethod_11(0);
			Working.smethod_13(0);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0003689C File Offset: 0x00034A9C
		public void InitPCConversion(string regionfolder, string pcPath, string workingFolder, ConvertParameters convertParameters, ConvertStatus convertStatus)
		{
			string text = this.method_45(pcPath, regionfolder);
			if (FileUtils.CheckFolderExists(text))
			{
				string[] regionFileNames = Constants.getRegionFileNames(convertParameters.ConvertNewGen);
				ManualResetEvent[] array = new ManualResetEvent[regionFileNames.Length];
				ConvertFromPCParameters[] array2 = new ConvertFromPCParameters[regionFileNames.Length];
				int num = 0;
				foreach (string regionName in Constants.getRegionFileNames(convertParameters.ConvertNewGen))
				{
					array[num] = new ManualResetEvent(false);
					ConvertFromPCParameters convertFromPCParameters = new ConvertFromPCParameters(regionName, regionfolder, text, workingFolder, convertParameters, array[num]);
					ConvertFromPC @object = new ConvertFromPC();
					ThreadPool.QueueUserWorkItem(new WaitCallback(@object.ExtractPCRegion), convertFromPCParameters);
					array2[num] = convertFromPCParameters;
					num++;
				}
				bool flag = false;
				bool flag2 = false;
				while (!flag2)
				{
					bool flag3 = true;
					if (!flag)
					{
						this.int_0 = 0;
					}
					flag2 = true;
					for (int j = 0; j < 4; j++)
					{
						if (!flag)
						{
							this.int_0 += array2[j].Count;
						}
						if (!array2[j].Done)
						{
							flag2 = false;
						}
						if (!array2[j].ProcessingCompleted)
						{
							flag3 = false;
						}
					}
					if (!flag && (flag = flag3))
					{
						this.int_0 = 0;
					}
					if (flag)
					{
						this.int_0++;
						if (this.int_0 > 100)
						{
							this.int_0 = 0;
						}
						this.method_56("Compressing " + regionfolder + " chunks", this.int_0);
					}
					else
					{
						this.method_55(string.Concat(new object[]
						{
							"Converting ",
							regionfolder,
							" chunk ",
							this.int_0,
							" of ",
							this.int_1
						}));
					}
					Thread.Sleep(100);
				}
				WaitHandle.WaitAll(array);
				foreach (ConvertFromPCParameters convertFromPCParameters2 in array2)
				{
					convertStatus.ProcessedChunkCount += convertFromPCParameters2.ProcessedChunkCount;
					convertStatus.MissingChunkCount += convertFromPCParameters2.MissingChunkCount;
					convertStatus.InvalidChunkCount += convertFromPCParameters2.InvalidChunkCount;
				}
			}
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00036ACC File Offset: 0x00034CCC
		private string method_45(string string_1, string string_2)
		{
			string text = string_1 + string_2;
			if (string_2.ToLower() != "region" && Utils.GetRegionFileCount(text) == 0)
			{
				int regionFileCount = Utils.GetRegionFileCount(text + this.string_0);
				if (regionFileCount > 0)
				{
					text += this.string_0;
				}
			}
			return FileUtils.CheckFolderSep(text);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00036B28 File Offset: 0x00034D28
		private void method_46(string string_1, string string_2, ConvertParameters convertParameters_0)
		{
			TagNodeCompound tagNodeCompound = Class46.smethod_49(string_2 + Working.smethod_4());
			TagNodeCompound tagNodeCompound2 = MCSupport.smethod_2(string_1);
			if (tagNodeCompound != null && tagNodeCompound2 != null)
			{
				string fileName = Path.GetFileName(string_1.Substring(0, string_1.Length - 1));
				tagNodeCompound["LevelName"] = new TagNodeString(fileName);
				if (tagNodeCompound2.ContainsKey("generatorName"))
				{
					tagNodeCompound["generatorName"] = tagNodeCompound2["generatorName"].Copy();
				}
				if (tagNodeCompound2.ContainsKey("generatorVersion"))
				{
					tagNodeCompound["generatorVersion"] = tagNodeCompound2["generatorVersion"].Copy();
				}
				if (tagNodeCompound2.ContainsKey("allowCommands"))
				{
					tagNodeCompound["hasBeenInCreative"] = tagNodeCompound2["allowCommands"].Copy();
				}
				if (tagNodeCompound2.ContainsKey("GameType"))
				{
					tagNodeCompound["GameType"] = tagNodeCompound2["GameType"].Copy();
				}
				tagNodeCompound["spawnBonusChest"] = new TagNodeByte(0);
				if (tagNodeCompound2 != null)
				{
					if (tagNodeCompound2.ContainsKey("DayTime"))
					{
						tagNodeCompound["DayTime"] = tagNodeCompound2["DayTime"].Copy();
					}
					else
					{
						tagNodeCompound["DayTime"] = new TagNodeLong(100L);
					}
					if (tagNodeCompound2.ContainsKey("Time"))
					{
						tagNodeCompound["Time"] = tagNodeCompound2["Time"].Copy();
					}
					if (tagNodeCompound2.ContainsKey("raining"))
					{
						tagNodeCompound["raining"] = tagNodeCompound2["raining"].Copy();
					}
					if (tagNodeCompound2.ContainsKey("rainTime"))
					{
						tagNodeCompound["rainTime"] = tagNodeCompound2["rainTime"].Copy();
					}
					if (tagNodeCompound2.ContainsKey("thundering"))
					{
						tagNodeCompound["thundering"] = tagNodeCompound2["thundering"].Copy();
					}
					if (tagNodeCompound2.ContainsKey("thunderTime"))
					{
						tagNodeCompound["thunderTime"] = tagNodeCompound2["thunderTime"].Copy();
					}
					int num = tagNodeCompound2["SpawnX"] as TagNodeInt;
					int d = tagNodeCompound2["SpawnY"] as TagNodeInt;
					int num2 = tagNodeCompound2["SpawnZ"] as TagNodeInt;
					if (num > 431 || num < -432)
					{
						num = 0;
					}
					if (num2 > 431 || num2 < -432)
					{
						num2 = 0;
					}
					tagNodeCompound["SpawnX"] = new TagNodeInt(num);
					tagNodeCompound["SpawnY"] = new TagNodeInt(d);
					tagNodeCompound["SpawnZ"] = new TagNodeInt(num2);
					if (convertParameters_0.ConvertNewGen)
					{
						tagNodeCompound["XZSize"] = new TagNodeInt(128);
					}
				}
				TagNodeCompound tagNodeCompound3 = new TagNodeCompound();
				tagNodeCompound3["Data"] = tagNodeCompound;
				string text = string_2 + Working.smethod_4() + "level.dat";
				Class46.smethod_44(tagNodeCompound3, text);
			}
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00004EF8 File Offset: 0x000030F8
		public void SaveFiles(string workingFolder, Dictionary<string, ModifiedFile> modifiedFiles)
		{
			this.method_56("Processing Files...", 0);
			this.method_47(workingFolder, modifiedFiles);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00036E50 File Offset: 0x00035050
		private void method_47(string string_1, Dictionary<string, ModifiedFile> dictionary_0)
		{
			List<ModifiedFile> list = new List<ModifiedFile>();
			foreach (string key in dictionary_0.Keys)
			{
				ModifiedFile modifiedFile = dictionary_0[key];
				if (modifiedFile.FileState != FileStateType.PINNED)
				{
					if (modifiedFile.Tag is ChunkData)
					{
						if (modifiedFile.FileState == FileStateType.MODIFIED)
						{
							modifiedFile.FileNode.Save();
						}
						list.Add(modifiedFile);
					}
					else if (modifiedFile.FileState == FileStateType.MODIFIED && modifiedFile.FileNode != null)
					{
						modifiedFile.FileNode.Save();
					}
				}
			}
			if (list.Count > 0)
			{
				this.method_49(list, string_1);
			}
			this.method_11(string_1, dictionary_0.Values.ToList<ModifiedFile>(), false);
			this.method_48(dictionary_0);
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00036F28 File Offset: 0x00035128
		private void method_48(Dictionary<string, ModifiedFile> dictionary_0)
		{
			List<string> list = new List<string>();
			foreach (string text in dictionary_0.Keys)
			{
				if (dictionary_0[text].FileState == FileStateType.DELETED)
				{
					list.Add(text);
				}
				else if (dictionary_0[text].FileState == FileStateType.MODIFIED)
				{
					dictionary_0[text].FileState = FileStateType.PINNED;
				}
			}
			foreach (string key in list)
			{
				dictionary_0.Remove(key);
			}
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00036FF4 File Offset: 0x000351F4
		private void method_49(List<ModifiedFile> list_0, string string_1)
		{
			new ProcessCaller();
			Dictionary<Guid, List<ModifiedFile>> dictionary = new Dictionary<Guid, List<ModifiedFile>>();
			foreach (ModifiedFile modifiedFile in list_0)
			{
				ChunkData chunkData = modifiedFile.Tag as ChunkData;
				ChunkIndexEntry chunkIndexEntry = chunkData.method_0();
				IndexEntry regionIndex = chunkData.RegionIndex;
				if (modifiedFile.FileState != FileStateType.MODIFIED && modifiedFile.FileState == FileStateType.DELETED)
				{
					chunkIndexEntry.OldChunkOffset = 0U;
					chunkIndexEntry.OldChunkLength = 0;
					chunkIndexEntry.NewChunkOffset = 0U;
					chunkIndexEntry.NewChunkLength = 0;
				}
				if (!dictionary.ContainsKey(regionIndex.Key))
				{
					dictionary[regionIndex.Key] = new List<ModifiedFile>();
				}
				dictionary[regionIndex.Key].Add(modifiedFile);
			}
			this.method_50(string_1, dictionary);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x000370D4 File Offset: 0x000352D4
		private void method_50(string string_1, Dictionary<Guid, List<ModifiedFile>> dictionary_0)
		{
			foreach (Guid key in dictionary_0.Keys)
			{
				List<ModifiedFile> list = dictionary_0[key];
				if (list != null && list.Count > 0)
				{
					ChunkData chunkData = list[0].Tag as ChunkData;
					IndexEntry regionIndex = chunkData.RegionIndex;
					string parentName = regionIndex.ParentName;
					string region = regionIndex.FileName.Substring(0, regionIndex.FileName.LastIndexOf('.'));
					this.UpdatedRegionFile(parentName, region, list, string_1);
				}
			}
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00004F0E File Offset: 0x0000310E
		public MCSupport()
		{
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00004F21 File Offset: 0x00003121
		public MCSupport(BackgroundWorker bw)
		{
			this.bw = bw;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00037180 File Offset: 0x00035380
		private void method_51(ConvertParameters convertParameters_0)
		{
			int num = 0;
			if (convertParameters_0.ConvertOverworld)
			{
				num += Constants.consoleRegionSizes["region"];
			}
			if (convertParameters_0.ConvertNether)
			{
				num += Constants.consoleRegionSizes["DIM-1"];
			}
			if (convertParameters_0.ConvertTheEnd)
			{
				num += Constants.consoleRegionSizes["DIM1"];
			}
			this.int_1 = num * 4;
			this.int_0 = 0;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x000371F0 File Offset: 0x000353F0
		private void method_52(string string_1, bool bool_0)
		{
			int num = 0;
			if (bool_0)
			{
				num += Constants.consoleRegionSizesExt[string_1];
				num *= Constants.regionFileNamesExt.Length;
			}
			else
			{
				num += Constants.consoleRegionSizes[string_1];
				num *= 4;
			}
			this.int_1 = num;
			this.int_0 = 0;
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0003723C File Offset: 0x0003543C
		private void method_53(string string_1)
		{
			int num = 0 + Constants.consoleRegionSizes[string_1];
			this.int_1 = num;
			this.int_0 = 0;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00037268 File Offset: 0x00035468
		internal static void smethod_4(string string_1)
		{
			if (string_1.IndexOf("\\") > 0)
			{
				string text = string_1.Substring(0, string_1.LastIndexOf('\\'));
				FileUtils.smethod_9(text);
			}
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00004F3B File Offset: 0x0000313B
		internal static void smethod_5(IndexEntry indexEntry_0, string string_1)
		{
			MCSupport.smethod_4(string_1 + indexEntry_0.FilePath);
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0003729C File Offset: 0x0003549C
		private void method_54(string string_1)
		{
			DateTime now = DateTime.Now;
			string string_2 = string_1 + string.Format(".Archive.{0}.{1}.{2}.{3}.{4}.{5}", new object[]
			{
				now.Month,
				now.Day,
				now.Year,
				now.Hour,
				now.Minute,
				now.Second
			});
			if (File.Exists(string_1))
			{
				FileUtils.smethod_11(string_1, string_2);
			}
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00037334 File Offset: 0x00035534
		private void method_55(string string_1)
		{
			this.int_0++;
			int int_ = (int)((float)(this.int_0 + 1) / (float)this.int_1 * 100f);
			this.method_56(string_1, int_);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00004F4E File Offset: 0x0000314E
		private void method_56(string string_1, int int_2 = 0)
		{
			if (this.bw != null)
			{
				this.bw.ReportProgress(int_2, string_1);
			}
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00037370 File Offset: 0x00035570
		private void method_57(string string_1)
		{
			if (this.method_59(string_1))
			{
				Class2 @class = new Class2();
				@class.method_1(string_1);
				@class.method_3(string_1);
				@class.method_2(string_1);
			}
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x000373A4 File Offset: 0x000355A4
		private void method_58(string string_1)
		{
			Class47 @class = new Class47();
			byte[] array = FileUtils.smethod_0(string_1);
			MemoryStream memoryStream = new MemoryStream();
			@class.method_10(0, memoryStream);
			@class.method_10(array.Length, memoryStream);
			@class.method_10(array.Length, memoryStream);
			byte[] array2 = Class46.smethod_66(array);
			memoryStream.Write(array2, 0, array2.Length);
			FileUtils.WriteFile(memoryStream.ToArray(), string_1);
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00004F65 File Offset: 0x00003165
		private bool method_59(string string_1)
		{
			return File.Exists(string_1 + "\\GAMEDATA") && File.Exists(string_1 + "\\METADATA") && File.Exists(string_1 + "\\PARAM.PFD");
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x000031AC File Offset: 0x000013AC
		[CompilerGenerated]
		private static int smethod_6(ChunkIndexEntry chunkIndexEntry_0)
		{
			return chunkIndexEntry_0.ChunkIndex;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00004F9D File Offset: 0x0000319D
		[CompilerGenerated]
		private static int smethod_7(ModifiedFile modifiedFile_0)
		{
			return ((ChunkData)modifiedFile_0.Tag).method_0().ChunkIndex;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00004FB4 File Offset: 0x000031B4
		[CompilerGenerated]
		private static string smethod_8(IndexEntry indexEntry_0)
		{
			return indexEntry_0.FileExt;
		}

		// Token: 0x0400039A RID: 922
		private string string_0 = "\\region";

		// Token: 0x0400039B RID: 923
		private BackgroundWorker bw;

		// Token: 0x0400039C RID: 924
		private int int_0;

		// Token: 0x0400039D RID: 925
		private int int_1;

		// Token: 0x0400039E RID: 926
		[CompilerGenerated]
		private static Func<ChunkIndexEntry, int> func_0;

		// Token: 0x0400039F RID: 927
		[CompilerGenerated]
		private static Func<ModifiedFile, int> func_1;

		// Token: 0x040003A0 RID: 928
		[CompilerGenerated]
		private static Func<IndexEntry, string> func_2;
	}
}
