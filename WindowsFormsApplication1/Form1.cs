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
            flashCardList.Add("StringBuffer is thread-safe\r\n"+
                               "StringBuilder is not thread-safe");

            flashCardList.Add("HashTable is thread-safe\r\n" +
                               "HashMap is not thread-safe");

            flashCardList.Add("Two ways to create threads\r\n"+
                "* Implement Runnable interface\r\n"+
                "* Extend Thread class");

            flashCardList.Add("Best datastructure to implement Stack\r\n" +
                "** Linked List **");

            //btnLeft.Click += new EventHandler(this.btnLeft_Click);
            //btnRight.Click += new EventHandler(this.btnRight_Click);
            txtFlashCard.Text = flashCardList[currentPosition].ToString();
            this.ActiveControl = txtFlashCard;

            updateCount();

            //enableDisableKeys();

        }

        private void updateCount()
        {
            txtTotalCards.Text = flashCardList.Count.ToString();
            txtCurrentCard.Text = (currentPosition + 1).ToString();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            currentPosition = getNextIndexForRightKey(currentPosition);
            txtFlashCard.Text = flashCardList[currentPosition].ToString();
            updateCount();
            //enableDisableKeys();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            currentPosition = getNextIndexForLeftKey(currentPosition);
            txtFlashCard.Text = flashCardList[currentPosition].ToString();
            updateCount();
            //enableDisableKeys();    
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //MessageBox.Show(keyData.ToString());
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

        private void toolStripExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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
