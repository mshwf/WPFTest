﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFTest.Models
{
    public class Inventory : INotifyPropertyChanged
    {
        int _carId;
        public int CarId
        {
            get
            { return _carId; }
            set
            {
                if (value == _carId) return;
                _carId = value;
                OnPropertyChanged();
            }
        }

        string _make;
        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                if (value == _make) return;
                _make = value;
                OnPropertyChanged();
            }
        }
        string _color;
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                if (value == _color) return;
                _color = value;
                OnPropertyChanged();
            }
        }
        string _petName;
        public string PetName
        {
            get
            {
                return _petName;
            }
            set
            {
                if (value == _petName) return;
                _petName = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        internal void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
