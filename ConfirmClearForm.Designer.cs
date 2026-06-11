namespace кокулятор
{
    partial class ConfirmClearForm
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
            buttonYes = new Button();
            buttonNo = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonYes
            // 
            buttonYes.Location = new Point(81, 123);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new Size(113, 41);
            buttonYes.TabIndex = 0;
            buttonYes.Text = "Так";
            buttonYes.UseVisualStyleBackColor = true;
            buttonYes.Click += buttonYes_Click;
            // 
            // buttonNo
            // 
            buttonNo.Location = new Point(260, 123);
            buttonNo.Name = "buttonNo";
            buttonNo.Size = new Size(113, 41);
            buttonNo.TabIndex = 1;
            buttonNo.Text = "Ні";
            buttonNo.UseVisualStyleBackColor = true;
            buttonNo.Click += buttonNo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(81, 40);
            label1.Name = "label1";
            label1.Size = new Size(292, 45);
            label1.TabIndex = 2;
            label1.Text = "Ви дійсно бажаєте";
            label1.Click += label1_Click;
            // 
            // ConfirmClearForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 189);
            Controls.Add(label1);
            Controls.Add(buttonNo);
            Controls.Add(buttonYes);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConfirmClearForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ConfirmClearForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonYes;
        private Button buttonNo;
        private Label label1;
    }
}