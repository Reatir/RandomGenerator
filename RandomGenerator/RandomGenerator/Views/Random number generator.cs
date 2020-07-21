using RandomGenerator.Presenters;
using System;
using System.Windows.Forms;

namespace RandomGenerator
{
    public partial class RandomNumberGeneratorView : Form
    {
        public PresenterRandomNumberGenerator _Presenter { get; set; }



        public RandomNumberGeneratorView()
        {
            InitializeComponent();
        }

        private void txtBotLimit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _Presenter.OnBotLimitChanged(int.Parse(txtBotLimit.Text));
            }
            catch (Exception)
            {

                MessageBox.Show("la borne basse n'est pas un entier");
            }
        }

        private void txtTopLimit_TextChanged(object sender, EventArgs e)
        {

            try
            {
                _Presenter.OnTopLimitChanged(int.Parse(txtTopLimit.Text));
            }
            catch (Exception)
            {

                MessageBox.Show("la borne haute n'est pas un entier");
            }
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            if(txtBotLimit.Text != "" && txtTopLimit.Text !="" )
            {
                _Presenter.OnGenerateClicked();
            }
            else
            {
                MessageBox.Show("Le champ des bornes ne doivent pas être laisser vide");
            }
           
        }

        public  void UpdateView(int result_)
        {
            lblResult.Text = result_.ToString();
        }

        private void MenuItemPickNumber_Click(object sender, EventArgs e)
        {

        }

        private void MenuItemPickString_Click(object sender, EventArgs e)
        {

        }

        private void MenuItemSortList_Click(object sender, EventArgs e)
        {

        }
    }
}
