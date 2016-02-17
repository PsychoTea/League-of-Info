namespace League_of_Info
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
            this.title1 = new System.Windows.Forms.Label();
            this.TextSummonerName = new System.Windows.Forms.TextBox();
            this.LabelSummonerName = new System.Windows.Forms.Label();
            this.DropdownRegion = new System.Windows.Forms.ComboBox();
            this.LabelRegion = new System.Windows.Forms.Label();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.LabelSummonerID = new System.Windows.Forms.Label();
            this.LabelSummonerLevel = new System.Windows.Forms.Label();
            this.LabelSummonerProfileIconID = new System.Windows.Forms.Label();
            this.LabelSummonerNameOut = new System.Windows.Forms.Label();
            this.ButtonLMI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1.Location = new System.Drawing.Point(12, 9);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(235, 39);
            this.title1.TabIndex = 0;
            this.title1.Text = "League of Info";
            this.title1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextSummonerName
            // 
            this.TextSummonerName.Location = new System.Drawing.Point(19, 84);
            this.TextSummonerName.Name = "TextSummonerName";
            this.TextSummonerName.Size = new System.Drawing.Size(129, 20);
            this.TextSummonerName.TabIndex = 2;
            // 
            // LabelSummonerName
            // 
            this.LabelSummonerName.AutoSize = true;
            this.LabelSummonerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSummonerName.Location = new System.Drawing.Point(15, 61);
            this.LabelSummonerName.Name = "LabelSummonerName";
            this.LabelSummonerName.Size = new System.Drawing.Size(133, 20);
            this.LabelSummonerName.TabIndex = 4;
            this.LabelSummonerName.Text = "Summoner Name";
            // 
            // DropdownRegion
            // 
            this.DropdownRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropdownRegion.FormattingEnabled = true;
            this.DropdownRegion.Items.AddRange(new object[] {
            "br",
            "eune",
            "euw",
            "kr",
            "lan",
            "las",
            "na",
            "oce",
            "ru",
            "tr"});
            this.DropdownRegion.Location = new System.Drawing.Point(19, 143);
            this.DropdownRegion.Name = "DropdownRegion";
            this.DropdownRegion.Size = new System.Drawing.Size(121, 21);
            this.DropdownRegion.TabIndex = 5;
            // 
            // LabelRegion
            // 
            this.LabelRegion.AutoSize = true;
            this.LabelRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRegion.Location = new System.Drawing.Point(15, 120);
            this.LabelRegion.Name = "LabelRegion";
            this.LabelRegion.Size = new System.Drawing.Size(60, 20);
            this.LabelRegion.TabIndex = 6;
            this.LabelRegion.Text = "Region";
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(19, 180);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(75, 23);
            this.ButtonSubmit.TabIndex = 7;
            this.ButtonSubmit.Text = "Go!";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // LabelSummonerID
            // 
            this.LabelSummonerID.AutoSize = true;
            this.LabelSummonerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSummonerID.Location = new System.Drawing.Point(15, 228);
            this.LabelSummonerID.Name = "LabelSummonerID";
            this.LabelSummonerID.Size = new System.Drawing.Size(34, 20);
            this.LabelSummonerID.TabIndex = 8;
            this.LabelSummonerID.Text = "ID: ";
            // 
            // LabelSummonerLevel
            // 
            this.LabelSummonerLevel.AutoSize = true;
            this.LabelSummonerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSummonerLevel.Location = new System.Drawing.Point(15, 288);
            this.LabelSummonerLevel.Name = "LabelSummonerLevel";
            this.LabelSummonerLevel.Size = new System.Drawing.Size(54, 20);
            this.LabelSummonerLevel.TabIndex = 9;
            this.LabelSummonerLevel.Text = "Level: ";
            // 
            // LabelSummonerProfileIconID
            // 
            this.LabelSummonerProfileIconID.AutoSize = true;
            this.LabelSummonerProfileIconID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSummonerProfileIconID.Location = new System.Drawing.Point(15, 268);
            this.LabelSummonerProfileIconID.Name = "LabelSummonerProfileIconID";
            this.LabelSummonerProfileIconID.Size = new System.Drawing.Size(117, 20);
            this.LabelSummonerProfileIconID.TabIndex = 10;
            this.LabelSummonerProfileIconID.Text = "Profile Icon ID: ";
            // 
            // LabelSummonerNameOut
            // 
            this.LabelSummonerNameOut.AutoSize = true;
            this.LabelSummonerNameOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSummonerNameOut.Location = new System.Drawing.Point(15, 248);
            this.LabelSummonerNameOut.Name = "LabelSummonerNameOut";
            this.LabelSummonerNameOut.Size = new System.Drawing.Size(59, 20);
            this.LabelSummonerNameOut.TabIndex = 11;
            this.LabelSummonerNameOut.Text = "Name: ";
            // 
            // ButtonLMI
            // 
            this.ButtonLMI.Location = new System.Drawing.Point(100, 180);
            this.ButtonLMI.Name = "ButtonLMI";
            this.ButtonLMI.Size = new System.Drawing.Size(91, 23);
            this.ButtonLMI.TabIndex = 12;
            this.ButtonLMI.Text = "Last Match Info";
            this.ButtonLMI.UseVisualStyleBackColor = true;
            this.ButtonLMI.Click += new System.EventHandler(this.ButtonLMI_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 320);
            this.Controls.Add(this.ButtonLMI);
            this.Controls.Add(this.LabelSummonerNameOut);
            this.Controls.Add(this.LabelSummonerProfileIconID);
            this.Controls.Add(this.LabelSummonerLevel);
            this.Controls.Add(this.LabelSummonerID);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.LabelRegion);
            this.Controls.Add(this.DropdownRegion);
            this.Controls.Add(this.LabelSummonerName);
            this.Controls.Add(this.TextSummonerName);
            this.Controls.Add(this.title1);
            this.Name = "Form1";
            this.Text = "League of Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.TextBox TextSummonerName;
        private System.Windows.Forms.Label LabelSummonerName;
        private System.Windows.Forms.ComboBox DropdownRegion;
        private System.Windows.Forms.Label LabelRegion;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.Label LabelSummonerID;
        private System.Windows.Forms.Label LabelSummonerLevel;
        private System.Windows.Forms.Label LabelSummonerProfileIconID;
        private System.Windows.Forms.Label LabelSummonerNameOut;
        private System.Windows.Forms.Button ButtonLMI;
    }
}

