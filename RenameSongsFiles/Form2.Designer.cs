
namespace RenameSongsFile
{
    partial class Form2
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
            this.rtbSongList = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnApplyList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbSongList
            // 
            this.rtbSongList.Location = new System.Drawing.Point(12, 25);
            this.rtbSongList.Name = "rtbSongList";
            this.rtbSongList.Size = new System.Drawing.Size(510, 578);
            this.rtbSongList.TabIndex = 0;
            this.rtbSongList.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Editar Nomes Manualmente";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(673, 580);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnApplyList
            // 
            this.btnApplyList.Location = new System.Drawing.Point(575, 580);
            this.btnApplyList.Name = "btnApplyList";
            this.btnApplyList.Size = new System.Drawing.Size(75, 23);
            this.btnApplyList.TabIndex = 4;
            this.btnApplyList.Text = "Aplicar";
            this.btnApplyList.UseVisualStyleBackColor = true;
            this.btnApplyList.Click += new System.EventHandler(this.btnApplyList_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 615);
            this.Controls.Add(this.btnApplyList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbSongList);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSongList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnApplyList;
    }
}