using Lzf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Code_Decode_Save
{
    public partial class Form1 : Form
    {
        /*  Credits to
         *  https://www.kongregate.com/forums/4721-general/topics/423987-how-to-decrypt-the-export-string
         *  and 
         *  http://forum.unity3d.com/threads/lzf-compression-and-decompression-for-unity.152579/
        */
        public Form1()
        {
            InitializeComponent();
        }
        String[] usefulData;//0 = JSON content, 1 = MD5 Hash of JSON content

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileContent.Text = File.ReadAllText(openFileDialog1.FileName).Replace("\0", "");
                txtFileName.Text = openFileDialog1.SafeFileName;
                btnDecode.PerformClick();
            }
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //MD5 creation is missing because the "Something else" is missing from the Decode side.
                int amountConverted = 0;
                byte[] input = Encoding.UTF8.GetBytes(txtDecodedContent.Text);
                byte[] output = new byte[input.Length];
                while (amountConverted == 0)
                {
                    output = new byte[output.Length * 2];
                    amountConverted = LZF.Compress(input, input.Length, output, output.Length);
                }
                usefulData[0] = "." + Convert.ToBase64String(output);
                File.WriteAllText(saveFileDialog1.FileName, usefulData[0] + "|" + usefulData[1]);
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            if (txtFileContent.TextLength > 0)
            {
                usefulData = txtFileContent.Text.Substring(1).Split('|');
                if (usefulData.Length != 2)//Not gonna happen, but in case it does...
                {
                    MessageBox.Show("Error while loading content");
                    return;
                }
                byte[] bytearraydecoded = Convert.FromBase64String(usefulData[0]);
                string base64decoded = Encoding.UTF8.GetString(bytearraydecoded);
                byte[] output = new byte[bytearraydecoded.Length];
                int amountConverted = 0;
                while (amountConverted == 0)
                {
                    output = new byte[output.Length * 2];
                    amountConverted = LZF.Decompress(bytearraydecoded, bytearraydecoded.Length, output, output.Length);
                }
                //Check MD5. But it's missing some information on the original thread...
                txtDecodedContent.Text = Encoding.ASCII.GetString(output);
            }
            else
            {
                MessageBox.Show("Please input some text");
            }
        }
    }
}
