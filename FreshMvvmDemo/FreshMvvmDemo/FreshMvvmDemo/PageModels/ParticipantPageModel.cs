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
    }
}
