using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseNumberConverter
{
    public partial class MainWindows : Form
    {
        private int iInputBase;
        private int iOutputBase;
        public MainWindows()
        {
            InitializeComponent();
            DefaultUISettings();
        }

        public void DefaultUISettings()
        {
            PopulateLists();
            this.ConvertButton.Enabled = false;
            iInputBase = -1;
            iOutputBase = -1;
        }

        public void PopulateLists()
        {
            PopulateInputList();
            PopulateOutputList();
        }

        public void PopulateInputList()
        {
            foreach (int iThisNumber in Program.iArrayCount){
                this.inputNumberBaseLB.Items.Add(iThisNumber.ToString());
            }
            this.inputNumberBaseLB.Update();
        }

        public void PopulateOutputList()
        {
            foreach (int iThisNumber in Program.iArrayCount)
            {
                this.outputNumberLB.Items.Add(iThisNumber.ToString());
            }
            this.inputNumberBaseLB.Update();
        }

        private void outputNumberBaseLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sThisValue = inputValueTB.Text;
            // check to see all characters are valid
            if (Logic.AllValidCharacters(sThisValue, Program.cArrayChars.ToList())){

            }
            else
            {
                inputValueTB.Text = "";
                MessageBox.Show("Invalid character(s) entered.  Please try again");
            }
        }



        private void UnlockConvertButton()
        {
            if (iInputBase > 0)
            {
                if (iOutputBase > 0)
                {
                    ConvertButton.Enabled = true;
                }
            }
        }

        private void inputNumberBaseLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inputNumberBaseLB.SelectedIndex >= 0)
            {
                iInputBase = inputNumberBaseLB.SelectedIndex + 1;
            }
            UnlockConvertButton();
        }

        private void outputNumberLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (outputNumberLB.SelectedIndex >= 0)
            {
                iOutputBase = outputNumberLB.SelectedIndex + 1;
            }
            UnlockConvertButton();
        }
    }
}
