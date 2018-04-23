using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T306403.CustomColorEdit {
    public class CustomColorEditViewInfo : ColorEditViewInfo {
        public CustomColorEditViewInfo(RepositoryItem item)
            : base(item) {
        }
    }
}
