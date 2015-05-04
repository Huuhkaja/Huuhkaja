using Huuhkaja.GUI;
namespace Huuhkaja.GUI
{
    partial class ConfigurationForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.useNaturesVigil = new System.Windows.Forms.CheckBox();
            this.useInc = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.starsurgePoolCA = new System.Windows.Forms.TextBox();
            this.useCA = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.minimumStarfall = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.aoeKey2 = new System.Windows.Forms.ComboBox();
            this.aoeKey1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.enableAOE = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save and Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Huuhkaja.GUI.Properties.Resources.owl;
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.useNaturesVigil);
            this.groupBox1.Location = new System.Drawing.Point(12, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Talents";
            // 
            // useNaturesVigil
            // 
            this.useNaturesVigil.AutoSize = true;
            this.useNaturesVigil.Location = new System.Drawing.Point(6, 19);
            this.useNaturesVigil.Name = "useNaturesVigil";
            this.useNaturesVigil.Size = new System.Drawing.Size(109, 17);
            this.useNaturesVigil.TabIndex = 1;
            this.useNaturesVigil.Text = "Use Nature\'s Vigil";
            this.useNaturesVigil.UseVisualStyleBackColor = true;
            this.useNaturesVigil.CheckedChanged += new System.EventHandler(this.useNaturesVigil_CheckedChanged);
            // 
            // useInc
            // 
            this.useInc.AutoSize = true;
            this.useInc.Location = new System.Drawing.Point(10, 42);
            this.useInc.Name = "useInc";
            this.useInc.Size = new System.Drawing.Size(101, 17);
            this.useInc.TabIndex = 0;
            this.useInc.Text = "Use Incarnation";
            this.useInc.UseVisualStyleBackColor = true;
            this.useInc.CheckedChanged += new System.EventHandler(this.useInc_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.starsurgePoolCA);
            this.groupBox2.Controls.Add(this.useCA);
            this.groupBox2.Controls.Add(this.useInc);
            this.groupBox2.Location = new System.Drawing.Point(174, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 95);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CDs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pool Starsurges for CA";
            // 
            // starsurgePoolCA
            // 
            this.starsurgePoolCA.Location = new System.Drawing.Point(10, 64);
            this.starsurgePoolCA.Name = "starsurgePoolCA";
            this.starsurgePoolCA.Size = new System.Drawing.Size(26, 20);
            this.starsurgePoolCA.TabIndex = 1;
            this.starsurgePoolCA.Text = "2";
            this.starsurgePoolCA.TextChanged += new System.EventHandler(this.starsurgePoolCA_TextChanged);
            // 
            // useCA
            // 
            this.useCA.AutoSize = true;
            this.useCA.Location = new System.Drawing.Point(10, 19);
            this.useCA.Name = "useCA";
            this.useCA.Size = new System.Drawing.Size(136, 17);
            this.useCA.TabIndex = 0;
            this.useCA.Text = "Use Celestial Aligement";
            this.useCA.UseVisualStyleBackColor = true;
            this.useCA.CheckedChanged += new System.EventHandler(this.useCA_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.minimumStarfall);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.aoeKey2);
            this.groupBox3.Controls.Add(this.aoeKey1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.enableAOE);
            this.groupBox3.Location = new System.Drawing.Point(174, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 122);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "AOE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Minimum targets for Starfall";
            // 
            // minimumStarfall
            // 
            this.minimumStarfall.Location = new System.Drawing.Point(6, 41);
            this.minimumStarfall.Name = "minimumStarfall";
            this.minimumStarfall.Size = new System.Drawing.Size(22, 20);
            this.minimumStarfall.TabIndex = 3;
            this.minimumStarfall.Text = "2";
            this.minimumStarfall.TextChanged += new System.EventHandler(this.minimumStarfall_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "+";
            // 
            // aoeKey2
            // 
            this.aoeKey2.FormattingEnabled = true;
            this.aoeKey2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.aoeKey2.Location = new System.Drawing.Point(108, 89);
            this.aoeKey2.Name = "aoeKey2";
            this.aoeKey2.Size = new System.Drawing.Size(60, 21);
            this.aoeKey2.TabIndex = 3;
            this.aoeKey2.SelectedIndexChanged += new System.EventHandler(this.aoeKey2_SelectedIndexChanged);
            // 
            // aoeKey1
            // 
            this.aoeKey1.FormattingEnabled = true;
            this.aoeKey1.Items.AddRange(new object[] {
            "Alt"});
            this.aoeKey1.Location = new System.Drawing.Point(6, 89);
            this.aoeKey1.Name = "aoeKey1";
            this.aoeKey1.Size = new System.Drawing.Size(81, 21);
            this.aoeKey1.TabIndex = 2;
            this.aoeKey1.SelectedIndexChanged += new System.EventHandler(this.aoeKey1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "AOE Keybinding";
            // 
            // enableAOE
            // 
            this.enableAOE.AutoSize = true;
            this.enableAOE.Location = new System.Drawing.Point(6, 21);
            this.enableAOE.Name = "enableAOE";
            this.enableAOE.Size = new System.Drawing.Size(84, 17);
            this.enableAOE.TabIndex = 0;
            this.enableAOE.Text = "Enable AOE";
            this.enableAOE.UseVisualStyleBackColor = true;
            this.enableAOE.CheckedChanged += new System.EventHandler(this.enableAOE_CheckedChanged);
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(381, 233);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "ConfigurationForm";
            this.Text = "Huuhkaja";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox starsurgePoolCA;
        private System.Windows.Forms.CheckBox useCA;
        private System.Windows.Forms.CheckBox useInc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox useNaturesVigil;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox enableAOE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox minimumStarfall;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox aoeKey2;
        private System.Windows.Forms.ComboBox aoeKey1;
        private System.Windows.Forms.Label label3;

    }
}