using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading.Tasks;

public class OverlayForm : Form
{
    // --- WinAPI ---
    [DllImport("user32.dll")] static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
    [DllImport("user32.dll")] static extern bool GetWindowRect(IntPtr hwnd, out RECT rect);
    [DllImport("user32.dll")] static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
    [DllImport("user32.dll")] static extern int GetWindowLong(IntPtr hWnd, int nIndex);
    [DllImport("user32.dll")] static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
    [DllImport("user32.dll")] static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
    [DllImport("user32.dll")] static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

    const uint WM_LBUTTONDOWN = 0x0201;
    const uint WM_LBUTTONUP = 0x0202;
    const int SW_MINIMIZE = 6;
    const int GWL_STYLE = -16;
    const int WS_MAXIMIZEBOX = 0x10000;
    const int WS_SIZEBOX = 0x40000;
    const uint SWP_NOSIZE = 0x0001;
    const uint SWP_NOZORDER = 0x0004;

    [StructLayout(LayoutKind.Sequential)]
    public struct RECT { public int Left, Top, Right, Bottom; }

    // --- Logic & Variables ---
    Process targetProcess;
    Timer timer = new Timer();
    Timer countCheckTimer = new Timer();
    Timer signOutCheckTimer = new Timer();
    int lastCount = -1;
    int lastSignOutCount = -1;
    bool isDragging = false;
    Point dragCursorOffset;

    // --- Layout Constants ---
    const int LEFT_X = 0;
    const int NBT_Y = 38, CONVERTER_Y = 102, PRUNER_Y = 166;
    const int EXTENSIONS_Y = 478, SETTINGS_Y = 542, SIGNOUT_Y = 606;
    const int NO_BUTTON_X = 886, MINIMIZE_X = 924;

    // --- Controls ---
    PictureBox logoBox = new PictureBox();
    PictureBox nbtButton = new PictureBox(), converterButton = new PictureBox();
    PictureBox prunerButton = new PictureBox(), extensionsButton = new PictureBox();
    PictureBox settingsButton = new PictureBox(), signOutButton = new PictureBox();
    PictureBox noButton = new PictureBox(), minimizeButton = new PictureBox();

    PictureBox converterOptionButton = new PictureBox(), converterHoverText = new PictureBox();
    PictureBox prunerOptionButton = new PictureBox(), prunerHoverText = new PictureBox();
    PictureBox nbtOptionButton = new PictureBox(), nbtHoverText = new PictureBox();

    // --- Images ---
    Image nbtNormal, nbtHover, converterNormal, converterHover, prunerNormal, prunerHover;
    Image extensionsNormal, extensionsHover, settingsNormal, settingsHover, signOutNormal, signOutHover;
    Image logoImage, noButtonImg, minimizeNormal, minimizeHover;
    Image converterOptionNormal, converterOptionHover, converterTextImage;
    Image prunerOptionNormal, prunerOptionHover, prunerTextImage;
    Image nbtOptionNormal, nbtOptionHover, nbtTextImage;

