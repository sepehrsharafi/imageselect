
namespace ImageSelector
{
    partial class frmImageSelector
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImageSelector));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtAddress = new DarkUI.Controls.DarkTextBox();
            this.dgSelectedImages = new System.Windows.Forms.DataGridView();
            this.colImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pbCurrentImage = new System.Windows.Forms.PictureBox();
            this.btnNext = new DarkUI.Controls.DarkButton();
            this.btnPrv = new DarkUI.Controls.DarkButton();
            this.darkDockPanel1 = new DarkUI.Docking.DarkDockPanel();
            this.btnNext10 = new DarkUI.Controls.DarkButton();
            this.btnPrv10 = new DarkUI.Controls.DarkButton();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblFileName = new DarkUI.Controls.DarkLabel();
            this.txtNotes = new DarkUI.Controls.DarkTextBox();
            this.btnRotateRight = new DarkUI.Controls.DarkButton();
            this.btnRotateLeft = new DarkUI.Controls.DarkButton();
            this.lblNull = new DarkUI.Controls.DarkLabel();
            this.TrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgSelectedImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(64, 64);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtAddress.Location = new System.Drawing.Point(0, 0);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(1175, 30);
            this.txtAddress.TabIndex = 1;
            // 
            // dgSelectedImages
            // 
            this.dgSelectedImages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSelectedImages.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.dgSelectedImages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSelectedImages.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgSelectedImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSelectedImages.ColumnHeadersVisible = false;
            this.dgSelectedImages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colImage,
            this.colRemove});
            this.dgSelectedImages.Location = new System.Drawing.Point(1020, 35);
            this.dgSelectedImages.Name = "dgSelectedImages";
            this.dgSelectedImages.RowHeadersVisible = false;
            this.dgSelectedImages.RowTemplate.Height = 100;
            this.dgSelectedImages.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSelectedImages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgSelectedImages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSelectedImages.Size = new System.Drawing.Size(155, 618);
            this.dgSelectedImages.TabIndex = 4;
            this.dgSelectedImages.TabStop = false;
            this.dgSelectedImages.DataSourceChanged += new System.EventHandler(this.dgSelectedImages_DataSourceChanged);
            this.dgSelectedImages.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSelectedImages_CellClick);
            this.dgSelectedImages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSelectedImages_CellContentClick);
            this.dgSelectedImages.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSelectedImages_CellDoubleClick);
            this.dgSelectedImages.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgSelectedImages_CellFormatting);
            this.dgSelectedImages.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgSelectedImages_DataBindingComplete);
            this.dgSelectedImages.DoubleClick += new System.EventHandler(this.dgSelectedImages_DoubleClick);
            // 
            // colImage
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.colImage.DefaultCellStyle = dataGridViewCellStyle1;
            this.colImage.HeaderText = "Image";
            this.colImage.Name = "colImage";
            this.colImage.Width = 120;
            // 
            // colRemove
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.colRemove.DefaultCellStyle = dataGridViewCellStyle2;
            this.colRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colRemove.HeaderText = "Remove";
            this.colRemove.Name = "colRemove";
            this.colRemove.Text = "X";
            this.colRemove.ToolTipText = "Remove";
            this.colRemove.UseColumnTextForButtonValue = true;
            this.colRemove.Width = 40;
            // 
            // pbCurrentImage
            // 
            this.pbCurrentImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCurrentImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbCurrentImage.Location = new System.Drawing.Point(-1, 86);
            this.pbCurrentImage.Name = "pbCurrentImage";
            this.pbCurrentImage.Size = new System.Drawing.Size(1014, 491);
            this.pbCurrentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCurrentImage.TabIndex = 5;
            this.pbCurrentImage.TabStop = false;
            this.pbCurrentImage.Click += new System.EventHandler(this.pbCurrentImage_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext.ImagePadding = 2;
            this.btnNext.Location = new System.Drawing.Point(543, 589);
            this.btnNext.Name = "btnNext";
            this.btnNext.Padding = new System.Windows.Forms.Padding(5);
            this.btnNext.Size = new System.Drawing.Size(97, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrv
            // 
            this.btnPrv.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrv.ImagePadding = 3;
            this.btnPrv.Location = new System.Drawing.Point(430, 589);
            this.btnPrv.Name = "btnPrv";
            this.btnPrv.Padding = new System.Windows.Forms.Padding(5);
            this.btnPrv.Size = new System.Drawing.Size(97, 23);
            this.btnPrv.TabIndex = 7;
            this.btnPrv.Text = "Previous";
            this.btnPrv.Click += new System.EventHandler(this.btnPrv_Click);
            // 
            // darkDockPanel1
            // 
            this.darkDockPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.darkDockPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkDockPanel1.Location = new System.Drawing.Point(-1, 579);
            this.darkDockPanel1.Name = "darkDockPanel1";
            this.darkDockPanel1.Size = new System.Drawing.Size(1175, 42);
            this.darkDockPanel1.TabIndex = 8;
            // 
            // btnNext10
            // 
            this.btnNext10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext10.Location = new System.Drawing.Point(644, 589);
            this.btnNext10.Name = "btnNext10";
            this.btnNext10.Padding = new System.Windows.Forms.Padding(5);
            this.btnNext10.Size = new System.Drawing.Size(97, 23);
            this.btnNext10.TabIndex = 4;
            this.btnNext10.Text = "Next 10";
            this.btnNext10.Click += new System.EventHandler(this.btnNext10_Click);
            // 
            // btnPrv10
            // 
            this.btnPrv10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrv10.Location = new System.Drawing.Point(329, 589);
            this.btnPrv10.Name = "btnPrv10";
            this.btnPrv10.Padding = new System.Windows.Forms.Padding(5);
            this.btnPrv10.Size = new System.Drawing.Size(97, 23);
            this.btnPrv10.TabIndex = 5;
            this.btnPrv10.Text = "Previous 10";
            this.btnPrv10.Click += new System.EventHandler(this.btnPrv10_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelect.Location = new System.Drawing.Point(1093, 624);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(81, 30);
            this.btnSelect.TabIndex = 11;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.BackColor = System.Drawing.Color.YellowGreen;
            this.btnOpen.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOpen.Location = new System.Drawing.Point(1092, 0);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(83, 30);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFileName.AutoSize = true;
            this.lblFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblFileName.Location = new System.Drawing.Point(12, 597);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(0, 15);
            this.lblFileName.TabIndex = 14;
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtNotes.Location = new System.Drawing.Point(0, 624);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(1094, 30);
            this.txtNotes.TabIndex = 10;
            // 
            // btnRotateRight
            // 
            this.btnRotateRight.Image = global::ImageSelector.Properties.Resources.image__2_;
            this.btnRotateRight.Location = new System.Drawing.Point(682, 42);
            this.btnRotateRight.Name = "btnRotateRight";
            this.btnRotateRight.Padding = new System.Windows.Forms.Padding(5);
            this.btnRotateRight.Size = new System.Drawing.Size(30, 30);
            this.btnRotateRight.TabIndex = 6;
            this.btnRotateRight.Click += new System.EventHandler(this.btnRotateRight_Click);
            // 
            // btnRotateLeft
            // 
            this.btnRotateLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRotateLeft.Image = global::ImageSelector.Properties.Resources.image__1_1;
            this.btnRotateLeft.Location = new System.Drawing.Point(636, 42);
            this.btnRotateLeft.Name = "btnRotateLeft";
            this.btnRotateLeft.Padding = new System.Windows.Forms.Padding(5);
            this.btnRotateLeft.Size = new System.Drawing.Size(30, 30);
            this.btnRotateLeft.TabIndex = 7;
            this.btnRotateLeft.Click += new System.EventHandler(this.btnRotateLeft_Click);
            // 
            // lblNull
            // 
            this.lblNull.AutoSize = true;
            this.lblNull.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lblNull.Location = new System.Drawing.Point(1070, 30);
            this.lblNull.Name = "lblNull";
            this.lblNull.Size = new System.Drawing.Size(287, 525);
            this.lblNull.TabIndex = 16;
            this.lblNull.Text = resources.GetString("lblNull.Text");
            // 
            // TrackBar
            // 
            this.TrackBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TrackBar.Location = new System.Drawing.Point(235, 36);
            this.TrackBar.Maximum = 6;
            this.TrackBar.Name = "TrackBar";
            this.TrackBar.Size = new System.Drawing.Size(245, 45);
            this.TrackBar.TabIndex = 17;
            this.TrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // frmImageSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 654);
            this.Controls.Add(this.TrackBar);
            this.Controls.Add(this.lblNull);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnPrv10);
            this.Controls.Add(this.btnRotateLeft);
            this.Controls.Add(this.btnNext10);
            this.Controls.Add(this.btnRotateRight);
            this.Controls.Add(this.dgSelectedImages);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrv);
            this.Controls.Add(this.darkDockPanel1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.pbCurrentImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmImageSelector";
            this.Text = "Image Selector";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmImageSelector_FormClosed);
            this.Load += new System.EventHandler(this.frmImageSelector_Load);
            this.DoubleClick += new System.EventHandler(this.frmImageSelector_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImageSelector_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgSelectedImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private DarkUI.Controls.DarkTextBox txtAddress;
        private System.Windows.Forms.DataGridView dgSelectedImages;
        private System.Windows.Forms.PictureBox pbCurrentImage;
        private System.Windows.Forms.DataGridViewImageColumn colImage;
        private System.Windows.Forms.DataGridViewButtonColumn colRemove;
        private DarkUI.Controls.DarkButton btnNext;
        private DarkUI.Controls.DarkButton btnPrv;
        private DarkUI.Docking.DarkDockPanel darkDockPanel1;
        private DarkUI.Controls.DarkButton btnNext10;
        private DarkUI.Controls.DarkButton btnPrv10;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnOpen;
        private DarkUI.Controls.DarkLabel lblFileName;
        private DarkUI.Controls.DarkTextBox txtNotes;
        private DarkUI.Controls.DarkButton btnRotateRight;
        private DarkUI.Controls.DarkButton btnRotateLeft;
        private DarkUI.Controls.DarkLabel lblNull;
        private DarkUI.Controls.DarkButton btnZoomIn;
        private DarkUI.Controls.DarkButton btnZoomOut;
        private System.Windows.Forms.TrackBar TrackBar;
    }
}

