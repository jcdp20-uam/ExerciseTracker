namespace ExerciseTracker
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            monthCalendar1 = new MonthCalendar();
            tabControl1 = new TabControl();
            Bitacora = new TabPage();
            bitacoraTextBox = new TextBox();
            EjericiosDelDia = new TabPage();
            ejercicioGridView = new DataGridView();
            contextMenuStripEjerciciosDelDia = new ContextMenuStrip(components);
            eliminarEjercicioToolStripMenuItem = new ToolStripMenuItem();
            EdicionDeRutina = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            DiaDeLaSemanaRutina = new Label();
            comboBoxDiaSemana = new ComboBox();
            NombreEjercicioTextBox = new Label();
            nombreEjercicioText = new TextBox();
            pesoEjercicio = new TextBox();
            PesoText = new Label();
            label1 = new Label();
            RepeticionesText = new TextBox();
            GuardarEjercicio = new Button();
            SeleccionDeRutina = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            comboBoxRutinas = new ComboBox();
            RenameRoutineLabel = new Label();
            RenameRoutineTextBox = new TextBox();
            SaveRoutineNameChangeButton = new Button();
            DeleteRoutine = new Button();
            CreacionDeRutina = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            CrearRutinaLabel = new Label();
            NombreRutinaNueva = new TextBox();
            BotonCrearRutina = new Button();
            menuStrip1 = new MenuStrip();
            acciónesToolStripMenuItem = new ToolStripMenuItem();
            guardarBitácoraToolStripMenuItem = new ToolStripMenuItem();
            cambiarDeRutinaToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            Bitacora.SuspendLayout();
            EjericiosDelDia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ejercicioGridView).BeginInit();
            contextMenuStripEjerciciosDelDia.SuspendLayout();
            EdicionDeRutina.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SeleccionDeRutina.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            CreacionDeRutina.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Info;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(monthCalendar1, 1, 0);
            tableLayoutPanel1.Controls.Add(tabControl1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 33);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1547, 592);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(2, 2);
            monthCalendar1.Dock = DockStyle.Fill;
            monthCalendar1.Location = new Point(782, 9);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Bitacora);
            tabControl1.Controls.Add(EjericiosDelDia);
            tabControl1.Controls.Add(EdicionDeRutina);
            tabControl1.Controls.Add(SeleccionDeRutina);
            tabControl1.Controls.Add(CreacionDeRutina);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(767, 586);
            tabControl1.TabIndex = 1;
            // 
            // Bitacora
            // 
            Bitacora.Controls.Add(bitacoraTextBox);
            Bitacora.Location = new Point(4, 34);
            Bitacora.Name = "Bitacora";
            Bitacora.Padding = new Padding(3);
            Bitacora.Size = new Size(759, 548);
            Bitacora.TabIndex = 0;
            Bitacora.Text = "Bitácora";
            Bitacora.UseVisualStyleBackColor = true;
            // 
            // bitacoraTextBox
            // 
            bitacoraTextBox.BackColor = Color.MintCream;
            bitacoraTextBox.Dock = DockStyle.Fill;
            bitacoraTextBox.Location = new Point(3, 3);
            bitacoraTextBox.Multiline = true;
            bitacoraTextBox.Name = "bitacoraTextBox";
            bitacoraTextBox.ScrollBars = ScrollBars.Vertical;
            bitacoraTextBox.Size = new Size(753, 542);
            bitacoraTextBox.TabIndex = 0;
            // 
            // EjericiosDelDia
            // 
            EjericiosDelDia.Controls.Add(ejercicioGridView);
            EjericiosDelDia.Location = new Point(4, 34);
            EjericiosDelDia.Name = "EjericiosDelDia";
            EjericiosDelDia.Padding = new Padding(3);
            EjericiosDelDia.Size = new Size(759, 548);
            EjericiosDelDia.TabIndex = 1;
            EjericiosDelDia.Text = "Ejercicios Del Día";
            EjericiosDelDia.UseVisualStyleBackColor = true;
            // 
            // ejercicioGridView
            // 
            ejercicioGridView.BackgroundColor = Color.MintCream;
            ejercicioGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ejercicioGridView.ContextMenuStrip = contextMenuStripEjerciciosDelDia;
            ejercicioGridView.Dock = DockStyle.Fill;
            ejercicioGridView.Location = new Point(3, 3);
            ejercicioGridView.Name = "ejercicioGridView";
            ejercicioGridView.RowHeadersWidth = 62;
            ejercicioGridView.Size = new Size(753, 542);
            ejercicioGridView.TabIndex = 0;
            // 
            // contextMenuStripEjerciciosDelDia
            // 
            contextMenuStripEjerciciosDelDia.ImageScalingSize = new Size(24, 24);
            contextMenuStripEjerciciosDelDia.Items.AddRange(new ToolStripItem[] { eliminarEjercicioToolStripMenuItem });
            contextMenuStripEjerciciosDelDia.Name = "contextMenuStripEjerciciosDelDia";
            contextMenuStripEjerciciosDelDia.Size = new Size(215, 36);
            // 
            // eliminarEjercicioToolStripMenuItem
            // 
            eliminarEjercicioToolStripMenuItem.Name = "eliminarEjercicioToolStripMenuItem";
            eliminarEjercicioToolStripMenuItem.Size = new Size(214, 32);
            eliminarEjercicioToolStripMenuItem.Text = "Eliminar Ejercicio";
            eliminarEjercicioToolStripMenuItem.Click += eliminarEjercicioToolStripMenuItem_Click;
            // 
            // EdicionDeRutina
            // 
            EdicionDeRutina.BackColor = Color.MintCream;
            EdicionDeRutina.Controls.Add(tableLayoutPanel2);
            EdicionDeRutina.Location = new Point(4, 34);
            EdicionDeRutina.Name = "EdicionDeRutina";
            EdicionDeRutina.Size = new Size(759, 548);
            EdicionDeRutina.TabIndex = 2;
            EdicionDeRutina.Text = "Edición de Rutina";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.7709923F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.2290039F));
            tableLayoutPanel2.Controls.Add(DiaDeLaSemanaRutina, 0, 0);
            tableLayoutPanel2.Controls.Add(comboBoxDiaSemana, 1, 0);
            tableLayoutPanel2.Controls.Add(NombreEjercicioTextBox, 0, 1);
            tableLayoutPanel2.Controls.Add(nombreEjercicioText, 1, 1);
            tableLayoutPanel2.Controls.Add(pesoEjercicio, 1, 2);
            tableLayoutPanel2.Controls.Add(PesoText, 0, 2);
            tableLayoutPanel2.Controls.Add(label1, 0, 3);
            tableLayoutPanel2.Controls.Add(RepeticionesText, 1, 3);
            tableLayoutPanel2.Controls.Add(GuardarEjercicio, 1, 4);
            tableLayoutPanel2.Location = new Point(52, 48);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(655, 453);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // DiaDeLaSemanaRutina
            // 
            DiaDeLaSemanaRutina.Anchor = AnchorStyles.None;
            DiaDeLaSemanaRutina.AutoSize = true;
            DiaDeLaSemanaRutina.Location = new Point(25, 32);
            DiaDeLaSemanaRutina.Name = "DiaDeLaSemanaRutina";
            DiaDeLaSemanaRutina.Size = new Size(144, 25);
            DiaDeLaSemanaRutina.TabIndex = 0;
            DiaDeLaSemanaRutina.Text = "Dia A Configurar";
            // 
            // comboBoxDiaSemana
            // 
            comboBoxDiaSemana.Anchor = AnchorStyles.None;
            comboBoxDiaSemana.FormattingEnabled = true;
            comboBoxDiaSemana.Items.AddRange(new object[] { "Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sabado" });
            comboBoxDiaSemana.Location = new Point(334, 27);
            comboBoxDiaSemana.Margin = new Padding(3, 1, 3, 3);
            comboBoxDiaSemana.Name = "comboBoxDiaSemana";
            comboBoxDiaSemana.Size = new Size(182, 33);
            comboBoxDiaSemana.TabIndex = 1;
            // 
            // NombreEjercicioTextBox
            // 
            NombreEjercicioTextBox.Anchor = AnchorStyles.None;
            NombreEjercicioTextBox.AutoSize = true;
            NombreEjercicioTextBox.Location = new Point(12, 122);
            NombreEjercicioTextBox.Name = "NombreEjercicioTextBox";
            NombreEjercicioTextBox.Size = new Size(171, 25);
            NombreEjercicioTextBox.TabIndex = 2;
            NombreEjercicioTextBox.Text = "Nombre de Ejercicio";
            // 
            // nombreEjercicioText
            // 
            nombreEjercicioText.Anchor = AnchorStyles.None;
            nombreEjercicioText.Location = new Point(350, 119);
            nombreEjercicioText.Name = "nombreEjercicioText";
            nombreEjercicioText.Size = new Size(150, 31);
            nombreEjercicioText.TabIndex = 3;
            // 
            // pesoEjercicio
            // 
            pesoEjercicio.Anchor = AnchorStyles.None;
            pesoEjercicio.Location = new Point(350, 209);
            pesoEjercicio.Name = "pesoEjercicio";
            pesoEjercicio.Size = new Size(150, 31);
            pesoEjercicio.TabIndex = 4;
            // 
            // PesoText
            // 
            PesoText.Anchor = AnchorStyles.None;
            PesoText.AutoSize = true;
            PesoText.Location = new Point(58, 212);
            PesoText.Name = "PesoText";
            PesoText.Size = new Size(79, 25);
            PesoText.TabIndex = 5;
            PesoText.Text = "Peso (lb)";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(42, 302);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 6;
            label1.Text = "Repeticiones";
            // 
            // RepeticionesText
            // 
            RepeticionesText.Anchor = AnchorStyles.None;
            RepeticionesText.Location = new Point(350, 299);
            RepeticionesText.Name = "RepeticionesText";
            RepeticionesText.Size = new Size(150, 31);
            RepeticionesText.TabIndex = 7;
            // 
            // GuardarEjercicio
            // 
            GuardarEjercicio.Anchor = AnchorStyles.None;
            GuardarEjercicio.Location = new Point(299, 389);
            GuardarEjercicio.Name = "GuardarEjercicio";
            GuardarEjercicio.Size = new Size(252, 34);
            GuardarEjercicio.TabIndex = 8;
            GuardarEjercicio.Text = "Guardar Ejercicio a Rutina";
            GuardarEjercicio.UseVisualStyleBackColor = true;
            GuardarEjercicio.Click += GuardarEjercicio_Click;
            // 
            // SeleccionDeRutina
            // 
            SeleccionDeRutina.Controls.Add(tableLayoutPanel3);
            SeleccionDeRutina.Location = new Point(4, 34);
            SeleccionDeRutina.Name = "SeleccionDeRutina";
            SeleccionDeRutina.Size = new Size(759, 548);
            SeleccionDeRutina.TabIndex = 3;
            SeleccionDeRutina.Text = "Selección de Rutina";
            SeleccionDeRutina.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.MintCream;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(comboBoxRutinas, 1, 0);
            tableLayoutPanel3.Controls.Add(RenameRoutineLabel, 0, 1);
            tableLayoutPanel3.Controls.Add(RenameRoutineTextBox, 1, 1);
            tableLayoutPanel3.Controls.Add(SaveRoutineNameChangeButton, 0, 4);
            tableLayoutPanel3.Controls.Add(DeleteRoutine, 1, 4);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(759, 548);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(100, 42);
            label2.Name = "label2";
            label2.Size = new Size(178, 25);
            label2.TabIndex = 0;
            label2.Text = "Selecciona una rutina";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(189, 260);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 2;
            // 
            // comboBoxRutinas
            // 
            comboBoxRutinas.Anchor = AnchorStyles.None;
            comboBoxRutinas.FormattingEnabled = true;
            comboBoxRutinas.Location = new Point(478, 38);
            comboBoxRutinas.Name = "comboBoxRutinas";
            comboBoxRutinas.Size = new Size(182, 33);
            comboBoxRutinas.TabIndex = 1;
            comboBoxRutinas.SelectedIndexChanged += comboBoxRutinas_SelectedIndexChanged;
            // 
            // RenameRoutineLabel
            // 
            RenameRoutineLabel.Anchor = AnchorStyles.None;
            RenameRoutineLabel.AutoSize = true;
            RenameRoutineLabel.Location = new Point(115, 151);
            RenameRoutineLabel.Name = "RenameRoutineLabel";
            RenameRoutineLabel.Size = new Size(149, 25);
            RenameRoutineLabel.TabIndex = 3;
            RenameRoutineLabel.Text = "Renombra Rutina";
            // 
            // RenameRoutineTextBox
            // 
            RenameRoutineTextBox.Anchor = AnchorStyles.None;
            RenameRoutineTextBox.Location = new Point(427, 148);
            RenameRoutineTextBox.Name = "RenameRoutineTextBox";
            RenameRoutineTextBox.Size = new Size(284, 31);
            RenameRoutineTextBox.TabIndex = 4;
            // 
            // SaveRoutineNameChangeButton
            // 
            SaveRoutineNameChangeButton.Anchor = AnchorStyles.None;
            SaveRoutineNameChangeButton.Location = new Point(90, 475);
            SaveRoutineNameChangeButton.Name = "SaveRoutineNameChangeButton";
            SaveRoutineNameChangeButton.Size = new Size(199, 34);
            SaveRoutineNameChangeButton.TabIndex = 5;
            SaveRoutineNameChangeButton.Text = "Guardar Cambios";
            SaveRoutineNameChangeButton.UseVisualStyleBackColor = true;
            SaveRoutineNameChangeButton.Click += SaveRoutineNameChangeButton_Click;
            // 
            // DeleteRoutine
            // 
            DeleteRoutine.Anchor = AnchorStyles.None;
            DeleteRoutine.Location = new Point(439, 475);
            DeleteRoutine.Name = "DeleteRoutine";
            DeleteRoutine.Size = new Size(260, 34);
            DeleteRoutine.TabIndex = 6;
            DeleteRoutine.Text = "Eliminar Rutina Seleccionada";
            DeleteRoutine.UseVisualStyleBackColor = true;
            DeleteRoutine.Click += DeleteRoutine_Click;
            // 
            // CreacionDeRutina
            // 
            CreacionDeRutina.Controls.Add(tableLayoutPanel4);
            CreacionDeRutina.Location = new Point(4, 34);
            CreacionDeRutina.Name = "CreacionDeRutina";
            CreacionDeRutina.Size = new Size(759, 548);
            CreacionDeRutina.TabIndex = 4;
            CreacionDeRutina.Text = "Creacion De Rutina";
            CreacionDeRutina.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.MintCream;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.54282F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.4571838F));
            tableLayoutPanel4.Controls.Add(CrearRutinaLabel, 0, 0);
            tableLayoutPanel4.Controls.Add(NombreRutinaNueva, 1, 0);
            tableLayoutPanel4.Controls.Add(BotonCrearRutina, 1, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 75.72993F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 24.2700729F));
            tableLayoutPanel4.Size = new Size(759, 548);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // CrearRutinaLabel
            // 
            CrearRutinaLabel.Anchor = AnchorStyles.None;
            CrearRutinaLabel.AutoSize = true;
            CrearRutinaLabel.Location = new Point(43, 195);
            CrearRutinaLabel.Name = "CrearRutinaLabel";
            CrearRutinaLabel.Size = new Size(160, 25);
            CrearRutinaLabel.TabIndex = 0;
            CrearRutinaLabel.Text = "Nombre De Rutina";
            // 
            // NombreRutinaNueva
            // 
            NombreRutinaNueva.Anchor = AnchorStyles.None;
            NombreRutinaNueva.Location = new Point(428, 192);
            NombreRutinaNueva.Name = "NombreRutinaNueva";
            NombreRutinaNueva.Size = new Size(150, 31);
            NombreRutinaNueva.TabIndex = 1;
            // 
            // BotonCrearRutina
            // 
            BotonCrearRutina.Anchor = AnchorStyles.None;
            BotonCrearRutina.Location = new Point(447, 464);
            BotonCrearRutina.Name = "BotonCrearRutina";
            BotonCrearRutina.Size = new Size(112, 34);
            BotonCrearRutina.TabIndex = 2;
            BotonCrearRutina.Text = "Crear";
            BotonCrearRutina.UseVisualStyleBackColor = true;
            BotonCrearRutina.Click += BotonCrearRutina_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { acciónesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1547, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // acciónesToolStripMenuItem
            // 
            acciónesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { guardarBitácoraToolStripMenuItem, cambiarDeRutinaToolStripMenuItem });
            acciónesToolStripMenuItem.Name = "acciónesToolStripMenuItem";
            acciónesToolStripMenuItem.Size = new Size(98, 29);
            acciónesToolStripMenuItem.Text = "Acciónes";
            // 
            // guardarBitácoraToolStripMenuItem
            // 
            guardarBitácoraToolStripMenuItem.Name = "guardarBitácoraToolStripMenuItem";
            guardarBitácoraToolStripMenuItem.Size = new Size(260, 34);
            guardarBitácoraToolStripMenuItem.Text = "Guardar Bitácora";
            guardarBitácoraToolStripMenuItem.Click += guardarBitácoraToolStripMenuItem_Click;
            // 
            // cambiarDeRutinaToolStripMenuItem
            // 
            cambiarDeRutinaToolStripMenuItem.Name = "cambiarDeRutinaToolStripMenuItem";
            cambiarDeRutinaToolStripMenuItem.Size = new Size(260, 34);
            cambiarDeRutinaToolStripMenuItem.Text = "Cambiar de Rutina";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1547, 625);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            Bitacora.ResumeLayout(false);
            Bitacora.PerformLayout();
            EjericiosDelDia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ejercicioGridView).EndInit();
            contextMenuStripEjerciciosDelDia.ResumeLayout(false);
            EdicionDeRutina.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            SeleccionDeRutina.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            CreacionDeRutina.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MonthCalendar monthCalendar1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem acciónesToolStripMenuItem;
        private ToolStripMenuItem guardarBitácoraToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage Bitacora;
        private TextBox bitacoraTextBox;
        private TabPage EjericiosDelDia;
        private DataGridView ejercicioGridView;
        private TabPage EdicionDeRutina;
        private TableLayoutPanel tableLayoutPanel2;
        private Label DiaDeLaSemanaRutina;
        private ComboBox comboBoxDiaSemana;
        private TabPage SeleccionDeRutina;
        private ToolStripMenuItem cambiarDeRutinaToolStripMenuItem;
        private Label NombreEjercicioTextBox;
        private TextBox nombreEjercicioText;
        private TextBox pesoEjercicio;
        private Label PesoText;
        private Label label1;
        private TextBox RepeticionesText;
        private Button GuardarEjercicio;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private ComboBox comboBoxRutinas;
        private TabPage CreacionDeRutina;
        private TableLayoutPanel tableLayoutPanel4;
        private Label CrearRutinaLabel;
        private TextBox NombreRutinaNueva;
        private Button BotonCrearRutina;
        private ContextMenuStrip contextMenuStripEjerciciosDelDia;
        private ToolStripMenuItem eliminarEjercicioToolStripMenuItem;
        private Label label3;
        private Label RenameRoutineLabel;
        private TextBox RenameRoutineTextBox;
        private Button SaveRoutineNameChangeButton;
        private Button DeleteRoutine;
    }
}