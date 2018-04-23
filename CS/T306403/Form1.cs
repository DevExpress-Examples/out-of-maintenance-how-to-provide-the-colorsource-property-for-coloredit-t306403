using DevExpress.Utils.Win;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraTab;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace T306403 {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
        }
        private static DataTable CreateDataTable() {
            DataTable table = new DataTable();
            table.Columns.Add("Column1");
            table.Columns.Add("Column2");
            table.Columns.Add("Column3", typeof(Color));
            table.Rows.Add("One", "Two", Color.Red);
            table.Rows.Add("One", "Two", Color.Blue);
            table.Rows.Add("One", "Two", Color.Green);
            return table;
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.customColorEdit11.Properties.ShowSystemColors = false;
            this.customColorEdit11.Properties.ShowCustomColors = false;
            this.customColorEdit11.Properties.ShowWebColors = false;
            this.customColorEdit11.Properties.ColorSource = new System.Collections.Generic.List<Color>() { Color.Red, Color.Green, Color.Yellow };
            this.repositoryItemCustomColorEdit11.ShowSystemColors = false;
            this.repositoryItemCustomColorEdit11.ShowCustomColors = false;
            this.repositoryItemCustomColorEdit11.ShowWebColors = false;
            this.repositoryItemCustomColorEdit11.ColorSource = new System.Collections.Generic.List<Color>() { Color.Red, Color.Green };
            this.gridControl1.DataSource = CreateDataTable();
        }
    }
}
