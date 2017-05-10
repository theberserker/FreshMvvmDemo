﻿using FreshMvvmDemo.Core;

namespace FreshMvvmDemo.Models
{
    public class Participant : NotifyPropertyChangedBase
    {
        private string _name;
        private string _companyName;

        public Participant(int id, string name, string companyName)
        {
            Id = id;
            Name = name;
            CompanyName = companyName;
        }

        public int Id { get; set; }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value; 
                OnPropertyChanged();
            }
        }

        public string CompanyName
        {
            get { return _companyName; }
            set
            {
                _companyName = value;
                OnPropertyChanged();
            }
        }

        public override string ToString()
        {
            return $"{Name} from {CompanyName}";
        }
    }
}
