using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;
namespace Cliente
{
    public partial class consultas : Form
    {
        Socket server;
        
        public consultas(Socket server)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.server = server;
            
        }

      
        private void BotonConsulta_Click(object sender, EventArgs e)
        {
            if ((UsuarioaConsultar.Text != "") && (Consulta.SelectedIndex == 0)) //Queremos saber el número de partidas ganadas del jugador consultado
            {
                string mensaje= "4/" + UsuarioaConsultar.Text;
                // Enviamos al servidor la consulta deseada
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }

            if ((UsuarioaConsultar.Text != "") && (Consulta.SelectedIndex == 1)) //Queremos saber los puntos totales del jugador consultado
            {
                string mensaje = "3/" + UsuarioaConsultar.Text;
                // Enviamos al servidor la consulta deseada
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }

            if ((UsuarioaConsultar.Text != "") && (Consulta.SelectedIndex == 2)) //Queremos saber el número de partidas jugadas del jugador consultado
            {
                string mensaje = "5/" + UsuarioaConsultar.Text;
                // Enviamos al servidor la consulta deseada
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
        }

        //Cómo modificar el texto del resultado de la consulta realizada
        public void ModificarResultadoConsulta(string mensaje)
        {
            Resultado.Text = mensaje;
        }
    }
}
