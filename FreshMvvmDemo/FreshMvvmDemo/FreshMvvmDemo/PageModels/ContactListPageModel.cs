using FreshMvvm;
using FreshMvvmDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshMvvmDemo.PageModels
{
    public class ContactListPageModel : FreshBasePageModel
    {
        public List<Contact> ContactList { get; set; }

        public Contact SelectedContact {
            get { return null; }
            set
            {
                CoreMethods.PushPageModel<ContactPageModel>(value);
                RaisePropertyChanged();
            }
        }

        public ContactListPageModel()
        {

        }

        public override void Init(object initData)
        {
            base.Init(initData);

            ContactList = new List<Contact>
            {
                new Contact { Id=1121, Name="David Gómez" },
                new Contact { Id=1122, Name="Germán Mono Burgos" },
                new Contact { Id=1123, Name="Diego Pablo Simeone" },
            };
        }
    }
}
