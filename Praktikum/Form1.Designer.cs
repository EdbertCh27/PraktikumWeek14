
namespace Praktikum
{
    partial class Form1
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
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.dataGridView5Pertandingan = new System.Windows.Forms.DataGridView();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.labelManager = new System.Windows.Forms.Label();
            this.labelStadium = new System.Windows.Forms.Label();
            this.labelTopScore = new System.Windows.Forms.Label();
            this.labelWorstDiscipline = new System.Windows.Forms.Label();
            this.labelIsiNamaTim = new System.Windows.Forms.Label();
            this.labelIsiNamaManager = new System.Windows.Forms.Label();
            this.labelIsiNamaStadium = new System.Windows.Forms.Label();
            this.labelIsiNamaTopSkor = new System.Windows.Forms.Label();
            this.labelIsiNamaWorstDiscipline = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5Pertandingan)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(158, 12);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(92, 51);
            this.buttonFirst.TabIndex = 0;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(263, 12);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(92, 51);
            this.buttonPrev.TabIndex = 1;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(473, 12);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(92, 51);
            this.buttonLast.TabIndex = 3;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(368, 12);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(92, 51);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // dataGridView5Pertandingan
            // 
            this.dataGridView5Pertandingan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5Pertandingan.Location = new System.Drawing.Point(64, 254);
            this.dataGridView5Pertandingan.Name = "dataGridView5Pertandingan";
            this.dataGridView5Pertandingan.RowHeadersWidth = 51;
            this.dataGridView5Pertandingan.RowTemplate.Height = 24;
            this.dataGridView5Pertandingan.Size = new System.Drawing.Size(677, 249);
            this.dataGridView5Pertandingan.TabIndex = 4;
            this.dataGridView5Pertandingan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5Pertandingan_CellContentClick);
            // 
            // labelTeamName
            // 
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Location = new System.Drawing.Point(137, 85);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(93, 17);
            this.labelTeamName.TabIndex = 5;
            this.labelTeamName.Text = "Team Name :";
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.Location = new System.Drawing.Point(158, 117);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(72, 17);
            this.labelManager.TabIndex = 6;
            this.labelManager.Text = "Manager :";
            // 
            // labelStadium
            // 
            this.labelStadium.AutoSize = true;
            this.labelStadium.Location = new System.Drawing.Point(163, 149);
            this.labelStadium.Name = "labelStadium";
            this.labelStadium.Size = new System.Drawing.Size(67, 17);
            this.labelStadium.TabIndex = 7;
            this.labelStadium.Text = "Stadium :";
            // 
            // labelTopScore
            // 
            this.labelTopScore.AutoSize = true;
            this.labelTopScore.Location = new System.Drawing.Point(143, 183);
            this.labelTopScore.Name = "labelTopScore";
            this.labelTopScore.Size = new System.Drawing.Size(87, 17);
            this.labelTopScore.TabIndex = 8;
            this.labelTopScore.Text = "Top Scorer :";
            this.labelTopScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWorstDiscipline
            // 
            this.labelWorstDiscipline.AutoSize = true;
            this.labelWorstDiscipline.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelWorstDiscipline.Location = new System.Drawing.Point(113, 210);
            this.labelWorstDiscipline.Name = "labelWorstDiscipline";
            this.labelWorstDiscipline.Size = new System.Drawing.Size(117, 17);
            this.labelWorstDiscipline.TabIndex = 9;
            this.labelWorstDiscipline.Text = "Worst Discipline :";
            this.labelWorstDiscipline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelIsiNamaTim
            // 
            this.labelIsiNamaTim.AutoSize = true;
            this.labelIsiNamaTim.Location = new System.Drawing.Point(263, 85);
            this.labelIsiNamaTim.Name = "labelIsiNamaTim";
            this.labelIsiNamaTim.Size = new System.Drawing.Size(40, 17);
            this.labelIsiNamaTim.TabIndex = 10;
            this.labelIsiNamaTim.Text = "[......]";
            // 
            // labelIsiNamaManager
            // 
            this.labelIsiNamaManager.AutoSize = true;
            this.labelIsiNamaManager.Location = new System.Drawing.Point(263, 117);
            this.labelIsiNamaManager.Name = "labelIsiNamaManager";
            this.labelIsiNamaManager.Size = new System.Drawing.Size(40, 17);
            this.labelIsiNamaManager.TabIndex = 11;
            this.labelIsiNamaManager.Text = "[......]";
            // 
            // labelIsiNamaStadium
            // 
            this.labelIsiNamaStadium.AutoSize = true;
            this.labelIsiNamaStadium.Location = new System.Drawing.Point(263, 149);
            this.labelIsiNamaStadium.Name = "labelIsiNamaStadium";
            this.labelIsiNamaStadium.Size = new System.Drawing.Size(40, 17);
            this.labelIsiNamaStadium.TabIndex = 12;
            this.labelIsiNamaStadium.Text = "[......]";
            // 
            // labelIsiNamaTopSkor
            // 
            this.labelIsiNamaTopSkor.AutoSize = true;
            this.labelIsiNamaTopSkor.Location = new System.Drawing.Point(263, 183);
            this.labelIsiNamaTopSkor.Name = "labelIsiNamaTopSkor";
            this.labelIsiNamaTopSkor.Size = new System.Drawing.Size(40, 17);
            this.labelIsiNamaTopSkor.TabIndex = 13;
            this.labelIsiNamaTopSkor.Text = "[......]";
            // 
            // labelIsiNamaWorstDiscipline
            // 
            this.labelIsiNamaWorstDiscipline.AutoSize = true;
            this.labelIsiNamaWorstDiscipline.Location = new System.Drawing.Point(263, 210);
            this.labelIsiNamaWorstDiscipline.Name = "labelIsiNamaWorstDiscipline";
            this.labelIsiNamaWorstDiscipline.Size = new System.Drawing.Size(40, 17);
            this.labelIsiNamaWorstDiscipline.TabIndex = 14;
            this.labelIsiNamaWorstDiscipline.Text = "[......]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 493);
            this.Controls.Add(this.labelIsiNamaWorstDiscipline);
            this.Controls.Add(this.labelIsiNamaTopSkor);
            this.Controls.Add(this.labelIsiNamaStadium);
            this.Controls.Add(this.labelIsiNamaManager);
            this.Controls.Add(this.labelIsiNamaTim);
            this.Controls.Add(this.labelWorstDiscipline);
            this.Controls.Add(this.labelTopScore);
            this.Controls.Add(this.labelStadium);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.labelTeamName);
            this.Controls.Add(this.dataGridView5Pertandingan);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5Pertandingan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.DataGridView dataGridView5Pertandingan;
        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.Label labelManager;
        private System.Windows.Forms.Label labelStadium;
        private System.Windows.Forms.Label labelTopScore;
        private System.Windows.Forms.Label labelWorstDiscipline;
        private System.Windows.Forms.Label labelIsiNamaTim;
        private System.Windows.Forms.Label labelIsiNamaManager;
        private System.Windows.Forms.Label labelIsiNamaStadium;
        private System.Windows.Forms.Label labelIsiNamaTopSkor;
        private System.Windows.Forms.Label labelIsiNamaWorstDiscipline;
    }
}

