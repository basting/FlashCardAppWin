using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class frmFlashCards : Form
    {
        private ArrayList flashCardList = new ArrayList();
        private int currentPosition = 0;
       
        public frmFlashCards()
        {
            InitializeComponent();
            initFlashCards();
        }

        private void initFlashCards()
        {
            flashCardList.Add("StringBuffer is thread-safe <br> "+
                               "StringBuilder is not thread-safe");

            flashCardList.Add("HashTable is thread-safe <br> " +
                               "HashMap is not thread-safe");

            flashCardList.Add("Two ways to create threads - Runnable & Thread");

            //btnLeft.Click += new EventHandler(this.btnLeft_Click);
            //btnRight.Click += new EventHandler(this.btnRight_Click);
            txtFlashCard.Text = flashCardList[currentPosition].ToString();
            this.ActiveControl = txtFlashCard;

            //enableDisableKeys();

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            currentPosition = getNextIndexForRightKey(currentPosition);
            txtFlashCard.Text = flashCardList[currentPosition].ToString();
            //enableDisableKeys();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            currentPosition = getNextIndexForLeftKey(currentPosition);
            txtFlashCard.Text = flashCardList[currentPosition].ToString();
            //enableDisableKeys();    
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                btnLeft.PerformClick();
            }
            else if (keyData == Keys.Right)
            {
                btnRight.PerformClick();
            }
            return true;
            //return base.ProcessCmdKey(ref msg, keyData);
        }

        private int getNextIndexForLeftKey(int currPos)
        {
            if (currPos <= 0)
            {
                return flashCardList.Count - 1;
            }
            return currPos - 1;
        }

        private int getNextIndexForRightKey(int currPos)
        {
            if (currPos >= flashCardList.Count - 1)
            {
                return 0;
            }
            return currPos + 1;
        }

        /*private void enableDisableKeys()
        {
            if (currentPosition == 0)
            {
                btnLeft.Enabled = false;
            }
            else
            {
                btnLeft.Enabled = true;
            }

            if (currentPosition == flashCardList.Count - 1)
            {
                btnRight.Enabled = false;
            }
            else
            {
                btnRight.Enabled = true;
            }
        }*/
    }
}
