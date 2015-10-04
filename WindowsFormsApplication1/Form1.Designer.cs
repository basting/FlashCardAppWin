﻿namespace WindowsFormsApplication1
{
    partial class frmFlashCards
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFlashCards));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.txtFlashCard = new System.Windows.Forms.TextBox();
            this.txtCurrentCard = new System.Windows.Forms.TextBox();
            this.txtTotalCards = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRight);
            this.panel1.Controls.Add(this.btnLeft);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 79);
            this.panel1.TabIndex = 0;
            // 
            // btnRight
            // 
            this.btnRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRight.BackgroundImage")));
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRight.Location = new System.Drawing.Point(161, 3);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(152, 73);
            this.btnRight.TabIndex = 1;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLeft.BackgroundImage")));
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeft.Location = new System.Drawing.Point(3, 3);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(152, 73);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // txtFlashCard
            // 
            this.txtFlashCard.Location = new System.Drawing.Point(5, 85);
            this.txtFlashCard.Multiline = true;
            this.txtFlashCard.Name = "txtFlashCard";
            this.txtFlashCard.ReadOnly = true;
            this.txtFlashCard.Size = new System.Drawing.Size(310, 206);
            this.txtFlashCard.TabIndex = 1;
            this.txtFlashCard.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // txtCurrentCard
            // 
            this.txtCurrentCard.Location = new System.Drawing.Point(153, 297);
            this.txtCurrentCard.Name = "txtCurrentCard";
            this.txtCurrentCard.ReadOnly = true;
            this.txtCurrentCard.Size = new System.Drawing.Size(67, 20);
            this.txtCurrentCard.TabIndex = 2;
            // 
            // txtTotalCards
            // 
            this.txtTotalCards.Location = new System.Drawing.Point(248, 297);
            this.txtTotalCards.Name = "txtTotalCards";
            this.txtTotalCards.ReadOnly = true;
            this.txtTotalCards.Size = new System.Drawing.Size(67, 20);
            this.txtTotalCards.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "of";
            // 
            // frmFlashCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 318);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalCards);
            this.Controls.Add(this.txtCurrentCard);
            this.Controls.Add(this.txtFlashCard);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFlashCards";
            this.Text = "Flash Cards";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.TextBox txtFlashCard;
        private System.Windows.Forms.TextBox txtCurrentCard;
        private System.Windows.Forms.TextBox txtTotalCards;
        private System.Windows.Forms.Label label1;
    }
}

