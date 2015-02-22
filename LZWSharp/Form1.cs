using LZWLib;
using System;
using System.IO;
using System.Windows.Forms;

namespace LZWSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPack_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            if (opf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtPath.Text = opf.FileName;

                var text = File.ReadAllText(opf.FileName, System.Text.ASCIIEncoding.Default);
                LZWEncoder encoder = new LZWEncoder();

                var buffer = encoder.EncodeToByteList(text);
                File.WriteAllBytes(opf.FileName + ".lzw", buffer);

                MessageBox.Show("Encoding complete.");
            }
        }

        private void btnUnpack_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "*.lzw|*.lzw";

            if (opf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtPath.Text = opf.FileName;

                var buffer = File.ReadAllBytes(opf.FileName);
                LZWDecoder decoder = new LZWDecoder();

                var text = decoder.DecodeFromCodes(buffer);
                File.WriteAllText(opf.FileName.Replace(".lzw", ""), text, System.Text.Encoding.Default);

                MessageBox.Show("Decoding complete.");
            }

        }
    }
}
