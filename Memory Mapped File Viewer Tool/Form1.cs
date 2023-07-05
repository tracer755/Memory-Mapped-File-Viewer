using System.IO.MemoryMappedFiles;

namespace Memory_Mapped_File_Viewer_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            LoopReadTimer.Start();
        }

        private void CloseApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (MemoryMappedFile mmf = MemoryMappedFile.OpenExisting(FileName.Text))
                {
                    using (MemoryMappedViewStream stream = mmf.CreateViewStream())
                    {
                        BinaryReader reader = new BinaryReader(stream);
                        string dat = reader.ReadString();
                        if (!string.IsNullOrEmpty(dat))
                        {
                            if (dat != OutputBox.Text)
                            {
                                OutputBox.Text = dat;
                            }
                            CharCount.Text = $"{dat.Length} characters";
                        }
                        else
                        {
                            OutputBox.Text = "Found file but the file was blank";
                            CharCount.Text = "0 characters";
                        }
                    }
                }
            }
            catch
            {
                OutputBox.Text = "Could not connect or find file";
                CharCount.Text = "";
            }
        }

        private void LoopReadTimerTick(object sender, EventArgs e)
        {
            if (LoopReadCheckBox.Checked)
            {
                button2.PerformClick();
            }
        }
    }
}