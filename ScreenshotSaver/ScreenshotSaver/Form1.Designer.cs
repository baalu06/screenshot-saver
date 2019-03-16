namespace ScreenshotSaver
{
    partial class Form1
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
            this.txt_DocName = new System.Windows.Forms.TextBox();
            this.lbl_DocName = new System.Windows.Forms.Label();
            this.lbl_Path = new System.Windows.Forms.Label();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.Worker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // txt_DocName
            // 
            this.txt_DocName.Location = new System.Drawing.Point(273, 92);
            this.txt_DocName.Name = "txt_DocName";
            this.txt_DocName.Size = new System.Drawing.Size(325, 26);
            this.txt_DocName.TabIndex = 0;
            // 
            // lbl_DocName
            // 
            this.lbl_DocName.AutoSize = true;
            this.lbl_DocName.Location = new System.Drawing.Point(86, 95);
            this.lbl_DocName.Name = "lbl_DocName";
            this.lbl_DocName.Size = new System.Drawing.Size(125, 20);
            this.lbl_DocName.TabIndex = 1;
            this.lbl_DocName.Text = "DocumentName";
            // 
            // lbl_Path
            // 
            this.lbl_Path.AutoSize = true;
            this.lbl_Path.Location = new System.Drawing.Point(169, 164);
            this.lbl_Path.Name = "lbl_Path";
            this.lbl_Path.Size = new System.Drawing.Size(42, 20);
            this.lbl_Path.TabIndex = 2;
            this.lbl_Path.Text = "Path";
            // 
            // txt_Path
            // 
            this.txt_Path.Location = new System.Drawing.Point(273, 158);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(290, 26);
            this.txt_Path.TabIndex = 3;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(190, 238);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(134, 39);
            this.btn_Start.TabIndex = 4;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(349, 238);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(134, 39);
            this.btn_Stop.TabIndex = 5;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // Worker
            // 
            this.Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.txt_Path);
            this.Controls.Add(this.lbl_Path);
            this.Controls.Add(this.lbl_DocName);
            this.Controls.Add(this.txt_DocName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_DocName;
        private System.Windows.Forms.Label lbl_DocName;
        private System.Windows.Forms.Label lbl_Path;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.ComponentModel.BackgroundWorker Worker;
    }
}

