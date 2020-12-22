using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyXamarinApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //dataGrid.AllowSorting = true;
            //dataGrid.AllowTriStateSorting = true;
            //dataGrid.AllowMultiSorting = true;
            //dataGrid.SortTapAction = Syncfusion.SfDataGrid.XForms.SortTapAction.DoubleTap;
            //dataGrid.SortColumnDescriptions.Add(new Syncfusion.SfDataGrid.XForms.SortColumnDescription()
            //{
            //    ColumnName = "OrderID",
            //    SortDirection = Syncfusion.Data.ListSortDirection.Descending
            //});

            //dataGrid.SortColumnsChanging += DataGrid_SortColumnsChanging;
        }

        private void DataGrid_SortColumnsChanging(object sender, Syncfusion.SfDataGrid.XForms.DataGridSortColumnsChangingEventArgs e)
        {
            if(e.AddedItems[0].ColumnName == "OrderID")
            {
                e.Cancel = true;
            }
        }
    }
}
