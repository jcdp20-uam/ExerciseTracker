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
            LoadDataFromFile();
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

            if (rutinaSeleccionada < 0 || rutinaSeleccionada >= rutinas.Count || rutinas == null || rutinas.Count <= rutinaSeleccionada || rutinas[rutinaSeleccionada] == null)
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

            if (bitacora.ContainsKey(fechaSeleccionada))
            {
                // Update the value if the key already exists
                bitacora[fechaSeleccionada] = bitacoraTextBox.Text;
            }
            else
            {
                // Add the new key-value pair
                bitacora.Add(fechaSeleccionada, bitacoraTextBox.Text);
            }
            SaveDataToFile();
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

                comboBoxRutinas_SelectedIndexChanged(null, null);

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

            SaveDataToFile();
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
            if (rutinaSeleccionada >= 0 && rutinaSeleccionada < rutinas.Count)
            {
                RenameRoutineTextBox.Text = rutinas[rutinaSeleccionada].Nombre;
            }
            else
            {
                RenameRoutineTextBox.Text = string.Empty;
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
            SaveDataToFile();
            MessageBox.Show($"La rutina '{NombreRutinaNueva}' se ha creado y seleccionado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BotonCrearRutina_Click(object sender, EventArgs e)
        {

            crearRutina();
            // Clear the input field
            NombreRutinaNueva.Text = string.Empty;
        }

        private void eliminarEjercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ejercicioGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un ejercicio para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (rutinaSeleccionada < 0 || rutinaSeleccionada >= rutinas.Count)
            {
                MessageBox.Show("No hay una rutina seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int diaIndex = (int)fechaSeleccionada.DayOfWeek;
            if (rutinas[rutinaSeleccionada].ejerciciosPorDia[diaIndex] == null)
            {
                MessageBox.Show("No hay ejercicios para el día seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int selectedRowIndex = ejercicioGridView.SelectedRows[0].Index;
            var ejerciciosDelDia = rutinas[rutinaSeleccionada].ejerciciosPorDia[diaIndex].ToList();

            if (selectedRowIndex < 0 || selectedRowIndex >= ejerciciosDelDia.Count)
            {
                MessageBox.Show("El índice seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            ejerciciosDelDia.RemoveAt(selectedRowIndex);
            rutinas[rutinaSeleccionada].ejerciciosPorDia[diaIndex] = ejerciciosDelDia.ToArray();
            SaveDataToFile();


            ejercicioGridView.DataSource = null;
            ejercicioGridView.DataSource = rutinas[rutinaSeleccionada].ejerciciosPorDia[diaIndex];

            MessageBox.Show("El ejercicio seleccionado ha sido eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void SaveRoutineNameChangeButton_Click(object sender, EventArgs e)
        {
            if (rutinaSeleccionada < 0 || rutinaSeleccionada >= rutinas.Count)
            {
                MessageBox.Show("No hay una rutina seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            string nuevoNombre = RenameRoutineTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(nuevoNombre))
            {
                MessageBox.Show("Por favor, introduce un nombre válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            rutinas[rutinaSeleccionada].Nombre = nuevoNombre;
            UpdateRoutineComboBox();

            MessageBox.Show("El nombre de la rutina ha sido actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SaveDataToFile();
        }

        private void DeleteRoutine_Click(object sender, EventArgs e)
        {
            if (rutinaSeleccionada < 0 || rutinaSeleccionada >= rutinas.Count)
            {
                MessageBox.Show("No hay una rutina seleccionada para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmResult = MessageBox.Show(
                $"¿Estás seguro de que deseas eliminar la rutina '{rutinas[rutinaSeleccionada].Nombre}'?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                rutinas.RemoveAt(rutinaSeleccionada);
                rutinaSeleccionada = rutinas.Count <= 0 ? -1 : 0;
                UpdateRoutineComboBox();
                ejercicioGridView.DataSource = null;
                SaveDataToFile();
                MessageBox.Show("La rutina seleccionada ha sido eliminada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

        private void LoadDataFromFile()
        {
            String FilePath = "rutinas.csv";
            if (!File.Exists(FilePath))
            {
                // Create an empty file if it doesn't exist
                File.WriteAllText(FilePath, "");
                rutinas = new List<Rutina>();
                bitacora = new Dictionary<DateTime, string>();
                return;
            }

            try
            {
                using (StreamReader reader = new StreamReader(FilePath))
                {
                    Rutina currentRutina = null;

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var parts = line.Split(',');

                        if (parts[0] == "Routine")
                        {
                            // Start a new routine
                            currentRutina = new Rutina
                            {
                                Nombre = parts[1].Trim(),
                                ejerciciosPorDia = new Ejercicio[(int)DiasDeLaSemana.SEMANA_LENGTH][]
                            };
                            for (int i = 0; i < (int)DiasDeLaSemana.SEMANA_LENGTH; i++)
                            {
                                currentRutina.ejerciciosPorDia[i] = new Ejercicio[0];
                            }
                            rutinas.Add(currentRutina);
                        }
                        else if (parts[0] == "Exercise" && currentRutina != null)
                        {
                            // Parse exercise
                            var day = (DiasDeLaSemana)Enum.Parse(typeof(DiasDeLaSemana), parts[1].Trim());
                            var ejercicio = new Ejercicio
                            {
                                Nombre = parts[2].Trim(),
                                Peso = double.Parse(parts[3].Trim()),
                                Repeticiones = int.Parse(parts[4].Trim())
                            };
                            var dayIndex = (int)day;
                            var ejerciciosList = currentRutina.ejerciciosPorDia[dayIndex]?.ToList() ?? new List<Ejercicio>();
                            ejerciciosList.Add(ejercicio);
                            currentRutina.ejerciciosPorDia[dayIndex] = ejerciciosList.ToArray();
                        }
                        else if (parts[0] == "Bitacora")
                        {
                            // Parse bitácora entry
                            var date = DateTime.Parse(parts[1].Trim());
                            var text = string.Join(",", parts.Skip(2)).Replace("\\,", ",").Trim();
                            bitacora[date] = text;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rutinas = new List<Rutina>();
                bitacora = new Dictionary<DateTime, string>();
            }
        }

        private void SaveDataToFile()
        {

            String FilePath = "rutinas.csv";
            try
            {
                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    // Save routines
                    foreach (var rutina in rutinas)
                    {
                        writer.WriteLine($"Routine,{rutina.Nombre}");

                        for (int i = 0; i < (int)DiasDeLaSemana.SEMANA_LENGTH; i++)
                        {
                            var ejercicios = rutina.ejerciciosPorDia[i];
                            if (ejercicios != null)
                            {
                                foreach (var ejercicio in ejercicios)
                                {
                                    writer.WriteLine($"Exercise,{(DiasDeLaSemana)i},{ejercicio.Nombre},{ejercicio.Peso},{ejercicio.Repeticiones}");
                                }
                            }
                        }
                    }

                    // Save bitácora entries
                    foreach (var entry in bitacora)
                    {
                        writer.WriteLine($"Bitacora,{entry.Key:yyyy-MM-dd},{entry.Value.Replace(",", "\\,")}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }


    }


}
