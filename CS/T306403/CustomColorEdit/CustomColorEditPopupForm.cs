using DevExpress.XtraEditors.Popup;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T306403.CustomColorEdit {
    public class CustomColorEditPopupForm : PopupColorEditForm {
        public CustomColorEditPopupForm(CustomColorEdit ownerEdit)
            : base(ownerEdit) {
        }
        protected override PopupColorEditForm.ColorEditTabControl CreateTabControl() {
            ColorEditTabControl control = base.CreateTabControl();
            if((this.Properties as RepositoryItemCustomColorEdit).ColorSource != null && (this.Properties as RepositoryItemCustomColorEdit).ColorSource.Count != 0) {
                XtraTabPage page = new XtraTabPage();
                page.Text = (this.Properties as RepositoryItemCustomColorEdit).TabName;
                control.TabPages.Add(page);
            }
            return control;
        }
        protected override PopupColorBuilder CreatePopupColorEditBuilder() {
            return new CustomPopupColorBuilder(this);
        }
    }
}
