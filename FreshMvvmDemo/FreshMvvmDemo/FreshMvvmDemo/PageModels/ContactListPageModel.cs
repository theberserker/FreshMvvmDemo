using Acr.UserDialogs;
using FreshMvvm;
using FreshMvvmDemo.Models;
using FreshMvvmDemo.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshMvvmDemo.PageModels
{
    public class ContactListPageModel : FreshBasePageModel
    {
        public IEnumerable<Contact> ContactList { get; set; }

        public Contact SelectedContact
        {
            get { return null; }
            set
            {
                CoreMethods.PushPageModel<ContactPageModel>(value);
                RaisePropertyChanged();
            }
        }

        IContactsService contactsService;

        IUserDialogs userDialogs;

        public ContactListPageModel(IContactsService contactsService, IUserDialogs userDialogs)
        {
            this.contactsService = contactsService;
            this.userDialogs = userDialogs;
        }

        public async override void Init(object initData)
        {
            base.Init(initData);
            userDialogs.ShowLoading();
            ContactList = await contactsService.GetContacts();
            RaisePropertyChanged("ContactList");
            userDialogs.HideLoading();
        }
    }
}
