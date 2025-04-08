using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenameSongsFiles
{
    public class VideoEntity
    {
       

        private string _fullPath;
        private string _newFileName;
        public int index { get; set; }
        public int id { get; set; }
        public string fullPath { get => _fullPath; set => setFullName(value); }
        public string path { get; set; }
        public string fileName { get; set; }
        public string name { get; set; }
        public string extension { get; set; }
        public string parentFolder { get; set; }
        public string newFullPath { get; set; }
        public string newName { get; set; }
        public string newFileName { get => _newFileName; set => setNewFileName(value); }
        public string newExtension { get; set; }
        public float fps { get; set; }
        public string aspectRatio { get; set; }
        public float resolution { get; set; }
        public string scanType { get; set; }
        public string codec { get; set; }
        public string profile { get; set; }
        public float bitRate { get; set; }
        public VAudioEntity audio { get; set; }

        public void setFullName(string value) 
        {
            this._fullPath = value;
            this.fileName = Path.GetFileName(this._fullPath);
            this.name = Path.GetFileNameWithoutExtension(this.fileName);
            this.extension = Path.GetExtension(this.fileName);
            this.parentFolder = Directory.GetParent(this._fullPath).Name;
            this.path = Path.GetDirectoryName(this._fullPath);
        }

        public void setNewFileName(string value)
        {
            this._newFileName = value;
            this.newFullPath = $@"{this.path}\{this._newFileName}";
            this.newName = Path.GetFileNameWithoutExtension(this._newFileName);
            this.newExtension = Path.GetExtension(this._newFileName);
        }

        public VideoEntity() 
        {
            this.audio = new VAudioEntity();
        }
    }

    public class VAudioEntity 
    {
        public float sampleRate { get; set; }
        public string channels { get; set; }
        public float bitRateU { get; set; }
        public float bitRateC { get; set; }
        public string containerFormat { get; set; }
        public string codec { get; set; }
        public int BitDepth { get; set; }
        public string bitRateType { get; set; }
        public VolumeVAudioEntity volume { get; set; }

        public VAudioEntity() 
        {
            this.volume = new VolumeVAudioEntity();
        }
    }

    public class VolumeVAudioEntity 
    {
        public double volume { get; set; }
        public string meanVolume { get; set; }
        public string maxVolume { get; set; }
    }
}
