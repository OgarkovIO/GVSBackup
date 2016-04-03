namespace GVSBackup
{
    partial class Form_Option
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSDP = new System.Windows.Forms.TextBox();
            this.textBoxORA = new System.Windows.Forms.TextBox();
            this.textBoxSUD = new System.Windows.Forms.TextBox();
            this.buttonSDP = new System.Windows.Forms.Button();
            this.buttonORA = new System.Windows.Forms.Button();
            this.buttonSUD = new System.Windows.Forms.Button();
            this.Discard = new System.Windows.Forms.Button();
            this.Applay = new System.Windows.Forms.Button();
            this.NumberOfStoredFiles = new System.Windows.Forms.NumericUpDown();
            this.NumberOfDays = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfStoredFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfDays)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "СДП:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oracle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Судимость:";
            // 
            // textBoxSDP
            // 
            this.textBoxSDP.Location = new System.Drawing.Point(76, 12);
            this.textBoxSDP.Name = "textBoxSDP";
            this.textBoxSDP.Size = new System.Drawing.Size(289, 20);
            this.textBoxSDP.TabIndex = 3;
            // 
            // textBoxORA
            // 
            this.textBoxORA.Location = new System.Drawing.Point(76, 38);
            this.textBoxORA.Name = "textBoxORA";
            this.textBoxORA.Size = new System.Drawing.Size(289, 20);
            this.textBoxORA.TabIndex = 4;
            // 
            // textBoxSUD
            // 
            this.textBoxSUD.Location = new System.Drawing.Point(76, 66);
            this.textBoxSUD.Name = "textBoxSUD";
            this.textBoxSUD.Size = new System.Drawing.Size(289, 20);
            this.textBoxSUD.TabIndex = 5;
            // 
            // buttonSDP
            // 
            this.buttonSDP.Location = new System.Drawing.Point(371, 9);
            this.buttonSDP.Name = "buttonSDP";
            this.buttonSDP.Size = new System.Drawing.Size(75, 23);
            this.buttonSDP.TabIndex = 6;
            this.buttonSDP.Text = "Обзор";
            this.buttonSDP.UseVisualStyleBackColor = true;
            this.buttonSDP.Click += new System.EventHandler(this.buttonSDP_Click);
            // 
            // buttonORA
            // 
            this.buttonORA.Location = new System.Drawing.Point(372, 37);
            this.buttonORA.Name = "buttonORA";
            this.buttonORA.Size = new System.Drawing.Size(75, 23);
            this.buttonORA.TabIndex = 7;
            this.buttonORA.Text = "Обзор";
            this.buttonORA.UseVisualStyleBackColor = true;
            this.buttonORA.Click += new System.EventHandler(this.buttonORA_Click);
            // 
            // buttonSUD
            // 
            this.buttonSUD.Location = new System.Drawing.Point(372, 66);
            this.buttonSUD.Name = "buttonSUD";
            this.buttonSUD.Size = new System.Drawing.Size(75, 23);
            this.buttonSUD.TabIndex = 8;
            this.buttonSUD.Text = "Обзор";
            this.buttonSUD.UseVisualStyleBackColor = true;
            this.buttonSUD.Click += new System.EventHandler(this.buttonSUD_Click);
            // 
            // Discard
            // 
            this.Discard.Location = new System.Drawing.Point(131, 155);
            this.Discard.Name = "Discard";
            this.Discard.Size = new System.Drawing.Size(75, 23);
            this.Discard.TabIndex = 9;
            this.Discard.Text = "Отмена";
            this.Discard.UseVisualStyleBackColor = true;
            this.Discard.Click += new System.EventHandler(this.Discard_Click);
            // 
            // Applay
            // 
            this.Applay.Location = new System.Drawing.Point(213, 155);
            this.Applay.Name = "Applay";
            this.Applay.Size = new System.Drawing.Size(75, 23);
            this.Applay.TabIndex = 10;
            this.Applay.Text = "Сохранить";
            this.Applay.UseVisualStyleBackColor = true;
            this.Applay.Click += new System.EventHandler(this.Applay_Click);
            // 
            // NumberOfStoredFiles
            // 
            this.NumberOfStoredFiles.Location = new System.Drawing.Point(299, 94);
            this.NumberOfStoredFiles.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.NumberOfStoredFiles.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumberOfStoredFiles.Name = "NumberOfStoredFiles";
            this.NumberOfStoredFiles.Size = new System.Drawing.Size(49, 20);
            this.NumberOfStoredFiles.TabIndex = 11;
            this.NumberOfStoredFiles.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // NumberOfDays
            // 
            this.NumberOfDays.Location = new System.Drawing.Point(299, 122);
            this.NumberOfDays.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.NumberOfDays.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumberOfDays.Name = "NumberOfDays";
            this.NumberOfDays.Size = new System.Drawing.Size(49, 20);
            this.NumberOfDays.TabIndex = 12;
            this.NumberOfDays.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Колличество гарантированно сохраняемых копий:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Период в течении которого хранятся файлы, в днях:";
            // 
            // Form_Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 190);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumberOfDays);
            this.Controls.Add(this.NumberOfStoredFiles);
            this.Controls.Add(this.Applay);
            this.Controls.Add(this.Discard);
            this.Controls.Add(this.buttonSUD);
            this.Controls.Add(this.buttonORA);
            this.Controls.Add(this.buttonSDP);
            this.Controls.Add(this.textBoxSUD);
            this.Controls.Add(this.textBoxORA);
            this.Controls.Add(this.textBoxSDP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Option";
            this.Text = "Настройки программы очистки";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfStoredFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSDP;
        private System.Windows.Forms.TextBox textBoxORA;
        private System.Windows.Forms.TextBox textBoxSUD;
        private System.Windows.Forms.Button buttonSDP;
        private System.Windows.Forms.Button buttonORA;
        private System.Windows.Forms.Button buttonSUD;
        private System.Windows.Forms.Button Discard;
        private System.Windows.Forms.Button Applay;
        private System.Windows.Forms.NumericUpDown NumberOfStoredFiles;
        private System.Windows.Forms.NumericUpDown NumberOfDays;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}