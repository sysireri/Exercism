namespace _RunDosCommand
{
    partial class FrmRun
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
            this.butRun = new System.Windows.Forms.Button();
            this.txtProgramm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArguments = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butRun
            // 
            this.butRun.Location = new System.Drawing.Point(664, 104);
            this.butRun.Name = "butRun";
            this.butRun.Size = new System.Drawing.Size(115, 48);
            this.butRun.TabIndex = 0;
            this.butRun.Text = "Exécuter la commande DOS";
            this.butRun.UseVisualStyleBackColor = true;
            this.butRun.Click += new System.EventHandler(this.butRun_Click);
            // 
            // txtProgramm
            // 
            this.txtProgramm.Location = new System.Drawing.Point(112, 104);
            this.txtProgramm.Name = "txtProgramm";
            this.txtProgramm.Size = new System.Drawing.Size(217, 20);
            this.txtProgramm.TabIndex = 1;
            this.txtProgramm.Text = "exercism";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Programme :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Arguments :";
            // 
            // txtArguments
            // 
            this.txtArguments.Location = new System.Drawing.Point(112, 130);
            this.txtArguments.Name = "txtArguments";
            this.txtArguments.Size = new System.Drawing.Size(546, 20);
            this.txtArguments.TabIndex = 3;
            this.txtArguments.Text = "submit C:\\Users\\eric\\Exercism\\csharp";
            // 
            // FrmRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtArguments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProgramm);
            this.Controls.Add(this.butRun);
            this.Name = "FrmRun";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butRun;
        private System.Windows.Forms.TextBox txtProgramm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArguments;
    }
}

