using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Visitor_Login.Helpers;

namespace Challenge_One
{
    public partial class frmMain : RadForm
    {
        private int amount;
        private int gamesCount;
        private int[] arrPrices;
        
        public frmMain()
        {
            InitializeComponent();
            this.tbxAmount.Value = this.tbxGames.Value = this.tbxPrice.Value = null;
        }

        #region Events
        private void btnSetAmount_Click(object sender, EventArgs e)
        {
            this.setAmount();
        }

        private void btnSetGames_Click(object sender, EventArgs e)
        {
            this.setGamesCount();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.AddPrice();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int _currentSumPrice = 0;

            Array.Sort(this.arrPrices);
            for(int i = 0; i < arrPrices.Length; i++)
            {
                if (arrPrices[i] > 0)
                {
                    _currentSumPrice += arrPrices[i];
                    if(_currentSumPrice > this.amount)
                    {
                        HelperUI.InfoMsg($"You can buy {i} games at most");
                        break;
                    }

                    if(i == arrPrices.Length - 1 && _currentSumPrice <= this.amount)
                    {
                        HelperUI.InfoMsg($"You can buy all {this.gamesCount} games");
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.arrPrices = null;
            this.amount = this.gamesCount = 0;
            this.tbxAmount.Value = this.tbxGames.Value = this.tbxPrice.Value = null;
            
            this.tbxAmount.Enabled = this.tbxGames.Enabled = true;
            this.btnSetAmount.Enabled = this.btnSetGames.Enabled = true;
            this.tbxPrice.Enabled = this.btnAdd.Enabled = false;          
            this.tPanel_01_Numbers.Controls.Clear();
        }

        private void tbxAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.setAmount();
        }

        private void tbxGames_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.setGamesCount();
        }

        private void tbxPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.AddPrice();
        }
        #endregion

        #region Methods
        private void setAmount()
        {
            if (this.tbxAmount.Value == null)
            {
                HelperUI.ErrorMsg("Amount cannot be empty");
                return;
            }

            if(!int.TryParse(this.tbxAmount.Text, out this.amount) || amount <= 0)
            {
                HelperUI.ErrorMsg("Invalid Input");
                return;
            }

            this.tbxAmount.Enabled = this.btnSetAmount.Enabled = false;
        }

        private void setGamesCount()
        {
            if (this.tbxGames.Value == null)
            {
                HelperUI.ErrorMsg("Games count cannot be empty");
                return;
            }

            if(!int.TryParse(this.tbxGames.Text, out this.gamesCount) || gamesCount <= 0)
            {
                HelperUI.ErrorMsg("Invalid Input");
                return;
            }

            try
            {
                this.arrPrices = new int[gamesCount];
                //Add labels to table layout panel
                for (int i = 0; i < gamesCount; i++)
                {
                    RadLabel lblEmpty = new RadLabel()
                    {
                        Tag = i,
                        ThemeName = this.ThemeName,
                        AutoSize = false,
                        BackColor = Color.White,
                        Dock = DockStyle.Fill,
                    };
                    lblEmpty.TextAlignment = ContentAlignment.MiddleCenter;
                    this.tPanel_01_Numbers.Controls.Add(lblEmpty);
                }
                this.tbxGames.Enabled = this.btnSetGames.Enabled = false;
                this.tbxPrice.Enabled = this.btnAdd.Enabled = true;
                this.tbxPrice.Focus();
            }
            catch (Exception ex)
            {
                HelperUI.ErrorMsg(ex.ToString());
            }
        }

        private void AddPrice()
        {
            if(this.tbxPrice.Value == null)
            {
                HelperUI.ErrorMsg("Price cannot be empty");
                this.tbxPrice.Focus();
                return;
            }
            //Detect illegal input
            if (!int.TryParse(this.tbxPrice.Text, out int _newPrice) || _newPrice <= 0)
            {
                HelperUI.ErrorMsg("Invalid Input");
                this.tbxPrice.Value = null;
                this.tbxPrice.Focus();
                return;
            }

            if(this.tPanel_01_Numbers.Controls.OfType<RadLabel>()
                .Where(x => x.Text == string.Empty).Count() == 0)
            {
                HelperUI.ErrorMsg($"Already inputed {this.gamesCount} games");
                return;
            }

            try
            {
                //Display inputed price and put them into array
                var _lblEmpty = this.tPanel_01_Numbers.Controls.OfType<RadLabel>()
                    .FirstOrDefault(x => x.Text == string.Empty);
                _lblEmpty.Text = _newPrice.ToString();
                this.arrPrices[(int)_lblEmpty.Tag] = _newPrice;                
            }
            catch (Exception ex)
            {
                HelperUI.ErrorMsg(ex.ToString());
            }
            finally
            {
                this.tbxPrice.Value = null;
                this.tbxPrice.Focus();
            }
        }
        #endregion
    }
}
