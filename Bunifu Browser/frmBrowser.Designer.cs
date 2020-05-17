namespace Bunifu_Browser
{
    partial class frmBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowser));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtSerachOrUrl = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnRefresh = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnForward = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.imgRefresh = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgSpinner = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.WhiteSmoke;
            this.bunifuCards1.Controls.Add(this.bunifuImageButton5);
            this.bunifuCards1.Controls.Add(this.bunifuImageButton6);
            this.bunifuCards1.Controls.Add(this.txtSerachOrUrl);
            this.bunifuCards1.Controls.Add(this.btnRefresh);
            this.bunifuCards1.Controls.Add(this.btnHome);
            this.bunifuCards1.Controls.Add(this.btnForward);
            this.bunifuCards1.Controls.Add(this.btnBack);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(-6, -6);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1145, 66);
            this.bunifuCards1.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.bunifuCards1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuCards1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuCards1, "");
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(1088, 20);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton5.TabIndex = 7;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton5, "Settings");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton5, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton5, "");
            this.bunifuImageButton5.Zoom = 10;
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.Image")));
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(1042, 20);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton6.TabIndex = 6;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton6, "Downloads");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton6, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton6, "");
            this.bunifuImageButton6.Zoom = 10;
            // 
            // txtSerachOrUrl
            // 
            this.txtSerachOrUrl.AcceptsReturn = false;
            this.txtSerachOrUrl.AcceptsTab = false;
            this.txtSerachOrUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerachOrUrl.AnimationSpeed = 220;
            this.txtSerachOrUrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSerachOrUrl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSerachOrUrl.BackColor = System.Drawing.Color.Transparent;
            this.txtSerachOrUrl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSerachOrUrl.BackgroundImage")));
            this.txtSerachOrUrl.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSerachOrUrl.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtSerachOrUrl.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSerachOrUrl.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSerachOrUrl.BorderRadius = 30;
            this.txtSerachOrUrl.BorderThickness = 2;
            this.txtSerachOrUrl.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSerachOrUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSerachOrUrl.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtSerachOrUrl.DefaultText = "";
            this.txtSerachOrUrl.FillColor = System.Drawing.Color.White;
            this.txtSerachOrUrl.HideSelection = true;
            this.txtSerachOrUrl.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSerachOrUrl.IconLeft")));
            this.txtSerachOrUrl.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSerachOrUrl.IconPadding = 10;
            this.txtSerachOrUrl.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSerachOrUrl.IconRight")));
            this.txtSerachOrUrl.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSerachOrUrl.Lines = new string[0];
            this.txtSerachOrUrl.Location = new System.Drawing.Point(226, 19);
            this.txtSerachOrUrl.MaxLength = 32767;
            this.txtSerachOrUrl.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtSerachOrUrl.Modified = false;
            this.txtSerachOrUrl.Multiline = false;
            this.txtSerachOrUrl.Name = "txtSerachOrUrl";
            this.txtSerachOrUrl.PasswordChar = '\0';
            this.txtSerachOrUrl.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSerachOrUrl.PlaceholderText = "Enter URL";
            this.txtSerachOrUrl.ReadOnly = false;
            this.txtSerachOrUrl.SelectedText = "";
            this.txtSerachOrUrl.SelectionLength = 0;
            this.txtSerachOrUrl.SelectionStart = 0;
            this.txtSerachOrUrl.ShortcutsEnabled = true;
            this.txtSerachOrUrl.Size = new System.Drawing.Size(796, 37);
            this.txtSerachOrUrl.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtSerachOrUrl.TabIndex = 5;
            this.txtSerachOrUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSerachOrUrl.TextMarginLeft = 10;
            this.txtSerachOrUrl.TextMarginTop = 0;
            this.txtSerachOrUrl.TextPlaceholder = "Enter URL";
            this.bunifuToolTip1.SetToolTip(this.txtSerachOrUrl, "");
            this.bunifuToolTip1.SetToolTipIcon(this.txtSerachOrUrl, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtSerachOrUrl, "");
            this.txtSerachOrUrl.UseSystemPasswordChar = false;
            this.txtSerachOrUrl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSerachOrUrl_KeyUp);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageActive = null;
            this.btnRefresh.Location = new System.Drawing.Point(178, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(30, 30);
            this.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnRefresh, "Refresh");
            this.bunifuToolTip1.SetToolTipIcon(this.btnRefresh, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnRefresh, "");
            this.btnRefresh.Zoom = 10;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageActive = null;
            this.btnHome.Location = new System.Drawing.Point(127, 22);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(30, 30);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 3;
            this.btnHome.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnHome, "Home");
            this.bunifuToolTip1.SetToolTipIcon(this.btnHome, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnHome, "");
            this.btnHome.Zoom = 10;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnForward
            // 
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.ImageActive = null;
            this.btnForward.Location = new System.Drawing.Point(73, 22);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(30, 30);
            this.btnForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnForward.TabIndex = 2;
            this.btnForward.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnForward, "Forward");
            this.bunifuToolTip1.SetToolTipIcon(this.btnForward, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnForward, "");
            this.btnForward.Zoom = 10;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageActive = null;
            this.btnBack.Location = new System.Drawing.Point(22, 22);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(30, 30);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 1;
            this.btnBack.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnBack, "Back");
            this.bunifuToolTip1.SetToolTipIcon(this.btnBack, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnBack, "");
            this.btnBack.Zoom = 10;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(4, 62);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1123, 733);
            this.webBrowser1.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.webBrowser1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.webBrowser1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.webBrowser1, "");
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = false;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 5000;
            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = false;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = null;
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = null;
            // 
            // imgRefresh
            // 
            this.imgRefresh.Image = ((System.Drawing.Image)(resources.GetObject("imgRefresh.Image")));
            this.imgRefresh.ImageActive = null;
            this.imgRefresh.Location = new System.Drawing.Point(47, 736);
            this.imgRefresh.Name = "imgRefresh";
            this.imgRefresh.Size = new System.Drawing.Size(30, 30);
            this.imgRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRefresh.TabIndex = 8;
            this.imgRefresh.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.imgRefresh, "Refresh");
            this.bunifuToolTip1.SetToolTipIcon(this.imgRefresh, null);
            this.bunifuToolTip1.SetToolTipTitle(this.imgRefresh, "");
            this.imgRefresh.Visible = false;
            this.imgRefresh.Zoom = 10;
            // 
            // imgSpinner
            // 
            this.imgSpinner.Image = ((System.Drawing.Image)(resources.GetObject("imgSpinner.Image")));
            this.imgSpinner.ImageActive = null;
            this.imgSpinner.Location = new System.Drawing.Point(83, 736);
            this.imgSpinner.Name = "imgSpinner";
            this.imgSpinner.Size = new System.Drawing.Size(30, 30);
            this.imgSpinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSpinner.TabIndex = 9;
            this.imgSpinner.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.imgSpinner, "Refresh");
            this.bunifuToolTip1.SetToolTipIcon(this.imgSpinner, null);
            this.bunifuToolTip1.SetToolTipTitle(this.imgSpinner, "");
            this.imgSpinner.Visible = false;
            this.imgSpinner.Zoom = 10;
            // 
            // frmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1129, 807);
            this.Controls.Add(this.imgSpinner);
            this.Controls.Add(this.imgRefresh);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBrowser";
            this.Text = "New Tab";
            this.bunifuCards1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpinner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtSerachOrUrl;
        private Bunifu.Framework.UI.BunifuImageButton btnRefresh;
        private Bunifu.Framework.UI.BunifuImageButton btnHome;
        private Bunifu.Framework.UI.BunifuImageButton btnForward;
        private Bunifu.Framework.UI.BunifuImageButton btnBack;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private Bunifu.Framework.UI.BunifuImageButton imgRefresh;
        private Bunifu.Framework.UI.BunifuImageButton imgSpinner;
    }
}