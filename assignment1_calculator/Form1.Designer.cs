
namespace assignment1_calculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tboxResult1 = new System.Windows.Forms.TextBox();
            this.tboxResult2 = new System.Windows.Forms.TextBox();
            this.tLayoutPlanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnRoute = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnFraction = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnMinusPlus = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMDown = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMMinus = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.lblMode = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.표준ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.공학용ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.그래프ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그래머ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.날짜계산ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.통화환율ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.부피ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tLayoutPlanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxResult1
            // 
            this.tboxResult1.BackColor = System.Drawing.SystemColors.Control;
            this.tboxResult1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxResult1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.tboxResult1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tboxResult1.Location = new System.Drawing.Point(12, 46);
            this.tboxResult1.Name = "tboxResult1";
            this.tboxResult1.Size = new System.Drawing.Size(294, 19);
            this.tboxResult1.TabIndex = 19;
            this.tboxResult1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tboxResult2
            // 
            this.tboxResult2.BackColor = System.Drawing.SystemColors.Control;
            this.tboxResult2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxResult2.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Bold);
            this.tboxResult2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tboxResult2.Location = new System.Drawing.Point(12, 76);
            this.tboxResult2.Name = "tboxResult2";
            this.tboxResult2.Size = new System.Drawing.Size(294, 46);
            this.tboxResult2.TabIndex = 18;
            this.tboxResult2.Text = "0";
            this.tboxResult2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tLayoutPlanel
            // 
            this.tLayoutPlanel.ColumnCount = 4;
            this.tLayoutPlanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tLayoutPlanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tLayoutPlanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tLayoutPlanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tLayoutPlanel.Controls.Add(this.btnPlus, 3, 4);
            this.tLayoutPlanel.Controls.Add(this.btn3, 2, 4);
            this.tLayoutPlanel.Controls.Add(this.btn2, 1, 4);
            this.tLayoutPlanel.Controls.Add(this.btn1, 0, 4);
            this.tLayoutPlanel.Controls.Add(this.btnMinus, 3, 3);
            this.tLayoutPlanel.Controls.Add(this.btn6, 2, 3);
            this.tLayoutPlanel.Controls.Add(this.btn5, 1, 3);
            this.tLayoutPlanel.Controls.Add(this.btn4, 0, 3);
            this.tLayoutPlanel.Controls.Add(this.btnMultiple, 3, 2);
            this.tLayoutPlanel.Controls.Add(this.btn9, 2, 2);
            this.tLayoutPlanel.Controls.Add(this.btn8, 1, 2);
            this.tLayoutPlanel.Controls.Add(this.btn7, 0, 2);
            this.tLayoutPlanel.Controls.Add(this.btnDivide, 3, 1);
            this.tLayoutPlanel.Controls.Add(this.btnRoute, 2, 1);
            this.tLayoutPlanel.Controls.Add(this.btnSquare, 1, 1);
            this.tLayoutPlanel.Controls.Add(this.btnFraction, 0, 1);
            this.tLayoutPlanel.Controls.Add(this.btnCancel, 3, 0);
            this.tLayoutPlanel.Controls.Add(this.btnC, 2, 0);
            this.tLayoutPlanel.Controls.Add(this.btnCE, 1, 0);
            this.tLayoutPlanel.Controls.Add(this.btnDot, 0, 5);
            this.tLayoutPlanel.Controls.Add(this.btn0, 0, 5);
            this.tLayoutPlanel.Controls.Add(this.btnEqual, 0, 5);
            this.tLayoutPlanel.Controls.Add(this.btnMinusPlus, 0, 5);
            this.tLayoutPlanel.Controls.Add(this.btnPercent, 0, 0);
            this.tLayoutPlanel.Font = new System.Drawing.Font("굴림", 14F);
            this.tLayoutPlanel.Location = new System.Drawing.Point(12, 178);
            this.tLayoutPlanel.Name = "tLayoutPlanel";
            this.tLayoutPlanel.RowCount = 6;
            this.tLayoutPlanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tLayoutPlanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tLayoutPlanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tLayoutPlanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tLayoutPlanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tLayoutPlanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tLayoutPlanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLayoutPlanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLayoutPlanel.Size = new System.Drawing.Size(294, 269);
            this.tLayoutPlanel.TabIndex = 17;
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlus.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnPlus.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Location = new System.Drawing.Point(219, 176);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 44);
            this.btnPlus.TabIndex = 24;
            this.btnPlus.Text = " + ";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(146, 176);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(73, 44);
            this.btn3.TabIndex = 23;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(73, 176);
            this.btn2.Margin = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(73, 44);
            this.btn2.TabIndex = 22;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(0, 176);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(73, 44);
            this.btn1.TabIndex = 21;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinus.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnMinus.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Location = new System.Drawing.Point(219, 132);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 44);
            this.btnMinus.TabIndex = 20;
            this.btnMinus.Text = " - ";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Location = new System.Drawing.Point(146, 132);
            this.btn6.Margin = new System.Windows.Forms.Padding(0);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(73, 44);
            this.btn6.TabIndex = 19;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Location = new System.Drawing.Point(73, 132);
            this.btn5.Margin = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(73, 44);
            this.btn5.TabIndex = 18;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Location = new System.Drawing.Point(0, 132);
            this.btn4.Margin = new System.Windows.Forms.Padding(0);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(73, 44);
            this.btn4.TabIndex = 17;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnMultiple
            // 
            this.btnMultiple.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMultiple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMultiple.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnMultiple.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnMultiple.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMultiple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiple.Location = new System.Drawing.Point(219, 88);
            this.btnMultiple.Margin = new System.Windows.Forms.Padding(0);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(75, 44);
            this.btnMultiple.TabIndex = 16;
            this.btnMultiple.Text = " × ";
            this.btnMultiple.UseVisualStyleBackColor = false;
            this.btnMultiple.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Location = new System.Drawing.Point(146, 88);
            this.btn9.Margin = new System.Windows.Forms.Padding(0);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(73, 44);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Location = new System.Drawing.Point(73, 88);
            this.btn8.Margin = new System.Windows.Forms.Padding(0);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(73, 44);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Location = new System.Drawing.Point(0, 88);
            this.btn7.Margin = new System.Windows.Forms.Padding(0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(73, 44);
            this.btn7.TabIndex = 13;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDivide.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDivide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnDivide.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Location = new System.Drawing.Point(219, 44);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(0);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 44);
            this.btnDivide.TabIndex = 12;
            this.btnDivide.Text = " ÷ ";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnRoute
            // 
            this.btnRoute.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRoute.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRoute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnRoute.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoute.Location = new System.Drawing.Point(146, 44);
            this.btnRoute.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoute.Name = "btnRoute";
            this.btnRoute.Size = new System.Drawing.Size(73, 44);
            this.btnRoute.TabIndex = 11;
            this.btnRoute.Text = "2√x";
            this.btnRoute.UseVisualStyleBackColor = false;
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSquare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSquare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSquare.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare.Location = new System.Drawing.Point(73, 44);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(0);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(73, 44);
            this.btnSquare.TabIndex = 10;
            this.btnSquare.Text = "x²";
            this.btnSquare.UseVisualStyleBackColor = false;
            // 
            // btnFraction
            // 
            this.btnFraction.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFraction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFraction.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnFraction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnFraction.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFraction.Location = new System.Drawing.Point(0, 44);
            this.btnFraction.Margin = new System.Windows.Forms.Padding(0);
            this.btnFraction.Name = "btnFraction";
            this.btnFraction.Size = new System.Drawing.Size(73, 44);
            this.btnFraction.TabIndex = 9;
            this.btnFraction.Text = "1/​x";
            this.btnFraction.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(219, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 44);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "<=";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnC.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnC.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Location = new System.Drawing.Point(146, 0);
            this.btnC.Margin = new System.Windows.Forms.Padding(0);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(73, 44);
            this.btnC.TabIndex = 7;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCE.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCE.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.Location = new System.Drawing.Point(73, 0);
            this.btnCE.Margin = new System.Windows.Forms.Padding(0);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(73, 44);
            this.btnCE.TabIndex = 6;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDot.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnDot.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Location = new System.Drawing.Point(146, 220);
            this.btnDot.Margin = new System.Windows.Forms.Padding(0);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(73, 49);
            this.btnDot.TabIndex = 4;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Location = new System.Drawing.Point(73, 220);
            this.btn0.Margin = new System.Windows.Forms.Padding(0);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(73, 49);
            this.btn0.TabIndex = 3;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEqual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEqual.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEqual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEqual.Location = new System.Drawing.Point(219, 220);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(0);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(75, 49);
            this.btnEqual.TabIndex = 2;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnMinusPlus
            // 
            this.btnMinusPlus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMinusPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinusPlus.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnMinusPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnMinusPlus.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinusPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinusPlus.Location = new System.Drawing.Point(0, 220);
            this.btnMinusPlus.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinusPlus.Name = "btnMinusPlus";
            this.btnMinusPlus.Size = new System.Drawing.Size(73, 49);
            this.btnMinusPlus.TabIndex = 1;
            this.btnMinusPlus.Text = "+/-";
            this.btnMinusPlus.UseVisualStyleBackColor = false;
            this.btnMinusPlus.Click += new System.EventHandler(this.btnMinusPlus_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPercent.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPercent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnPercent.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPercent.Location = new System.Drawing.Point(0, 0);
            this.btnPercent.Margin = new System.Windows.Forms.Padding(0);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(73, 44);
            this.btnPercent.TabIndex = 5;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.btnMDown, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMS, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMMinus, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMPlus, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMR, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMC, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 140);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 27);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // btnMDown
            // 
            this.btnMDown.BackColor = System.Drawing.SystemColors.Control;
            this.btnMDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMDown.FlatAppearance.BorderSize = 0;
            this.btnMDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMDown.Location = new System.Drawing.Point(240, 0);
            this.btnMDown.Margin = new System.Windows.Forms.Padding(0);
            this.btnMDown.Name = "btnMDown";
            this.btnMDown.Size = new System.Drawing.Size(54, 27);
            this.btnMDown.TabIndex = 5;
            this.btnMDown.Text = "M∨";
            this.btnMDown.UseVisualStyleBackColor = false;
            // 
            // btnMS
            // 
            this.btnMS.BackColor = System.Drawing.SystemColors.Control;
            this.btnMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMS.FlatAppearance.BorderSize = 0;
            this.btnMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMS.Location = new System.Drawing.Point(192, 0);
            this.btnMS.Margin = new System.Windows.Forms.Padding(0);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(48, 27);
            this.btnMS.TabIndex = 4;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = false;
            // 
            // btnMMinus
            // 
            this.btnMMinus.BackColor = System.Drawing.SystemColors.Control;
            this.btnMMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMMinus.FlatAppearance.BorderSize = 0;
            this.btnMMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMMinus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMMinus.Location = new System.Drawing.Point(144, 0);
            this.btnMMinus.Margin = new System.Windows.Forms.Padding(0);
            this.btnMMinus.Name = "btnMMinus";
            this.btnMMinus.Size = new System.Drawing.Size(48, 27);
            this.btnMMinus.TabIndex = 3;
            this.btnMMinus.Text = "M-";
            this.btnMMinus.UseVisualStyleBackColor = false;
            // 
            // btnMPlus
            // 
            this.btnMPlus.BackColor = System.Drawing.SystemColors.Control;
            this.btnMPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMPlus.FlatAppearance.BorderSize = 0;
            this.btnMPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMPlus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMPlus.Location = new System.Drawing.Point(96, 0);
            this.btnMPlus.Margin = new System.Windows.Forms.Padding(0);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(48, 27);
            this.btnMPlus.TabIndex = 2;
            this.btnMPlus.Text = "M+";
            this.btnMPlus.UseVisualStyleBackColor = false;
            // 
            // btnMR
            // 
            this.btnMR.BackColor = System.Drawing.SystemColors.Control;
            this.btnMR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMR.FlatAppearance.BorderSize = 0;
            this.btnMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMR.Location = new System.Drawing.Point(48, 0);
            this.btnMR.Margin = new System.Windows.Forms.Padding(0);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(48, 27);
            this.btnMR.TabIndex = 1;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = false;
            // 
            // btnMC
            // 
            this.btnMC.BackColor = System.Drawing.SystemColors.Control;
            this.btnMC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMC.FlatAppearance.BorderSize = 0;
            this.btnMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMC.Location = new System.Drawing.Point(0, 0);
            this.btnMC.Margin = new System.Windows.Forms.Padding(0);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(48, 27);
            this.btnMC.TabIndex = 0;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = false;
            // 
            // lblMode
            // 
            this.lblMode.BackColor = System.Drawing.SystemColors.Control;
            this.lblMode.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.lblMode.Location = new System.Drawing.Point(42, 14);
            this.lblMode.Margin = new System.Windows.Forms.Padding(0);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(52, 23);
            this.lblMode.TabIndex = 15;
            this.lblMode.Text = "표준";
            this.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(315, 44);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.표준ToolStripMenuItem,
            this.공학용ToolStripMenuItem,
            this.그래프ToolStripMenuItem,
            this.프로그래머ToolStripMenuItem,
            this.날짜계산ToolStripMenuItem,
            this.toolStripTextBox2,
            this.통화환율ToolStripMenuItem,
            this.부피ToolStripMenuItem,
            this.toolStripSeparator1,
            this.설정ToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItem1.Size = new System.Drawing.Size(40, 40);
            this.toolStripMenuItem1.Text = "☰";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox1.Enabled = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 22);
            this.toolStripTextBox1.Text = "계산기";
            // 
            // 표준ToolStripMenuItem
            // 
            this.표준ToolStripMenuItem.Name = "표준ToolStripMenuItem";
            this.표준ToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.표준ToolStripMenuItem.Text = "표준";
            // 
            // 공학용ToolStripMenuItem
            // 
            this.공학용ToolStripMenuItem.Name = "공학용ToolStripMenuItem";
            this.공학용ToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.공학용ToolStripMenuItem.Text = "공학용";
            // 
            // 그래프ToolStripMenuItem
            // 
            this.그래프ToolStripMenuItem.Name = "그래프ToolStripMenuItem";
            this.그래프ToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.그래프ToolStripMenuItem.Text = "그래프";
            // 
            // 프로그래머ToolStripMenuItem
            // 
            this.프로그래머ToolStripMenuItem.Name = "프로그래머ToolStripMenuItem";
            this.프로그래머ToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.프로그래머ToolStripMenuItem.Text = "프로그래머";
            // 
            // 날짜계산ToolStripMenuItem
            // 
            this.날짜계산ToolStripMenuItem.Name = "날짜계산ToolStripMenuItem";
            this.날짜계산ToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.날짜계산ToolStripMenuItem.Text = "날짜 계산";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox2.Enabled = false;
            this.toolStripTextBox2.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 22);
            this.toolStripTextBox2.Text = "변환기";
            // 
            // 통화환율ToolStripMenuItem
            // 
            this.통화환율ToolStripMenuItem.Name = "통화환율ToolStripMenuItem";
            this.통화환율ToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.통화환율ToolStripMenuItem.Text = "통화 환율";
            // 
            // 부피ToolStripMenuItem
            // 
            this.부피ToolStripMenuItem.Name = "부피ToolStripMenuItem";
            this.부피ToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.부피ToolStripMenuItem.Text = "부피";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.설정ToolStripMenuItem.Text = "설정";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 455);
            this.Controls.Add(this.tboxResult1);
            this.Controls.Add(this.tboxResult2);
            this.Controls.Add(this.tLayoutPlanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tLayoutPlanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxResult1;
        private System.Windows.Forms.TextBox tboxResult2;
        private System.Windows.Forms.TableLayoutPanel tLayoutPlanel;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnRoute;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnFraction;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnMinusPlus;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnMDown;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMMinus;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem 표준ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 공학용ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 그래프ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로그래머ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 날짜계산ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem 통화환율ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 부피ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
    }
}

