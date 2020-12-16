using CommonServiceLocator;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuotesApp.ViewModels
{
  public  class ViewModelLocator
    {
        public QuotesViewModel QuotesViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<QuotesViewModel>();
            }
        }
    }
}
