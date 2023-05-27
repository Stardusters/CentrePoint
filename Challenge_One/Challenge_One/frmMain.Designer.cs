namespace Challenge_One
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
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.tPanel_00 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSetGames = new Telerik.WinControls.UI.RadButton();
            this.tbxGames = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.tbxPrice = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.tPanel_01_Numbers = new System.Windows.Forms.TableLayoutPanel();
            this.btnSetAmount = new Telerik.WinControls.UI.RadButton();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.btnCalculate = new Telerik.WinControls.UI.RadButton();
            this.btnReset = new Telerik.WinControls.UI.RadButton();
            this.tbxAmount = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.tPanel_00.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalculate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tPanel_00
            // 
            this.tPanel_00.ColumnCount = 2;
            this.tPanel_00.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tPanel_00.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tPanel_00.Controls.Add(this.btnSetGames, 1, 1);
            this.tPanel_00.Controls.Add(this.tbxGames, 0, 1);
            this.tPanel_00.Controls.Add(this.tbxPrice, 0, 2);
            this.tPanel_00.Controls.Add(this.tPanel_01_Numbers, 0, 3);
            this.tPanel_00.Controls.Add(this.btnSetAmount, 1, 0);
            this.tPanel_00.Controls.Add(this.btnAdd, 1, 2);
            this.tPanel_00.Controls.Add(this.btnCalculate, 1, 3);
            this.tPanel_00.Controls.Add(this.btnReset, 1, 4);
            this.tPanel_00.Controls.Add(this.tbxAmount, 0, 0);
            this.tPanel_00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tPanel_00.Location = new System.Drawing.Point(0, 0);
            this.tPanel_00.Name = "tPanel_00";
            this.tPanel_00.RowCount = 5;
            this.tPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tPanel_00.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tPanel_00.Size = new System.Drawing.Size(504, 464);
            this.tPanel_00.TabIndex = 0;
            // 
            // btnSetGames
            // 
            this.btnSetGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetGames.Location = new System.Drawing.Point(374, 104);
            this.btnSetGames.Margin = new System.Windows.Forms.Padding(24, 24, 24, 24);
            this.btnSetGames.Name = "btnSetGames";
            this.btnSetGames.Size = new System.Drawing.Size(106, 32);
            this.btnSetGames.TabIndex = 10;
            this.btnSetGames.Text = "Set";
            this.btnSetGames.ThemeName = "Crystal";
            this.btnSetGames.Click += new System.EventHandler(this.btnSetGames_Click);
            // 
            // tbxGames
            // 
            this.tbxGames.AutoSize = false;
            this.tbxGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxGames.Location = new System.Drawing.Point(10, 90);
            this.tbxGames.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.tbxGames.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.tbxGames.Name = "tbxGames";
            this.tbxGames.NullText = "Step 2: Input numbers of games (N)";
            this.tbxGames.Size = new System.Drawing.Size(330, 60);
            this.tbxGames.TabIndex = 5;
            this.tbxGames.TabStop = false;
            this.tbxGames.Text = "0";
            this.tbxGames.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxGames.ThemeName = "Crystal";
            this.tbxGames.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxGames_KeyDown);
            // 
            // tbxPrice
            // 
            this.tbxPrice.AutoSize = false;
            this.tbxPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPrice.Enabled = false;
            this.tbxPrice.Location = new System.Drawing.Point(10, 170);
            this.tbxPrice.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.tbxPrice.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.NullText = "Step 3: Input Price Here";
            this.tbxPrice.Size = new System.Drawing.Size(330, 60);
            this.tbxPrice.TabIndex = 15;
            this.tbxPrice.TabStop = false;
            this.tbxPrice.Text = "0";
            this.tbxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPrice.ThemeName = "Crystal";
            this.tbxPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxPrice_KeyDown);
            // 
            // tPanel_01_Numbers
            // 
            this.tPanel_01_Numbers.BackColor = System.Drawing.Color.Gainsboro;
            this.tPanel_01_Numbers.ColumnCount = 3;
            this.tPanel_01_Numbers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tPanel_01_Numbers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tPanel_01_Numbers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tPanel_01_Numbers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tPanel_01_Numbers.Location = new System.Drawing.Point(3, 243);
            this.tPanel_01_Numbers.Name = "tPanel_01_Numbers";
            this.tPanel_01_Numbers.RowCount = 4;
            this.tPanel_00.SetRowSpan(this.tPanel_01_Numbers, 2);
            this.tPanel_01_Numbers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tPanel_01_Numbers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tPanel_01_Numbers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tPanel_01_Numbers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tPanel_01_Numbers.Size = new System.Drawing.Size(344, 218);
            this.tPanel_01_Numbers.TabIndex = 7;
            // 
            // btnSetAmount
            // 
            this.btnSetAmount.Location = new System.Drawing.Point(369, 19);
            this.btnSetAmount.Margin = new System.Windows.Forms.Padding(19, 19, 19, 19);
            this.btnSetAmount.Name = "btnSetAmount";
            this.btnSetAmount.Size = new System.Drawing.Size(116, 42);
            this.btnSetAmount.TabIndex = 0;
            this.btnSetAmount.Text = "Set";
            this.btnSetAmount.ThemeName = "Crystal";
            this.btnSetAmount.Click += new System.EventHandler(this.btnSetAmount_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(374, 184);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(24, 24, 24, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 32);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.ThemeName = "Crystal";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(374, 264);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(24, 24, 24, 24);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(106, 96);
            this.btnCalculate.TabIndex = 25;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.ThemeName = "Crystal";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(374, 408);
            this.btnReset.Margin = new System.Windows.Forms.Padding(24, 24, 24, 24);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 32);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "Reset";
            this.btnReset.ThemeName = "Crystal";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbxAmount
            // 
            this.tbxAmount.AutoSize = false;
            this.tbxAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxAmount.Location = new System.Drawing.Point(8, 8);
            this.tbxAmount.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tbxAmount.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.NullText = "Step 1: Input Amount Here (K)";
            this.tbxAmount.Size = new System.Drawing.Size(334, 64);
            this.tbxAmount.TabIndex = 35;
            this.tbxAmount.TabStop = false;
            this.tbxAmount.Text = "0";
            this.tbxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxAmount.ThemeName = "Crystal";
            this.tbxAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxAmount_KeyDown);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 464);
            this.Controls.Add(this.tPanel_00);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Games";
            this.ThemeName = "Crystal";
            this.tPanel_00.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSetGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalculate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private System.Windows.Forms.TableLayoutPanel tPanel_00;
        private Telerik.WinControls.UI.RadButton btnSetAmount;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadButton btnCalculate;
        private Telerik.WinControls.UI.RadButton btnReset;
        private System.Windows.Forms.TableLayoutPanel tPanel_01_Numbers;
        private Telerik.WinControls.UI.RadMaskedEditBox tbxPrice;
        private Telerik.WinControls.UI.RadMaskedEditBox tbxAmount;
        private Telerik.WinControls.UI.RadButton btnSetGames;
        private Telerik.WinControls.UI.RadMaskedEditBox tbxGames;
    }
}

