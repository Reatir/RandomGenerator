using RandomGenerator.Models;
using RandomGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGenerator.Presenters
{
    public class Presenter
    {
        private Model model;
        private RandomGeneratorView view;

        public Presenter(Model model_, RandomGeneratorView view_)
        {
            this.model = model_;
            this.view = view_;

            view._Presenter = this;
        }

        public void OnTopLimitChanged(int nb_)
        {
            model._TopLimit = nb_;
        }

        public void OnBotLimitChanged(int nb_)
        {
            model._BotLimit = nb_;
        }

        public void OnGenerateClicked()
        {
            model.GenerateRandomNumber();
            UpdateView();
        }

        private void UpdateView()
        {
            view.UpdateView(model._Result);
        }


    }
}
