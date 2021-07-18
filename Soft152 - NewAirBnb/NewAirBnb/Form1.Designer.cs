namespace NewAirBnb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstDist = new System.Windows.Forms.ListBox();
            this.ToolBox = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddDist = new System.Windows.Forms.Button();
            this.btnAddNeigh = new System.Windows.Forms.Button();
            this.btnAddProp = new System.Windows.Forms.Button();
            this.lbDistricts = new System.Windows.Forms.Label();
            this.lblNeigh = new System.Windows.Forms.Label();
            this.lblprops = new System.Windows.Forms.Label();
            this.lstNeigh = new System.Windows.Forms.ListBox();
            this.lstV = new System.Windows.Forms.ListView();
            this.spacer2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PropID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PropName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Avail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cords = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mininights = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sapcer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hostID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hostname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numowned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBoxText = new System.Windows.Forms.TextBox();
            this.btnDelProp = new System.Windows.Forms.Button();
            this.SearchBoxTextNeigh = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ToolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstDist
            // 
            this.lstDist.FormattingEnabled = true;
            this.lstDist.Location = new System.Drawing.Point(11, 190);
            this.lstDist.Name = "lstDist";
            this.lstDist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstDist.Size = new System.Drawing.Size(131, 108);
            this.lstDist.TabIndex = 0;
            this.lstDist.SelectedIndexChanged += new System.EventHandler(this.lstDist_SelectedIndexChanged);
            // 
            // ToolBox
            // 
            this.ToolBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToolBox.Controls.Add(this.button4);
            this.ToolBox.Controls.Add(this.button3);
            this.ToolBox.Controls.Add(this.button2);
            this.ToolBox.Controls.Add(this.btnAnalysis);
            this.ToolBox.Controls.Add(this.btnRefresh);
            this.ToolBox.Location = new System.Drawing.Point(12, 95);
            this.ToolBox.Name = "ToolBox";
            this.ToolBox.Size = new System.Drawing.Size(1284, 52);
            this.ToolBox.TabIndex = 2;
            this.ToolBox.TabStop = false;
            this.ToolBox.Text = "𝗚𝗹𝗼𝗯𝗮𝗹 𝗧𝗼𝗼𝗹𝘀";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(226, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "🖊️ Edit Neighbourhood";
            this.button4.UseMnemonic = false;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(116, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "🖊️ Edit District";
            this.button3.UseMnemonic = false;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(358, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "🖊️ Edit Property";
            this.button2.UseMnemonic = false;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Location = new System.Drawing.Point(6, 19);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(104, 23);
            this.btnAnalysis.TabIndex = 12;
            this.btnAnalysis.Text = "Analysis Page ";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(1153, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(125, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "⭮  Reload ";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddDist
            // 
            this.btnAddDist.Location = new System.Drawing.Point(98, 167);
            this.btnAddDist.Name = "btnAddDist";
            this.btnAddDist.Size = new System.Drawing.Size(44, 20);
            this.btnAddDist.TabIndex = 6;
            this.btnAddDist.Text = "➕";
            this.btnAddDist.UseMnemonic = false;
            this.btnAddDist.UseVisualStyleBackColor = true;
            this.btnAddDist.Click += new System.EventHandler(this.btnAddDist_Click);
            // 
            // btnAddNeigh
            // 
            this.btnAddNeigh.Location = new System.Drawing.Point(98, 322);
            this.btnAddNeigh.Name = "btnAddNeigh";
            this.btnAddNeigh.Size = new System.Drawing.Size(44, 20);
            this.btnAddNeigh.TabIndex = 5;
            this.btnAddNeigh.Text = "➕";
            this.btnAddNeigh.UseMnemonic = false;
            this.btnAddNeigh.UseVisualStyleBackColor = true;
            this.btnAddNeigh.Click += new System.EventHandler(this.btnAddNeigh_Click);
            // 
            // btnAddProp
            // 
            this.btnAddProp.Location = new System.Drawing.Point(160, 167);
            this.btnAddProp.Name = "btnAddProp";
            this.btnAddProp.Size = new System.Drawing.Size(104, 20);
            this.btnAddProp.TabIndex = 4;
            this.btnAddProp.Text = "➕ Add Property";
            this.btnAddProp.UseMnemonic = false;
            this.btnAddProp.UseVisualStyleBackColor = true;
            this.btnAddProp.Click += new System.EventHandler(this.btnAddProp_Click);
            // 
            // lbDistricts
            // 
            this.lbDistricts.AutoSize = true;
            this.lbDistricts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline);
            this.lbDistricts.Location = new System.Drawing.Point(9, 149);
            this.lbDistricts.Name = "lbDistricts";
            this.lbDistricts.Size = new System.Drawing.Size(55, 15);
            this.lbDistricts.TabIndex = 5;
            this.lbDistricts.Text = "𝗗𝗶𝘀𝘁𝗿𝗶𝗰𝘁𝘀:";
            // 
            // lblNeigh
            // 
            this.lblNeigh.AutoSize = true;
            this.lblNeigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline);
            this.lblNeigh.Location = new System.Drawing.Point(9, 304);
            this.lblNeigh.Name = "lblNeigh";
            this.lblNeigh.Size = new System.Drawing.Size(103, 15);
            this.lblNeigh.TabIndex = 8;
            this.lblNeigh.Text = "𝗡𝗲𝗶𝗴𝗵𝗯𝗼𝘂𝗿𝗵𝗼𝗼𝗱𝘀:";
            // 
            // lblprops
            // 
            this.lblprops.AutoSize = true;
            this.lblprops.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline);
            this.lblprops.Location = new System.Drawing.Point(157, 149);
            this.lblprops.Name = "lblprops";
            this.lblprops.Size = new System.Drawing.Size(68, 15);
            this.lblprops.TabIndex = 9;
            this.lblprops.Text = "𝗣𝗿𝗼𝗽𝗲𝗿𝘁𝗶𝗲𝘀:";
            // 
            // lstNeigh
            // 
            this.lstNeigh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstNeigh.FormattingEnabled = true;
            this.lstNeigh.Location = new System.Drawing.Point(12, 345);
            this.lstNeigh.Name = "lstNeigh";
            this.lstNeigh.Size = new System.Drawing.Size(131, 316);
            this.lstNeigh.TabIndex = 10;
            this.lstNeigh.SelectedIndexChanged += new System.EventHandler(this.lstNeigh_SelectedIndexChanged);
            // 
            // lstV
            // 
            this.lstV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.spacer2,
            this.PropID,
            this.PropName,
            this.RType,
            this.Price,
            this.Avail,
            this.cords,
            this.mininights,
            this.Sapcer,
            this.hostID,
            this.hostname,
            this.numowned});
            this.lstV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstV.FullRowSelect = true;
            this.lstV.GridLines = true;
            this.lstV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstV.HideSelection = false;
            this.lstV.Location = new System.Drawing.Point(160, 190);
            this.lstV.Name = "lstV";
            this.lstV.Size = new System.Drawing.Size(1136, 471);
            this.lstV.TabIndex = 11;
            this.lstV.UseCompatibleStateImageBehavior = false;
            this.lstV.View = System.Windows.Forms.View.Details;
            // 
            // spacer2
            // 
            this.spacer2.Text = "🏡";
            this.spacer2.Width = 22;
            // 
            // PropID
            // 
            this.PropID.Text = "𝗣𝗿𝗼𝗽𝗲𝗿𝘁𝘆 𝗜𝗗";
            this.PropID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PropID.Width = 93;
            // 
            // PropName
            // 
            this.PropName.Text = "𝗣𝗿𝗼𝗽𝗲𝗿𝘁𝘆 𝗧𝗶𝘁𝗹𝗲";
            this.PropName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PropName.Width = 304;
            // 
            // RType
            // 
            this.RType.Text = "𝗧𝘆𝗽𝗲";
            this.RType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RType.Width = 81;
            // 
            // Price
            // 
            this.Price.Text = "𝗣𝗿𝗶𝗰𝗲";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Width = 54;
            // 
            // Avail
            // 
            this.Avail.Text = "𝗔𝘃𝗮𝗶𝗹𝗮𝗯𝗶𝗹𝗶𝘁𝘆";
            this.Avail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Avail.Width = 105;
            // 
            // cords
            // 
            this.cords.DisplayIndex = 7;
            this.cords.Text = "𝗖𝗼𝗼𝗿𝗱𝗶𝗻𝗮𝘁𝗲𝘀";
            this.cords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cords.Width = 111;
            // 
            // mininights
            // 
            this.mininights.DisplayIndex = 6;
            this.mininights.Text = "𝗠𝗶𝗻𝗶𝗺𝘂𝗺 𝗡𝗶𝗴𝗵𝘁𝘀";
            this.mininights.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mininights.Width = 97;
            // 
            // Sapcer
            // 
            this.Sapcer.Text = "👤";
            this.Sapcer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sapcer.Width = 27;
            // 
            // hostID
            // 
            this.hostID.Text = "𝗛𝗼𝘀𝘁 𝗜𝗗";
            this.hostID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hostID.Width = 91;
            // 
            // hostname
            // 
            this.hostname.Text = "𝗡𝗮𝗺𝗲";
            this.hostname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hostname.Width = 86;
            // 
            // numowned
            // 
            this.numowned.Text = "𝗢𝘄𝗻𝗲𝗱";
            this.numowned.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numowned.Width = 50;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1076, 666);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Soft152 AirBnB Project  - By Matt Caine 2019";
            // 
            // SearchBoxText
            // 
            this.SearchBoxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBoxText.Location = new System.Drawing.Point(11, 167);
            this.SearchBoxText.Multiline = true;
            this.SearchBoxText.Name = "SearchBoxText";
            this.SearchBoxText.Size = new System.Drawing.Size(85, 20);
            this.SearchBoxText.TabIndex = 13;
            this.SearchBoxText.Text = "🔍 Search...";
            this.SearchBoxText.TextChanged += new System.EventHandler(this.SearchBoxText_TextChanged);
            // 
            // btnDelProp
            // 
            this.btnDelProp.Location = new System.Drawing.Point(266, 167);
            this.btnDelProp.Name = "btnDelProp";
            this.btnDelProp.Size = new System.Drawing.Size(153, 20);
            this.btnDelProp.TabIndex = 18;
            this.btnDelProp.Text = "🗑️ Delete Selcted Properties";
            this.btnDelProp.UseMnemonic = false;
            this.btnDelProp.UseVisualStyleBackColor = true;
            this.btnDelProp.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SearchBoxTextNeigh
            // 
            this.SearchBoxTextNeigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBoxTextNeigh.Location = new System.Drawing.Point(12, 322);
            this.SearchBoxTextNeigh.Multiline = true;
            this.SearchBoxTextNeigh.Name = "SearchBoxTextNeigh";
            this.SearchBoxTextNeigh.Size = new System.Drawing.Size(84, 20);
            this.SearchBoxTextNeigh.TabIndex = 14;
            this.SearchBoxTextNeigh.Text = "🔍 Search...";
            this.SearchBoxTextNeigh.TextChanged += new System.EventHandler(this.SearchBoxTextNeigh_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::NewAirBnb.Properties.Resources.LongBanner;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1284, 77);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1308, 687);
            this.Controls.Add(this.btnDelProp);
            this.Controls.Add(this.btnAddProp);
            this.Controls.Add(this.btnAddNeigh);
            this.Controls.Add(this.SearchBoxTextNeigh);
            this.Controls.Add(this.btnAddDist);
            this.Controls.Add(this.SearchBoxText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstV);
            this.Controls.Add(this.lstNeigh);
            this.Controls.Add(this.lblprops);
            this.Controls.Add(this.lblNeigh);
            this.Controls.Add(this.lbDistricts);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ToolBox);
            this.Controls.Add(this.lstDist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soft152 - AirBnB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ToolBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDist;
        private System.Windows.Forms.GroupBox ToolBox;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddDist;
        private System.Windows.Forms.Button btnAddNeigh;
        private System.Windows.Forms.Button btnAddProp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbDistricts;
        private System.Windows.Forms.Label lblNeigh;
        private System.Windows.Forms.Label lblprops;
        private System.Windows.Forms.ListBox lstNeigh;
        private System.Windows.Forms.ListView lstV;
        private System.Windows.Forms.ColumnHeader PropID;
        private System.Windows.Forms.ColumnHeader PropName;
        private System.Windows.Forms.ColumnHeader RType;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Avail;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.ColumnHeader mininights;
        private System.Windows.Forms.ColumnHeader cords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Sapcer;
        private System.Windows.Forms.ColumnHeader hostID;
        private System.Windows.Forms.ColumnHeader hostname;
        private System.Windows.Forms.ColumnHeader numowned;
        private System.Windows.Forms.ColumnHeader spacer2;
        private System.Windows.Forms.TextBox SearchBoxText;
        private System.Windows.Forms.Button btnDelProp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox SearchBoxTextNeigh;
    }
}

