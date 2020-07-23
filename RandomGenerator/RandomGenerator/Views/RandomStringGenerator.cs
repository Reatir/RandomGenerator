using RandomGenerator.Models;
using RandomGenerator.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomGenerator.Views
{
    public partial class ViewRandomStringGenerator : Form
    {
        public PresenterRandomStringGenerator _presenter;
        public ViewRandomStringGenerator()
        {
            InitializeComponent();
        }

        private void btplus_Click(object sender, EventArgs e)
        {
            _presenter.OnAddClicked();
        }

        private void btmoins_Click(object sender, EventArgs e)
        {
            _presenter.OnSubtractClicked();
        }

        public void UpdateLabel(int value_)
        {
            label1.Text = value_.ToString();
        }

        private void MenuItemPickNumber_Click(object sender, EventArgs e)
        {
            ModelRandomNumberGenerator model = new ModelRandomNumberGenerator();

            RandomNumberGeneratorView view = new RandomNumberGeneratorView();

            PresenterRandomNumberGenerator presenter = new PresenterRandomNumberGenerator(model, view);

            view.Visible = true;
            this.Visible = false;
        }
    }
}