    public OverlayForm(Process process)
    {
        targetProcess = process;
        this.FormBorderStyle = FormBorderStyle.None;
        this.StartPosition = FormStartPosition.Manual;
        this.ShowInTaskbar = false;
        this.BackColor = Color.Lime;
        this.TransparencyKey = Color.Lime;

        SetParent(this.Handle, targetProcess.MainWindowHandle);
        DisableResize();
        LoadImages();

        // 1. Sidebar Buttons Setup
        SetupButton(nbtButton, nbtNormal, nbtHover, 70, 64);
        SetupButton(converterButton, converterNormal, converterHover, 70, 64);
        SetupButton(prunerButton, prunerNormal, prunerHover, 70, 64);
        SetupButton(extensionsButton, extensionsNormal, extensionsHover, 70, 64);
        SetupButton(settingsButton, settingsNormal, settingsHover, 70, 64);
        SetupButton(signOutButton, signOutNormal, signOutHover, 70, 64);

        PictureBox[] sidebars = { nbtButton, converterButton, prunerButton, extensionsButton, settingsButton, signOutButton };
        foreach (var btn in sidebars) { btn.Visible = false; }

        foreach (var btn in sidebars)
        {
            if (btn == signOutButton) continue;
            btn.Click += (s, e) => {
                ClickThroughToProcess(btn);
                btn.Image = GetNormalImage(btn);
                foreach (var b in sidebars) b.Visible = true;
                btn.Visible = false;
            };
        }

        signOutButton.Click += async (s, e) => {
            ClickThroughToProcess(signOutButton);
            signOutButton.Image = signOutNormal;
            foreach (var b in sidebars) b.Visible = true;
            signOutButton.Visible = false;
            try { using (WebClient wc = new WebClient()) await wc.DownloadStringTaskAsync("http://localhost/UMT_Minecraft_Cracked/sign-out.php"); } catch { }
        };

        // 2. Option Buttons & Hover Text
        SetupOptionButtons();

        converterOptionButton.Click += (s, e) => { ClickThroughToProcess(converterOptionButton); HideAllOptions(); ReloadSidebarImages(); foreach (var b in sidebars) b.Visible = true; converterButton.Visible = false; };
        prunerOptionButton.Click += (s, e) => { ClickThroughToProcess(prunerOptionButton); HideAllOptions(); ReloadSidebarImages(); foreach (var b in sidebars) b.Visible = true; prunerButton.Visible = false; };
        nbtOptionButton.Click += (s, e) => { ClickThroughToProcess(nbtOptionButton); HideAllOptions(); ReloadSidebarImages(); foreach (var b in sidebars) b.Visible = true; nbtButton.Visible = false; };

        SetupNoButton(); SetupMinimizeButton(); SetupLogo();

        timer.Interval = 10; timer.Tick += TrackPosition; timer.Start();
        countCheckTimer.Interval = 500; countCheckTimer.Tick += CheckCount; countCheckTimer.Start();
        signOutCheckTimer.Interval = 100; signOutCheckTimer.Tick += CheckSignOutCount; signOutCheckTimer.Start();
    }

    void SetupLogo()
    {
        logoBox.Size = new Size(455, 37);
        logoBox.Image = logoImage;
        logoBox.SizeMode = PictureBoxSizeMode.StretchImage;

        logoBox.MouseDown += (s, e) => { if (e.Button == MouseButtons.Left) { isDragging = true; dragCursorOffset = e.Location; } };
        logoBox.MouseMove += (s, e) => {
            if (isDragging)
            {
                Point mousePos = Cursor.Position;
                SetWindowPos(targetProcess.MainWindowHandle, IntPtr.Zero, mousePos.X - dragCursorOffset.X, mousePos.Y - dragCursorOffset.Y, 0, 0, SWP_NOSIZE | SWP_NOZORDER);
            }
        };
        logoBox.MouseUp += (s, e) => { isDragging = false; };
        Controls.Add(logoBox);
    }

    void SetupOptionButtons()
    {
        SetupButton(converterOptionButton, converterOptionNormal, converterOptionHover, 192, 192);
        SetupButton(prunerOptionButton, prunerOptionNormal, prunerOptionHover, 192, 192);
        SetupButton(nbtOptionButton, nbtOptionNormal, nbtOptionHover, 192, 192);

        converterHoverText.Size = new Size(446, 12); converterHoverText.SizeMode = PictureBoxSizeMode.StretchImage;
        prunerHoverText.Size = new Size(389, 11); prunerHoverText.SizeMode = PictureBoxSizeMode.StretchImage;
        nbtHoverText.Size = new Size(491, 11); nbtHoverText.SizeMode = PictureBoxSizeMode.StretchImage;

        converterOptionButton.MouseEnter += (s, e) => { if (converterOptionButton.Visible) { converterHoverText.Visible = true; converterHoverText.BringToFront(); } };
        converterOptionButton.MouseLeave += (s, e) => { converterHoverText.Visible = false; };

        prunerOptionButton.MouseEnter += (s, e) => { if (prunerOptionButton.Visible) { prunerHoverText.Visible = true; prunerHoverText.BringToFront(); } };
        prunerOptionButton.MouseLeave += (s, e) => { prunerHoverText.Visible = false; };

        nbtOptionButton.MouseEnter += (s, e) => { if (nbtOptionButton.Visible) { nbtHoverText.Visible = true; nbtHoverText.BringToFront(); } };
        nbtOptionButton.MouseLeave += (s, e) => { nbtHoverText.Visible = false; };

        Controls.Add(converterHoverText); Controls.Add(prunerHoverText); Controls.Add(nbtHoverText);
        HideAllOptions();
    }

