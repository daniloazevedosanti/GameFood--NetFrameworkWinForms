﻿using System.Drawing;

namespace GameFood
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Generate by Windows Form Designer

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // session button / button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // session textLabel
            // 
            this.textLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.Location = new System.Drawing.Point(58, 21);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(175, 16);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "Pense num prato que goste";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // session Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(298, 92);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.button1);
            this.Icon = new Icon("ico-food.ico"); 
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameFood";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label textLabel;
    }
}

