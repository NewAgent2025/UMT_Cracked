using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Full_UMT_Convertor.workers
{
	// Token: 0x02000151 RID: 337
	public class DirectBitmap : IDisposable
	{
		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x00009145 File Offset: 0x00007345
		// (set) Token: 0x06000E2C RID: 3628 RVA: 0x0000914D File Offset: 0x0000734D
		public Bitmap Bitmap { get; private set; }

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x00009156 File Offset: 0x00007356
		// (set) Token: 0x06000E2E RID: 3630 RVA: 0x0000915E File Offset: 0x0000735E
		public int[] Bits { get; private set; }

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x00009167 File Offset: 0x00007367
		// (set) Token: 0x06000E30 RID: 3632 RVA: 0x0000916F File Offset: 0x0000736F
		public bool Disposed { get; private set; }

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000E31 RID: 3633 RVA: 0x00009178 File Offset: 0x00007378
		// (set) Token: 0x06000E32 RID: 3634 RVA: 0x00009180 File Offset: 0x00007380
		public int Height { get; private set; }

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x00009189 File Offset: 0x00007389
		// (set) Token: 0x06000E34 RID: 3636 RVA: 0x00009191 File Offset: 0x00007391
		public int Width { get; private set; }

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000E35 RID: 3637 RVA: 0x0000919A File Offset: 0x0000739A
		// (set) Token: 0x06000E36 RID: 3638 RVA: 0x000091A2 File Offset: 0x000073A2
		private protected GCHandle BitsHandle { protected get; private set; }

		// Token: 0x06000E37 RID: 3639 RVA: 0x0005E3B4 File Offset: 0x0005C5B4
		public DirectBitmap(int width, int height)
		{
			this.Width = width;
			this.Height = height;
			this.Bits = new int[width * height];
			this.BitsHandle = GCHandle.Alloc(this.Bits, GCHandleType.Pinned);
			this.Bitmap = new Bitmap(width, height, width * 4, PixelFormat.Format32bppPArgb, this.BitsHandle.AddrOfPinnedObject());
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x0005E418 File Offset: 0x0005C618
		public void SetPixel(int x, int y, Color colour)
		{
			int num = x + y * this.Width;
			int num2 = colour.ToArgb();
			this.Bits[num] = num2;
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x0005E444 File Offset: 0x0005C644
		public Color GetPixel(int x, int y)
		{
			int num = x + y * this.Width;
			int argb = this.Bits[num];
			return Color.FromArgb(argb);
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x0005E470 File Offset: 0x0005C670
		public void Dispose()
		{
			if (this.Disposed)
			{
				return;
			}
			this.Disposed = true;
			this.Bitmap.Dispose();
			this.BitsHandle.Free();
		}

		// Token: 0x04000847 RID: 2119
		[CompilerGenerated]
		private Bitmap bitmap_0;

		// Token: 0x04000848 RID: 2120
		[CompilerGenerated]
		private int[] int_0;

		// Token: 0x04000849 RID: 2121
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400084A RID: 2122
		[CompilerGenerated]
		private int int_1;

		// Token: 0x0400084B RID: 2123
		[CompilerGenerated]
		private int int_2;

		// Token: 0x0400084C RID: 2124
		[CompilerGenerated]
		private GCHandle gchandle_0;
	}
}
