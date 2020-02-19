namespace StartWithInheritance
{
    partial class frmVormen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbVierkant = new System.Windows.Forms.RadioButton();
            this.rdbCirkel = new System.Windows.Forms.RadioButton();
            this.lstVormen = new System.Windows.Forms.ListBox();
            this.picBord = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGrootte = new System.Windows.Forms.TextBox();
            this.btnMaken = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBord)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbVierkant);
            this.groupBox1.Controls.Add(this.rdbCirkel);
            this.groupBox1.Location = new System.Drawing.Point(19, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 148);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kies je vorm";
            // 
            // rdbVierkant
            // 
            this.rdbVierkant.AutoSize = true;
            this.rdbVierkant.Location = new System.Drawing.Point(58, 94);
            this.rdbVierkant.Name = "rdbVierkant";
            this.rdbVierkant.Size = new System.Drawing.Size(64, 17);
            this.rdbVierkant.TabIndex = 1;
            this.rdbVierkant.TabStop = true;
            this.rdbVierkant.Text = "Vierkant";
            this.rdbVierkant.UseVisualStyleBackColor = true;
            // 
            // rdbCirkel
            // 
            this.rdbCirkel.AutoSize = true;
            this.rdbCirkel.Location = new System.Drawing.Point(58, 41);
            this.rdbCirkel.Name = "rdbCirkel";
            this.rdbCirkel.Size = new System.Drawing.Size(51, 17);
            this.rdbCirkel.TabIndex = 0;
            this.rdbCirkel.TabStop = true;
            this.rdbCirkel.Text = "Cirkel";
            this.rdbCirkel.UseVisualStyleBackColor = true;
            // 
            // lstVormen
            // 
            this.lstVormen.FormattingEnabled = true;
            this.lstVormen.Location = new System.Drawing.Point(670, 12);
            this.lstVormen.Name = "lstVormen";
            this.lstVormen.Size = new System.Drawing.Size(165, 342);
            this.lstVormen.TabIndex = 10;
            // 
            // picBord
            // 
            this.picBord.Location = new System.Drawing.Point(216, 12);
            this.picBord.Name = "picBord";
            this.picBord.Size = new System.Drawing.Size(413, 343);
            this.picBord.TabIndex = 9;
            this.picBord.TabStop = false;
            this.picBord.Paint += new System.Windows.Forms.PaintEventHandler(this.picBord_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Grootte:";
            // 
            // txtGrootte
            // 
            this.txtGrootte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrootte.Location = new System.Drawing.Point(105, 12);
            this.txtGrootte.Name = "txtGrootte";
            this.txtGrootte.Size = new System.Drawing.Size(82, 31);
            this.txtGrootte.TabIndex = 7;
            this.txtGrootte.TextChanged += new System.EventHandler(this.txtGrootte_TextChanged);
            // 
            // btnMaken
            // 
            this.btnMaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaken.Location = new System.Drawing.Point(19, 81);
            this.btnMaken.Name = "btnMaken";
            this.btnMaken.Size = new System.Drawing.Size(168, 49);
            this.btnMaken.TabIndex = 6;
            this.btnMaken.Text = "Maken";
            this.btnMaken.UseVisualStyleBackColor = true;
            this.btnMaken.Click += new System.EventHandler(this.btnMaken_Click);
            // 
            // frmVormen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstVormen);
            this.Controls.Add(this.picBord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGrootte);
            this.Controls.Add(this.btnMaken);
            this.Name = "frmVormen";
            this.Text = "Vormen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbVierkant;
        private System.Windows.Forms.RadioButton rdbCirkel;
        private System.Windows.Forms.ListBox lstVormen;
        private System.Windows.Forms.PictureBox picBord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrootte;
        private System.Windows.Forms.Button btnMaken;
    }
}

