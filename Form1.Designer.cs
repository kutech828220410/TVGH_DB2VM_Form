
namespace DB2VM_Form
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_Main = new System.Windows.Forms.Panel();
            this.plC_RJ_ScreenButton3 = new MyUI.PLC_RJ_ScreenButton();
            this.plC_RJ_ScreenButton2 = new MyUI.PLC_RJ_ScreenButton();
            this.plC_ScreenPage_Main = new MyUI.PLC_ScreenPage();
            this.UDSDBBCM = new System.Windows.Forms.TabPage();
            this.plC_ScreenPage_UDSDBBCM = new MyUI.PLC_ScreenPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部 = new MyUI.PLC_RJ_Button();
            this.rJ_GroupBox1 = new MyUI.RJ_GroupBox();
            this.sqL_DataGridView_UDSDBBCM = new SQLUI.SQL_DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox_UDSDBBCM_API_GET = new System.Windows.Forms.RichTextBox();
            this.rJ_Lable96 = new MyUI.RJ_Lable();
            this.rJ_TextBox_UDSDBBCM_API_URL = new MyUI.RJ_TextBox();
            this.plC_RJ_Button_UDSDBBCM_Get = new MyUI.PLC_RJ_Button();
            this.panel_UDSDBBCM = new System.Windows.Forms.Panel();
            this.plC_RJ_ScreenButton1 = new MyUI.PLC_RJ_ScreenButton();
            this.plC_RJ_ScreenButton4 = new MyUI.PLC_RJ_ScreenButton();
            this.系統 = new System.Windows.Forms.TabPage();
            this.lowerMachine_Panel1 = new LadderUI.LowerMachine_Panel();
            this.plC_UI_Init1 = new MyUI.PLC_UI_Init();
            this.ContentsPanel = new MyUI.RJ_Pannel();
            this.panel_Main.SuspendLayout();
            this.plC_ScreenPage_Main.SuspendLayout();
            this.UDSDBBCM.SuspendLayout();
            this.plC_ScreenPage_UDSDBBCM.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.rJ_GroupBox1.ContentsPanel.SuspendLayout();
            this.rJ_GroupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel_UDSDBBCM.SuspendLayout();
            this.系統.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.plC_RJ_ScreenButton3);
            this.panel_Main.Controls.Add(this.plC_RJ_ScreenButton2);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1264, 64);
            this.panel_Main.TabIndex = 0;
            // 
            // plC_RJ_ScreenButton3
            // 
            this.plC_RJ_ScreenButton3.but_press = false;
            this.plC_RJ_ScreenButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.plC_RJ_ScreenButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.plC_RJ_ScreenButton3.IconSize = 40;
            this.plC_RJ_ScreenButton3.Location = new System.Drawing.Point(183, 0);
            this.plC_RJ_ScreenButton3.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton3.Name = "plC_RJ_ScreenButton3";
            this.plC_RJ_ScreenButton3.OffBackColor = System.Drawing.Color.DarkCyan;
            this.plC_RJ_ScreenButton3.OffFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton3.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton3.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton3.OffText = "系統";
            this.plC_RJ_ScreenButton3.OnBackColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton3.OnFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton3.OnForeColor = System.Drawing.Color.DarkCyan;
            this.plC_RJ_ScreenButton3.OnIconColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_ScreenButton3.OnText = "系統";
            this.plC_RJ_ScreenButton3.ShowIcon = false;
            this.plC_RJ_ScreenButton3.Size = new System.Drawing.Size(183, 64);
            this.plC_RJ_ScreenButton3.TabIndex = 86;
            this.plC_RJ_ScreenButton3.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton3.寫入位置註解 = "";
            this.plC_RJ_ScreenButton3.寫入元件位置 = "";
            this.plC_RJ_ScreenButton3.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton3.控制位址 = "D0";
            this.plC_RJ_ScreenButton3.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton3.致能讀取位置 = "";
            this.plC_RJ_ScreenButton3.讀取位元反向 = false;
            this.plC_RJ_ScreenButton3.讀取位置註解 = "";
            this.plC_RJ_ScreenButton3.讀取元件位置 = "";
            this.plC_RJ_ScreenButton3.音效 = true;
            this.plC_RJ_ScreenButton3.頁面名稱 = "系統";
            this.plC_RJ_ScreenButton3.頁面編號 = 0;
            this.plC_RJ_ScreenButton3.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton3.顯示狀態 = false;
            this.plC_RJ_ScreenButton3.顯示讀取位置 = "";
            // 
            // plC_RJ_ScreenButton2
            // 
            this.plC_RJ_ScreenButton2.but_press = false;
            this.plC_RJ_ScreenButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.plC_RJ_ScreenButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.plC_RJ_ScreenButton2.IconSize = 40;
            this.plC_RJ_ScreenButton2.Location = new System.Drawing.Point(0, 0);
            this.plC_RJ_ScreenButton2.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton2.Name = "plC_RJ_ScreenButton2";
            this.plC_RJ_ScreenButton2.OffBackColor = System.Drawing.Color.DarkCyan;
            this.plC_RJ_ScreenButton2.OffFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton2.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton2.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton2.OffText = "UDSDBBCM";
            this.plC_RJ_ScreenButton2.OnBackColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton2.OnFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton2.OnForeColor = System.Drawing.Color.DarkCyan;
            this.plC_RJ_ScreenButton2.OnIconColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_ScreenButton2.OnText = "UDSDBBCM";
            this.plC_RJ_ScreenButton2.ShowIcon = false;
            this.plC_RJ_ScreenButton2.Size = new System.Drawing.Size(183, 64);
            this.plC_RJ_ScreenButton2.TabIndex = 85;
            this.plC_RJ_ScreenButton2.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton2.寫入位置註解 = "";
            this.plC_RJ_ScreenButton2.寫入元件位置 = "";
            this.plC_RJ_ScreenButton2.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton2.控制位址 = "D0";
            this.plC_RJ_ScreenButton2.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton2.致能讀取位置 = "";
            this.plC_RJ_ScreenButton2.讀取位元反向 = false;
            this.plC_RJ_ScreenButton2.讀取位置註解 = "";
            this.plC_RJ_ScreenButton2.讀取元件位置 = "";
            this.plC_RJ_ScreenButton2.音效 = true;
            this.plC_RJ_ScreenButton2.頁面名稱 = "UDSDBBCM";
            this.plC_RJ_ScreenButton2.頁面編號 = 0;
            this.plC_RJ_ScreenButton2.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton2.顯示狀態 = false;
            this.plC_RJ_ScreenButton2.顯示讀取位置 = "";
            // 
            // plC_ScreenPage_Main
            // 
            this.plC_ScreenPage_Main.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.plC_ScreenPage_Main.BackColor = System.Drawing.Color.White;
            this.plC_ScreenPage_Main.Controls.Add(this.UDSDBBCM);
            this.plC_ScreenPage_Main.Controls.Add(this.系統);
            this.plC_ScreenPage_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plC_ScreenPage_Main.ForekColor = System.Drawing.Color.Black;
            this.plC_ScreenPage_Main.ItemSize = new System.Drawing.Size(54, 21);
            this.plC_ScreenPage_Main.Location = new System.Drawing.Point(0, 64);
            this.plC_ScreenPage_Main.Name = "plC_ScreenPage_Main";
            this.plC_ScreenPage_Main.SelectedIndex = 0;
            this.plC_ScreenPage_Main.Size = new System.Drawing.Size(1264, 857);
            this.plC_ScreenPage_Main.TabBackColor = System.Drawing.Color.White;
            this.plC_ScreenPage_Main.TabIndex = 1;
            this.plC_ScreenPage_Main.顯示標籤列 = MyUI.PLC_ScreenPage.TabVisibleEnum.顯示;
            this.plC_ScreenPage_Main.顯示頁面 = 0;
            // 
            // UDSDBBCM
            // 
            this.UDSDBBCM.BackColor = System.Drawing.Color.White;
            this.UDSDBBCM.Controls.Add(this.plC_ScreenPage_UDSDBBCM);
            this.UDSDBBCM.Controls.Add(this.panel_UDSDBBCM);
            this.UDSDBBCM.Location = new System.Drawing.Point(4, 25);
            this.UDSDBBCM.Name = "UDSDBBCM";
            this.UDSDBBCM.Size = new System.Drawing.Size(1256, 828);
            this.UDSDBBCM.TabIndex = 0;
            this.UDSDBBCM.Text = "UDSDBBCM";
            // 
            // plC_ScreenPage_UDSDBBCM
            // 
            this.plC_ScreenPage_UDSDBBCM.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.plC_ScreenPage_UDSDBBCM.BackColor = System.Drawing.Color.White;
            this.plC_ScreenPage_UDSDBBCM.Controls.Add(this.tabPage1);
            this.plC_ScreenPage_UDSDBBCM.Controls.Add(this.tabPage2);
            this.plC_ScreenPage_UDSDBBCM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plC_ScreenPage_UDSDBBCM.ForekColor = System.Drawing.Color.Black;
            this.plC_ScreenPage_UDSDBBCM.ItemSize = new System.Drawing.Size(54, 21);
            this.plC_ScreenPage_UDSDBBCM.Location = new System.Drawing.Point(0, 64);
            this.plC_ScreenPage_UDSDBBCM.Name = "plC_ScreenPage_UDSDBBCM";
            this.plC_ScreenPage_UDSDBBCM.SelectedIndex = 0;
            this.plC_ScreenPage_UDSDBBCM.Size = new System.Drawing.Size(1256, 764);
            this.plC_ScreenPage_UDSDBBCM.TabBackColor = System.Drawing.Color.White;
            this.plC_ScreenPage_UDSDBBCM.TabIndex = 143;
            this.plC_ScreenPage_UDSDBBCM.顯示標籤列 = MyUI.PLC_ScreenPage.TabVisibleEnum.顯示;
            this.plC_ScreenPage_UDSDBBCM.顯示頁面 = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.plC_RJ_Button_USDSBBCM_表單_顯示全部);
            this.tabPage1.Controls.Add(this.rJ_GroupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1248, 735);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "表單";
            // 
            // plC_RJ_Button_USDSBBCM_表單_顯示全部
            // 
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.AutoResetState = false;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.Bool = false;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.BorderRadius = 5;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.BorderSize = 0;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.but_press = false;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.Location = new System.Drawing.Point(973, 633);
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.Name = "plC_RJ_Button_USDSBBCM_表單_顯示全部";
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.OFF_文字內容 = "顯示全部";
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.ON_文字內容 = "顯示全部";
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 12F);
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.Size = new System.Drawing.Size(171, 75);
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.State = false;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.TabIndex = 148;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.Text = "顯示全部";
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.Texts = "顯示全部";
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.字型鎖住 = false;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.文字鎖住 = false;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.讀取位元反向 = false;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.讀寫鎖住 = false;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.音效 = true;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.顯示 = false;
            this.plC_RJ_Button_USDSBBCM_表單_顯示全部.顯示狀態 = false;
            // 
            // rJ_GroupBox1
            // 
            // 
            // rJ_GroupBox1.ContentsPanel
            // 
            this.rJ_GroupBox1.ContentsPanel.BackColor = System.Drawing.Color.White;
            this.rJ_GroupBox1.ContentsPanel.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox1.ContentsPanel.BorderRadius = 5;
            this.rJ_GroupBox1.ContentsPanel.BorderSize = 2;
            this.rJ_GroupBox1.ContentsPanel.Controls.Add(this.sqL_DataGridView_UDSDBBCM);
            this.rJ_GroupBox1.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rJ_GroupBox1.ContentsPanel.ForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox1.ContentsPanel.Location = new System.Drawing.Point(0, 37);
            this.rJ_GroupBox1.ContentsPanel.Name = "ContentsPanel";
            this.rJ_GroupBox1.ContentsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.rJ_GroupBox1.ContentsPanel.Size = new System.Drawing.Size(1248, 576);
            this.rJ_GroupBox1.ContentsPanel.TabIndex = 2;
            this.rJ_GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rJ_GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.rJ_GroupBox1.Name = "rJ_GroupBox1";
            this.rJ_GroupBox1.PannelBackColor = System.Drawing.Color.White;
            this.rJ_GroupBox1.PannelBorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox1.PannelBorderRadius = 5;
            this.rJ_GroupBox1.PannelBorderSize = 2;
            this.rJ_GroupBox1.Size = new System.Drawing.Size(1248, 613);
            this.rJ_GroupBox1.TabIndex = 2;
            this.rJ_GroupBox1.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.rJ_GroupBox1.TitleBorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_GroupBox1.TitleBorderRadius = 5;
            this.rJ_GroupBox1.TitleBorderSize = 0;
            this.rJ_GroupBox1.TitleFont = new System.Drawing.Font("新細明體", 12F);
            this.rJ_GroupBox1.TitleForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox1.TitleHeight = 37;
            this.rJ_GroupBox1.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_GroupBox1.TitleTexts = "藥品資料";
            // 
            // sqL_DataGridView_UDSDBBCM
            // 
            this.sqL_DataGridView_UDSDBBCM.AutoSelectToDeep = true;
            this.sqL_DataGridView_UDSDBBCM.backColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_UDSDBBCM.BorderColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_UDSDBBCM.BorderRadius = 10;
            this.sqL_DataGridView_UDSDBBCM.BorderSize = 2;
            this.sqL_DataGridView_UDSDBBCM.cellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sqL_DataGridView_UDSDBBCM.cellStylBackColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_UDSDBBCM.cellStyleFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_UDSDBBCM.cellStylForeColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_UDSDBBCM.columnHeaderBackColor = System.Drawing.Color.SkyBlue;
            this.sqL_DataGridView_UDSDBBCM.columnHeaderFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_UDSDBBCM.columnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_UDSDBBCM.columnHeadersHeight = 18;
            this.sqL_DataGridView_UDSDBBCM.columnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqL_DataGridView_UDSDBBCM.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_UDSDBBCM.Columns"))));
            this.sqL_DataGridView_UDSDBBCM.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_UDSDBBCM.Columns1"))));
            this.sqL_DataGridView_UDSDBBCM.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_UDSDBBCM.Columns2"))));
            this.sqL_DataGridView_UDSDBBCM.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_UDSDBBCM.Columns3"))));
            this.sqL_DataGridView_UDSDBBCM.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_UDSDBBCM.Columns4"))));
            this.sqL_DataGridView_UDSDBBCM.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_UDSDBBCM.Columns5"))));
            this.sqL_DataGridView_UDSDBBCM.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_UDSDBBCM.Columns6"))));
            this.sqL_DataGridView_UDSDBBCM.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_UDSDBBCM.Columns7"))));
            this.sqL_DataGridView_UDSDBBCM.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_UDSDBBCM.Columns8"))));
            this.sqL_DataGridView_UDSDBBCM.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_UDSDBBCM.Columns9"))));
            this.sqL_DataGridView_UDSDBBCM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqL_DataGridView_UDSDBBCM.Font = new System.Drawing.Font("新細明體", 9F);
            this.sqL_DataGridView_UDSDBBCM.ImageBox = false;
            this.sqL_DataGridView_UDSDBBCM.Location = new System.Drawing.Point(5, 5);
            this.sqL_DataGridView_UDSDBBCM.Name = "sqL_DataGridView_UDSDBBCM";
            this.sqL_DataGridView_UDSDBBCM.OnlineState = SQLUI.SQL_DataGridView.OnlineEnum.Online;
            this.sqL_DataGridView_UDSDBBCM.Password = "user82822040";
            this.sqL_DataGridView_UDSDBBCM.Port = ((uint)(3306u));
            this.sqL_DataGridView_UDSDBBCM.rowHeaderBackColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_UDSDBBCM.rowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_UDSDBBCM.RowsColor = System.Drawing.Color.White;
            this.sqL_DataGridView_UDSDBBCM.RowsHeight = 60;
            this.sqL_DataGridView_UDSDBBCM.SaveFileName = "SQL_DataGridView";
            this.sqL_DataGridView_UDSDBBCM.Server = "127.0.0.0";
            this.sqL_DataGridView_UDSDBBCM.Size = new System.Drawing.Size(1238, 566);
            this.sqL_DataGridView_UDSDBBCM.SSLMode = MySql.Data.MySqlClient.MySqlSslMode.None;
            this.sqL_DataGridView_UDSDBBCM.TabIndex = 0;
            this.sqL_DataGridView_UDSDBBCM.TableName = "UDSDBBCM";
            this.sqL_DataGridView_UDSDBBCM.UserName = "root";
            this.sqL_DataGridView_UDSDBBCM.可拖曳欄位寬度 = false;
            this.sqL_DataGridView_UDSDBBCM.可選擇多列 = false;
            this.sqL_DataGridView_UDSDBBCM.單格樣式 = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sqL_DataGridView_UDSDBBCM.自動換行 = true;
            this.sqL_DataGridView_UDSDBBCM.表單字體 = new System.Drawing.Font("新細明體", 9F);
            this.sqL_DataGridView_UDSDBBCM.邊框樣式 = System.Windows.Forms.BorderStyle.None;
            this.sqL_DataGridView_UDSDBBCM.顯示CheckBox = false;
            this.sqL_DataGridView_UDSDBBCM.顯示首列 = true;
            this.sqL_DataGridView_UDSDBBCM.顯示首行 = true;
            this.sqL_DataGridView_UDSDBBCM.首列樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_UDSDBBCM.首行樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.richTextBox_UDSDBBCM_API_GET);
            this.tabPage2.Controls.Add(this.rJ_Lable96);
            this.tabPage2.Controls.Add(this.rJ_TextBox_UDSDBBCM_API_URL);
            this.tabPage2.Controls.Add(this.plC_RJ_Button_UDSDBBCM_Get);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1248, 735);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "API";
            // 
            // richTextBox_UDSDBBCM_API_GET
            // 
            this.richTextBox_UDSDBBCM_API_GET.Location = new System.Drawing.Point(28, 73);
            this.richTextBox_UDSDBBCM_API_GET.Name = "richTextBox_UDSDBBCM_API_GET";
            this.richTextBox_UDSDBBCM_API_GET.Size = new System.Drawing.Size(869, 535);
            this.richTextBox_UDSDBBCM_API_GET.TabIndex = 148;
            this.richTextBox_UDSDBBCM_API_GET.Text = "";
            // 
            // rJ_Lable96
            // 
            this.rJ_Lable96.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable96.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable96.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable96.BorderRadius = 8;
            this.rJ_Lable96.BorderSize = 0;
            this.rJ_Lable96.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable96.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_Lable96.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable96.Location = new System.Drawing.Point(24, 21);
            this.rJ_Lable96.Name = "rJ_Lable96";
            this.rJ_Lable96.Size = new System.Drawing.Size(122, 46);
            this.rJ_Lable96.TabIndex = 146;
            this.rJ_Lable96.Text = "API Url";
            this.rJ_Lable96.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable96.TextColor = System.Drawing.Color.Black;
            // 
            // rJ_TextBox_UDSDBBCM_API_URL
            // 
            this.rJ_TextBox_UDSDBBCM_API_URL.BackColor = System.Drawing.SystemColors.Window;
            this.rJ_TextBox_UDSDBBCM_API_URL.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rJ_TextBox_UDSDBBCM_API_URL.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_TextBox_UDSDBBCM_API_URL.BorderRadius = 0;
            this.rJ_TextBox_UDSDBBCM_API_URL.BorderSize = 2;
            this.rJ_TextBox_UDSDBBCM_API_URL.Font = new System.Drawing.Font("新細明體", 20F);
            this.rJ_TextBox_UDSDBBCM_API_URL.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_UDSDBBCM_API_URL.Location = new System.Drawing.Point(152, 21);
            this.rJ_TextBox_UDSDBBCM_API_URL.Multiline = false;
            this.rJ_TextBox_UDSDBBCM_API_URL.Name = "rJ_TextBox_UDSDBBCM_API_URL";
            this.rJ_TextBox_UDSDBBCM_API_URL.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_UDSDBBCM_API_URL.PassWordChar = false;
            this.rJ_TextBox_UDSDBBCM_API_URL.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_UDSDBBCM_API_URL.PlaceholderText = "";
            this.rJ_TextBox_UDSDBBCM_API_URL.ShowTouchPannel = false;
            this.rJ_TextBox_UDSDBBCM_API_URL.Size = new System.Drawing.Size(506, 46);
            this.rJ_TextBox_UDSDBBCM_API_URL.TabIndex = 145;
            this.rJ_TextBox_UDSDBBCM_API_URL.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_UDSDBBCM_API_URL.Texts = "";
            this.rJ_TextBox_UDSDBBCM_API_URL.UnderlineStyle = false;
            // 
            // plC_RJ_Button_UDSDBBCM_Get
            // 
            this.plC_RJ_Button_UDSDBBCM_Get.AutoResetState = false;
            this.plC_RJ_Button_UDSDBBCM_Get.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_UDSDBBCM_Get.Bool = false;
            this.plC_RJ_Button_UDSDBBCM_Get.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_UDSDBBCM_Get.BorderRadius = 5;
            this.plC_RJ_Button_UDSDBBCM_Get.BorderSize = 0;
            this.plC_RJ_Button_UDSDBBCM_Get.but_press = false;
            this.plC_RJ_Button_UDSDBBCM_Get.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_UDSDBBCM_Get.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_UDSDBBCM_Get.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_UDSDBBCM_Get.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_UDSDBBCM_Get.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_UDSDBBCM_Get.Location = new System.Drawing.Point(664, 21);
            this.plC_RJ_Button_UDSDBBCM_Get.Name = "plC_RJ_Button_UDSDBBCM_Get";
            this.plC_RJ_Button_UDSDBBCM_Get.OFF_文字內容 = "Get";
            this.plC_RJ_Button_UDSDBBCM_Get.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_UDSDBBCM_Get.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_UDSDBBCM_Get.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_UDSDBBCM_Get.ON_文字內容 = "Get";
            this.plC_RJ_Button_UDSDBBCM_Get.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 12F);
            this.plC_RJ_Button_UDSDBBCM_Get.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_UDSDBBCM_Get.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_UDSDBBCM_Get.Size = new System.Drawing.Size(72, 46);
            this.plC_RJ_Button_UDSDBBCM_Get.State = false;
            this.plC_RJ_Button_UDSDBBCM_Get.TabIndex = 147;
            this.plC_RJ_Button_UDSDBBCM_Get.Text = "Get";
            this.plC_RJ_Button_UDSDBBCM_Get.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_UDSDBBCM_Get.Texts = "Get";
            this.plC_RJ_Button_UDSDBBCM_Get.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_UDSDBBCM_Get.字型鎖住 = false;
            this.plC_RJ_Button_UDSDBBCM_Get.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_UDSDBBCM_Get.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_UDSDBBCM_Get.文字鎖住 = false;
            this.plC_RJ_Button_UDSDBBCM_Get.讀取位元反向 = false;
            this.plC_RJ_Button_UDSDBBCM_Get.讀寫鎖住 = false;
            this.plC_RJ_Button_UDSDBBCM_Get.音效 = true;
            this.plC_RJ_Button_UDSDBBCM_Get.顯示 = false;
            this.plC_RJ_Button_UDSDBBCM_Get.顯示狀態 = false;
            // 
            // panel_UDSDBBCM
            // 
            this.panel_UDSDBBCM.Controls.Add(this.plC_RJ_ScreenButton1);
            this.panel_UDSDBBCM.Controls.Add(this.plC_RJ_ScreenButton4);
            this.panel_UDSDBBCM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_UDSDBBCM.Location = new System.Drawing.Point(0, 0);
            this.panel_UDSDBBCM.Name = "panel_UDSDBBCM";
            this.panel_UDSDBBCM.Size = new System.Drawing.Size(1256, 64);
            this.panel_UDSDBBCM.TabIndex = 142;
            // 
            // plC_RJ_ScreenButton1
            // 
            this.plC_RJ_ScreenButton1.but_press = false;
            this.plC_RJ_ScreenButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.plC_RJ_ScreenButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.plC_RJ_ScreenButton1.IconSize = 40;
            this.plC_RJ_ScreenButton1.Location = new System.Drawing.Point(183, 0);
            this.plC_RJ_ScreenButton1.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton1.Name = "plC_RJ_ScreenButton1";
            this.plC_RJ_ScreenButton1.OffBackColor = System.Drawing.Color.DarkCyan;
            this.plC_RJ_ScreenButton1.OffFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton1.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton1.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton1.OffText = "API";
            this.plC_RJ_ScreenButton1.OnBackColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton1.OnFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton1.OnForeColor = System.Drawing.Color.DarkCyan;
            this.plC_RJ_ScreenButton1.OnIconColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_ScreenButton1.OnText = "API";
            this.plC_RJ_ScreenButton1.ShowIcon = false;
            this.plC_RJ_ScreenButton1.Size = new System.Drawing.Size(183, 64);
            this.plC_RJ_ScreenButton1.TabIndex = 86;
            this.plC_RJ_ScreenButton1.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton1.寫入位置註解 = "";
            this.plC_RJ_ScreenButton1.寫入元件位置 = "";
            this.plC_RJ_ScreenButton1.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton1.控制位址 = "D0";
            this.plC_RJ_ScreenButton1.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton1.致能讀取位置 = "";
            this.plC_RJ_ScreenButton1.讀取位元反向 = false;
            this.plC_RJ_ScreenButton1.讀取位置註解 = "";
            this.plC_RJ_ScreenButton1.讀取元件位置 = "";
            this.plC_RJ_ScreenButton1.音效 = true;
            this.plC_RJ_ScreenButton1.頁面名稱 = "API";
            this.plC_RJ_ScreenButton1.頁面編號 = 0;
            this.plC_RJ_ScreenButton1.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton1.顯示狀態 = false;
            this.plC_RJ_ScreenButton1.顯示讀取位置 = "";
            // 
            // plC_RJ_ScreenButton4
            // 
            this.plC_RJ_ScreenButton4.but_press = false;
            this.plC_RJ_ScreenButton4.Dock = System.Windows.Forms.DockStyle.Left;
            this.plC_RJ_ScreenButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.plC_RJ_ScreenButton4.IconSize = 40;
            this.plC_RJ_ScreenButton4.Location = new System.Drawing.Point(0, 0);
            this.plC_RJ_ScreenButton4.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton4.Name = "plC_RJ_ScreenButton4";
            this.plC_RJ_ScreenButton4.OffBackColor = System.Drawing.Color.DarkCyan;
            this.plC_RJ_ScreenButton4.OffFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton4.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton4.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton4.OffText = "表單";
            this.plC_RJ_ScreenButton4.OnBackColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton4.OnFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton4.OnForeColor = System.Drawing.Color.DarkCyan;
            this.plC_RJ_ScreenButton4.OnIconColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_ScreenButton4.OnText = "表單";
            this.plC_RJ_ScreenButton4.ShowIcon = false;
            this.plC_RJ_ScreenButton4.Size = new System.Drawing.Size(183, 64);
            this.plC_RJ_ScreenButton4.TabIndex = 85;
            this.plC_RJ_ScreenButton4.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton4.寫入位置註解 = "";
            this.plC_RJ_ScreenButton4.寫入元件位置 = "";
            this.plC_RJ_ScreenButton4.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton4.控制位址 = "D0";
            this.plC_RJ_ScreenButton4.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton4.致能讀取位置 = "";
            this.plC_RJ_ScreenButton4.讀取位元反向 = false;
            this.plC_RJ_ScreenButton4.讀取位置註解 = "";
            this.plC_RJ_ScreenButton4.讀取元件位置 = "";
            this.plC_RJ_ScreenButton4.音效 = true;
            this.plC_RJ_ScreenButton4.頁面名稱 = "表單";
            this.plC_RJ_ScreenButton4.頁面編號 = 0;
            this.plC_RJ_ScreenButton4.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton4.顯示狀態 = false;
            this.plC_RJ_ScreenButton4.顯示讀取位置 = "";
            // 
            // 系統
            // 
            this.系統.BackColor = System.Drawing.Color.White;
            this.系統.Controls.Add(this.lowerMachine_Panel1);
            this.系統.Controls.Add(this.plC_UI_Init1);
            this.系統.Location = new System.Drawing.Point(4, 25);
            this.系統.Name = "系統";
            this.系統.Size = new System.Drawing.Size(1256, 828);
            this.系統.TabIndex = 1;
            this.系統.Text = "系統";
            // 
            // lowerMachine_Panel1
            // 
            this.lowerMachine_Panel1.Location = new System.Drawing.Point(3, 12);
            this.lowerMachine_Panel1.Name = "lowerMachine_Panel1";
            this.lowerMachine_Panel1.Size = new System.Drawing.Size(869, 565);
            this.lowerMachine_Panel1.TabIndex = 3;
            this.lowerMachine_Panel1.掃描速度 = 100;
            // 
            // plC_UI_Init1
            // 
            this.plC_UI_Init1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.plC_UI_Init1.Location = new System.Drawing.Point(878, 12);
            this.plC_UI_Init1.Name = "plC_UI_Init1";
            this.plC_UI_Init1.Size = new System.Drawing.Size(72, 25);
            this.plC_UI_Init1.TabIndex = 2;
            this.plC_UI_Init1.光道視覺元件初始化 = false;
            this.plC_UI_Init1.全螢幕顯示 = false;
            this.plC_UI_Init1.掃描速度 = 10;
            this.plC_UI_Init1.起始畫面標題內容 = "鴻森整合機電有限公司";
            this.plC_UI_Init1.起始畫面標題字體 = new System.Drawing.Font("標楷體", 20F, System.Drawing.FontStyle.Bold);
            this.plC_UI_Init1.起始畫面背景 = ((System.Drawing.Image)(resources.GetObject("plC_UI_Init1.起始畫面背景")));
            this.plC_UI_Init1.起始畫面顯示 = false;
            this.plC_UI_Init1.邁得威視元件初始化 = false;
            this.plC_UI_Init1.開機延遲 = 0;
            this.plC_UI_Init1.音效 = false;
            // 
            // ContentsPanel
            // 
            this.ContentsPanel.BackColor = System.Drawing.Color.White;
            this.ContentsPanel.BorderColor = System.Drawing.Color.SkyBlue;
            this.ContentsPanel.BorderRadius = 5;
            this.ContentsPanel.BorderSize = 2;
            this.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentsPanel.ForeColor = System.Drawing.Color.White;
            this.ContentsPanel.Location = new System.Drawing.Point(0, 37);
            this.ContentsPanel.Name = "ContentsPanel";
            this.ContentsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.ContentsPanel.Size = new System.Drawing.Size(1256, 576);
            this.ContentsPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 921);
            this.Controls.Add(this.plC_ScreenPage_Main);
            this.Controls.Add(this.panel_Main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Main.ResumeLayout(false);
            this.plC_ScreenPage_Main.ResumeLayout(false);
            this.UDSDBBCM.ResumeLayout(false);
            this.plC_ScreenPage_UDSDBBCM.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.rJ_GroupBox1.ContentsPanel.ResumeLayout(false);
            this.rJ_GroupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel_UDSDBBCM.ResumeLayout(false);
            this.系統.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel panel_Main;
        private MyUI.PLC_ScreenPage plC_ScreenPage_Main;
        private System.Windows.Forms.TabPage UDSDBBCM;
        private System.Windows.Forms.TabPage 系統;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton3;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton2;
        private MyUI.PLC_UI_Init plC_UI_Init1;
        private LadderUI.LowerMachine_Panel lowerMachine_Panel1;
        private MyUI.PLC_ScreenPage plC_ScreenPage_UDSDBBCM;
        private System.Windows.Forms.TabPage tabPage1;
        private MyUI.RJ_GroupBox rJ_GroupBox1;
        private SQLUI.SQL_DataGridView sqL_DataGridView_UDSDBBCM;
        private System.Windows.Forms.TabPage tabPage2;
        private MyUI.RJ_Lable rJ_Lable96;
        internal MyUI.RJ_TextBox rJ_TextBox_UDSDBBCM_API_URL;
        private MyUI.PLC_RJ_Button plC_RJ_Button_UDSDBBCM_Get;
        private System.Windows.Forms.Panel panel_UDSDBBCM;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton1;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton4;
        private MyUI.RJ_Pannel ContentsPanel;
        private System.Windows.Forms.RichTextBox richTextBox_UDSDBBCM_API_GET;
        private MyUI.PLC_RJ_Button plC_RJ_Button_USDSBBCM_表單_顯示全部;
        #endregion
    }
}

