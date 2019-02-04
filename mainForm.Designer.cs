namespace GenPass
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.btnGenPass = new System.Windows.Forms.Button();
            this.txtBoxGenerator = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkBoxSpecial = new System.Windows.Forms.CheckBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.grpBoxAll = new System.Windows.Forms.GroupBox();
            this.chkBoxAll = new System.Windows.Forms.CheckBox();
            this.grpBoxCustom = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxCustom = new System.Windows.Forms.TextBox();
            this.chkBoxCustom = new System.Windows.Forms.CheckBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.grpBoxAll.SuspendLayout();
            this.grpBoxCustom.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenPass
            // 
            this.btnGenPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenPass.Location = new System.Drawing.Point(178, 171);
            this.btnGenPass.Name = "btnGenPass";
            this.btnGenPass.Size = new System.Drawing.Size(348, 56);
            this.btnGenPass.TabIndex = 1;
            this.btnGenPass.Text = "Generate Password";
            this.btnGenPass.UseVisualStyleBackColor = true;
            this.btnGenPass.Click += new System.EventHandler(this.BtnGenPass_Click);
            // 
            // txtBoxGenerator
            // 
            this.txtBoxGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxGenerator.Location = new System.Drawing.Point(15, 243);
            this.txtBoxGenerator.Name = "txtBoxGenerator";
            this.txtBoxGenerator.Size = new System.Drawing.Size(678, 22);
            this.txtBoxGenerator.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "GENPASS";
            // 
            // txtBoxLength
            // 
            this.txtBoxLength.Location = new System.Drawing.Point(257, 18);
            this.txtBoxLength.Name = "txtBoxLength";
            this.txtBoxLength.Size = new System.Drawing.Size(59, 20);
            this.txtBoxLength.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Desired Password Length";
            // 
            // chkBoxSpecial
            // 
            this.chkBoxSpecial.AutoSize = true;
            this.chkBoxSpecial.Location = new System.Drawing.Point(21, 47);
            this.chkBoxSpecial.Name = "chkBoxSpecial";
            this.chkBoxSpecial.Size = new System.Drawing.Size(174, 17);
            this.chkBoxSpecial.TabIndex = 7;
            this.chkBoxSpecial.Text = "Do Not Use Special Characters";
            this.chkBoxSpecial.UseVisualStyleBackColor = true;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(12, 281);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(35, 13);
            this.lblVersion.TabIndex = 10;
            this.lblVersion.Text = "label3";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(178, 276);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(348, 23);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy Password to Clipboard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // grpBoxAll
            // 
            this.grpBoxAll.Controls.Add(this.chkBoxSpecial);
            this.grpBoxAll.Controls.Add(this.label2);
            this.grpBoxAll.Controls.Add(this.txtBoxLength);
            this.grpBoxAll.Location = new System.Drawing.Point(360, 92);
            this.grpBoxAll.Name = "grpBoxAll";
            this.grpBoxAll.Size = new System.Drawing.Size(327, 73);
            this.grpBoxAll.TabIndex = 11;
            this.grpBoxAll.TabStop = false;
            this.grpBoxAll.Text = "`";
            // 
            // chkBoxAll
            // 
            this.chkBoxAll.AutoSize = true;
            this.chkBoxAll.Location = new System.Drawing.Point(381, 67);
            this.chkBoxAll.Name = "chkBoxAll";
            this.chkBoxAll.Size = new System.Drawing.Size(91, 17);
            this.chkBoxAll.TabIndex = 8;
            this.chkBoxAll.Text = "All Characters";
            this.chkBoxAll.UseVisualStyleBackColor = true;
            this.chkBoxAll.CheckedChanged += new System.EventHandler(this.ChkBoxAll_CheckedChanged);
            // 
            // grpBoxCustom
            // 
            this.grpBoxCustom.Controls.Add(this.label3);
            this.grpBoxCustom.Controls.Add(this.txtBoxCustom);
            this.grpBoxCustom.Location = new System.Drawing.Point(12, 92);
            this.grpBoxCustom.Name = "grpBoxCustom";
            this.grpBoxCustom.Size = new System.Drawing.Size(327, 73);
            this.grpBoxCustom.TabIndex = 12;
            this.grpBoxCustom.TabStop = false;
            this.grpBoxCustom.Text = "`";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Characters To Be Used";
            // 
            // txtBoxCustom
            // 
            this.txtBoxCustom.Location = new System.Drawing.Point(43, 45);
            this.txtBoxCustom.Name = "txtBoxCustom";
            this.txtBoxCustom.Size = new System.Drawing.Size(214, 20);
            this.txtBoxCustom.TabIndex = 0;
            // 
            // chkBoxCustom
            // 
            this.chkBoxCustom.AutoSize = true;
            this.chkBoxCustom.Location = new System.Drawing.Point(55, 67);
            this.chkBoxCustom.Name = "chkBoxCustom";
            this.chkBoxCustom.Size = new System.Drawing.Size(156, 17);
            this.chkBoxCustom.TabIndex = 8;
            this.chkBoxCustom.Text = "User Defined Character List";
            this.chkBoxCustom.UseVisualStyleBackColor = true;
            this.chkBoxCustom.CheckedChanged += new System.EventHandler(this.ChkBoxCustom_CheckedChanged);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(601, 276);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(92, 23);
            this.btnAbout.TabIndex = 13;
            this.btnAbout.Text = "About GenPass";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // mainForm
            // 
            this.AcceptButton = this.btnGenPass;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 305);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.chkBoxAll);
            this.Controls.Add(this.chkBoxCustom);
            this.Controls.Add(this.grpBoxCustom);
            this.Controls.Add(this.grpBoxAll);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxGenerator);
            this.Controls.Add(this.btnGenPass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "GenPass";
            this.grpBoxAll.ResumeLayout(false);
            this.grpBoxAll.PerformLayout();
            this.grpBoxCustom.ResumeLayout(false);
            this.grpBoxCustom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenPass;
        private System.Windows.Forms.TextBox txtBoxGenerator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkBoxSpecial;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.GroupBox grpBoxAll;
        private System.Windows.Forms.CheckBox chkBoxAll;
        private System.Windows.Forms.GroupBox grpBoxCustom;
        private System.Windows.Forms.CheckBox chkBoxCustom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxCustom;
        private System.Windows.Forms.Button btnAbout;
    }
}

