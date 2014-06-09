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
                if (ParentMerchantCategory != null)
                {
                    return String.Format("{0} > {1}", ParentMerchantCategory.Name, Name);
                }
                else
                {
                    return Name;
                }
            }
        }
    }
}
