using RandomGenerator.Models;
using RandomGenerator.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGenerator.Presenters
{
    public class PresenterRandomStringGenerator
    {
        private ViewRandomStringGenerator view;
        private ModelRandomStringGenerator model;

        public PresenterRandomStringGenerator(ViewRandomStringGenerator view_, ModelRandomStringGenerator model_)
        {
            this.view = view_;
            this.model = model_;

            view._presenter = this;
        }

        public void OnAddClicked()
        {
            model.Add();
            UpdateLabel();
        }

        public void OnSubtractClicked()
        {
            model.Subtract();
            UpdateLabel();
        }

        private void UpdateLabel()
        {
            view.UpdateLabel(model.Nb);
        }
    }
}
