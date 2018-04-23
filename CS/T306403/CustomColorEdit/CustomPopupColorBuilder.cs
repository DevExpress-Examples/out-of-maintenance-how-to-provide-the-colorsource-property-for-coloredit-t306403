using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace T306403.CustomColorEdit {
    public class CustomPopupColorBuilder : PopupColorBuilder {
        public CustomPopupColorBuilder(IPopupColorEdit edit)
            : base(edit) {

        }
        protected override void SetTabPageProperties(int pageIndex, PopupBaseForm shadowForm) {
            if(pageIndex == 3) {
                XtraTabPage tabPage = this.TabControl.TabPages[pageIndex];
                ColorListBox colorBox = CreateColorListBox();
                colorBox.HighlightedItemStyle = Properties.HighlightedItemStyle;
                object[] colors = new object[(this.Properties as RepositoryItemCustomColorEdit).ColorSource.Count];
                for(int i = 0; i < colors.Length; i++) {
                    colors[i] = (this.Properties as RepositoryItemCustomColorEdit).ColorSource[i];
                }
                colorBox.Items.AddRange(colors);
                colorBox.EnterColor += new EnterColorEventHandler(OnEnterColor);
                colorBox.SelectedIndexChanged += new EventHandler(OnSelectedIndexChanged);
                colorBox.Size = GetBestListBoxSize(colorBox);
                tabPage.PageVisible = (this.Properties as RepositoryItemCustomColorEdit).ShowMyCustomColors;
                colorBox.Dock = DockStyle.Fill;
                colorBox.BorderStyle = BorderStyles.NoBorder;
                if(Owner.LookAndFeel != null)
                    colorBox.LookAndFeel.Assign(Owner.LookAndFeel);
                tabPage.Controls.Add(colorBox);
                return;
            }
            base.SetTabPageProperties(pageIndex, shadowForm);
        }
    }
}
