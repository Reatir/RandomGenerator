using RandomGenerator.Presenters;
using System;
using System.Windows.Forms;

namespace RandomGenerator
{
    public partial class RandomGeneratorView : Form
    {
        public Presenter _Presenter { get; set; }



        public RandomGeneratorView()
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

            _Presenter.OnGenerateClicked();
        }

        public  void UpdateView(int result_)
        {
            lblResult.Text = result_.ToString();
        }
    }
}
