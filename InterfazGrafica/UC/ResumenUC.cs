using ObjetosTransferencia.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica.UC
{
    public partial class ResumenUC : UserControl
    {

        private List<PedidoDTO> listaPedidos;

        public ResumenUC(List<PedidoDTO> listaPedidos)
        {
            InitializeComponent();

            // TODO: Añade los campos que se piden al eje X e Y
            //listaPedidos = ControlladorBLL.List

            List<String> x1 = new List<String>();
            List<float> y1 = new List<float>();

            for (int i = 0; i < listaPedidos.Count; i++)
            {
                chart_Pedidos.Series["Series1"].Points.AddXY(listaPedidos[i].FechaPedido, listaPedidos[i].PrecioEnvio);
            }

            chart_Pedidos.Series["Series1"].LegendText = "Gastos de envio";

            // TODO: suma los gastos
        }


        public ResumenUC() {
            InitializeComponent();

        }


    }
}