    void ReloadOptionImages()
    {
        string optUrl = "https://raw.githubusercontent.com/NewAgent2025/NewAgentsSite/refs/heads/main/UMT_Images_Buttons/Converter_Options/";
        converterOptionNormal = LoadImage(optUrl + "Convertor.png");
        converterOptionHover = LoadImage(optUrl + "Convertor_h.png");
        converterTextImage = LoadImage(optUrl + "Convertor_Text.png");
        prunerOptionNormal = LoadImage(optUrl + "Pruner.png");
        prunerOptionHover = LoadImage(optUrl + "Pruner_h.png");
        prunerTextImage = LoadImage(optUrl + "Pruner_Text.png");
        nbtOptionNormal = LoadImage(optUrl + "NBT_Editor.png");
        nbtOptionHover = LoadImage(optUrl + "NBT_Editor_h.png");
        nbtTextImage = LoadImage(optUrl + "NBT_Text.png");

        if (converterHoverText != null) converterHoverText.Image = converterTextImage;
        if (prunerHoverText != null) prunerHoverText.Image = prunerTextImage;
        if (nbtHoverText != null) nbtHoverText.Image = nbtTextImage;

        converterOptionButton.Image = converterOptionNormal;
        prunerOptionButton.Image = prunerOptionNormal;
        nbtOptionButton.Image = nbtOptionNormal;
    }

    void LoadImages()
    {
        ReloadSidebarImages();
        ReloadOptionImages();
        string baseUrl = "https://raw.githubusercontent.com/NewAgent2025/NewAgentsSite/refs/heads/main/UMT_Images_Buttons/";
        logoImage = LoadImage(baseUrl + "UMT_Cracked_Logo.png");
        noButtonImg = LoadImage(baseUrl + "No_Button.png");
        minimizeNormal = LoadImage(baseUrl + "Minimize.png");
        minimizeHover = LoadImage(baseUrl + "Minimize_h.png");
    }

    void TrackPosition(object sender, EventArgs e)
    {
        if (targetProcess == null || targetProcess.HasExited) { Close(); return; }
        if (GetWindowRect(targetProcess.MainWindowHandle, out RECT rect))
        {
            nbtButton.Location = new Point(LEFT_X, NBT_Y);
            converterButton.Location = new Point(LEFT_X, CONVERTER_Y);
            prunerButton.Location = new Point(LEFT_X, PRUNER_Y);
            extensionsButton.Location = new Point(LEFT_X, EXTENSIONS_Y);
            settingsButton.Location = new Point(LEFT_X, SETTINGS_Y);
            signOutButton.Location = new Point(LEFT_X, SIGNOUT_Y);

            converterOptionButton.Location = new Point(404, 264);
            converterHoverText.Location = new Point(277, 502);
            prunerOptionButton.Location = new Point(616, 264);
            prunerHoverText.Location = new Point(305, 502);
            nbtOptionButton.Location = new Point(192, 264);
            nbtHoverText.Location = new Point(254, 502);

            noButton.Location = new Point(NO_BUTTON_X, 0);
            minimizeButton.Location = new Point(MINIMIZE_X, 0);
            logoBox.Location = new Point(0, 0);
            this.Location = new Point(0, 0);
            this.Size = new Size(1000, 700);
        }
    }

