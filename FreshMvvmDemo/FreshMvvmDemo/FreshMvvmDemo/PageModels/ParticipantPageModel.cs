using FreshMvvmDemo.Models;
using System;
using FreshMvvm;

namespace FreshMvvmDemo.PageModels
{
    public class ParticipantPageModel : FreshBasePageModel
    {
        public Participant Participant { get; set; }

        public ParticipantPageModel()
        {

        }

        public override void Init(object initData)
        {
            base.Init(initData);

            Participant = initData as Participant;

        }


        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);

            string message = string.Format("Entramos al detalle del contacto {0}", Participant.Name);
            CoreMethods.DisplayAlert("Detalle", message, "Ok");
        }
    }
}
