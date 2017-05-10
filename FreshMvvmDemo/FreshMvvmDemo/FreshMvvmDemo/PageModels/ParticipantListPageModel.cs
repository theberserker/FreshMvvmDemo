using Acr.UserDialogs;
using FreshMvvm;
using FreshMvvmDemo.Models;
using FreshMvvmDemo.Services;
using System.Collections.Generic;

namespace FreshMvvmDemo.PageModels
{
    public class ParticipantListPageModel : FreshBasePageModel
    {
        public IEnumerable<Participant> ParticipantList { get; set; }

        public Participant SelectedParticipant
        {
            get { return null; }
            set
            {
                CoreMethods.PushPageModel<ParticipantPageModel>(value);
                RaisePropertyChanged();
            }
        }

        readonly IParticipantsService _participantsService;

        readonly IUserDialogs _userDialogs;

        public ParticipantListPageModel(IParticipantsService participantsService, IUserDialogs userDialogs)
        {
            this._participantsService = participantsService;
            this._userDialogs = userDialogs;
        }

        public override async void Init(object initData)
        {
            base.Init(initData);
            _userDialogs.ShowLoading();
            ParticipantList = await _participantsService.GetAll();
            RaisePropertyChanged(nameof(ParticipantList));
            _userDialogs.HideLoading();
        }
    }
}