    // --- Helper Methods ---
    void HideAllOptions() { converterOptionButton.Visible = prunerOptionButton.Visible = nbtOptionButton.Visible = false; converterHoverText.Visible = prunerHoverText.Visible = nbtHoverText.Visible = false; }
    void ReloadSidebarImages() { string b = "https://raw.githubusercontent.com/NewAgent2025/NewAgentsSite/refs/heads/main/UMT_Images_Buttons/"; nbtNormal = LoadImage(b + "NBT_Editor.png"); nbtHover = LoadImage(b + "NBT_Editor_h.png"); converterNormal = LoadImage(b + "Converter.png"); converterHover = LoadImage(b + "Converter_h.png"); prunerNormal = LoadImage(b + "Pruner.png"); prunerHover = LoadImage(b + "Pruner_h.png"); extensionsNormal = LoadImage(b + "Extensions.png"); extensionsHover = LoadImage(b + "Extensions_h.png"); settingsNormal = LoadImage(b + "Settings.png"); settingsHover = LoadImage(b + "Settings_h.png"); signOutNormal = LoadImage(b + "SignOut.png"); signOutHover = LoadImage(b + "SignOut_h.png"); }
    Image LoadImage(string url) { try { using (WebClient wc = new WebClient()) return Image.FromStream(new System.IO.MemoryStream(wc.DownloadData(url))); } catch { return new Bitmap(1, 1); } }
    void SetupButton(PictureBox btn, Image normal, Image hover, int w, int h) { btn.Size = new Size(w, h); btn.SizeMode = PictureBoxSizeMode.StretchImage; btn.Image = normal; btn.MouseEnter += (s, e) => { if (btn.Visible) btn.Image = hover; }; btn.MouseLeave += (s, e) => { if (btn.Visible) btn.Image = normal; }; Controls.Add(btn); }
    void SetupNoButton() { noButton.Size = new Size(38, 37); noButton.SizeMode = PictureBoxSizeMode.StretchImage; noButton.Image = noButtonImg; Controls.Add(noButton); }
    void SetupMinimizeButton() { minimizeButton.Size = new Size(38, 37); minimizeButton.SizeMode = PictureBoxSizeMode.StretchImage; minimizeButton.Image = minimizeNormal; minimizeButton.MouseEnter += (s, e) => minimizeButton.Image = minimizeHover; minimizeButton.MouseLeave += (s, e) => minimizeButton.Image = minimizeNormal; minimizeButton.MouseUp += (s, e) => ShowWindow(targetProcess.MainWindowHandle, SW_MINIMIZE); Controls.Add(minimizeButton); }
    private Image GetNormalImage(PictureBox pb) { if (pb == nbtButton) return nbtNormal; if (pb == converterButton) return converterNormal; if (pb == prunerButton) return prunerNormal; if (pb == extensionsButton) return extensionsNormal; if (pb == settingsButton) return settingsNormal; return signOutNormal; }
    private void ClickThroughToProcess(PictureBox btn) { if (targetProcess == null) return; int x = btn.Left + (btn.Width / 2); int y = btn.Top + (btn.Height / 2); IntPtr lParam = (IntPtr)((y << 16) | (x & 0xFFFF)); PostMessage(targetProcess.MainWindowHandle, WM_LBUTTONDOWN, (IntPtr)1, lParam); PostMessage(targetProcess.MainWindowHandle, WM_LBUTTONUP, IntPtr.Zero, lParam); }
    void DisableResize() { IntPtr hwnd = targetProcess.MainWindowHandle; int style = GetWindowLong(hwnd, GWL_STYLE); style &= ~WS_MAXIMIZEBOX; style &= ~WS_SIZEBOX; SetWindowLong(hwnd, GWL_STYLE, style); }
    async void CheckCount(object sender, EventArgs e) { try { using (WebClient wc = new WebClient()) { string text = (await wc.DownloadStringTaskAsync("http://localhost/UMT_Minecraft_Cracked/Count.txt")).Trim(); if (int.TryParse(text, out int newCount)) { if (lastCount == -1) { lastCount = newCount; return; } if (newCount != lastCount) { lastCount = newCount; HideAllOptions(); ReloadOptionImages(); await Task.Delay(1000); converterOptionButton.Visible = prunerOptionButton.Visible = nbtOptionButton.Visible = true; } } } } catch { } }
    async void CheckSignOutCount(object sender, EventArgs e) { try { using (WebClient wc = new WebClient()) { string text = (await wc.DownloadStringTaskAsync("http://localhost/UMT_Minecraft_Cracked/Sign_Out_Count.txt")).Trim(); if (int.TryParse(text, out int newSignOutCount)) { if (lastSignOutCount == -1) { lastSignOutCount = newSignOutCount; return; } if (newSignOutCount != lastSignOutCount) { lastSignOutCount = newSignOutCount; lastCount = -1; HideAllOptions(); nbtButton.Visible = converterButton.Visible = prunerButton.Visible = extensionsButton.Visible = settingsButton.Visible = signOutButton.Visible = false; } } } } catch { } }
}

class Program
{
    [STAThread] static void Main() { Process[] ps = Process.GetProcessesByName("UMT_Cracked"); if (ps.Length == 0) return; Application.EnableVisualStyles(); Application.Run(new OverlayForm(ps[0])); }
}
