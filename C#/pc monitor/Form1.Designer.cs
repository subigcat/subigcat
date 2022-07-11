
namespace pc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.cpuid = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.powershow = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.freqtext = new System.Windows.Forms.Label();
            this.tempshow = new System.Windows.Forms.Label();
            this.freqshow = new System.Windows.Forms.Label();
            this.temptext = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.MemoryID = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.circularProgressBar2 = new CircularProgressBar.CircularProgressBar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.availablememoryshow = new System.Windows.Forms.Label();
            this.availablememorytext = new System.Windows.Forms.Label();
            this.usedmemorytext = new System.Windows.Forms.Label();
            this.usedmemoryshow = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.gpuid = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.circularProgressBar3 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar4 = new CircularProgressBar.CircularProgressBar();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gputempshow = new System.Windows.Forms.Label();
            this.gputemperaturetext = new System.Windows.Forms.Label();
            this.gpucoretext = new System.Windows.Forms.Label();
            this.gpumemorytext = new System.Windows.Forms.Label();
            this.gpushadertext = new System.Windows.Forms.Label();
            this.gpumemoryshow = new System.Windows.Forms.Label();
            this.gpushadershow = new System.Windows.Forms.Label();
            this.gpucoreshow = new System.Windows.Forms.Label();
            this.gpumemoryusedtext = new System.Windows.Forms.Label();
            this.gpumemoryusedshow = new System.Windows.Forms.Label();
            this.gpumemoryfreetext = new System.Windows.Forms.Label();
            this.gpumemoryavailableshow = new System.Windows.Forms.Label();
            this.GPUMemoryTotaltext = new System.Windows.Forms.Label();
            this.gpumemorytotalshow = new System.Windows.Forms.Label();
            this.gpufantext = new System.Windows.Forms.Label();
            this.gpufanshow = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("circularProgressBar1.AnimationFunction")));
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.circularProgressBar1.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.Black;
            this.circularProgressBar1.InnerColor = System.Drawing.SystemColors.HotTrack;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(32, 37);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.SystemColors.MenuHighlight;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.Navy;
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.circularProgressBar1.Size = new System.Drawing.Size(136, 136);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 0;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // cpuid
            // 
            this.cpuid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cpuid.AutoSize = true;
            this.cpuid.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cpuid.Location = new System.Drawing.Point(100, 5);
            this.cpuid.Name = "cpuid";
            this.cpuid.Size = new System.Drawing.Size(0, 21);
            this.cpuid.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel8);
            this.panel1.Controls.Add(this.tableLayoutPanel7);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.circularProgressBar1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 338);
            this.panel1.TabIndex = 10;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.cpuid, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(200, 31);
            this.tableLayoutPanel8.TabIndex = 13;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(1, 188);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(200, 35);
            this.tableLayoutPanel7.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(52, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU Usage";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.Controls.Add(this.powershow, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.freqtext, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tempshow, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.freqshow, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.temptext, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 247);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.20635F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.79365F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 91);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // powershow
            // 
            this.powershow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.powershow.AutoSize = true;
            this.powershow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.powershow.Location = new System.Drawing.Point(117, 66);
            this.powershow.Name = "powershow";
            this.powershow.Size = new System.Drawing.Size(41, 21);
            this.powershow.TabIndex = 11;
            this.powershow.Text = "Null";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(3, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Power";
            // 
            // freqtext
            // 
            this.freqtext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.freqtext.AutoSize = true;
            this.freqtext.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.freqtext.Location = new System.Drawing.Point(3, 4);
            this.freqtext.Name = "freqtext";
            this.freqtext.Size = new System.Drawing.Size(90, 21);
            this.freqtext.TabIndex = 10;
            this.freqtext.Text = "Frequency";
            // 
            // tempshow
            // 
            this.tempshow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tempshow.AutoSize = true;
            this.tempshow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tempshow.Location = new System.Drawing.Point(117, 35);
            this.tempshow.Name = "tempshow";
            this.tempshow.Size = new System.Drawing.Size(41, 21);
            this.tempshow.TabIndex = 9;
            this.tempshow.Text = "Null";
            // 
            // freqshow
            // 
            this.freqshow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.freqshow.AutoSize = true;
            this.freqshow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.freqshow.Location = new System.Drawing.Point(117, 4);
            this.freqshow.Name = "freqshow";
            this.freqshow.Size = new System.Drawing.Size(41, 21);
            this.freqshow.TabIndex = 11;
            this.freqshow.Text = "Null";
            // 
            // temptext
            // 
            this.temptext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.temptext.AutoSize = true;
            this.temptext.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.temptext.Location = new System.Drawing.Point(3, 35);
            this.temptext.Name = "temptext";
            this.temptext.Size = new System.Drawing.Size(108, 21);
            this.temptext.TabIndex = 2;
            this.temptext.Text = "Temperature";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel9);
            this.panel2.Controls.Add(this.tableLayoutPanel6);
            this.panel2.Controls.Add(this.circularProgressBar2);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(206, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 338);
            this.panel2.TabIndex = 11;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.MemoryID, 0, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(200, 31);
            this.tableLayoutPanel9.TabIndex = 4;
            // 
            // MemoryID
            // 
            this.MemoryID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MemoryID.AutoSize = true;
            this.MemoryID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemoryID.Location = new System.Drawing.Point(100, 5);
            this.MemoryID.Name = "MemoryID";
            this.MemoryID.Size = new System.Drawing.Size(0, 21);
            this.MemoryID.TabIndex = 12;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(1, 188);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(200, 35);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(36, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Memory Usage";
            // 
            // circularProgressBar2
            // 
            this.circularProgressBar2.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("circularProgressBar2.AnimationFunction")));
            this.circularProgressBar2.AnimationSpeed = 500;
            this.circularProgressBar2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.circularProgressBar2.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar2.ForeColor = System.Drawing.Color.Black;
            this.circularProgressBar2.InnerColor = System.Drawing.SystemColors.HotTrack;
            this.circularProgressBar2.InnerMargin = 2;
            this.circularProgressBar2.InnerWidth = -1;
            this.circularProgressBar2.Location = new System.Drawing.Point(30, 37);
            this.circularProgressBar2.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar2.Name = "circularProgressBar2";
            this.circularProgressBar2.OuterColor = System.Drawing.SystemColors.MenuHighlight;
            this.circularProgressBar2.OuterMargin = -25;
            this.circularProgressBar2.OuterWidth = 26;
            this.circularProgressBar2.ProgressColor = System.Drawing.Color.Navy;
            this.circularProgressBar2.ProgressWidth = 25;
            this.circularProgressBar2.SecondaryFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.circularProgressBar2.Size = new System.Drawing.Size(136, 136);
            this.circularProgressBar2.StartAngle = 270;
            this.circularProgressBar2.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar2.SubscriptText = "";
            this.circularProgressBar2.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar2.SuperscriptText = "";
            this.circularProgressBar2.TabIndex = 2;
            this.circularProgressBar2.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar2.Value = 68;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel2.Controls.Add(this.availablememoryshow, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.availablememorytext, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.usedmemorytext, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.usedmemoryshow, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 276);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 62);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // availablememoryshow
            // 
            this.availablememoryshow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.availablememoryshow.AutoSize = true;
            this.availablememoryshow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.availablememoryshow.Location = new System.Drawing.Point(114, 36);
            this.availablememoryshow.Name = "availablememoryshow";
            this.availablememoryshow.Size = new System.Drawing.Size(41, 21);
            this.availablememoryshow.TabIndex = 13;
            this.availablememoryshow.Text = "Null";
            // 
            // availablememorytext
            // 
            this.availablememorytext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.availablememorytext.AutoSize = true;
            this.availablememorytext.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.availablememorytext.Location = new System.Drawing.Point(3, 36);
            this.availablememorytext.Name = "availablememorytext";
            this.availablememorytext.Size = new System.Drawing.Size(80, 21);
            this.availablememorytext.TabIndex = 15;
            this.availablememorytext.Text = "Available";
            // 
            // usedmemorytext
            // 
            this.usedmemorytext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.usedmemorytext.AutoSize = true;
            this.usedmemorytext.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.usedmemorytext.Location = new System.Drawing.Point(3, 5);
            this.usedmemorytext.Name = "usedmemorytext";
            this.usedmemorytext.Size = new System.Drawing.Size(49, 21);
            this.usedmemorytext.TabIndex = 14;
            this.usedmemorytext.Text = "Used";
            // 
            // usedmemoryshow
            // 
            this.usedmemoryshow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.usedmemoryshow.AutoSize = true;
            this.usedmemoryshow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.usedmemoryshow.Location = new System.Drawing.Point(114, 5);
            this.usedmemoryshow.Name = "usedmemoryshow";
            this.usedmemoryshow.Size = new System.Drawing.Size(41, 21);
            this.usedmemoryshow.TabIndex = 12;
            this.usedmemoryshow.Text = "Null";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel10);
            this.panel3.Controls.Add(this.tableLayoutPanel5);
            this.panel3.Controls.Add(this.tableLayoutPanel4);
            this.panel3.Controls.Add(this.tableLayoutPanel3);
            this.panel3.Location = new System.Drawing.Point(413, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 509);
            this.panel3.TabIndex = 12;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.gpuid, 0, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(384, 31);
            this.tableLayoutPanel10.TabIndex = 16;
            // 
            // gpuid
            // 
            this.gpuid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpuid.AutoSize = true;
            this.gpuid.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpuid.Location = new System.Drawing.Point(192, 5);
            this.gpuid.Name = "gpuid";
            this.gpuid.Size = new System.Drawing.Size(0, 21);
            this.gpuid.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.tableLayoutPanel5.Controls.Add(this.circularProgressBar3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.circularProgressBar4, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 37);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(384, 154);
            this.tableLayoutPanel5.TabIndex = 15;
            // 
            // circularProgressBar3
            // 
            this.circularProgressBar3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularProgressBar3.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("circularProgressBar3.AnimationFunction")));
            this.circularProgressBar3.AnimationSpeed = 500;
            this.circularProgressBar3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.circularProgressBar3.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar3.ForeColor = System.Drawing.Color.Black;
            this.circularProgressBar3.InnerColor = System.Drawing.SystemColors.HotTrack;
            this.circularProgressBar3.InnerMargin = 2;
            this.circularProgressBar3.InnerWidth = -1;
            this.circularProgressBar3.Location = new System.Drawing.Point(28, 9);
            this.circularProgressBar3.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar3.Name = "circularProgressBar3";
            this.circularProgressBar3.OuterColor = System.Drawing.SystemColors.MenuHighlight;
            this.circularProgressBar3.OuterMargin = -25;
            this.circularProgressBar3.OuterWidth = 26;
            this.circularProgressBar3.ProgressColor = System.Drawing.Color.Navy;
            this.circularProgressBar3.ProgressWidth = 25;
            this.circularProgressBar3.SecondaryFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.circularProgressBar3.Size = new System.Drawing.Size(136, 136);
            this.circularProgressBar3.StartAngle = 270;
            this.circularProgressBar3.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar3.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar3.SubscriptText = "";
            this.circularProgressBar3.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar3.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar3.SuperscriptText = "";
            this.circularProgressBar3.TabIndex = 13;
            this.circularProgressBar3.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar3.Value = 68;
            // 
            // circularProgressBar4
            // 
            this.circularProgressBar4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularProgressBar4.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("circularProgressBar4.AnimationFunction")));
            this.circularProgressBar4.AnimationSpeed = 500;
            this.circularProgressBar4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.circularProgressBar4.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar4.ForeColor = System.Drawing.Color.Black;
            this.circularProgressBar4.InnerColor = System.Drawing.SystemColors.HotTrack;
            this.circularProgressBar4.InnerMargin = 2;
            this.circularProgressBar4.InnerWidth = -1;
            this.circularProgressBar4.Location = new System.Drawing.Point(220, 9);
            this.circularProgressBar4.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar4.Name = "circularProgressBar4";
            this.circularProgressBar4.OuterColor = System.Drawing.SystemColors.MenuHighlight;
            this.circularProgressBar4.OuterMargin = -25;
            this.circularProgressBar4.OuterWidth = 26;
            this.circularProgressBar4.ProgressColor = System.Drawing.Color.Navy;
            this.circularProgressBar4.ProgressWidth = 25;
            this.circularProgressBar4.SecondaryFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.circularProgressBar4.Size = new System.Drawing.Size(136, 136);
            this.circularProgressBar4.StartAngle = 270;
            this.circularProgressBar4.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar4.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar4.SubscriptText = "";
            this.circularProgressBar4.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar4.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar4.SuperscriptText = "";
            this.circularProgressBar4.TabIndex = 13;
            this.circularProgressBar4.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar4.Value = 68;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 188);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(384, 35);
            this.tableLayoutPanel4.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(205, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "GPU Memory Usage";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(47, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "GPU Usage";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanel3.Controls.Add(this.gputempshow, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.gputemperaturetext, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.gpucoretext, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.gpumemorytext, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.gpushadertext, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.gpumemoryshow, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.gpushadershow, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.gpucoreshow, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.gpumemoryusedtext, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.gpumemoryusedshow, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.gpumemoryfreetext, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.gpumemoryavailableshow, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.GPUMemoryTotaltext, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.gpumemorytotalshow, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.gpufantext, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.gpufanshow, 1, 7);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 247);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.81967F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.18033F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(384, 261);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // gputempshow
            // 
            this.gputempshow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gputempshow.AutoSize = true;
            this.gputempshow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gputempshow.Location = new System.Drawing.Point(204, 96);
            this.gputempshow.Name = "gputempshow";
            this.gputempshow.Size = new System.Drawing.Size(41, 21);
            this.gputempshow.TabIndex = 23;
            this.gputempshow.Text = "Null";
            // 
            // gputemperaturetext
            // 
            this.gputemperaturetext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gputemperaturetext.AutoSize = true;
            this.gputemperaturetext.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gputemperaturetext.Location = new System.Drawing.Point(3, 96);
            this.gputemperaturetext.Name = "gputemperaturetext";
            this.gputemperaturetext.Size = new System.Drawing.Size(146, 21);
            this.gputemperaturetext.TabIndex = 16;
            this.gputemperaturetext.Text = "GPU Temperature";
            // 
            // gpucoretext
            // 
            this.gpucoretext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gpucoretext.AutoSize = true;
            this.gpucoretext.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpucoretext.Location = new System.Drawing.Point(3, 5);
            this.gpucoretext.Name = "gpucoretext";
            this.gpucoretext.Size = new System.Drawing.Size(84, 21);
            this.gpucoretext.TabIndex = 13;
            this.gpucoretext.Text = "GPU Core";
            // 
            // gpumemorytext
            // 
            this.gpumemorytext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gpumemorytext.AutoSize = true;
            this.gpumemorytext.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpumemorytext.Location = new System.Drawing.Point(3, 35);
            this.gpumemorytext.Name = "gpumemorytext";
            this.gpumemorytext.Size = new System.Drawing.Size(113, 21);
            this.gpumemorytext.TabIndex = 14;
            this.gpumemorytext.Text = "GPU Memory";
            // 
            // gpushadertext
            // 
            this.gpushadertext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gpushadertext.AutoSize = true;
            this.gpushadertext.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpushadertext.Location = new System.Drawing.Point(3, 65);
            this.gpushadertext.Name = "gpushadertext";
            this.gpushadertext.Size = new System.Drawing.Size(101, 21);
            this.gpushadertext.TabIndex = 21;
            this.gpushadertext.Text = "GPU Shader";
            // 
            // gpumemoryshow
            // 
            this.gpumemoryshow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gpumemoryshow.AutoSize = true;
            this.gpumemoryshow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpumemoryshow.Location = new System.Drawing.Point(204, 35);
            this.gpumemoryshow.Name = "gpumemoryshow";
            this.gpumemoryshow.Size = new System.Drawing.Size(41, 21);
            this.gpumemoryshow.TabIndex = 16;
            this.gpumemoryshow.Text = "Null";
            // 
            // gpushadershow
            // 
            this.gpushadershow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gpushadershow.AutoSize = true;
            this.gpushadershow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpushadershow.Location = new System.Drawing.Point(204, 65);
            this.gpushadershow.Name = "gpushadershow";
            this.gpushadershow.Size = new System.Drawing.Size(41, 21);
            this.gpushadershow.TabIndex = 14;
            this.gpushadershow.Text = "Null";
            // 
            // gpucoreshow
            // 
            this.gpucoreshow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gpucoreshow.AutoSize = true;
            this.gpucoreshow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpucoreshow.Location = new System.Drawing.Point(204, 5);
            this.gpucoreshow.Name = "gpucoreshow";
            this.gpucoreshow.Size = new System.Drawing.Size(41, 21);
            this.gpucoreshow.TabIndex = 13;
            this.gpucoreshow.Text = "Null";
            // 
            // gpumemoryusedtext
            // 
            this.gpumemoryusedtext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gpumemoryusedtext.AutoSize = true;
            this.gpumemoryusedtext.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpumemoryusedtext.Location = new System.Drawing.Point(3, 129);
            this.gpumemoryusedtext.Name = "gpumemoryusedtext";
            this.gpumemoryusedtext.Size = new System.Drawing.Size(156, 21);
            this.gpumemoryusedtext.TabIndex = 22;
            this.gpumemoryusedtext.Text = "GPU Memory Used";
            // 
            // gpumemoryusedshow
            // 
            this.gpumemoryusedshow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gpumemoryusedshow.AutoSize = true;
            this.gpumemoryusedshow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpumemoryusedshow.Location = new System.Drawing.Point(204, 129);
            this.gpumemoryusedshow.Name = "gpumemoryusedshow";
            this.gpumemoryusedshow.Size = new System.Drawing.Size(41, 21);
            this.gpumemoryusedshow.TabIndex = 17;
            this.gpumemoryusedshow.Text = "Null";
            // 
            // gpumemoryfreetext
            // 
            this.gpumemoryfreetext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gpumemoryfreetext.AutoSize = true;
            this.gpumemoryfreetext.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpumemoryfreetext.Location = new System.Drawing.Point(3, 162);
            this.gpumemoryfreetext.Name = "gpumemoryfreetext";
            this.gpumemoryfreetext.Size = new System.Drawing.Size(187, 21);
            this.gpumemoryfreetext.TabIndex = 23;
            this.gpumemoryfreetext.Text = "GPU Memory Available";
            // 
            // gpumemoryavailableshow
            // 
            this.gpumemoryavailableshow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gpumemoryavailableshow.AutoSize = true;
            this.gpumemoryavailableshow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpumemoryavailableshow.Location = new System.Drawing.Point(204, 162);
            this.gpumemoryavailableshow.Name = "gpumemoryavailableshow";
            this.gpumemoryavailableshow.Size = new System.Drawing.Size(41, 21);
            this.gpumemoryavailableshow.TabIndex = 22;
            this.gpumemoryavailableshow.Text = "Null";
            // 
            // GPUMemoryTotaltext
            // 
            this.GPUMemoryTotaltext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GPUMemoryTotaltext.AutoSize = true;
            this.GPUMemoryTotaltext.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GPUMemoryTotaltext.Location = new System.Drawing.Point(3, 196);
            this.GPUMemoryTotaltext.Name = "GPUMemoryTotaltext";
            this.GPUMemoryTotaltext.Size = new System.Drawing.Size(155, 21);
            this.GPUMemoryTotaltext.TabIndex = 20;
            this.GPUMemoryTotaltext.Text = "GPU Memory Total";
            // 
            // gpumemorytotalshow
            // 
            this.gpumemorytotalshow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gpumemorytotalshow.AutoSize = true;
            this.gpumemorytotalshow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpumemorytotalshow.Location = new System.Drawing.Point(204, 196);
            this.gpumemorytotalshow.Name = "gpumemorytotalshow";
            this.gpumemorytotalshow.Size = new System.Drawing.Size(41, 21);
            this.gpumemorytotalshow.TabIndex = 20;
            this.gpumemorytotalshow.Text = "Null";
            // 
            // gpufantext
            // 
            this.gpufantext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gpufantext.AutoSize = true;
            this.gpufantext.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpufantext.Location = new System.Drawing.Point(3, 232);
            this.gpufantext.Name = "gpufantext";
            this.gpufantext.Size = new System.Drawing.Size(76, 21);
            this.gpufantext.TabIndex = 15;
            this.gpufantext.Text = "GPU Fan";
            // 
            // gpufanshow
            // 
            this.gpufanshow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gpufanshow.AutoSize = true;
            this.gpufanshow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpufanshow.Location = new System.Drawing.Point(204, 232);
            this.gpufanshow.Name = "gpufanshow";
            this.gpufanshow.Size = new System.Drawing.Size(41, 21);
            this.gpufanshow.TabIndex = 21;
            this.gpufanshow.Text = "Null";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(798, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label cpuid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label temptext;
        private System.Windows.Forms.Label freqtext;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label powershow;
        private System.Windows.Forms.Label tempshow;
        private System.Windows.Forms.Label freqshow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label availablememoryshow;
        private System.Windows.Forms.Label availablememorytext;
        private System.Windows.Forms.Label usedmemorytext;
        private System.Windows.Forms.Label usedmemoryshow;
        private System.Windows.Forms.Label MemoryID;
        private CircularProgressBar.CircularProgressBar circularProgressBar2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label gpufantext;
        private System.Windows.Forms.Label gputemperaturetext;
        private System.Windows.Forms.Label gpucoretext;
        private System.Windows.Forms.Label gpumemorytext;
        private System.Windows.Forms.Label gpushadertext;
        private System.Windows.Forms.Label GPUMemoryTotaltext;
        private System.Windows.Forms.Label gpumemoryfreetext;
        private System.Windows.Forms.Label gpumemoryusedtext;
        private System.Windows.Forms.Label gpumemoryshow;
        private System.Windows.Forms.Label gpushadershow;
        private System.Windows.Forms.Label gpucoreshow;
        private System.Windows.Forms.Label gpumemoryusedshow;
        private System.Windows.Forms.Label gpumemorytotalshow;
        private System.Windows.Forms.Label gpufanshow;
        private System.Windows.Forms.Label gpumemoryavailableshow;
        private System.Windows.Forms.Label gputempshow;
        private CircularProgressBar.CircularProgressBar circularProgressBar4;
        private CircularProgressBar.CircularProgressBar circularProgressBar3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label gpuid;
    }
}

