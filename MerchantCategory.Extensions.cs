using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelectedHotelsModel
{
    public partial class MerchantCategory
    {
        public string FullName
        {
            get
            {
                return String.Format("{0} > {1}", ParentName, Name);
            }
        }
    }
}
