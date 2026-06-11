namespace кокулятор
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlDisplay = new Panel();
            panel1 = new Panel();
            lblDisplay = new Label();
            tlpButtonsPanel = new TableLayoutPanel();
            btntch = new Button();
            btn0 = new Button();
            btnpl = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnmin = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnmn = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnBackspace = new Button();
            btnce = new Button();
            btnvid = new Button();
            btndl = new Button();
            btndr = new Button();
            radioOn = new RadioButton();
            radioOff = new RadioButton();
            pnlDisplay.SuspendLayout();
            tlpButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDisplay
            // 
            pnlDisplay.Controls.Add(panel1);
            pnlDisplay.Controls.Add(lblDisplay);
            pnlDisplay.Dock = DockStyle.Top;
            pnlDisplay.Location = new Point(0, 0);
            pnlDisplay.MaximumSize = new Size(0, 80);
            pnlDisplay.MinimumSize = new Size(0, 80);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Padding = new Padding(5);
            pnlDisplay.Size = new Size(366, 80);
            pnlDisplay.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 233);
            panel1.TabIndex = 1;
            // 
            // lblDisplay
            // 
            lblDisplay.BackColor = Color.White;
            lblDisplay.Dock = DockStyle.Fill;
            lblDisplay.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisplay.Location = new Point(5, 5);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(356, 70);
            lblDisplay.TabIndex = 0;
            lblDisplay.Text = "0";
            lblDisplay.TextAlign = ContentAlignment.MiddleRight;
            lblDisplay.TextChanged += lblDisplay_TextChanged;
            // 
            // tlpButtonsPanel
            // 
            tlpButtonsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpButtonsPanel.ColumnCount = 4;
            tlpButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.7704926F));
            tlpButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.31694F));
            tlpButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.9562836F));
            tlpButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.9562836F));
            tlpButtonsPanel.Controls.Add(btntch, 1, 4);
            tlpButtonsPanel.Controls.Add(btn0, 0, 4);
            tlpButtonsPanel.Controls.Add(btnpl, 3, 3);
            tlpButtonsPanel.Controls.Add(btn3, 2, 3);
            tlpButtonsPanel.Controls.Add(btn2, 1, 3);
            tlpButtonsPanel.Controls.Add(btn1, 0, 3);
            tlpButtonsPanel.Controls.Add(btnmin, 3, 2);
            tlpButtonsPanel.Controls.Add(btn6, 2, 2);
            tlpButtonsPanel.Controls.Add(btn5, 1, 2);
            tlpButtonsPanel.Controls.Add(btn4, 0, 2);
            tlpButtonsPanel.Controls.Add(btnmn, 3, 1);
            tlpButtonsPanel.Controls.Add(btn9, 2, 1);
            tlpButtonsPanel.Controls.Add(btn8, 1, 1);
            tlpButtonsPanel.Controls.Add(btn7, 0, 1);
            tlpButtonsPanel.Controls.Add(btnBackspace, 1, 0);
            tlpButtonsPanel.Controls.Add(btnce, 0, 0);
            tlpButtonsPanel.Controls.Add(btnvid, 2, 0);
            tlpButtonsPanel.Controls.Add(btndl, 3, 0);
            tlpButtonsPanel.Controls.Add(btndr, 2, 4);
            tlpButtonsPanel.Location = new Point(0, 102);
            tlpButtonsPanel.Name = "tlpButtonsPanel";
            tlpButtonsPanel.RowCount = 5;
            tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 19.4552536F));
            tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20.2334633F));
            tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpButtonsPanel.Size = new Size(366, 233);
            tlpButtonsPanel.TabIndex = 1;
            // 
            // btntch
            // 
            btntch.Dock = DockStyle.Fill;
            btntch.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btntch.Location = new Point(89, 186);
            btntch.Margin = new Padding(2);
            btntch.Name = "btntch";
            btntch.Size = new Size(85, 45);
            btntch.TabIndex = 17;
            btntch.Text = ".";
            btntch.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Dock = DockStyle.Fill;
            btn0.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn0.Location = new Point(2, 186);
            btn0.Margin = new Padding(2);
            btn0.Name = "btn0";
            btn0.Size = new Size(83, 45);
            btn0.TabIndex = 16;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btnpl
            // 
            btnpl.Dock = DockStyle.Fill;
            btnpl.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnpl.Location = new Point(273, 139);
            btnpl.Margin = new Padding(2);
            btnpl.Name = "btnpl";
            btnpl.Size = new Size(91, 43);
            btnpl.TabIndex = 15;
            btnpl.Text = "+";
            btnpl.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Dock = DockStyle.Fill;
            btn3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.Location = new Point(178, 139);
            btn3.Margin = new Padding(2);
            btn3.Name = "btn3";
            btn3.Size = new Size(91, 43);
            btn3.TabIndex = 14;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Dock = DockStyle.Fill;
            btn2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(89, 139);
            btn2.Margin = new Padding(2);
            btn2.Name = "btn2";
            btn2.Size = new Size(85, 43);
            btn2.TabIndex = 13;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Fill;
            btn1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(2, 139);
            btn1.Margin = new Padding(2);
            btn1.Name = "btn1";
            btn1.Size = new Size(83, 43);
            btn1.TabIndex = 12;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btnmin
            // 
            btnmin.Dock = DockStyle.Fill;
            btnmin.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnmin.Location = new Point(273, 94);
            btnmin.Margin = new Padding(2);
            btnmin.Name = "btnmin";
            btnmin.Size = new Size(91, 41);
            btnmin.TabIndex = 11;
            btnmin.Text = "-";
            btnmin.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Dock = DockStyle.Fill;
            btn6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.Location = new Point(178, 94);
            btn6.Margin = new Padding(2);
            btn6.Name = "btn6";
            btn6.Size = new Size(91, 41);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Dock = DockStyle.Fill;
            btn5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.Location = new Point(89, 94);
            btn5.Margin = new Padding(2);
            btn5.Name = "btn5";
            btn5.Size = new Size(85, 41);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Dock = DockStyle.Fill;
            btn4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.Location = new Point(2, 94);
            btn4.Margin = new Padding(2);
            btn4.Name = "btn4";
            btn4.Size = new Size(83, 41);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btnmn
            // 
            btnmn.Dock = DockStyle.Fill;
            btnmn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnmn.Location = new Point(273, 48);
            btnmn.Margin = new Padding(2);
            btnmn.Name = "btnmn";
            btnmn.Size = new Size(91, 42);
            btnmn.TabIndex = 7;
            btnmn.Text = "*";
            btnmn.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Dock = DockStyle.Fill;
            btn9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.Location = new Point(178, 48);
            btn9.Margin = new Padding(2);
            btn9.Name = "btn9";
            btn9.Size = new Size(91, 42);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Dock = DockStyle.Fill;
            btn8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.Location = new Point(89, 48);
            btn8.Margin = new Padding(2);
            btn8.Name = "btn8";
            btn8.Size = new Size(85, 42);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Dock = DockStyle.Fill;
            btn7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.Location = new Point(2, 48);
            btn7.Margin = new Padding(2);
            btn7.Name = "btn7";
            btn7.Size = new Size(83, 42);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btnBackspace
            // 
            btnBackspace.Dock = DockStyle.Fill;
            btnBackspace.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnBackspace.Location = new Point(89, 2);
            btnBackspace.Margin = new Padding(2);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(85, 42);
            btnBackspace.TabIndex = 1;
            btnBackspace.Text = "←";
            btnBackspace.UseVisualStyleBackColor = true;
            // 
            // btnce
            // 
            btnce.Dock = DockStyle.Fill;
            btnce.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnce.ForeColor = Color.OrangeRed;
            btnce.Location = new Point(2, 2);
            btnce.Margin = new Padding(2);
            btnce.Name = "btnce";
            btnce.Size = new Size(83, 42);
            btnce.TabIndex = 0;
            btnce.Text = "CE";
            btnce.UseVisualStyleBackColor = true;
            btnce.Click += btnce_Click;
            // 
            // btnvid
            // 
            btnvid.Dock = DockStyle.Fill;
            btnvid.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnvid.Location = new Point(178, 2);
            btnvid.Margin = new Padding(2);
            btnvid.Name = "btnvid";
            btnvid.Size = new Size(91, 42);
            btnvid.TabIndex = 2;
            btnvid.Text = "%";
            btnvid.UseVisualStyleBackColor = true;
            // 
            // btndl
            // 
            btndl.Dock = DockStyle.Fill;
            btndl.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btndl.Location = new Point(273, 2);
            btndl.Margin = new Padding(2);
            btndl.Name = "btndl";
            btndl.Size = new Size(91, 42);
            btndl.TabIndex = 3;
            btndl.Text = "/";
            btndl.UseVisualStyleBackColor = true;
            // 
            // btndr
            // 
            tlpButtonsPanel.SetColumnSpan(btndr, 2);
            btndr.Dock = DockStyle.Fill;
            btndr.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btndr.Location = new Point(178, 186);
            btndr.Margin = new Padding(2);
            btndr.Name = "btndr";
            btndr.Size = new Size(186, 45);
            btndr.TabIndex = 19;
            btndr.Text = "=";
            btndr.UseVisualStyleBackColor = true;
            // 
            // radioOn
            // 
            radioOn.AutoSize = true;
            radioOn.Location = new Point(5, 80);
            radioOn.Name = "radioOn";
            radioOn.Size = new Size(43, 19);
            radioOn.TabIndex = 2;
            radioOn.TabStop = true;
            radioOn.Text = "ON";
            radioOn.UseVisualStyleBackColor = true;
            radioOn.CheckedChanged += radioOn_CheckedChanged;
            // 
            // radioOff
            // 
            radioOff.AutoSize = true;
            radioOff.Location = new Point(54, 80);
            radioOff.Name = "radioOff";
            radioOff.Size = new Size(46, 19);
            radioOff.TabIndex = 3;
            radioOff.TabStop = true;
            radioOff.Text = "OFF";
            radioOff.UseVisualStyleBackColor = true;
            radioOff.CheckedChanged += radioOff_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 335);
            Controls.Add(radioOff);
            Controls.Add(radioOn);
            Controls.Add(pnlDisplay);
            Controls.Add(tlpButtonsPanel);
            Name = "Form1";
            Text = "Калькулятор";
            Load += Form1_Load;
            pnlDisplay.ResumeLayout(false);
            tlpButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlDisplay;
        private Label lblDisplay;
        private TableLayoutPanel tlpButtonsPanel;
        private Panel panel1;
        private Button btndr;
        private Button btntch;
        private Button btn0;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnBackspace;
        private Button btnce;
        private Button btnvid;
        private Button btnpl;
        private Button btnmin;
        private Button btnmn;
        private Button btndl;
        private RadioButton radioOn;
        private RadioButton radioOff;
    }
}