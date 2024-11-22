using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExerciseTracker
{
    public partial class Main : Form
    {
        private DateTime fechaSeleccionada = new DateTime(1900, 1, 1);
        private Dictionary<DateTime, String> bitacora = new Dictionary<DateTime, string>();
        private List<Rutina> rutinas = new List<Rutina>();
        private int rutinaSeleccionada = -1;

        private enum DiasDeLaSemana
        {
            Domingo,
            Lunes,
            Martes,
            Miercoles,
            Jueves,
            Viernes,
            Sabado,
            SEMANA_LENGTH
        }

        private class Ejercicio
        {
            public String Nombre { get; set; }
            public double Peso { get; set; }
            public int Repeticiones { get; set; }
        }

        private class Rutina
        {
            public String Nombre;
            public Ejercicio[][] ejerciciosPorDia = new Ejercicio[(int)DiasDeLaSemana.SEMANA_LENGTH][];
        }

        public Main()
        {
            InitializeComponent();
            UpdateRoutineComboBox();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            fechaSeleccionada = e.Start;
            string bitacoraString;

            if (bitacora.TryGetValue(fechaSeleccionada, out bitacoraString))
            {
                bitacoraTextBox.Text = bitacoraString;
            }
            else
            {
                bitacoraTextBox.Text = string.Empty;
            }

            if (rutinas == null || rutinas.Count <= rutinaSeleccionada || rutinas[rutinaSeleccionada] == null)
            {
                ejercicioGridView.DataSource = null;
                ejercicioGridView.Refresh();
                return;
            }

            var ejercicios = rutinas[rutinaSeleccionada].ejerciciosPorDia[(int)fechaSeleccionada.DayOfWeek];

            if (ejercicios != null && ejercicios.Length > 0)
            {
                ejercicioGridView.DataSource = ejercicios;

            }
            else
            {
                ejercicioGridView.DataSource = null;
            }
        }

        private void guardarBitácoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bitacoraTextBox.Text.Length == 0 || fechaSeleccionada == new DateTime(1900, 1, 1))
            {
                return;
            }

            bitacora.Add(fechaSeleccionada, bitacoraTextBox.Text);
        }

        private void GuardarEjercicio_Click(object sender, EventArgs e)
        {
            if (rutinaSeleccionada == -1)
            {
                
                Rutina nuevaRutina = new Rutina
                {
                    Nombre = "Primera Rutina",
                    ejerciciosPorDia = new Ejercicio[(int)DiasDeLaSemana.SEMANA_LENGTH][]
                };

              
                for (int i = 0; i < (int)DiasDeLaSemana.SEMANA_LENGTH; i++)
                {
                    nuevaRutina.ejerciciosPorDia[i] = new Ejercicio[0];
                }

                rutinas.Add(nuevaRutina); 
                rutinaSeleccionada = rutinas.Count - 1;
            }

            UpdateRoutineComboBox();
            Rutina rutinaActual = rutinas[rutinaSeleccionada];
           
            if (comboBoxDiaSemana.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un día de la semana.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombreEjercicio = nombreEjercicioText.Text.Trim();
            if (string.IsNullOrEmpty(nombreEjercicio))
            {
                MessageBox.Show("Por favor, introduce el nombre del ejercicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            if (!double.TryParse(pesoEjercicio.Text.Trim(), out double peso) || peso <= 0)
            {
                MessageBox.Show("Por favor, introduce un peso válido (número mayor que 0).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (!int.TryParse(RepeticionesText.Text.Trim(), out int repeticiones) || repeticiones <= 0)
            {
                MessageBox.Show("Por favor, introduce un número de repeticiones válido (número mayor que 0).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            Ejercicio nuevoEjercicio = new Ejercicio
            {
                Nombre = nombreEjercicio,
                Peso = peso,
                Repeticiones = repeticiones
            };

            
            int diaIndex = comboBoxDiaSemana.SelectedIndex;

           
            List<Ejercicio> ejerciciosDelDia = rutinaActual.ejerciciosPorDia[diaIndex]?.ToList() ?? new List<Ejercicio>();
            ejerciciosDelDia.Add(nuevoEjercicio);
            rutinaActual.ejerciciosPorDia[diaIndex] = ejerciciosDelDia.ToArray();

            
            MessageBox.Show($"Ejercicio '{nombreEjercicio}' añadido a la rutina '{rutinaActual.Nombre}' para el día {comboBoxDiaSemana.SelectedItem}.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
            nombreEjercicioText.Text = string.Empty;
            pesoEjercicio.Text = string.Empty;
            RepeticionesText.Text = string.Empty;

            
            if (fechaSeleccionada.DayOfWeek == (DayOfWeek)diaIndex)
            {
                ejercicioGridView.DataSource = rutinaActual.ejerciciosPorDia[diaIndex];
            }
        }

        private void UpdateRoutineComboBox()
        {
            comboBoxRutinas.Items.Clear(); 
            foreach (var rutina in rutinas)
            {
                comboBoxRutinas.Items.Add(rutina.Nombre); 
            }

            if (rutinaSeleccionada != -1 && rutinaSeleccionada < comboBoxRutinas.Items.Count)
            {
                comboBoxRutinas.SelectedIndex = rutinaSeleccionada; 
            }
        }

        private void comboBoxRutinas_SelectedIndexChanged(object sender, EventArgs e)
        {
            rutinaSeleccionada = comboBoxRutinas.SelectedIndex;
            if (rutinaSeleccionada != -1)
            {
              

                // Update DataGridView to reflect the selected routine's exercises for the selected day
                var ejercicios = rutinas[rutinaSeleccionada].ejerciciosPorDia[(int)fechaSeleccionada.DayOfWeek];
                ejercicioGridView.DataSource = ejercicios ?? new Ejercicio[0];
            }
        }

        private void crearRutina()
        {
            if (string.IsNullOrWhiteSpace(NombreRutinaNueva.Text))
            {
                MessageBox.Show("Por favor, introduce un nombre válido para la rutina.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Rutina nuevaRutina = new Rutina
            {
                Nombre = NombreRutinaNueva.Text,
                ejerciciosPorDia = new Ejercicio[(int)DiasDeLaSemana.SEMANA_LENGTH][]
            };

            for (int i = 0; i < (int)DiasDeLaSemana.SEMANA_LENGTH; i++)
            {
                nuevaRutina.ejerciciosPorDia[i] = new Ejercicio[0];
            }

           
            rutinas.Add(nuevaRutina);

           
            UpdateRoutineComboBox();
            comboBoxRutinas.SelectedIndex = rutinas.Count - 1; 
            rutinaSeleccionada = rutinas.Count - 1;

            MessageBox.Show($"La rutina '{NombreRutinaNueva}' se ha creado y seleccionado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BotonCrearRutina_Click(object sender, EventArgs e)
        {
            
            crearRutina();

            // Clear the input field
            NombreRutinaNueva.Text = string.Empty;
        }
    }
}
