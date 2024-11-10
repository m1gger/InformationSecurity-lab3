using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace InformationSecurity_lab3
{
    public partial class Form1 : Form
    {
        private const char spaceSign = ' ';

        private int _keyLen;

        private SuperincreasingSequence _privateKey;
        private SuperincreasingSequence _publicKey;
        private BigInteger _m;
        private int _n;

        public Form1()
        {
            InitializeComponent();
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = File.ReadAllText(filename);

            var fixText = fileText.ToArray();

            inputTextBox.Text = new string(fixText);
        }

        private void generateKeyBtn_Click(object sender, EventArgs e)
        {
            _privateKey = new SuperincreasingSequence(_keyLen).RandomFill();
            (_m, _n) = MerkleHellmanHelper.GetMN(_privateKey.Summ);
            _publicKey = MerkleHellmanHelper.GetInverseSequence(_privateKey, _m, _n);
            ShowKey();
        }

        private void ShowKey()
        {
            privateKeyTextBox.Text = _privateKey.ToString();
            publicKeyTextBox.Text = _publicKey.ToString();
            mTextBox.Text = _m.ToString();
            nTextBox.Text = _n.ToString();
        }

        private void keySizeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _keyLen = Convert.ToInt32(keySizeBox.Text);
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            string encryptedText = MerkleHellmanHelper.Encrypt(inputTextBox.Text, _publicKey.ToArray());

            outputTextBox.Text = encryptedText;
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            string decryptText = MerkleHellmanHelper.Decrypt(inputTextBox.Text, _privateKey.ToArray(), _m, _n);

            outputTextBox.Text = decryptText;
        }

        private void replaceTextBtn_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = outputTextBox.Text;
            outputTextBox.Text = string.Empty;
        }
    }
}
