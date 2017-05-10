using Acr.UserDialogs;
using FreshMvvm;
using FreshMvvmDemo.Models;
using FreshMvvmDemo.Services;
using System.Collections.Generic;

namespace FreshMvvmDemo.PageModels
{
    public class ParticipantListPageModel : FreshBasePageModel
    {
        public IEnumerable<Participant> ContactList { get; set; }

        public Participant SelectedParticipant
        {
            get { return null; }
            set
            {
                CoreMethods.PushPageModel<ParticipantPageModel>(value);
                RaisePropertyChanged();
            }
        }

        readonly IParticipantsService participantsService;

        readonly IUserDialogs _userDialogs;

        public ParticipantListPageModel(IParticipantsService participantsService, IUserDialogs userDialogs)
        {
            this.participantsService = participantsService;
            this._userDialogs = userDialogs;
        }

        public override async void Init(object initData)
        {
            base.Init(initData);
            _userDialogs.ShowLoading();
            ContactList = await participantsService.GetContacts();
            RaisePropertyChanged(nameof(ContactList));
            _userDialogs.HideLoading();
        }
    }
}
