using System;
using System.Data;
using System.Web.UI.WebControls;

public partial class Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //Creating Data Table of Products With Three Columns
            DataTable dTable = new DataTable("Products");
            dTable.Columns.Add("ItemName", typeof(string));
            dTable.Columns.Add("ItemPrice", typeof(int));
            dTable.Columns.Add("ItemQuantity", typeof(int));

            //Adding Sample Records
            dTable.Rows.Add("TeleVision", 14999, 1000);
            dTable.Rows.Add("16 GB Pendrive", 499, 2000);
            dTable.Rows.Add("Ear Phones", 99, 500);
            dTable.Rows.Add("Washing Machine", 16499, 100);
            dTable.Rows.Add("AC", 18999, 50);
            dTable.Rows.Add("Water Heater", 19999, 249);
            dTable.Rows.Add("Water Purifier", 13999, 199);
            ViewState["dTable"] = dTable;
            BindGridViewData(dTable, false);
        }
    }

    private void BindGridViewData(DataTable dTable, bool IsRotate = false)
    {
        grdProducts.ShowHeader = true;
        if (IsRotate)
            grdProducts.ShowHeader = false;
        grdProducts.DataSource = dTable;
        grdProducts.DataBind();
        if (IsRotate)
        {
            foreach (GridViewRow row in grdProducts.Rows)
            {
                row.Cells[0].CssClass = "grdhead";
            }
        }
    }
    protected void btnConvertRowstoColumns_Click(object sender, EventArgs e)
    {
        DataTable dTable = (DataTable)ViewState["dTable"];

        if ((sender as Button).CommandArgument == "RowstoColumns")
        {
            DataTable dTable2 = new DataTable();
            for (int i = 0; i <= dTable.Rows.Count; i++)
            {
                dTable2.Columns.Add();
            }
            for (int i = 0; i < dTable.Columns.Count; i++)
            {
                dTable2.Rows.Add();
                dTable2.Rows[i][0] = dTable.Columns[i].ColumnName;
            }
            for (int i = 0; i < dTable.Columns.Count; i++)
            {
                for (int j = 0; j < dTable.Rows.Count; j++)
                {
                    dTable2.Rows[i][j + 1] = dTable.Rows[j][i];
                }
            }
            btnConvertRowstoColumns.Visible = false;
            btnConvertColumnstoRows.Visible = true;
            BindGridViewData(dTable2, true);
        }
        else
        {
            btnConvertRowstoColumns.Visible = true;
            btnConvertColumnstoRows.Visible = false;
            BindGridViewData(dTable, false);
        }
    }
}