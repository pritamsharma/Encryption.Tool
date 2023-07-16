namespace Encryption.Tool
{
    partial class FrmEncryptionTool
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEncryptionTool));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxEncrypt = new System.Windows.Forms.GroupBox();
            this.rbDecrypt = new System.Windows.Forms.RadioButton();
            this.rbEncrypt = new System.Windows.Forms.RadioButton();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbPassword = new System.Windows.Forms.RadioButton();
            this.rbQueryString = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpBoxEncrypt.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(63, 62);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(447, 22);
            this.txtInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text:";
            // 
            // grpBoxEncrypt
            // 
            this.grpBoxEncrypt.Controls.Add(this.rbDecrypt);
            this.grpBoxEncrypt.Controls.Add(this.rbEncrypt);
            this.grpBoxEncrypt.Location = new System.Drawing.Point(219, 103);
            this.grpBoxEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxEncrypt.Name = "grpBoxEncrypt";
            this.grpBoxEncrypt.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxEncrypt.Size = new System.Drawing.Size(180, 42);
            this.grpBoxEncrypt.TabIndex = 2;
            this.grpBoxEncrypt.TabStop = false;
            // 
            // rbDecrypt
            // 
            this.rbDecrypt.AutoSize = true;
            this.rbDecrypt.Location = new System.Drawing.Point(91, 15);
            this.rbDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.rbDecrypt.Name = "rbDecrypt";
            this.rbDecrypt.Size = new System.Drawing.Size(75, 20);
            this.rbDecrypt.TabIndex = 1;
            this.rbDecrypt.Text = "Decrypt";
            this.rbDecrypt.UseVisualStyleBackColor = true;
            // 
            // rbEncrypt
            // 
            this.rbEncrypt.AutoSize = true;
            this.rbEncrypt.Checked = true;
            this.rbEncrypt.Location = new System.Drawing.Point(8, 15);
            this.rbEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.rbEncrypt.Name = "rbEncrypt";
            this.rbEncrypt.Size = new System.Drawing.Size(73, 20);
            this.rbEncrypt.TabIndex = 0;
            this.rbEncrypt.TabStop = true;
            this.rbEncrypt.Text = "Encrypt";
            this.rbEncrypt.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(63, 177);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(447, 22);
            this.txtResult.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result:";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(412, 114);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(95, 28);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Key:";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(63, 117);
            this.txtKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(149, 22);
            this.txtKey.TabIndex = 7;
            this.txtKey.Text = "pritamsh";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbPassword);
            this.groupBox2.Controls.Add(this.rbQueryString);
            this.groupBox2.Location = new System.Drawing.Point(63, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(355, 42);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // rbPassword
            // 
            this.rbPassword.AutoSize = true;
            this.rbPassword.Location = new System.Drawing.Point(163, 15);
            this.rbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.rbPassword.Name = "rbPassword";
            this.rbPassword.Size = new System.Drawing.Size(124, 20);
            this.rbPassword.TabIndex = 1;
            this.rbPassword.Text = "Encrypt with Salt";
            this.rbPassword.UseVisualStyleBackColor = true;
            this.rbPassword.Visible = false;
            this.rbPassword.CheckedChanged += new System.EventHandler(this.rbPassword_CheckedChanged);
            // 
            // rbQueryString
            // 
            this.rbQueryString.AutoSize = true;
            this.rbQueryString.Checked = true;
            this.rbQueryString.Location = new System.Drawing.Point(8, 14);
            this.rbQueryString.Margin = new System.Windows.Forms.Padding(4);
            this.rbQueryString.Name = "rbQueryString";
            this.rbQueryString.Size = new System.Drawing.Size(124, 20);
            this.rbQueryString.TabIndex = 0;
            this.rbQueryString.TabStop = true;
            this.rbQueryString.Text = "Encrypt with Key";
            this.rbQueryString.UseVisualStyleBackColor = true;
            this.rbQueryString.CheckedChanged += new System.EventHandler(this.rbQueryString_CheckedChanged);
            // 
            // FrmEncryptionTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 238);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.grpBoxEncrypt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmEncryptionTool";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryption Tool";
            this.grpBoxEncrypt.ResumeLayout(false);
            this.grpBoxEncrypt.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBoxEncrypt;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.RadioButton rbDecrypt;
        private System.Windows.Forms.RadioButton rbEncrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbPassword;
        private System.Windows.Forms.RadioButton rbQueryString;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

