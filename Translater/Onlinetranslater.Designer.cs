
namespace Translater
{
    partial class Onlinetranslater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Onlinetranslater));
            this.txtSrc = new System.Windows.Forms.RichTextBox();
            this.txtDestLang = new System.Windows.Forms.RichTextBox();
            this.btnDetectSrcLang = new System.Windows.Forms.Button();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.comboAvivableLangs = new System.Windows.Forms.ComboBox();
            this.lblSrcLang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSrc
            // 
            this.txtSrc.Location = new System.Drawing.Point(12, 12);
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.Size = new System.Drawing.Size(339, 101);
            this.txtSrc.TabIndex = 0;
            this.txtSrc.Text = "";
            // 
            // txtDestLang
            // 
            this.txtDestLang.Location = new System.Drawing.Point(12, 214);
            this.txtDestLang.Name = "txtDestLang";
            this.txtDestLang.Size = new System.Drawing.Size(339, 107);
            this.txtDestLang.TabIndex = 1;
            this.txtDestLang.Text = "";
            // 
            // btnDetectSrcLang
            // 
            this.btnDetectSrcLang.Location = new System.Drawing.Point(12, 119);
            this.btnDetectSrcLang.Name = "btnDetectSrcLang";
            this.btnDetectSrcLang.Size = new System.Drawing.Size(339, 30);
            this.btnDetectSrcLang.TabIndex = 2;
            this.btnDetectSrcLang.Text = "Detect Language";
            this.btnDetectSrcLang.UseVisualStyleBackColor = true;
            this.btnDetectSrcLang.Click += new System.EventHandler(this.btnDetectSrcLang_Click);
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(192, 155);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(159, 23);
            this.btnTranslate.TabIndex = 3;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnAC
            // 
            this.btnAC.Location = new System.Drawing.Point(12, 155);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(174, 23);
            this.btnAC.TabIndex = 4;
            this.btnAC.Text = "AC";
            this.btnAC.UseVisualStyleBackColor = true;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // comboAvivableLangs
            // 
            this.comboAvivableLangs.FormattingEnabled = true;
            this.comboAvivableLangs.Location = new System.Drawing.Point(12, 184);
            this.comboAvivableLangs.Name = "comboAvivableLangs";
            this.comboAvivableLangs.Size = new System.Drawing.Size(339, 24);
            this.comboAvivableLangs.TabIndex = 5;
            // 
            // lblSrcLang
            // 
            this.lblSrcLang.AutoSize = true;
            this.lblSrcLang.Location = new System.Drawing.Point(12, 324);
            this.lblSrcLang.Name = "lblSrcLang";
            this.lblSrcLang.Size = new System.Drawing.Size(125, 17);
            this.lblSrcLang.TabIndex = 6;
            this.lblSrcLang.Text = "Source Language:";
            // 
            // Onlinetranslater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 342);
            this.Controls.Add(this.lblSrcLang);
            this.Controls.Add(this.comboAvivableLangs);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.btnDetectSrcLang);
            this.Controls.Add(this.txtDestLang);
            this.Controls.Add(this.txtSrc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Onlinetranslater";
            this.Text = "ExEx Platform Binary";
            this.Load += new System.EventHandler(this.Onlinetranslater_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtSrc;
        private System.Windows.Forms.RichTextBox txtDestLang;
        private System.Windows.Forms.Button btnDetectSrcLang;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.ComboBox comboAvivableLangs;
        private System.Windows.Forms.Label lblSrcLang;
    }
}