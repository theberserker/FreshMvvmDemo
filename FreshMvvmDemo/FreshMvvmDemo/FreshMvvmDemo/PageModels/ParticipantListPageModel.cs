﻿using System;
using Acr.UserDialogs;
using FreshMvvm;
using FreshMvvmDemo.Models;
using FreshMvvmDemo.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FreshMvvmDemo.PageModels
{
    public class ParticipantListPageModel : FreshBasePageModel
    {
        private readonly IParticipantsService _participantsService;

        private readonly IUserDialogs _userDialogs;

        private ICommand _raffleCommand;

        public IList<Participant> ParticipantList { get; set; }

        public Participant SelectedParticipant
        {
            get { return null; }
            set
            {
                if (value != null)
                {
                    CoreMethods.PushPageModel<ParticipantPageModel>(value);
                    RaisePropertyChanged();
                }
            }
        }

        public ParticipantListPageModel(IParticipantsService participantsService, IUserDialogs userDialogs)
        {
            this._participantsService = participantsService;
            this._userDialogs = userDialogs;
        }

        public override async void Init(object initData)
        {
            base.Init(initData);
            _userDialogs.ShowLoading();
            ParticipantList = (await _participantsService.GetAll()).ToList();
            RaisePropertyChanged(nameof(ParticipantList));
            _userDialogs.HideLoading();
        }

        public ICommand RaffleCommand
        {
            get { return _raffleCommand ?? (_raffleCommand = new Command(async arg => await Raffle(arg))); }
        }

        private async Task Raffle(object arg)
        {
            var random = new Random();
            int winnerIndex = random.Next(0, ParticipantList.Count);
            var winner = ParticipantList[winnerIndex];
            await CoreMethods.DisplayAlert("And the winner is....", winner.ToString() , "Ok");
        }
    }
}
