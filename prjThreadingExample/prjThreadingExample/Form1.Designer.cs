namespace prjThreadingExample
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
            btn_Start = new Button();
            lbl_Status = new Label();
            lbl_Count = new Label();
            SuspendLayout();
            // 
            // btn_Start
            // 
            btn_Start.Location = new Point(117, 208);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(94, 29);
            btn_Start.TabIndex = 0;
            btn_Start.Text = "START";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // lbl_Status
            // 
            lbl_Status.AutoSize = true;
            lbl_Status.Location = new Point(136, 60);
            lbl_Status.Name = "lbl_Status";
            lbl_Status.Size = new Size(59, 20);
            lbl_Status.TabIndex = 1;
            lbl_Status.Text = "STATUS";
            // 
            // lbl_Count
            // 
            lbl_Count.AutoSize = true;
            lbl_Count.Location = new Point(73, 131);
            lbl_Count.Name = "lbl_Count";
            lbl_Count.Size = new Size(185, 20);
            lbl_Count.TabIndex = 2;
            lbl_Count.Text = "Count Numbers Goes Here";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 301);
            Controls.Add(lbl_Count);
            Controls.Add(lbl_Status);
            Controls.Add(btn_Start);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Start;
        private Label lbl_Status;
        private Label lbl_Count;
    }
}
