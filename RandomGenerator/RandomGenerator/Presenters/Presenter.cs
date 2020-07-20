﻿using RandomGenerator.Models;
using RandomGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGenerator.Presenters
{
    //Transmet les informations entre le model(code metier) et la  view(interface)
    public class Presenter
    {
        private Model model;
        private RandomGeneratorView view;

        //constructeur permettant de relier les differentes parties
        public Presenter(Model model_, RandomGeneratorView view_)
        {
            this.model = model_;
            this.view = view_;

            view._Presenter = this;
        }

        //Code premettant de recuperer les information de l'interface et les transfere au model
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


        //Fonction permettant au model d'agir sur l'interface
        private void UpdateView()
        {
            view.UpdateView(model._Result);
        }


    }
}
