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
    public partial class Form1 : Form
    {
        private ArrayList flashCardList = new ArrayList();
        private int currentPosition = 0;
       
        public Form1()
        {
            InitializeComponent();
            initFlashCards();
        }

        private void initFlashCards()
        {
            flashCardList.Add("StringBuffer is thread-safe \n "+
                               "StringBuilder is not thread-safe");

            flashCardList.Add("HashTable is thread-safe \n " +
                               "HashMap is not thread-safe");

            flashCardList.Add("Two ways to create threads - Runnable & Thread");

            btnLeft.Click += new EventHandler(this.btnLeft_Click);
            btnRight.Click += new EventHandler(this.btnRight_Click);
            txtFlashCard.Text = flashCardList[currentPosition].ToString();
            
            /*
            if(currentPosition == 0)
            {
                btnLeft.Enabled = false;
            }
            else
            {
                btnLeft.Enabled = true;
            }

            if (currentPosition == flashCardList.Count-1)
            {
                btnRight.Enabled = false;
            }
            else
            {
                btnRight.Enabled = true;
            }*/

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (currentPosition >= flashCardList.Count - 1)
            {
                return;
            }
            txtFlashCard.Text = flashCardList[++currentPosition].ToString();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (currentPosition <= 0)
            {
                return;
            }
            txtFlashCard.Text = flashCardList[--currentPosition].ToString();
        }
        
    }
}
