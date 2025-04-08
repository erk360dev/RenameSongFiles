

namespace RenameSongsFiles
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
            this.components = new System.ComponentModel.Container();
            this.lbSongs = new System.Windows.Forms.ListBox();
            this.btnLoadSongs = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRenameFilesList = new System.Windows.Forms.Button();
            this.txtPatternRemove = new System.Windows.Forms.TextBox();
            this.lbSongsModified = new System.Windows.Forms.ListBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.txtInitialPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelDir = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnClearPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReapplyPatern = new System.Windows.Forms.TextBox();
            this.btnReapplyPattern = new System.Windows.Forms.Button();
            this.btnClearReapplyPatern = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bntClearLstBoxMod = new System.Windows.Forms.Button();
            this.txtSubsPattern = new System.Windows.Forms.TextBox();
            this.chkSubPattern = new System.Windows.Forms.CheckBox();
            this.bntClose = new System.Windows.Forms.Button();
            this.btnBackBefore = new System.Windows.Forms.Button();
            this.chkSubFolders = new System.Windows.Forms.CheckBox();
            this.bntEditList = new System.Windows.Forms.Button();
            this.bntShowDetail = new System.Windows.Forms.Button();
            this.bntLoadFFmpeg = new System.Windows.Forms.Button();
            this.lblTotalVideos = new System.Windows.Forms.Label();
            this.lblCountFFmpegLoaded = new System.Windows.Forms.Label();
            this.chkRemAutNmFile = new System.Windows.Forms.CheckBox();
            this.btnPutNnFolderFile = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkLoadSorted = new System.Windows.Forms.CheckBox();
            this.btnAudioNorm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSongs
            // 
            this.lbSongs.FormattingEnabled = true;
            this.lbSongs.Location = new System.Drawing.Point(6, 22);
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.Size = new System.Drawing.Size(422, 329);
            this.lbSongs.TabIndex = 0;
            // 
            // btnLoadSongs
            // 
            this.btnLoadSongs.Location = new System.Drawing.Point(351, 368);
            this.btnLoadSongs.Name = "btnLoadSongs";
            this.btnLoadSongs.Size = new System.Drawing.Size(75, 23);
            this.btnLoadSongs.TabIndex = 1;
            this.btnLoadSongs.Text = "Carregar";
            this.btnLoadSongs.UseVisualStyleBackColor = true;
            this.btnLoadSongs.Click += new System.EventHandler(this.btnLoadSongs_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(270, 368);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRenameFilesList
            // 
            this.btnRenameFilesList.Location = new System.Drawing.Point(486, 328);
            this.btnRenameFilesList.Name = "btnRenameFilesList";
            this.btnRenameFilesList.Size = new System.Drawing.Size(115, 23);
            this.btnRenameFilesList.TabIndex = 3;
            this.btnRenameFilesList.Text = "Ajustar Nomes ->";
            this.btnRenameFilesList.UseVisualStyleBackColor = true;
            this.btnRenameFilesList.Click += new System.EventHandler(this.btnRenameFileList_Click);
            // 
            // txtPatternRemove
            // 
            this.txtPatternRemove.Location = new System.Drawing.Point(5, 371);
            this.txtPatternRemove.Name = "txtPatternRemove";
            this.txtPatternRemove.Size = new System.Drawing.Size(243, 20);
            this.txtPatternRemove.TabIndex = 4;
            // 
            // lbSongsModified
            // 
            this.lbSongsModified.FormattingEnabled = true;
            this.lbSongsModified.Location = new System.Drawing.Point(662, 22);
            this.lbSongsModified.Name = "lbSongsModified";
            this.lbSongsModified.Size = new System.Drawing.Size(442, 329);
            this.lbSongsModified.TabIndex = 5;
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(1109, 368);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 36);
            this.btnRename.TabIndex = 6;
            this.btnRename.Text = "Salvar Novo Nome";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // txtInitialPath
            // 
            this.txtInitialPath.BackColor = System.Drawing.SystemColors.Window;
            this.txtInitialPath.Location = new System.Drawing.Point(5, 450);
            this.txtInitialPath.Name = "txtInitialPath";
            this.txtInitialPath.ReadOnly = true;
            this.txtInitialPath.Size = new System.Drawing.Size(260, 20);
            this.txtInitialPath.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Diretorio Atual";
            // 
            // btnSelDir
            // 
            this.btnSelDir.Location = new System.Drawing.Point(271, 448);
            this.btnSelDir.Name = "btnSelDir";
            this.btnSelDir.Size = new System.Drawing.Size(75, 23);
            this.btnSelDir.TabIndex = 9;
            this.btnSelDir.Text = "Definir";
            this.btnSelDir.UseVisualStyleBackColor = true;
            this.btnSelDir.Click += new System.EventHandler(this.btnSelDir_Click);
            // 
            // btnClearPath
            // 
            this.btnClearPath.Location = new System.Drawing.Point(5, 477);
            this.btnClearPath.Name = "btnClearPath";
            this.btnClearPath.Size = new System.Drawing.Size(75, 23);
            this.btnClearPath.TabIndex = 10;
            this.btnClearPath.Text = "Limpar Path";
            this.btnClearPath.UseVisualStyleBackColor = true;
            this.btnClearPath.Click += new System.EventHandler(this.btnClearPath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Texto Expressão Remoção";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(659, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Reaplicar Expressão Lista";
            // 
            // txtReapplyPatern
            // 
            this.txtReapplyPatern.Location = new System.Drawing.Point(662, 370);
            this.txtReapplyPatern.Name = "txtReapplyPatern";
            this.txtReapplyPatern.Size = new System.Drawing.Size(263, 20);
            this.txtReapplyPatern.TabIndex = 13;
            // 
            // btnReapplyPattern
            // 
            this.btnReapplyPattern.Location = new System.Drawing.Point(931, 368);
            this.btnReapplyPattern.Name = "btnReapplyPattern";
            this.btnReapplyPattern.Size = new System.Drawing.Size(75, 23);
            this.btnReapplyPattern.TabIndex = 14;
            this.btnReapplyPattern.Text = "Re-Aplicar";
            this.btnReapplyPattern.UseVisualStyleBackColor = true;
            this.btnReapplyPattern.Click += new System.EventHandler(this.btnReapplyPattern_Click);
            // 
            // btnClearReapplyPatern
            // 
            this.btnClearReapplyPatern.Location = new System.Drawing.Point(850, 394);
            this.btnClearReapplyPatern.Name = "btnClearReapplyPatern";
            this.btnClearReapplyPatern.Size = new System.Drawing.Size(75, 23);
            this.btnClearReapplyPatern.TabIndex = 15;
            this.btnClearReapplyPatern.Text = "Limpar";
            this.btnClearReapplyPatern.UseVisualStyleBackColor = true;
            this.btnClearReapplyPatern.Click += new System.EventHandler(this.btnClearReapplyPatern_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(1109, 420);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 16;
            this.btnClearAll.Text = "Limpar Tudo";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nome Arquivo Original";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(659, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Novo Nome Arquivo";
            // 
            // bntClearLstBoxMod
            // 
            this.bntClearLstBoxMod.Location = new System.Drawing.Point(1109, 328);
            this.bntClearLstBoxMod.Name = "bntClearLstBoxMod";
            this.bntClearLstBoxMod.Size = new System.Drawing.Size(75, 23);
            this.bntClearLstBoxMod.TabIndex = 19;
            this.bntClearLstBoxMod.Text = "Limpar Lista";
            this.bntClearLstBoxMod.UseVisualStyleBackColor = true;
            this.bntClearLstBoxMod.Click += new System.EventHandler(this.bntClearLstBoxMod_Click);
            // 
            // txtSubsPattern
            // 
            this.txtSubsPattern.Location = new System.Drawing.Point(662, 423);
            this.txtSubsPattern.Name = "txtSubsPattern";
            this.txtSubsPattern.ReadOnly = true;
            this.txtSubsPattern.Size = new System.Drawing.Size(263, 20);
            this.txtSubsPattern.TabIndex = 21;
            // 
            // chkSubPattern
            // 
            this.chkSubPattern.AutoSize = true;
            this.chkSubPattern.Location = new System.Drawing.Point(662, 406);
            this.chkSubPattern.Name = "chkSubPattern";
            this.chkSubPattern.Size = new System.Drawing.Size(123, 17);
            this.chkSubPattern.TabIndex = 22;
            this.chkSubPattern.Text = "Substituir por padrão";
            this.chkSubPattern.UseVisualStyleBackColor = true;
            this.chkSubPattern.CheckedChanged += new System.EventHandler(this.chkSubPattern_CheckedChanged);
            // 
            // bntClose
            // 
            this.bntClose.Location = new System.Drawing.Point(1109, 477);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(75, 23);
            this.bntClose.TabIndex = 23;
            this.bntClose.Text = "Fechar";
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // btnBackBefore
            // 
            this.btnBackBefore.Location = new System.Drawing.Point(1109, 22);
            this.btnBackBefore.Name = "btnBackBefore";
            this.btnBackBefore.Size = new System.Drawing.Size(84, 38);
            this.btnBackBefore.TabIndex = 24;
            this.btnBackBefore.Text = "Voltar Nome Anterior";
            this.btnBackBefore.UseVisualStyleBackColor = true;
            this.btnBackBefore.Click += new System.EventHandler(this.btnBackBefore_Click);
            // 
            // chkSubFolders
            // 
            this.chkSubFolders.AutoSize = true;
            this.chkSubFolders.Location = new System.Drawing.Point(352, 352);
            this.chkSubFolders.Name = "chkSubFolders";
            this.chkSubFolders.Size = new System.Drawing.Size(80, 17);
            this.chkSubFolders.TabIndex = 25;
            this.chkSubFolders.Text = "Sub-Pastas";
            this.chkSubFolders.UseVisualStyleBackColor = true;
            // 
            // bntEditList
            // 
            this.bntEditList.Location = new System.Drawing.Point(1109, 85);
            this.bntEditList.Name = "bntEditList";
            this.bntEditList.Size = new System.Drawing.Size(84, 39);
            this.bntEditList.TabIndex = 26;
            this.bntEditList.Text = "Editar Manualmente";
            this.bntEditList.UseVisualStyleBackColor = true;
            this.bntEditList.Click += new System.EventHandler(this.bntEditList_Click);
            // 
            // bntShowDetail
            // 
            this.bntShowDetail.Location = new System.Drawing.Point(662, 477);
            this.bntShowDetail.Name = "bntShowDetail";
            this.bntShowDetail.Size = new System.Drawing.Size(111, 23);
            this.bntShowDetail.TabIndex = 27;
            this.bntShowDetail.Text = "Mostrar Detalhes";
            this.bntShowDetail.UseVisualStyleBackColor = true;
            this.bntShowDetail.Click += new System.EventHandler(this.bntShowDetail_Click);
            // 
            // bntLoadFFmpeg
            // 
            this.bntLoadFFmpeg.Location = new System.Drawing.Point(486, 22);
            this.bntLoadFFmpeg.Name = "bntLoadFFmpeg";
            this.bntLoadFFmpeg.Size = new System.Drawing.Size(115, 23);
            this.bntLoadFFmpeg.TabIndex = 28;
            this.bntLoadFFmpeg.Text = "Carregar FFmpeg";
            this.bntLoadFFmpeg.UseVisualStyleBackColor = true;
            this.bntLoadFFmpeg.Click += new System.EventHandler(this.bntLoadFFmpeg_Click);
            // 
            // lblTotalVideos
            // 
            this.lblTotalVideos.AutoSize = true;
            this.lblTotalVideos.Location = new System.Drawing.Point(391, 5);
            this.lblTotalVideos.Name = "lblTotalVideos";
            this.lblTotalVideos.Size = new System.Drawing.Size(37, 13);
            this.lblTotalVideos.TabIndex = 29;
            this.lblTotalVideos.Text = "00000";
            // 
            // lblCountFFmpegLoaded
            // 
            this.lblCountFFmpegLoaded.AutoSize = true;
            this.lblCountFFmpegLoaded.Location = new System.Drawing.Point(566, 48);
            this.lblCountFFmpegLoaded.Name = "lblCountFFmpegLoaded";
            this.lblCountFFmpegLoaded.Size = new System.Drawing.Size(37, 13);
            this.lblCountFFmpegLoaded.TabIndex = 30;
            this.lblCountFFmpegLoaded.Text = "00000";
            // 
            // chkRemAutNmFile
            // 
            this.chkRemAutNmFile.AutoSize = true;
            this.chkRemAutNmFile.Location = new System.Drawing.Point(5, 394);
            this.chkRemAutNmFile.Name = "chkRemAutNmFile";
            this.chkRemAutNmFile.Size = new System.Drawing.Size(169, 17);
            this.chkRemAutNmFile.TabIndex = 31;
            this.chkRemAutNmFile.Text = "Remover Pasta Nome Arquivo";
            this.chkRemAutNmFile.UseVisualStyleBackColor = true;
            // 
            // btnPutNnFolderFile
            // 
            this.btnPutNnFolderFile.Location = new System.Drawing.Point(1109, 146);
            this.btnPutNnFolderFile.Name = "btnPutNnFolderFile";
            this.btnPutNnFolderFile.Size = new System.Drawing.Size(84, 49);
            this.btnPutNnFolderFile.TabIndex = 32;
            this.btnPutNnFolderFile.Text = "Colocar Pasta no Nome dos Arquivos";
            this.btnPutNnFolderFile.UseVisualStyleBackColor = true;
            this.btnPutNnFolderFile.Click += new System.EventHandler(this.btnRemNnFolderFile_Click);
            // 
            // chkLoadSorted
            // 
            this.chkLoadSorted.AutoSize = true;
            this.chkLoadSorted.Location = new System.Drawing.Point(431, 338);
            this.chkLoadSorted.Margin = new System.Windows.Forms.Padding(0);
            this.chkLoadSorted.Name = "chkLoadSorted";
            this.chkLoadSorted.Size = new System.Drawing.Size(15, 14);
            this.chkLoadSorted.TabIndex = 33;
            this.chkLoadSorted.UseVisualStyleBackColor = true;
            // 
            // btnAudioNorm
            // 
            this.btnAudioNorm.Location = new System.Drawing.Point(1111, 217);
            this.btnAudioNorm.Name = "btnAudioNorm";
            this.btnAudioNorm.Size = new System.Drawing.Size(75, 35);
            this.btnAudioNorm.TabIndex = 34;
            this.btnAudioNorm.Text = "Normalizar Audio";
            this.btnAudioNorm.UseVisualStyleBackColor = true;
            this.btnAudioNorm.Click += new System.EventHandler(this.btnAudioNorm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 516);
            this.Controls.Add(this.btnAudioNorm);
            this.Controls.Add(this.chkLoadSorted);
            this.Controls.Add(this.btnPutNnFolderFile);
            this.Controls.Add(this.chkRemAutNmFile);
            this.Controls.Add(this.lblCountFFmpegLoaded);
            this.Controls.Add(this.lblTotalVideos);
            this.Controls.Add(this.bntLoadFFmpeg);
            this.Controls.Add(this.bntShowDetail);
            this.Controls.Add(this.bntEditList);
            this.Controls.Add(this.chkSubFolders);
            this.Controls.Add(this.btnBackBefore);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.chkSubPattern);
            this.Controls.Add(this.txtSubsPattern);
            this.Controls.Add(this.bntClearLstBoxMod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnClearReapplyPatern);
            this.Controls.Add(this.btnReapplyPattern);
            this.Controls.Add(this.txtReapplyPatern);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClearPath);
            this.Controls.Add(this.btnSelDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInitialPath);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.lbSongsModified);
            this.Controls.Add(this.txtPatternRemove);
            this.Controls.Add(this.btnRenameFilesList);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoadSongs);
            this.Controls.Add(this.lbSongs);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       

        private System.Windows.Forms.ListBox lbSongs;
        private System.Windows.Forms.Button btnLoadSongs;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtPatternRemove;
        private System.Windows.Forms.Button btnRenameFilesList;
        private System.Windows.Forms.ListBox lbSongsModified;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnSelDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInitialPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnClearPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClearReapplyPatern;
        private System.Windows.Forms.Button btnReapplyPattern;
        private System.Windows.Forms.TextBox txtReapplyPatern;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntClearLstBoxMod;
        private System.Windows.Forms.CheckBox chkSubPattern;
        private System.Windows.Forms.TextBox txtSubsPattern;
        private System.Windows.Forms.Button bntClose;
        private System.Windows.Forms.Button btnBackBefore;
        private System.Windows.Forms.CheckBox chkSubFolders;
        private System.Windows.Forms.Button bntEditList;
        private System.Windows.Forms.Button bntShowDetail;
        private System.Windows.Forms.Button bntLoadFFmpeg;
        private System.Windows.Forms.Label lblTotalVideos;
        private System.Windows.Forms.Label lblCountFFmpegLoaded;
        private System.Windows.Forms.CheckBox chkRemAutNmFile;
        private System.Windows.Forms.Button btnPutNnFolderFile;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkLoadSorted;
        private System.Windows.Forms.Button btnAudioNorm;
    }
}

