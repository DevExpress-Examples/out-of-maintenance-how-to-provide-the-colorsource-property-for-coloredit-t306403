using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace T306403.CustomColorEdit {
    [ToolboxItem(true)]
    public class CustomColorEdit : ColorEdit {
        static CustomColorEdit() {
            RepositoryItemCustomColorEdit.RegisterCustomColorEdit();
        }
        protected override bool IsAllTabsHidden {
            get {
                return !Properties.ShowCustomColors && !Properties.ShowWebColors && !Properties.ShowSystemColors && !Properties.ShowMyCustomColors;
            }
        }
        public CustomColorEdit() {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomColorEdit Properties {
            get {
                return base.Properties as RepositoryItemCustomColorEdit;
            }
        }
        public override string EditorTypeName {
            get {
                return RepositoryItemCustomColorEdit.CustomEditName;
            }
        }
        protected override PopupBaseForm CreatePopupForm() {
            return new CustomColorEditPopupForm(this);
        }
    }
}
