using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Newtonsoft.Json;
using System.Data;
using System.Text.RegularExpressions;
using System.Text;

namespace Consumidor
{
    public partial class About : Page
    {
        Sref.WebService1SoapClient oClient = new Sref.WebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btn_select_Click(object sender, EventArgs e)
        {
            
            string allData = oClient.get_all_prod();
            
            DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(allData);
            GridView1.DataSource = dataSet;
            GridView1.DataBind();
        }

        protected void btn_insert_Click(object sender, EventArgs e)
        {
            //int id = int.Parse(txtbox_id.Text);
            string cod = txtbox_codigo.Text;
            string nom = txtbox_nombre.Text;
            string marca = txtbox_marca.Text;
            string desc = txtbox_desc.Text;
            double compra = double.Parse(txtbox_compra.Text);
            double venta = double.Parse(txtbox_venta.Text);
            string material = txtbox_material.Text;

            oClient.insert_prod(cod, nom, marca, desc, compra, venta, material);
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtbox_id.Text);
            string cod = txtbox_codigo.Text;
            string nom = txtbox_nombre.Text;
            string marca = txtbox_marca.Text;
            string desc = txtbox_desc.Text;
            double compra = double.Parse(txtbox_compra.Text);
            double venta = double.Parse(txtbox_venta.Text);
            string material = txtbox_material.Text;

            oClient.update_prod(id, cod, nom, marca, desc, compra, venta, material);
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtbox_id.Text);
            oClient.delete_prod(id);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbox_id.Text = (GridView1.SelectedRow.Cells[1].Text.ToString());
            txtbox_codigo.Text = (GridView1.SelectedRow.Cells[2].Text.ToString() );
            txtbox_nombre.Text = (GridView1.SelectedRow.Cells[3].Text.ToString() );
            txtbox_marca.Text = (GridView1.SelectedRow.Cells[4].Text.ToString() );
            txtbox_desc.Text = (GridView1.SelectedRow.Cells[5].Text.ToString() );
            txtbox_compra.Text = (GridView1.SelectedRow.Cells[6].Text.ToString() );
            txtbox_venta.Text = (GridView1.SelectedRow.Cells[7].Text.ToString() );
            txtbox_material.Text = ( GridView1.SelectedRow.Cells[8].Text.Normalize() );
        }
    }
}
