namespace App1
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
            BtnReadStr = new Button();
            BtnWriteStr = new Button();
            TxtHello = new TextBox();
            SuspendLayout();
            // 
            // BtnReadStr
            // 
            BtnReadStr.Location = new Point(227, 12);
            BtnReadStr.Name = "BtnReadStr";
            BtnReadStr.Size = new Size(75, 23);
            BtnReadStr.TabIndex = 0;
            BtnReadStr.Text = "Read";
            BtnReadStr.UseVisualStyleBackColor = true;
            BtnReadStr.Click += BtnReadStr_Click;
            // 
            // BtnWriteStr
            // 
            BtnWriteStr.Location = new Point(330, 12);
            BtnWriteStr.Name = "BtnWriteStr";
            BtnWriteStr.Size = new Size(75, 23);
            BtnWriteStr.TabIndex = 1;
            BtnWriteStr.Text = "Write";
            BtnWriteStr.UseVisualStyleBackColor = true;
            BtnWriteStr.Click += BtnWriteStr_Click;
            // 
            // TxtHello
            // 
            TxtHello.Location = new Point(12, 12);
            TxtHello.Name = "TxtHello";
            TxtHello.Size = new Size(199, 23);
            TxtHello.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 49);
            Controls.Add(TxtHello);
            Controls.Add(BtnWriteStr);
            Controls.Add(BtnReadStr);
            Name = "Form1";
            Text = "App1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnReadStr;
        private Button BtnWriteStr;
        private TextBox TxtHello;
    }
}
