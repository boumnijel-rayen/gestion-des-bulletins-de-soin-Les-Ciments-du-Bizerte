
namespace projetDotNet
{
    partial class Rechercher_bulletin
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
            this.label1 = new System.Windows.Forms.Label();
            this.numb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.matE = new System.Windows.Forms.TextBox();
            this.dataGridViewBulletin = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateD = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBulletin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Numéro de Bulletin :";
            // 
            // numb
            // 
            this.numb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numb.Location = new System.Drawing.Point(26, 83);
            this.numb.Name = "numb";
            this.numb.Size = new System.Drawing.Size(147, 29);
            this.numb.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Matricule de l\'employée et la date de depot de bulletin :";
            // 
            // matE
            // 
            this.matE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matE.Location = new System.Drawing.Point(269, 81);
            this.matE.Name = "matE";
            this.matE.Size = new System.Drawing.Size(147, 29);
            this.matE.TabIndex = 9;
            // 
            // dataGridViewBulletin
            // 
            this.dataGridViewBulletin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBulletin.Location = new System.Drawing.Point(121, 214);
            this.dataGridViewBulletin.Name = "dataGridViewBulletin";
            this.dataGridViewBulletin.Size = new System.Drawing.Size(538, 150);
            this.dataGridViewBulletin.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(110)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(581, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 37);
            this.button2.TabIndex = 13;
            this.button2.Text = "Rechercher";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(43, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 27);
            this.button1.TabIndex = 12;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateD
            // 
            this.dateD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateD.Location = new System.Drawing.Point(452, 83);
            this.dateD.Name = "dateD";
            this.dateD.Size = new System.Drawing.Size(255, 26);
            this.dateD.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(110)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(78, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 37);
            this.button3.TabIndex = 15;
            this.button3.Text = "Rechercher";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Rechercher_bulletin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dateD);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewBulletin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numb);
            this.Name = "Rechercher_bulletin";
            this.Text = "Rechercher_bulletin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBulletin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox matE;
        private System.Windows.Forms.DataGridView dataGridViewBulletin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateD;
        private System.Windows.Forms.Button button3;
    }
}