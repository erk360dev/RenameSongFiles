using RenameSongsFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameSongsFiles
{
    public partial class Form1 : Form
    {
        private List<string> lstLastSongModified = new List<string>();
        private string tempUserFileName = null;
        private string[] selectedFilePaths = null;
        private Form2 form2 = null;
        private Form3 form3 = null;
        private List<VideoEntity> videos = null;
        public Form1()
        {
            InitializeComponent();

            loadCustomSettings();
        }

        private void loadCustomSettings() 
        {

            string tempPath = Path.GetTempPath();
            string tempFileName = Application.ProductName + "001.dat";
            string suggestionFolder = null;
            CultureInfo customCulture = (CultureInfo)CultureInfo.CurrentCulture.Clone();

            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = customCulture;
            Thread.CurrentThread.CurrentUICulture = customCulture;

            lblTotalVideos.Text = "";
            lblCountFFmpegLoaded.Text = "";
            tempUserFileName = Path.Combine(tempPath, tempFileName);

            if (File.Exists(tempUserFileName))
                suggestionFolder = File.ReadAllText(tempUserFileName);

            if (Directory.Exists(suggestionFolder))
            {
                folderBrowserDialog1.SelectedPath = suggestionFolder;
                txtInitialPath.Text = suggestionFolder;
            }
            else
            {
                folderBrowserDialog1.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }

            VideoHelper.FFmpegPath = System.Configuration.ConfigurationManager.AppSettings["FFmpegPath"];
            VideoHelper.FFmpegHandle = new FFmpegHandle();

            VideoHelper.LocalTempUser = $@"{System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)}\temp";
            if (!Directory.Exists(VideoHelper.LocalTempUser))
                Directory.CreateDirectory(VideoHelper.LocalTempUser);           
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void btnLoadSongs_Click(object sender, EventArgs e)
        {
            loadSongs();
        }

        private void loadSongs()
        {
            this.clearAll(true);

            if (!Directory.Exists(txtInitialPath.Text))
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtInitialPath.Text = folderBrowserDialog1.SelectedPath;
                    File.WriteAllText(tempUserFileName, txtInitialPath.Text);
                }
                else
                    return;
            }

            try
            {
                if(videos ==null)
                    videos = new List<VideoEntity>();

                if (chkSubFolders.Checked)
                {
                    selectedFilePaths = Directory.GetFiles(txtInitialPath.Text, "*.*", SearchOption.AllDirectories);                    

                    if(chkLoadSorted.Checked)
                        selectedFilePaths = selectedFilePaths.OrderBy(l => Path.GetFileName(l)).ToArray();

                    foreach (string filePath in selectedFilePaths)
                    {
                        videos.Add(new VideoEntity{ fullPath = filePath });
                        lbSongs.Items.Add(Path.GetFileName(filePath));
                    }
                }
                else
                {

                    OpenFileDialog openFileDialog = new OpenFileDialog();


                    openFileDialog.Title = "Select Files";
                    openFileDialog.Filter = "All Files (*.*)|*.*";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.Multiselect = true; 
                    openFileDialog.InitialDirectory = txtInitialPath.Text;//Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);


                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string otherPath = null;

                        selectedFilePaths = openFileDialog.FileNames;

                        foreach (string filePath in selectedFilePaths)
                        {
                            videos.Add(new VideoEntity { fullPath = filePath });
                            lbSongs.Items.Add(Path.GetFileName(filePath));

                            if (string.IsNullOrEmpty(otherPath))
                            {
                                otherPath = Path.GetDirectoryName(filePath);
                                if (!txtInitialPath.Text.ToUpper().Equals(otherPath.ToUpper()))
                                {
                                    txtInitialPath.Text = otherPath;
                                    File.WriteAllText(tempUserFileName, txtInitialPath.Text);
                                }
                            }
                        }
                    }
                }

                this.lblTotalVideos.Text = videos.Count().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lbSongs.Items.Count > 0)
            {
                lbSongs.Items.Clear();
                videos.Clear();
                this.lblTotalVideos.Text = "";
            }

            if (lbSongsModified.Items.Count > 0)
                lbSongsModified.Items.Clear();
        }

        private void btnRenameFileList_Click(object sender, EventArgs e)
        {
            if (txtPatternRemove.Text.Length == 0 && !chkRemAutNmFile.Checked)
            {
                MessageBox.Show(
                    "Defina o padrão de texto para remoção.",
                    "Alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            lbSongsModified.Items.Clear();

            if (chkRemAutNmFile.Checked)
            {
                for (int i = 0; i < videos.Count; i++) 
                {

                    videos[i].newFileName = Regex.Replace(videos[i].fileName, videos[i].parentFolder, "", RegexOptions.IgnoreCase).Trim();
                    lbSongsModified.Items.Add(videos[i].newFileName);
                    lstLastSongModified.Add(videos[i].newFileName);
                }
            }
            else
            {
                for (int i = 0; i < videos.Count; i++) 
                {
                    videos[i].newFileName = Regex.Replace(videos[i].fileName, txtPatternRemove.Text, "", RegexOptions.IgnoreCase).Trim();
                    lbSongsModified.Items.Add(videos[i].newFileName);
                    lstLastSongModified.Add(videos[i].newFileName);
                }
            }

        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            string oldFileName = null;
            string newFileName = null;

            if (chkSubFolders.Checked)
            {
                string auxPath = null;
                for (int i = 0; i < selectedFilePaths.Count(); i++)
                {
                    auxPath = Path.GetDirectoryName(selectedFilePaths[i]);

                    oldFileName = $@"{auxPath}\{lbSongs.Items[i].ToString()}";
                    newFileName = $@"{auxPath}\{lbSongsModified.Items[i].ToString()}";

                    if (File.Exists(oldFileName))
                    {
                     

                        if (oldFileName.ToUpper() == newFileName.ToUpper())
                            continue;

                        if (File.Exists(newFileName))
                        {
                            newFileName = $@"{auxPath}\{ Path.GetFileNameWithoutExtension(newFileName)}_copy{Path.GetExtension(newFileName)}";
                        }

                        if(oldFileName.ToUpper() != newFileName.ToUpper())
                            File.Move(oldFileName, newFileName);                        
                    }
                }

                auxPath = null;
                if (oldFileName.Trim().Length > 0)
                {
                    for (int i = 0; i < selectedFilePaths.Count(); i++)
                    {
                        auxPath = Path.GetDirectoryName(selectedFilePaths[i]);

                        if (File.Exists($@"{auxPath}\{lbSongsModified.Items[i].ToString()}"))
                        {
                            lbSongs.Items[i] = lbSongsModified.Items[i];
                            videos[i].fullPath = $@"{videos[i]}\{lbSongs.Items[i]}";
                        }
                    }
                    MessageBox.Show("Nome de arquivo renomeado som sucesso!", "Informação",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {

                for (int i = 0; i < lbSongs.Items.Count; i++)
                {
                    oldFileName = $@"{txtInitialPath.Text}\{lbSongs.Items[i].ToString()}";
                    newFileName = $@"{txtInitialPath.Text}\{lbSongsModified.Items[i].ToString()}";

                    if (File.Exists(oldFileName))
                    {
                 

                        if (File.Exists(newFileName))
                        {
                            newFileName = $@"{txtInitialPath.Text}\{ Path.GetFileNameWithoutExtension(newFileName)}_copy{Path.GetExtension(newFileName)}";
                        }

                        File.Move(oldFileName, newFileName);
                    }
                }

                if (oldFileName.Trim().Length > 0)
                {
                    for (int i = 0; i < lbSongs.Items.Count; i++)
                    {
                        if (File.Exists($@"{txtInitialPath.Text}\{lbSongsModified.Items[i].ToString()}"))
                        {
                            lbSongs.Items[i] = lbSongsModified.Items[i];
                            videos[i].fullPath = $@"{videos[i]}\{lbSongs.Items[i]}";
                        }
                    }
                    MessageBox.Show("Nome de arquivo renomeado som sucesso!", "Informação",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }



        }

        private void btnSelDir_Click(object sender, EventArgs e)
        {
            this.clearAll();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtInitialPath.Text = folderBrowserDialog1.SelectedPath;
                File.WriteAllText(tempUserFileName, txtInitialPath.Text);
            }
        }

        private void btnClearPath_Click(object sender, EventArgs e)
        {
            txtInitialPath.Text = "";
        }

        private void clearAll(bool noPath = false)
        {
            txtPatternRemove.Clear();
            lbSongs.Items.Clear();
            lbSongsModified.Items.Clear();
            txtReapplyPatern.Clear();
            txtSubsPattern.Clear();
            chkSubPattern.Checked = false;
            lstLastSongModified.Clear();
            this.lblTotalVideos.Text = "";
            lblCountFFmpegLoaded.Text = "";

            if (videos != null)
                videos.Clear();
            
            if (!noPath)
                txtInitialPath.Clear();

            
            if (selectedFilePaths != null)
            {
                Array.Clear(selectedFilePaths, 0, selectedFilePaths.Length);
                selectedFilePaths = null;
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnClearReapplyPatern_Click(object sender, EventArgs e)
        {
            this.txtReapplyPatern.Clear();
        }

        private void btnReapplyPattern_Click(object sender, EventArgs e)
        {
            string subsText = "";
            string auxFileName = null;
            string tempFileName = null;
            string tempExtensionFile = null;

            if (txtReapplyPatern.Text.Length == 0)
            {
                MessageBox.Show(
                   "Defina o padrão de texto para reaplicar.",
                   "Alerta",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
                );
                return;
            }

            if (lbSongsModified.Items.Count == 0)
            {
                MessageBox.Show(
                   "Preencha a lista de modificação",
                   "Alerta",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
                );
                return;
            }

            if (chkSubPattern.Checked)
            {
                if (txtSubsPattern.Text.Trim().Length > 0 || txtSubsPattern.Text == " ")
                    subsText = txtSubsPattern.Text;
            }

            //lstLastSongModified.Clear();
            for (int i = 0; i < lbSongsModified.Items.Count; i++)
            {
                auxFileName = lbSongsModified.Items[i].ToString();
                lstLastSongModified[i]=auxFileName;

                tempFileName = Path.GetFileNameWithoutExtension(auxFileName);
                tempExtensionFile = Path.GetExtension(auxFileName);

                videos[i].newFileName = Regex.Replace(tempFileName, txtReapplyPatern.Text, subsText, RegexOptions.IgnoreCase).Trim() + tempExtensionFile;
                lbSongsModified.Items[i] = videos[i].newFileName;
            }
        }

        private void bntClearLstBoxMod_Click(object sender, EventArgs e)
        {
            lbSongsModified.Items.Clear();
        }

        private void chkSubPattern_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                txtSubsPattern.ReadOnly = false;
            }
            else
            {
                txtSubsPattern.ReadOnly = true;
            }
        }

        private void btnBackBefore_Click(object sender, EventArgs e)
        {
            if (lstLastSongModified.Count > 0 && lbSongsModified.Items.Count > 0) {
                lbSongsModified.Items.Clear();
                foreach (string oldFileName in lstLastSongModified)
                {
                    lbSongsModified.Items.Add(oldFileName);
                }
            }
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            this.Close();
            if (this.form2 != null)
                this.form2.Close();
        }

        private void bntEditList_Click(object sender, EventArgs e)
        {
            if (lbSongsModified.Items.Count > 0)
            {
                if (this.form2 == null)
                {
                    this.form2 = new Form2();
                    this.form2.setCallBackSongListEdited(updateModfManualSongList);
                }

                this.form2.loadListSongs(lbSongsModified.Items.Cast<string>());
                this.form2.Show();
            }
        }

        private void updateModfManualSongList(string textListSong)
        {
            if (textListSong.Length > 0)
                lbSongsModified.Items.Clear();
            
            int i = 0;
            foreach (string song in textListSong.Split(new string[] { "\n" }, StringSplitOptions.None).ToList())
            {
                lbSongsModified.Items.Add(song);
                videos[i].newFileName = song;
                i++;
            }
        }

        private void bntShowDetail_Click(object sender, EventArgs e)
        {
            if (this.form3 == null)
                this.form3 = new Form3();
                       

            this.form3.loadListSongsDet(videos.Select(v=> v.fileName + " | " + v.audio.volume.meanVolume + " _-_ " + v.audio.volume.maxVolume).Cast<string>()); 
            this.form3.Show();

        }

        private async void bntLoadFFmpeg_Click(object sender, EventArgs e)
        {

            await Task.Run(() => {
                VideoEntity tempVideo = null;
                for(int i=0; i<videos.Count;i++)
                {
                    tempVideo = videos[i];
                    VideoHelper.FFmpegHandle.getVolume(ref tempVideo);
                    videos[i].audio.volume = tempVideo.audio.volume;

                    lblCountFFmpegLoaded.Invoke((MethodInvoker)(() =>
                    {
                        lblCountFFmpegLoaded.Text = (i + 1).ToString();
                    }));
                }                
            });
           
            MessageBox.Show("Informações de midia carregadas totalmente!", "Informação",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemNnFolderFile_Click(object sender, EventArgs e)
        {
            if (lbSongsModified.Items.Count > 0 && videos.Count>0)
            {
                string auxFileName = null;
                for (int i = 0; i < videos.Count; i++) 
                {
                    auxFileName = lbSongsModified.Items[i].ToString();
                    lstLastSongModified[i] = auxFileName;

                    lbSongsModified.Items[i] = videos[i].parentFolder + " - " +  lbSongsModified.Items[i];
                    videos[i].newFileName = lbSongsModified.Items[i].ToString();
                }
            }
            
        }

        private float meanVolumeDesired = -16f;
        private float maxVolumeDesired = -1.5f;

        private float meanVolutOffDown= -21f;
        private float meanVolutOffUp = -13f;
        private float maxVolCutOffDown = -3f;

        private void btnAudioNorm_Click(object sender, EventArgs e)
        {
            float meanVolAux;
            float maxVolAux;
            bool normalizedVol = false;

            foreach (VideoEntity video in this.videos) 
            {
                float.TryParse(video.audio.volume.meanVolume, out meanVolAux);
                float.TryParse(video.audio.volume.maxVolume, out maxVolAux);
                normalizedVol = false;

                if (meanVolAux > meanVolutOffUp && !normalizedVol) 
                {
                    VideoHelper.FFmpegHandle.normalizeVolume(video);
                    normalizedVol = true;
                }

                if (meanVolAux < meanVolutOffDown && !normalizedVol)
                {
                    VideoHelper.FFmpegHandle.normalizeVolume(video);
                    normalizedVol = true;
                }

                if (maxVolAux < maxVolCutOffDown && !normalizedVol)
                {
                    VideoHelper.FFmpegHandle.normalizeVolume(video);
                    normalizedVol = true;
                }
            }

        }
    }
}
