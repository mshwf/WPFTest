using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTest.Models
{
    partial class Book : EntityBase, IDataErrorInfo
    {
        public string Error => "";
        public string this[string columnName]
        {
            get
            {
                bool hasError = false;
                string[] errors = null;
                switch (columnName)
                {

                    case nameof(Id):
                        errors = GetErrorsFromAnnotations(nameof(Id), Id);
                        if (errors != null && errors.Length != 0)
                        {
                            AddErrors(nameof(Id), errors);
                            hasError = true;
                        }
                        if (Id >= 1000)
                        {

                            AddError(nameof(Id), "No Id GT 1000 allowed");
                            hasError = true;
                        }
                        if (!hasError) ClearErrors(nameof(Id));
                        break;
                    case nameof(Title):
                        errors = GetErrorsFromAnnotations(nameof(Title), Title);
                        if (errors != null && errors.Length != 0)
                        {
                            AddErrors(nameof(Title), errors);
                            hasError = true;
                        }
                        if (Title == "N")
                        {
                            AddError(nameof(Title), "Annoying");
                            hasError = true;
                        }
                        else
                            if (CheckNameAndPages()) hasError = true;

                        if (!hasError)
                            ClearErrors(nameof(Title));
                        break;
                    case nameof(PagesCount):
                        errors = GetErrorsFromAnnotations(nameof(PagesCount), PagesCount);
                        if (errors != null && errors.Length != 0)
                        {
                            AddErrors(nameof(PagesCount), errors);
                            hasError = true;
                        }
                        hasError = CheckNameAndPages();

                        if (!hasError)
                            ClearErrors(nameof(PagesCount));

                        break;
                    case nameof(Color):
                        errors = GetErrorsFromAnnotations(nameof(Color), Color);
                        if (errors != null && errors.Length != 0)
                        {
                            AddErrors(nameof(Color), errors);
                            hasError = true;
                        }
                        if (Color == "Orange")
                        {
                            AddError(nameof(Color), "It's summer, Orange is HOT!");
                            hasError = true;
                        }
                        if (!hasError) ClearErrors(nameof(Color));
                        break;
                }

                return "";
            }
        }
        bool CheckNameAndPages()
        {
            if (Title == "s" && PagesCount == "3")
            {
                AddError(nameof(Title), "SS and 33 not compatible");
                AddError(nameof(PagesCount), "SS and 33 not compatible");
                return true;
            }
            return false;
        }
    }
}
