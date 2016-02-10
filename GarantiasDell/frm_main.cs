using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GarantiasDell.com.dell.xserv;

namespace GarantiasDell
{
    public partial class frm_main : Form
    {
        private Asset[] res = new Asset[0];
        public frm_main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Net.ServicePointManager.Expect100Continue = false;
            txt_servisetag.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscar_datos();    
        }

        private void buscar_datos()
        {
            string servicetag = txt_servisetag.Text;
            if (servicetag == String.Empty)
            {
                lbl_error.Text = "Ingrese un Service Tag";

            }
            else
            {
                try
                {
                    AssetService consulta = new AssetService();
                    System.Guid guid = new Guid("12345678-1234-1234-1234-123456789012");
                    res = consulta.GetAssetInformation(guid, "mio", servicetag);
                    if (res.Length == 0)
                    {
                        lbl_error.Text = "Error con el servicio";
                    }
                    else
                    {
                        llenado_Datos(res);
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }

                lst_garantias.Focus();
            }
        }

        private void llenado_Datos(Asset[] resp)
        {
            ///borrado de datos
            borrado_datos();
            
            ///llenado de datos del equipo
            lbl_modelo.Text = resp[0].AssetHeaderData.SystemModel;
            //lbl_region.Text = resp[0].AssetHeaderData.Region;
            lbl_tipo.Text = resp[0].AssetHeaderData.SystemType;
            lbl_fecha_compra.Text = resp[0].AssetHeaderData.SystemShipDate.ToShortDateString();
        
            ///llenado  de listado de garantias
            foreach (var item in resp[0].Entitlements)
	        {
                string[] info_garantia = new string[] { item.ServiceLevelDescription.ToString(), item.EntitlementType.ToString(),item.StartDate.ToShortDateString(),item.EndDate.ToShortDateString(), item.DaysLeft.ToString() };
		        ListViewItem garantia = new ListViewItem(info_garantia);
                lst_garantias.Items.Add(garantia);
	        }

        }

        private void borrado_datos()
        {
            lst_garantias.Items.Clear();
            lbl_fecha_compra.Text = String.Empty;
            lbl_modelo.Text = String.Empty;
            lbl_tipo.Text = String.Empty;
            lbl_error.Text = String.Empty;
        }

        private void txt_servisetag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buscar_datos();
            } 
        }
    }
}
