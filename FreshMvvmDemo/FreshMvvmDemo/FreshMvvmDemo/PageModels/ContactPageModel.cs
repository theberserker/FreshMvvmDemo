using FreshMvvmDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshMvvmDemo.PageModels
{
    public class ContactPageModel : FreshMvvm.FreshBasePageModel
    {
        public Contact Contact { get; set; }

        public ContactPageModel()
        {

        }

        public override void Init(object initData)
        {
            base.Init(initData);

            Contact = initData as Contact;

        }


        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);

            string message = string.Format("Entramos al detalle del contacto {0}", Contact.Name);
            CoreMethods.DisplayAlert("Detalle", message, "Ok");
        }
    }
}
