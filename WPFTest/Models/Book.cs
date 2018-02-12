using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WPFTest.Models
{
    public partial class Book : INotifyPropertyChanged
    {

        int id;
        string title;
        string color;
        string pagesCount;
        bool isPublished;
        private bool _readOnly;
        bool isChanged;
        public bool IsChanged
        {
            get
            {
                return isChanged;
            }
            set
            {
                if (value == isChanged) return;
                isChanged = value;
                OnPropertyChanged();

            }
        }
        [Required(ErrorMessage = "You cannot omit Id")]
        public int Id
        {
            get { return id; }
            set
            {
                if (id == value) return;
                id = value;
                if (ReadOnly) return;

                OnPropertyChanged(nameof(Id));
            }
        }
        [MaxLength(20, ErrorMessage ="Tooo long!!"), Required(ErrorMessage ="You cannot omit Title")]
        public string Title
        {
            get { return title; }
            set
            {
                if (title == value) return;
                title = value;
                if (ReadOnly) return;
                OnPropertyChanged(nameof(Title));
                OnPropertyChanged(nameof(PagesCount));
            }
        }
        [RegularExpression("^[0-9]*$", ErrorMessage ="numbers only"), Required(ErrorMessage = "You cannot omit Pages Count")]
        public string PagesCount
        {
            get { return pagesCount; }
            set
            {
                if (ReadOnly || pagesCount == value) return;

                pagesCount = value;
                OnPropertyChanged(nameof(Title));
                OnPropertyChanged(nameof(PagesCount));
            }
        }
        public string Color
        {
            get { return color; }
            set
            {
                if (ReadOnly || color == value) return;
                color = value;
                OnPropertyChanged(nameof(Color));
            }
        }

        public bool IsPublished
        {
            get { return isPublished; }
            set
            {
                if (ReadOnly || isPublished == value) return;
                isPublished = value;
                OnPropertyChanged(nameof(IsPublished));
            }
        }
        public bool ReadOnly
        {
            get { return _readOnly; }
            set
            {
                if (value == _readOnly)
                    return;

                _readOnly = value;
                OnPropertyChanged(nameof(ReadOnly));
            }
        }


        private void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            if (propertyName != nameof(IsChanged))
                IsChanged = true;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
