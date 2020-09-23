using System;
using System.Collections.Generic;
using System.Text;

namespace QuotesApp
{
   public class PageAViewModel
    {

        private string loginName;

        public string LoginName
        {
            get { return loginName; }
            set { loginName = value; }
        }

        public PageAViewModel(string param)
        {
            loginName = param;

        }
    }
}
