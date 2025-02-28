﻿namespace MicrophoneSpectrumAnalyzer
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbRecordingSource = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBackgroundSource = new System.Windows.Forms.ComboBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSpectrumMode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSpectrumVisualizer = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumLines = new System.Windows.Forms.NumericUpDown();
            this.horizontalSpectrumVisualizer1 = new MicrophoneSpectrumAnalyzer.AudioSpectrumVisualizers.HorizontalSpectrumVisualizer();
            this.circleSpectrumVisualizer1 = new MicrophoneSpectrumAnalyzer.AudioSpectrumVisualizers.CircleSpectrumVisualizer();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumLines)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRecordingSource
            // 
            this.cmbRecordingSource.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRecordingSource.FormattingEnabled = true;
            this.cmbRecordingSource.Location = new System.Drawing.Point(11, 105);
            this.cmbRecordingSource.Name = "cmbRecordingSource";
            this.cmbRecordingSource.Size = new System.Drawing.Size(442, 32);
            this.cmbRecordingSource.TabIndex = 0;
            this.cmbRecordingSource.SelectedIndexChanged += new System.EventHandler(this.CmbRecordingSource_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Audio input device :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(470, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Background source :";
            // 
            // cmbBackgroundSource
            // 
            this.cmbBackgroundSource.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBackgroundSource.FormattingEnabled = true;
            this.cmbBackgroundSource.Items.AddRange(new object[] {
            "None (transparent)",
            "Color",
            "Image / Animated gif",
            "Video"});
            this.cmbBackgroundSource.Location = new System.Drawing.Point(473, 105);
            this.cmbBackgroundSource.Name = "cmbBackgroundSource";
            this.cmbBackgroundSource.Size = new System.Drawing.Size(442, 32);
            this.cmbBackgroundSource.TabIndex = 3;
            this.cmbBackgroundSource.SelectedIndexChanged += new System.EventHandler(this.CmbBackgroundSource_SelectedIndexChanged);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.Location = new System.Drawing.Point(12, 175);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(750, 32);
            this.txtFilePath.TabIndex = 5;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePath.Location = new System.Drawing.Point(8, 151);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(256, 21);
            this.lblFilePath.TabIndex = 6;
            this.lblFilePath.Text = "File path to display as background :";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(768, 173);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(147, 36);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "The key color to remove is #00b140";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Spectrum mode :";
            // 
            // cmbSpectrumMode
            // 
            this.cmbSpectrumMode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSpectrumMode.FormattingEnabled = true;
            this.cmbSpectrumMode.Items.AddRange(new object[] {
            "Fast Fourier Transform (FFT)",
            "Amplitude"});
            this.cmbSpectrumMode.Location = new System.Drawing.Point(11, 34);
            this.cmbSpectrumMode.Name = "cmbSpectrumMode";
            this.cmbSpectrumMode.Size = new System.Drawing.Size(275, 32);
            this.cmbSpectrumMode.TabIndex = 9;
            this.cmbSpectrumMode.SelectedIndexChanged += new System.EventHandler(this.CmbSpectrumMode_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(320, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Spectrum visualizer :";
            // 
            // cmbSpectrumVisualizer
            // 
            this.cmbSpectrumVisualizer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSpectrumVisualizer.FormattingEnabled = true;
            this.cmbSpectrumVisualizer.Items.AddRange(new object[] {
            "Circle bar",
            "Horizontal bar"});
            this.cmbSpectrumVisualizer.Location = new System.Drawing.Point(323, 34);
            this.cmbSpectrumVisualizer.Name = "cmbSpectrumVisualizer";
            this.cmbSpectrumVisualizer.Size = new System.Drawing.Size(275, 32);
            this.cmbSpectrumVisualizer.TabIndex = 11;
            this.cmbSpectrumVisualizer.SelectedIndexChanged += new System.EventHandler(this.CmbSpectrumVisualizer_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(636, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Number of lines";
            // 
            // txtNumLines
            // 
            this.txtNumLines.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumLines.Location = new System.Drawing.Point(640, 34);
            this.txtNumLines.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.txtNumLines.Name = "txtNumLines";
            this.txtNumLines.Size = new System.Drawing.Size(275, 32);
            this.txtNumLines.TabIndex = 15;
            this.txtNumLines.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtNumLines.ValueChanged += new System.EventHandler(this.TxtNumLines_ValueChanged);
            // 
            // horizontalSpectrumVisualizer1
            // 
            this.horizontalSpectrumVisualizer1.Location = new System.Drawing.Point(14, 324);
            this.horizontalSpectrumVisualizer1.Name = "horizontalSpectrumVisualizer1";
            this.horizontalSpectrumVisualizer1.Size = new System.Drawing.Size(901, 345);
            this.horizontalSpectrumVisualizer1.TabIndex = 16;
            this.horizontalSpectrumVisualizer1.Text = "horizontalSpectrumVisualizer1";
            // 
            // circleSpectrumVisualizer1
            // 
            this.circleSpectrumVisualizer1.Img = null;
            this.circleSpectrumVisualizer1.Location = new System.Drawing.Point(153, 271);
            this.circleSpectrumVisualizer1.Name = "circleSpectrumVisualizer1";
            this.circleSpectrumVisualizer1.Size = new System.Drawing.Size(626, 689);
            this.circleSpectrumVisualizer1.TabIndex = 2;
            this.circleSpectrumVisualizer1.Text = "circleSpectrumVisualizer1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(936, 972);
            this.Controls.Add(this.horizontalSpectrumVisualizer1);
            this.Controls.Add(this.txtNumLines);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSpectrumVisualizer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSpectrumMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBackgroundSource);
            this.Controls.Add(this.circleSpectrumVisualizer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRecordingSource);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Microphone spectrum analyser - Stream tool by BigPino67-TV ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRecordingSource;
        private System.Windows.Forms.Label label1;
        private AudioSpectrumVisualizers.CircleSpectrumVisualizer circleSpectrumVisualizer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBackgroundSource;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSpectrumMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSpectrumVisualizer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtNumLines;
        private AudioSpectrumVisualizers.HorizontalSpectrumVisualizer horizontalSpectrumVisualizer1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

