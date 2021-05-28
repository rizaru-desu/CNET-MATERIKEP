namespace APPS
{
    partial class XtraFormData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormData));
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel = new Telerik.WinControls.UI.RadLabel();
            this.stackPanel2 = new DevExpress.Utils.Layout.StackPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.stackPanel3 = new DevExpress.Utils.Layout.StackPanel();
            this.radTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.btn_Refresh = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridViewDB = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).BeginInit();
            this.stackPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel3)).BeginInit();
            this.stackPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).BeginInit();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.radLabel1);
            this.stackPanel1.Controls.Add(this.dataGridViewDB);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.stackPanel1.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.stackPanel1.Location = new System.Drawing.Point(283, 0);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(493, 577);
            this.stackPanel1.TabIndex = 1;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(217, 3);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(58, 31);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "<html><span style=\"font-size: 16pt; font-family: segoe ui light\"><strong>Daftar</" +
    "strong></span></html>";
            // 
            // radLabel
            // 
            this.radLabel.AutoSize = false;
            this.radLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel.Location = new System.Drawing.Point(39, 248);
            this.radLabel.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.radLabel.Name = "radLabel";
            this.radLabel.Size = new System.Drawing.Size(204, 78);
            this.radLabel.TabIndex = 2;
            this.radLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stackPanel2
            // 
            this.stackPanel2.Controls.Add(this.pictureBox);
            this.stackPanel2.Controls.Add(this.radLabel);
            this.stackPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel2.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.stackPanel2.Location = new System.Drawing.Point(0, 0);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(283, 542);
            this.stackPanel2.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(41, 25);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 200);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // stackPanel3
            // 
            this.stackPanel3.Controls.Add(this.radTextBox);
            this.stackPanel3.Controls.Add(this.btn_Refresh);
            this.stackPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel3.Location = new System.Drawing.Point(0, 542);
            this.stackPanel3.Name = "stackPanel3";
            this.stackPanel3.Size = new System.Drawing.Size(283, 35);
            this.stackPanel3.TabIndex = 5;
            // 
            // radTextBox
            // 
            this.radTextBox.Location = new System.Drawing.Point(3, 7);
            this.radTextBox.Name = "radTextBox";
            this.radTextBox.Size = new System.Drawing.Size(207, 20);
            this.radTextBox.TabIndex = 0;
            this.radTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RadTextBox_KeyPress);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(216, 6);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(61, 23);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // dataGridViewDB
            // 
            this.dataGridViewDB.AllowUserToAddRows = false;
            this.dataGridViewDB.AllowUserToDeleteRows = false;
            this.dataGridViewDB.AllowUserToResizeRows = false;
            this.dataGridViewDB.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewDB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDB.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewDB.Location = new System.Drawing.Point(21, 40);
            this.dataGridViewDB.MultiSelect = false;
            this.dataGridViewDB.Name = "dataGridViewDB";
            this.dataGridViewDB.RowHeadersVisible = false;
            this.dataGridViewDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDB.Size = new System.Drawing.Size(450, 520);
            this.dataGridViewDB.TabIndex = 6;
            this.dataGridViewDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDB_CellClick);
            this.dataGridViewDB.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDB_CellDoubleClick);
            // 
            // XtraFormData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 577);
            this.Controls.Add(this.stackPanel2);
            this.Controls.Add(this.stackPanel3);
            this.Controls.Add(this.stackPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XtraFormData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List";
            this.Load += new System.EventHandler(this.XtraFormData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            this.stackPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).EndInit();
            this.stackPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel3)).EndInit();
            this.stackPanel3.ResumeLayout(false);
            this.stackPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel;
        private DevExpress.Utils.Layout.StackPanel stackPanel2;
        private System.Windows.Forms.PictureBox pictureBox;
        private DevExpress.Utils.Layout.StackPanel stackPanel3;
        private Telerik.WinControls.UI.RadTextBox radTextBox;
        private DevExpress.XtraEditors.SimpleButton btn_Refresh;
        private System.Windows.Forms.DataGridView dataGridViewDB;
    }
}