using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameSongsFiles
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void loadListSongsDet(IEnumerable<string> listSongs)//(string song) 
        {

            foreach (string ls in listSongs)
            {
                rtbSongListDet.Text = rtbSongListDet.Text.Length == 0 ? ls : rtbSongListDet.Text + "\n" + ls;
            }
        }
    }
}
