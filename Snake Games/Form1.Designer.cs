
namespace Snake_Games
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.xal = new System.Windows.Forms.Label();
            this.MaxXal = new System.Windows.Forms.Label();
            this.SnakeMove = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(876, 117);
            this.label1.TabIndex = 0;
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.SlateGray;
            this.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl.Font = new System.Drawing.Font("Bodoni MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnl.Location = new System.Drawing.Point(6, 71);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(876, 571);
            this.pnl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Toplam Xal :";
            // 
            // xal
            // 
            this.xal.AutoSize = true;
            this.xal.BackColor = System.Drawing.Color.White;
            this.xal.Location = new System.Drawing.Point(197, 23);
            this.xal.Name = "xal";
            this.xal.Size = new System.Drawing.Size(25, 26);
            this.xal.TabIndex = 3;
            this.xal.Text = "0";
            // 
            // MaxXal
            // 
            this.MaxXal.AutoSize = true;
            this.MaxXal.BackColor = System.Drawing.Color.White;
            this.MaxXal.Location = new System.Drawing.Point(832, 23);
            this.MaxXal.Name = "MaxXal";
            this.MaxXal.Size = new System.Drawing.Size(25, 26);
            this.MaxXal.TabIndex = 5;
            this.MaxXal.Text = "0";
            // 
            // SnakeMove
            // 
            this.SnakeMove.Interval = 150;
            this.SnakeMove.Tick += new System.EventHandler(this.SnakeMove_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(651, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "ən yaxşı nəticə :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(888, 645);
            this.Controls.Add(this.MaxXal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.xal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Games";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label xal;
        private System.Windows.Forms.Label MaxXal;
        private System.Windows.Forms.Timer SnakeMove;
        private System.Windows.Forms.Label label4;
    }
}

