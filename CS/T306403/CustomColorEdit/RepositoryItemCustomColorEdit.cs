using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace T306403.CustomColorEdit {
    [UserRepositoryItem("RegisterCustomColorEdit")]
    public class RepositoryItemCustomColorEdit : RepositoryItemColorEdit {
        static RepositoryItemCustomColorEdit() {
            RegisterCustomColorEdit();
        }
        private IList<Color> _ColorSource;
        private string tabName;


        public const string CustomEditName = "CustomColorEdit";

        public RepositoryItemCustomColorEdit() {
            ShowMyCustomColors = true;
        }
        public IList<Color> ColorSource {
            get { return _ColorSource; }
            set {
                _ColorSource = value;
            }
        }
        public string TabName {
            get {
                if(string.IsNullOrEmpty(tabName)) return "CustomTab";
                else
                    return tabName;
            }
            set { tabName = value; }
        }
        public bool ShowMyCustomColors { get; set; }

        public override string EditorTypeName {
            get {
                return CustomEditName;
            }
        }
        public static void RegisterCustomColorEdit() {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(CustomColorEdit), typeof(RepositoryItemCustomColorEdit), typeof(CustomColorEditViewInfo), new CustomColorEditPainter(), true, img));
        }

        public override void Assign(RepositoryItem item) {
            BeginUpdate();
            try {
                base.Assign(item);
                RepositoryItemCustomColorEdit source = item as RepositoryItemCustomColorEdit;
                if(source == null) return;
                this.ColorSource = source.ColorSource;
                this.ShowMyCustomColors = source.ShowMyCustomColors;
                this.TabName = source.TabName;
                //
            }
            finally {
                EndUpdate();
            }
        }
    }
}
