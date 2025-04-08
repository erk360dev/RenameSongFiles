
namespace RenameSongsFiles
{
    partial class Form3
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
            this.rtbSongListDet = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbSongListDet
            // 
            this.rtbSongListDet.Location = new System.Drawing.Point(12, 12);
            this.rtbSongListDet.Name = "rtbSongListDet";
            this.rtbSongListDet.Size = new System.Drawing.Size(861, 565);
            this.rtbSongListDet.TabIndex = 0;
            this.rtbSongListDet.Text = "";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 589);
            this.Controls.Add(this.rtbSongListDet);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSongListDet;
    }
}