namespace DataSec_Lab_04_PRJ
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.saveFPathBox = new System.Windows.Forms.TextBox();
            this.openFPathBox = new System.Windows.Forms.TextBox();
            this.saveLabel = new System.Windows.Forms.Label();
            this.openLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.keySizeLabel = new System.Windows.Forms.Label();
            this.kSizeTextLabel = new System.Windows.Forms.Label();
            this.buttonGenerateKey = new System.Windows.Forms.Button();
            this.buttonSaveKey = new System.Windows.Forms.Button();
            this.buttonOpenKey = new System.Windows.Forms.Button();
            this.keyPathBox = new System.Windows.Forms.TextBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.totTTextLabel = new System.Windows.Forms.Label();
            this.totTimeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSaveFile);
            this.groupBox1.Controls.Add(this.buttonOpenFile);
            this.groupBox1.Controls.Add(this.saveFPathBox);
            this.groupBox1.Controls.Add(this.openFPathBox);
            this.groupBox1.Controls.Add(this.saveLabel);
            this.groupBox1.Controls.Add(this.openLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(324, 57);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(40, 23);
            this.buttonSaveFile.TabIndex = 5;
            this.buttonSaveFile.Text = "...";
            this.toolTip1.SetToolTip(this.buttonSaveFile, "Save to file");
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(324, 24);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(40, 23);
            this.buttonOpenFile.TabIndex = 4;
            this.buttonOpenFile.Text = "...";
            this.toolTip1.SetToolTip(this.buttonOpenFile, "Open file");
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // saveFPathBox
            // 
            this.saveFPathBox.Location = new System.Drawing.Point(75, 57);
            this.saveFPathBox.Name = "saveFPathBox";
            this.saveFPathBox.Size = new System.Drawing.Size(243, 21);
            this.saveFPathBox.TabIndex = 3;
            // 
            // openFPathBox
            // 
            this.openFPathBox.Location = new System.Drawing.Point(75, 24);
            this.openFPathBox.Name = "openFPathBox";
            this.openFPathBox.Size = new System.Drawing.Size(243, 21);
            this.openFPathBox.TabIndex = 2;
            // 
            // saveLabel
            // 
            this.saveLabel.AutoSize = true;
            this.saveLabel.Location = new System.Drawing.Point(6, 60);
            this.saveLabel.Name = "saveLabel";
            this.saveLabel.Size = new System.Drawing.Size(69, 15);
            this.saveLabel.TabIndex = 1;
            this.saveLabel.Text = "Save to file:";
            // 
            // openLabel
            // 
            this.openLabel.AutoSize = true;
            this.openLabel.Location = new System.Drawing.Point(6, 27);
            this.openLabel.Name = "openLabel";
            this.openLabel.Size = new System.Drawing.Size(59, 15);
            this.openLabel.TabIndex = 0;
            this.openLabel.Text = "Open file:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.keySizeLabel);
            this.groupBox2.Controls.Add(this.kSizeTextLabel);
            this.groupBox2.Controls.Add(this.buttonGenerateKey);
            this.groupBox2.Controls.Add(this.buttonSaveKey);
            this.groupBox2.Controls.Add(this.buttonOpenKey);
            this.groupBox2.Controls.Add(this.keyPathBox);
            this.groupBox2.Controls.Add(this.keyLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(15, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Key";
            // 
            // keySizeLabel
            // 
            this.keySizeLabel.AutoSize = true;
            this.keySizeLabel.Location = new System.Drawing.Point(71, 61);
            this.keySizeLabel.Name = "keySizeLabel";
            this.keySizeLabel.Size = new System.Drawing.Size(24, 15);
            this.keySizeLabel.TabIndex = 10;
            this.keySizeLabel.Text = "0 b";
            this.keySizeLabel.Click += new System.EventHandler(this.keySizeLabel_Click);
            // 
            // kSizeTextLabel
            // 
            this.kSizeTextLabel.AutoSize = true;
            this.kSizeTextLabel.Location = new System.Drawing.Point(6, 61);
            this.kSizeTextLabel.Name = "kSizeTextLabel";
            this.kSizeTextLabel.Size = new System.Drawing.Size(55, 15);
            this.kSizeTextLabel.TabIndex = 9;
            this.kSizeTextLabel.Text = "Key size:";
            // 
            // buttonGenerateKey
            // 
            this.buttonGenerateKey.BackgroundImage = global::DataSec_Lab_04_PRJ.Properties.Resources.key21;
            this.buttonGenerateKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGenerateKey.Location = new System.Drawing.Point(141, 55);
            this.buttonGenerateKey.Name = "buttonGenerateKey";
            this.buttonGenerateKey.Size = new System.Drawing.Size(50, 35);
            this.buttonGenerateKey.TabIndex = 7;
            this.toolTip1.SetToolTip(this.buttonGenerateKey, "Generate key");
            this.buttonGenerateKey.UseVisualStyleBackColor = true;
            this.buttonGenerateKey.Click += new System.EventHandler(this.buttonGenerateKey_Click);
            // 
            // buttonSaveKey
            // 
            this.buttonSaveKey.BackgroundImage = global::DataSec_Lab_04_PRJ.Properties.Resources.open_folder;
            this.buttonSaveKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSaveKey.Location = new System.Drawing.Point(278, 26);
            this.buttonSaveKey.Name = "buttonSaveKey";
            this.buttonSaveKey.Size = new System.Drawing.Size(40, 40);
            this.buttonSaveKey.TabIndex = 6;
            this.toolTip1.SetToolTip(this.buttonSaveKey, "Save key to file");
            this.buttonSaveKey.UseVisualStyleBackColor = true;
            this.buttonSaveKey.Click += new System.EventHandler(this.buttonSaveKey_Click);
            // 
            // buttonOpenKey
            // 
            this.buttonOpenKey.BackgroundImage = global::DataSec_Lab_04_PRJ.Properties.Resources.diskette;
            this.buttonOpenKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOpenKey.Location = new System.Drawing.Point(324, 26);
            this.buttonOpenKey.Name = "buttonOpenKey";
            this.buttonOpenKey.Size = new System.Drawing.Size(40, 40);
            this.buttonOpenKey.TabIndex = 5;
            this.toolTip1.SetToolTip(this.buttonOpenKey, "Open key file");
            this.buttonOpenKey.UseVisualStyleBackColor = true;
            this.buttonOpenKey.Click += new System.EventHandler(this.buttonOpenKey_Click);
            // 
            // keyPathBox
            // 
            this.keyPathBox.Location = new System.Drawing.Point(61, 28);
            this.keyPathBox.Name = "keyPathBox";
            this.keyPathBox.Size = new System.Drawing.Size(208, 21);
            this.keyPathBox.TabIndex = 3;
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(6, 31);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(49, 15);
            this.keyLabel.TabIndex = 2;
            this.keyLabel.Text = "Key file:";
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(263, 221);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(70, 30);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // totTTextLabel
            // 
            this.totTTextLabel.AutoSize = true;
            this.totTTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totTTextLabel.Location = new System.Drawing.Point(15, 225);
            this.totTTextLabel.Name = "totTTextLabel";
            this.totTTextLabel.Size = new System.Drawing.Size(157, 15);
            this.totTTextLabel.TabIndex = 8;
            this.totTTextLabel.Text = "Encryption time (m : s . ms):";
            // 
            // totTimeLabel
            // 
            this.totTimeLabel.AutoSize = true;
            this.totTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totTimeLabel.Location = new System.Drawing.Point(178, 225);
            this.totTimeLabel.Name = "totTimeLabel";
            this.totTimeLabel.Size = new System.Drawing.Size(62, 15);
            this.totTimeLabel.TabIndex = 9;
            this.totTimeLabel.Text = "00:00.000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.Controls.Add(this.totTimeLabel);
            this.Controls.Add(this.totTTextLabel);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lab04 - XOR File";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label saveLabel;
        private System.Windows.Forms.Label openLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TextBox saveFPathBox;
        private System.Windows.Forms.TextBox openFPathBox;
        private System.Windows.Forms.Button buttonSaveKey;
        private System.Windows.Forms.Button buttonOpenKey;
        private System.Windows.Forms.TextBox keyPathBox;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonGenerateKey;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label totTTextLabel;
        private System.Windows.Forms.Label totTimeLabel;
        private System.Windows.Forms.Label keySizeLabel;
        private System.Windows.Forms.Label kSizeTextLabel;
    }
}

