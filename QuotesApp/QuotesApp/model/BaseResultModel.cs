using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuotesApp.model
{
    public class BaseResultModel<T>
    {
     
            public List<T> Results { get; set; }


    }
}
