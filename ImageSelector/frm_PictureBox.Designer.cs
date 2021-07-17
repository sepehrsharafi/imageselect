
namespace ImageSelector
{
    partial class frm_PictureBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PictureBox));
            this.frm1_PictureBox = new System.Windows.Forms.PictureBox();
            this.txtNotes = new DarkUI.Controls.DarkTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.frm1_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // frm1_PictureBox
            // 
            this.frm1_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm1_PictureBox.InitialImage = null;
            this.frm1_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.frm1_PictureBox.Name = "frm1_PictureBox";
            this.frm1_PictureBox.Size = new System.Drawing.Size(1080, 575);
            this.frm1_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frm1_PictureBox.TabIndex = 0;
            this.frm1_PictureBox.TabStop = false;
            this.frm1_PictureBox.Click += new System.EventHandler(this.frm1_PictureBox_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtNotes.Location = new System.Drawing.Point(0, 545);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(997, 30);
            this.txtNotes.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(997, 545);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 30);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frm_PictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1080, 575);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.frm1_PictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_PictureBox";
            this.Text = "Selected Image Preview";
            this.Load += new System.EventHandler(this.frm_PictureBox_Load);
            this.DoubleClick += new System.EventHandler(this.frm_PictureBox_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.frm1_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox frm1_PictureBox;
        private DarkUI.Controls.DarkTextBox txtNotes;
        private System.Windows.Forms.Button btnSave;
    }
}