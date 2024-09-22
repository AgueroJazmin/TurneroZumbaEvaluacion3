using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurneroZumbaEvaluacion3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Aca agrego los dias y turnos de los combox
            //que quiero ofrecer del turnero de Zumba
            cbDias.Items.Add("Martes");
            cbDias.Items.Add("Jueves");

            cbTurnos.Items.Add("Mañana");
            cbTurnos.Items.Add("Tarde");
            cbTurnos.Items.Add("Noche");


            lblSalida.Text = "";
        }

        List<Turno> listaTurnos = new List<Turno>();
        private void btAgendar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string dia = cbDias.SelectedItem.ToString();
            string turno = cbTurnos.SelectedItem.ToString();
            string horario = cbHorarios.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(nombre) || 
                string.IsNullOrEmpty(dia) || 
                string.IsNullOrEmpty(turno) || 
                string.IsNullOrEmpty(horario))
            {
                MessageBox.Show("Por favor, complete todos los datos.");
                return;
            }

            Turno nuevoTurno = new Turno(nombre, dia, turno, horario);
            listaTurnos.Add(nuevoTurno);

            // Aca quiero mostrar todos los turnos
            // agendados usando un ciclo
            string mensaje = "Turnos agendados:\n";
            //El foreach es otra forma de repeticion que 
            //itera sobre una colección de elementos
            //"t" va a contener cada elemento de la lista y cuando
            //la llame me va a mostrar cada elemento que tiene
            foreach (Turno t in listaTurnos)
            {
                mensaje += $"{t.Nombre} agendaste un turno el {t.Dia}, " +
                    $"turno de {t.TurnoDelDia} a las {t.Horario}\n";
            }

            MessageBox.Show(mensaje);

            LimpiarTxt();
            lblSalida.Text = ArmarSalida();
        }


        //Esto seria un subproceso como en PsInt, que va a ser privado por lo cual nomas funcionara
        //en esta clase, y tambien sera void, es decir no devolvera nada
        private void LimpiarTxt()
        {
            txtNombre.Text = "";
            cbDias.Text = "";
            cbTurnos.Text = "";
            cbHorarios.Text = "";
            txtNombre.Focus();
        }

        private string ArmarSalida()
        {
            //string salida = lblSalida.Text + "\r\n" + listaTurnos.ToString();
            //La linea esta  no sirve porque
            //ToString() de una lista simplemente devuelve el nombre del tipo
            //y no los elementos de la lista.
            string salida = lblSalida.Text + "\r\n";
            foreach (Turno t in listaTurnos)
            {
                salida += $"{t.Nombre} agendaste un turno el" +
                    $" {t.Dia}, turno de " +
                    $"{t.TurnoDelDia} a las {t.Horario}\n";
            }
            return salida;
        }

        private void cbTurnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHorarios.Items.Clear();

            string turnoSeleccionado = cbTurnos.SelectedItem.ToString();

            if (turnoSeleccionado == "Mañana")
            {
                cbHorarios.Items.Add("08:30");
                cbHorarios.Items.Add("09:30");
            }
            else if (turnoSeleccionado == "Tarde")
            {
                cbHorarios.Items.Add("16:30");
                cbHorarios.Items.Add("17:30");
            }
            else if (turnoSeleccionado == "Noche")
            {
                cbHorarios.Items.Add("19:30");
                cbHorarios.Items.Add("20:30");
            }
        }
    }
}
