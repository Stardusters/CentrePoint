namespace Challenge_Two
{
    partial class frmMain
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
            this.windows11Theme1 = new Telerik.WinControls.Themes.Windows11Theme();
            this.tPanel_00 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxStringOne = new Telerik.WinControls.UI.RadTextBox();
            this.tbxStringTwo = new Telerik.WinControls.UI.RadTextBox();
            this.btnCompare = new Telerik.WinControls.UI.RadButton();
            this.lblResult = new Telerik.WinControls.UI.RadLabel();
            this.tPanel_00.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxStringOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxStringTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCompare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tPanel_00
            // 
            this.tPanel_00.ColumnCount = 4;
            this.tPanel_00.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tPanel_00.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tPanel_00.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tPanel_00.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tPanel_00.Controls.Add(this.tbxStringTwo, 1, 2);
            this.tPanel_00.Controls.Add(this.tbxStringOne, 1, 1);
            this.tPanel_00.Controls.Add(this.btnCompare, 2, 1);
            this.tPanel_00.Controls.Add(this.lblResult, 1, 4);
            this.tPanel_00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tPanel_00.Location = new System.Drawing.Point(0, 0);
            this.tPanel_00.Name = "tPanel_00";
            this.tPanel_00.RowCount = 6;
            this.tPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tPanel_00.Size = new System.Drawing.Size(596, 267);
            this.tPanel_00.TabIndex = 0;
            // 
            // tbxStringOne
            // 
            this.tbxStringOne.AutoSize = false;
            this.tbxStringOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxStringOne.Location = new System.Drawing.Point(24, 12);
            this.tbxStringOne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxStringOne.Name = "tbxStringOne";
            this.tbxStringOne.ShowClearButton = true;
            this.tbxStringOne.Size = new System.Drawing.Size(325, 72);
            this.tbxStringOne.TabIndex = 5;
            this.tbxStringOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxStringOne.ThemeName = "Windows11";
            // 
            // tbxStringTwo
            // 
            this.tbxStringTwo.AutoSize = false;
            this.tbxStringTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxStringTwo.Location = new System.Drawing.Point(25, 93);
            this.tbxStringTwo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbxStringTwo.Name = "tbxStringTwo";
            this.tbxStringTwo.ShowClearButton = true;
            this.tbxStringTwo.Size = new System.Drawing.Size(323, 70);
            this.tbxStringTwo.TabIndex = 10;
            this.tbxStringTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxStringTwo.ThemeName = "Windows11";
            // 
            // btnCompare
            // 
            this.btnCompare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCompare.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompare.Location = new System.Drawing.Point(357, 12);
            this.btnCompare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCompare.Name = "btnCompare";
            this.tPanel_00.SetRowSpan(this.btnCompare, 2);
            this.btnCompare.Size = new System.Drawing.Size(214, 152);
            this.btnCompare.TabIndex = 0;
            this.btnCompare.Text = "Compare";
            this.btnCompare.ThemeName = "Windows11";
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = false;
            this.tPanel_00.SetColumnSpan(this.lblResult, 2);
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResult.Location = new System.Drawing.Point(24, 180);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(547, 72);
            this.lblResult.TabIndex = 15;
            this.lblResult.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResult.ThemeName = "Windows11";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 267);
            this.Controls.Add(this.tPanel_00);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Compare two strings";
            this.ThemeName = "Windows11";
            this.tPanel_00.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbxStringOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxStringTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCompare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Windows11Theme windows11Theme1;
        private System.Windows.Forms.TableLayoutPanel tPanel_00;
        private Telerik.WinControls.UI.RadTextBox tbxStringOne;
        private Telerik.WinControls.UI.RadTextBox tbxStringTwo;
        private Telerik.WinControls.UI.RadButton btnCompare;
        private Telerik.WinControls.UI.RadLabel lblResult;
    }
}

