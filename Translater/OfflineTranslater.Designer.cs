
namespace Translater
{
    partial class OfflineTranslater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfflineTranslater));
            this.txtSrc = new System.Windows.Forms.RichTextBox();
            this.txtOut = new System.Windows.Forms.RichTextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.txtTrLang = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtSrc
            // 
            this.txtSrc.Location = new System.Drawing.Point(149, 48);
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.Size = new System.Drawing.Size(100, 96);
            this.txtSrc.TabIndex = 0;
            this.txtSrc.Text = "";
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(149, 229);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(100, 96);
            this.txtOut.TabIndex = 1;
            this.txtOut.Text = "";
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(149, 174);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 2;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // txtTrLang
            // 
            this.txtTrLang.Location = new System.Drawing.Point(12, 117);
            this.txtTrLang.Name = "txtTrLang";
            this.txtTrLang.Size = new System.Drawing.Size(86, 44);
            this.txtTrLang.TabIndex = 3;
            this.txtTrLang.Text = "";
            // 
            // OfflineTranslater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 355);
            this.Controls.Add(this.txtTrLang);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.txtSrc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OfflineTranslater";
            this.Text = "ExEx Platform Binary";
            this.Load += new System.EventHandler(this.OfflineTranslater_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtSrc;
        private System.Windows.Forms.RichTextBox txtOut;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.RichTextBox txtTrLang;
    }
}