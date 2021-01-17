// Chad Weirick
// UAT MS507
// This is the main UI module.
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
            // remove last item as it is not valid
            this.inputNumberBaseLB.Items.RemoveAt(this.inputNumberBaseLB.Items.Count - 1);
            this.inputNumberBaseLB.Update();
        }

        public void PopulateOutputList()
        {
            foreach (int iThisNumber in Program.iArrayCount)
            {
                this.outputNumberLB.Items.Add(iThisNumber.ToString());
            }
            // remove last item as it is not valid
            this.outputNumberLB.Items.RemoveAt(this.outputNumberLB.Items.Count - 1);
            this.outputNumberLB.Update();
        }

        private void outputNumberBaseLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sThisValue = inputValueTB.Text;
            // check to see all characters are valid
            if (Logic.AllValidCharacters(sThisValue, Program.cArrayChars.ToList(), (iInputBase + 1))){
                inputValueTB.Text = "";
                MessageBox.Show(Logic.ConvertBase(sThisValue, (iInputBase + 1), (iOutputBase + 1)));
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
