using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameSongsFile
{
    public partial class Form2 : Form
    {
        public delegate void DelCallbackSongList(string textListSong);

        private DelCallbackSongList songListEdited;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void loadListSongs(IEnumerable<string> listSongs)//(string song) 
        {

            foreach (string ls in listSongs) 
            {
                rtbSongList.Text = rtbSongList.Text.Length == 0 ? ls : rtbSongList.Text + "\n" + ls;
            }            
        }

        public void setCallBackSongListEdited(DelCallbackSongList delegateCallBack) 
        {
            this.songListEdited = delegateCallBack;
        }

        private void btnApplyList_Click(object sender, EventArgs e)
        {
            songListEdited(this.rtbSongList.Text);
            this.Hide();
        }
    }
}
