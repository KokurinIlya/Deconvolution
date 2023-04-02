
namespace SignalWithNoiseWFORMS
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelGeneralSettings = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAccuracy = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSignalEnergy = new System.Windows.Forms.Label();
            this.textBoxSignalEnergy = new System.Windows.Forms.TextBox();
            this.labelNoiseLevel = new System.Windows.Forms.Label();
            this.textBoxNoiseLevel = new System.Windows.Forms.TextBox();
            this.buttonColorPick = new System.Windows.Forms.Button();
            this.labelPhaseDescret = new System.Windows.Forms.Label();
            this.textBoxPhaseDescret = new System.Windows.Forms.TextBox();
            this.labelSignalWidth = new System.Windows.Forms.Label();
            this.labelHarmonics = new System.Windows.Forms.Label();
            this.labelGeneralSettings = new System.Windows.Forms.Label();
            this.generalSettingsLogo = new System.Windows.Forms.PictureBox();
            this.comboBoxSignalWidth = new System.Windows.Forms.ComboBox();
            this.comboBoxHarmonics = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelHarmonic3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelHarmonic2 = new System.Windows.Forms.Label();
            this.Harmonic2Logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelHarmonic1 = new System.Windows.Forms.Label();
            this.Harmonic1Logo = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonModeling = new System.Windows.Forms.Button();
            this.GRAPH = new System.Windows.Forms.PictureBox();
            this.impulseCharacteristicGraph = new System.Windows.Forms.PictureBox();
            this.convolutionGraph = new System.Windows.Forms.PictureBox();
            this.textBoxAmplitude3 = new customDesignForWForms.CustomControls.textBox_ByIlya();
            this.textBoxAverage3 = new customDesignForWForms.CustomControls.textBox_ByIlya();
            this.textBoxQuadraticDeviation3 = new customDesignForWForms.CustomControls.textBox_ByIlya();
            this.textBoxQuadraticDeviation2 = new customDesignForWForms.CustomControls.textBox_ByIlya();
            this.textBoxAverage2 = new customDesignForWForms.CustomControls.textBox_ByIlya();
            this.textBoxAmplitude2 = new customDesignForWForms.CustomControls.textBox_ByIlya();
            this.textBoxQuadraticDeviation1 = new customDesignForWForms.CustomControls.textBox_ByIlya();
            this.textBoxAverage1 = new customDesignForWForms.CustomControls.textBox_ByIlya();
            this.textBoxAmplitude1 = new customDesignForWForms.CustomControls.textBox_ByIlya();
            this.textBoxQuadraticDeviationCharacteristic = new customDesignForWForms.CustomControls.textBox_ByIlya();
            this.textBoxAmplitudeCharacteristic = new customDesignForWForms.CustomControls.textBox_ByIlya();
            this.panelGeneralSettings.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalSettingsLogo)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Harmonic2Logo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Harmonic1Logo)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRAPH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.impulseCharacteristicGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.convolutionGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGeneralSettings
            // 
            this.panelGeneralSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(1)))));
            this.panelGeneralSettings.Controls.Add(this.label2);
            this.panelGeneralSettings.Controls.Add(this.textBoxAccuracy);
            this.panelGeneralSettings.Controls.Add(this.panel4);
            this.panelGeneralSettings.Controls.Add(this.labelSignalEnergy);
            this.panelGeneralSettings.Controls.Add(this.textBoxSignalEnergy);
            this.panelGeneralSettings.Controls.Add(this.labelNoiseLevel);
            this.panelGeneralSettings.Controls.Add(this.textBoxNoiseLevel);
            this.panelGeneralSettings.Controls.Add(this.buttonColorPick);
            this.panelGeneralSettings.Controls.Add(this.labelPhaseDescret);
            this.panelGeneralSettings.Controls.Add(this.textBoxPhaseDescret);
            this.panelGeneralSettings.Controls.Add(this.labelSignalWidth);
            this.panelGeneralSettings.Controls.Add(this.labelHarmonics);
            this.panelGeneralSettings.Controls.Add(this.labelGeneralSettings);
            this.panelGeneralSettings.Controls.Add(this.generalSettingsLogo);
            this.panelGeneralSettings.Controls.Add(this.comboBoxSignalWidth);
            this.panelGeneralSettings.Controls.Add(this.comboBoxHarmonics);
            this.panelGeneralSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGeneralSettings.Location = new System.Drawing.Point(0, 0);
            this.panelGeneralSettings.Name = "panelGeneralSettings";
            this.panelGeneralSettings.Padding = new System.Windows.Forms.Padding(20);
            this.panelGeneralSettings.Size = new System.Drawing.Size(515, 250);
            this.panelGeneralSettings.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(301, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Точность";
            // 
            // textBoxAccuracy
            // 
            this.textBoxAccuracy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAccuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAccuracy.Location = new System.Drawing.Point(392, 187);
            this.textBoxAccuracy.MaximumSize = new System.Drawing.Size(100, 20);
            this.textBoxAccuracy.MinimumSize = new System.Drawing.Size(100, 20);
            this.textBoxAccuracy.Name = "textBoxAccuracy";
            this.textBoxAccuracy.Size = new System.Drawing.Size(100, 15);
            this.textBoxAccuracy.TabIndex = 18;
            this.textBoxAccuracy.Text = "0,0001";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.textBoxQuadraticDeviationCharacteristic);
            this.panel4.Controls.Add(this.textBoxAmplitudeCharacteristic);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(304, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(188, 157);
            this.panel4.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 40);
            this.label1.TabIndex = 18;
            this.label1.Text = "Импульсная \r\n      характеристика";
            // 
            // labelSignalEnergy
            // 
            this.labelSignalEnergy.AutoSize = true;
            this.labelSignalEnergy.BackColor = System.Drawing.Color.Transparent;
            this.labelSignalEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignalEnergy.ForeColor = System.Drawing.Color.White;
            this.labelSignalEnergy.Location = new System.Drawing.Point(23, 180);
            this.labelSignalEnergy.Margin = new System.Windows.Forms.Padding(3, 0, 2, 0);
            this.labelSignalEnergy.Name = "labelSignalEnergy";
            this.labelSignalEnergy.Size = new System.Drawing.Size(137, 13);
            this.labelSignalEnergy.TabIndex = 16;
            this.labelSignalEnergy.Text = "Уровень восстановления";
            // 
            // textBoxSignalEnergy
            // 
            this.textBoxSignalEnergy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSignalEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSignalEnergy.Location = new System.Drawing.Point(180, 180);
            this.textBoxSignalEnergy.MaximumSize = new System.Drawing.Size(100, 20);
            this.textBoxSignalEnergy.MinimumSize = new System.Drawing.Size(100, 20);
            this.textBoxSignalEnergy.Name = "textBoxSignalEnergy";
            this.textBoxSignalEnergy.Size = new System.Drawing.Size(100, 15);
            this.textBoxSignalEnergy.TabIndex = 15;
            this.textBoxSignalEnergy.Text = "84,8";
            this.textBoxSignalEnergy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // labelNoiseLevel
            // 
            this.labelNoiseLevel.AutoSize = true;
            this.labelNoiseLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelNoiseLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoiseLevel.ForeColor = System.Drawing.Color.White;
            this.labelNoiseLevel.Location = new System.Drawing.Point(85, 158);
            this.labelNoiseLevel.Margin = new System.Windows.Forms.Padding(3, 0, 2, 0);
            this.labelNoiseLevel.Name = "labelNoiseLevel";
            this.labelNoiseLevel.Size = new System.Drawing.Size(81, 13);
            this.labelNoiseLevel.TabIndex = 14;
            this.labelNoiseLevel.Text = "Уровень шума";
            // 
            // textBoxNoiseLevel
            // 
            this.textBoxNoiseLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNoiseLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNoiseLevel.Location = new System.Drawing.Point(180, 157);
            this.textBoxNoiseLevel.MaximumSize = new System.Drawing.Size(100, 20);
            this.textBoxNoiseLevel.MinimumSize = new System.Drawing.Size(100, 20);
            this.textBoxNoiseLevel.Name = "textBoxNoiseLevel";
            this.textBoxNoiseLevel.Size = new System.Drawing.Size(100, 15);
            this.textBoxNoiseLevel.TabIndex = 13;
            this.textBoxNoiseLevel.Text = "20";
            this.textBoxNoiseLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // buttonColorPick
            // 
            this.buttonColorPick.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonColorPick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonColorPick.FlatAppearance.BorderSize = 0;
            this.buttonColorPick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColorPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonColorPick.Location = new System.Drawing.Point(23, 206);
            this.buttonColorPick.Name = "buttonColorPick";
            this.buttonColorPick.Size = new System.Drawing.Size(257, 23);
            this.buttonColorPick.TabIndex = 12;
            this.buttonColorPick.Text = "Выбрать цвет графика";
            this.buttonColorPick.UseVisualStyleBackColor = false;
            this.buttonColorPick.Click += new System.EventHandler(this.buttonColorPick_Click);
            // 
            // labelPhaseDescret
            // 
            this.labelPhaseDescret.AutoSize = true;
            this.labelPhaseDescret.BackColor = System.Drawing.Color.Transparent;
            this.labelPhaseDescret.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhaseDescret.ForeColor = System.Drawing.Color.White;
            this.labelPhaseDescret.Location = new System.Drawing.Point(32, 134);
            this.labelPhaseDescret.Margin = new System.Windows.Forms.Padding(3, 0, 2, 0);
            this.labelPhaseDescret.Name = "labelPhaseDescret";
            this.labelPhaseDescret.Size = new System.Drawing.Size(129, 13);
            this.labelPhaseDescret.TabIndex = 11;
            this.labelPhaseDescret.Text = "Частота дескритизации";
            // 
            // textBoxPhaseDescret
            // 
            this.textBoxPhaseDescret.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhaseDescret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhaseDescret.Location = new System.Drawing.Point(180, 133);
            this.textBoxPhaseDescret.MaximumSize = new System.Drawing.Size(100, 20);
            this.textBoxPhaseDescret.MinimumSize = new System.Drawing.Size(100, 20);
            this.textBoxPhaseDescret.Name = "textBoxPhaseDescret";
            this.textBoxPhaseDescret.Size = new System.Drawing.Size(100, 15);
            this.textBoxPhaseDescret.TabIndex = 10;
            this.textBoxPhaseDescret.Text = "20";
            this.textBoxPhaseDescret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // labelSignalWidth
            // 
            this.labelSignalWidth.AutoSize = true;
            this.labelSignalWidth.BackColor = System.Drawing.Color.Transparent;
            this.labelSignalWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignalWidth.ForeColor = System.Drawing.Color.White;
            this.labelSignalWidth.Location = new System.Drawing.Point(83, 100);
            this.labelSignalWidth.Margin = new System.Windows.Forms.Padding(3, 0, 2, 0);
            this.labelSignalWidth.Name = "labelSignalWidth";
            this.labelSignalWidth.Size = new System.Drawing.Size(84, 13);
            this.labelSignalWidth.TabIndex = 5;
            this.labelSignalWidth.Text = "Длина сигнала";
            // 
            // labelHarmonics
            // 
            this.labelHarmonics.AutoSize = true;
            this.labelHarmonics.BackColor = System.Drawing.Color.Transparent;
            this.labelHarmonics.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarmonics.ForeColor = System.Drawing.Color.White;
            this.labelHarmonics.Location = new System.Drawing.Point(56, 74);
            this.labelHarmonics.Margin = new System.Windows.Forms.Padding(3, 0, 2, 0);
            this.labelHarmonics.Name = "labelHarmonics";
            this.labelHarmonics.Size = new System.Drawing.Size(110, 13);
            this.labelHarmonics.TabIndex = 4;
            this.labelHarmonics.Text = "Количество куполов";
            // 
            // labelGeneralSettings
            // 
            this.labelGeneralSettings.AutoSize = true;
            this.labelGeneralSettings.BackColor = System.Drawing.Color.Transparent;
            this.labelGeneralSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGeneralSettings.ForeColor = System.Drawing.Color.White;
            this.labelGeneralSettings.Location = new System.Drawing.Point(56, 20);
            this.labelGeneralSettings.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelGeneralSettings.Name = "labelGeneralSettings";
            this.labelGeneralSettings.Size = new System.Drawing.Size(186, 20);
            this.labelGeneralSettings.TabIndex = 3;
            this.labelGeneralSettings.Text = "Основные настройки";
            // 
            // generalSettingsLogo
            // 
            this.generalSettingsLogo.Image = global::SignalWithNoiseWFORMS.Properties.Resources.settings__1_;
            this.generalSettingsLogo.Location = new System.Drawing.Point(23, 20);
            this.generalSettingsLogo.Margin = new System.Windows.Forms.Padding(0);
            this.generalSettingsLogo.Name = "generalSettingsLogo";
            this.generalSettingsLogo.Size = new System.Drawing.Size(32, 32);
            this.generalSettingsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.generalSettingsLogo.TabIndex = 2;
            this.generalSettingsLogo.TabStop = false;
            // 
            // comboBoxSignalWidth
            // 
            this.comboBoxSignalWidth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSignalWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSignalWidth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSignalWidth.FormattingEnabled = true;
            this.comboBoxSignalWidth.Items.AddRange(new object[] {
            "32",
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048"});
            this.comboBoxSignalWidth.Location = new System.Drawing.Point(180, 98);
            this.comboBoxSignalWidth.Name = "comboBoxSignalWidth";
            this.comboBoxSignalWidth.Size = new System.Drawing.Size(100, 21);
            this.comboBoxSignalWidth.TabIndex = 1;
            // 
            // comboBoxHarmonics
            // 
            this.comboBoxHarmonics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxHarmonics.DisplayMember = "1";
            this.comboBoxHarmonics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHarmonics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxHarmonics.FormattingEnabled = true;
            this.comboBoxHarmonics.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxHarmonics.Location = new System.Drawing.Point(180, 71);
            this.comboBoxHarmonics.Name = "comboBoxHarmonics";
            this.comboBoxHarmonics.Size = new System.Drawing.Size(100, 21);
            this.comboBoxHarmonics.TabIndex = 0;
            this.comboBoxHarmonics.SelectedIndexChanged += new System.EventHandler(this.comboBoxHarmonics_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(214)))), ((int)(((byte)(99)))));
            this.panel3.Controls.Add(this.textBoxAmplitude3);
            this.panel3.Controls.Add(this.textBoxAverage3);
            this.panel3.Controls.Add(this.textBoxQuadraticDeviation3);
            this.panel3.Controls.Add(this.labelHarmonic3);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(893, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20);
            this.panel3.Size = new System.Drawing.Size(189, 250);
            this.panel3.TabIndex = 4;
            // 
            // labelHarmonic3
            // 
            this.labelHarmonic3.AutoSize = true;
            this.labelHarmonic3.BackColor = System.Drawing.Color.Transparent;
            this.labelHarmonic3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarmonic3.ForeColor = System.Drawing.Color.White;
            this.labelHarmonic3.Location = new System.Drawing.Point(62, 15);
            this.labelHarmonic3.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelHarmonic3.Name = "labelHarmonic3";
            this.labelHarmonic3.Size = new System.Drawing.Size(69, 40);
            this.labelHarmonic3.TabIndex = 3;
            this.labelHarmonic3.Text = "Третий\r\nкупол";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SignalWithNoiseWFORMS.Properties.Resources.sin;
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(87)))), ((int)(((byte)(103)))));
            this.panel2.Controls.Add(this.textBoxQuadraticDeviation2);
            this.panel2.Controls.Add(this.textBoxAverage2);
            this.panel2.Controls.Add(this.textBoxAmplitude2);
            this.panel2.Controls.Add(this.labelHarmonic2);
            this.panel2.Controls.Add(this.Harmonic2Logo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(704, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(189, 250);
            this.panel2.TabIndex = 3;
            // 
            // labelHarmonic2
            // 
            this.labelHarmonic2.AutoSize = true;
            this.labelHarmonic2.BackColor = System.Drawing.Color.Transparent;
            this.labelHarmonic2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarmonic2.ForeColor = System.Drawing.Color.White;
            this.labelHarmonic2.Location = new System.Drawing.Point(62, 15);
            this.labelHarmonic2.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelHarmonic2.Name = "labelHarmonic2";
            this.labelHarmonic2.Size = new System.Drawing.Size(71, 40);
            this.labelHarmonic2.TabIndex = 3;
            this.labelHarmonic2.Text = "Второй\r\nкупол";
            // 
            // Harmonic2Logo
            // 
            this.Harmonic2Logo.Image = global::SignalWithNoiseWFORMS.Properties.Resources.sin;
            this.Harmonic2Logo.Location = new System.Drawing.Point(20, 20);
            this.Harmonic2Logo.Margin = new System.Windows.Forms.Padding(0);
            this.Harmonic2Logo.Name = "Harmonic2Logo";
            this.Harmonic2Logo.Size = new System.Drawing.Size(32, 32);
            this.Harmonic2Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Harmonic2Logo.TabIndex = 2;
            this.Harmonic2Logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.textBoxQuadraticDeviation1);
            this.panel1.Controls.Add(this.textBoxAverage1);
            this.panel1.Controls.Add(this.textBoxAmplitude1);
            this.panel1.Controls.Add(this.labelHarmonic1);
            this.panel1.Controls.Add(this.Harmonic1Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(515, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(189, 250);
            this.panel1.TabIndex = 2;
            // 
            // labelHarmonic1
            // 
            this.labelHarmonic1.AutoSize = true;
            this.labelHarmonic1.BackColor = System.Drawing.Color.Transparent;
            this.labelHarmonic1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarmonic1.ForeColor = System.Drawing.Color.White;
            this.labelHarmonic1.Location = new System.Drawing.Point(55, 15);
            this.labelHarmonic1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelHarmonic1.Name = "labelHarmonic1";
            this.labelHarmonic1.Size = new System.Drawing.Size(79, 40);
            this.labelHarmonic1.TabIndex = 3;
            this.labelHarmonic1.Text = "Первый \r\nкупол";
            // 
            // Harmonic1Logo
            // 
            this.Harmonic1Logo.Image = global::SignalWithNoiseWFORMS.Properties.Resources.sin;
            this.Harmonic1Logo.Location = new System.Drawing.Point(20, 20);
            this.Harmonic1Logo.Margin = new System.Windows.Forms.Padding(0);
            this.Harmonic1Logo.Name = "Harmonic1Logo";
            this.Harmonic1Logo.Size = new System.Drawing.Size(32, 32);
            this.Harmonic1Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Harmonic1Logo.TabIndex = 2;
            this.Harmonic1Logo.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonModeling);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.panelGeneralSettings);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1319, 250);
            this.panelMenu.TabIndex = 8;
            // 
            // buttonModeling
            // 
            this.buttonModeling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(41)))), ((int)(((byte)(124)))));
            this.buttonModeling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModeling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonModeling.FlatAppearance.BorderSize = 0;
            this.buttonModeling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModeling.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonModeling.ForeColor = System.Drawing.Color.White;
            this.buttonModeling.Image = global::SignalWithNoiseWFORMS.Properties.Resources.tap__1_;
            this.buttonModeling.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonModeling.Location = new System.Drawing.Point(1082, 0);
            this.buttonModeling.Margin = new System.Windows.Forms.Padding(0);
            this.buttonModeling.Name = "buttonModeling";
            this.buttonModeling.Padding = new System.Windows.Forms.Padding(20);
            this.buttonModeling.Size = new System.Drawing.Size(237, 250);
            this.buttonModeling.TabIndex = 5;
            this.buttonModeling.Text = "Моделировать";
            this.buttonModeling.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonModeling.UseVisualStyleBackColor = false;
            this.buttonModeling.Click += new System.EventHandler(this.buttonModeling_Click);
            // 
            // GRAPH
            // 
            this.GRAPH.BackColor = System.Drawing.Color.White;
            this.GRAPH.Location = new System.Drawing.Point(0, 504);
            this.GRAPH.Margin = new System.Windows.Forms.Padding(30);
            this.GRAPH.Name = "GRAPH";
            this.GRAPH.Size = new System.Drawing.Size(1319, 257);
            this.GRAPH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GRAPH.TabIndex = 0;
            this.GRAPH.TabStop = false;
            // 
            // impulseCharacteristicGraph
            // 
            this.impulseCharacteristicGraph.BackColor = System.Drawing.Color.White;
            this.impulseCharacteristicGraph.Location = new System.Drawing.Point(0, 250);
            this.impulseCharacteristicGraph.Name = "impulseCharacteristicGraph";
            this.impulseCharacteristicGraph.Size = new System.Drawing.Size(658, 257);
            this.impulseCharacteristicGraph.TabIndex = 11;
            this.impulseCharacteristicGraph.TabStop = false;
            // 
            // convolutionGraph
            // 
            this.convolutionGraph.BackColor = System.Drawing.Color.White;
            this.convolutionGraph.Location = new System.Drawing.Point(656, 250);
            this.convolutionGraph.Margin = new System.Windows.Forms.Padding(30);
            this.convolutionGraph.Name = "convolutionGraph";
            this.convolutionGraph.Size = new System.Drawing.Size(663, 257);
            this.convolutionGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.convolutionGraph.TabIndex = 12;
            this.convolutionGraph.TabStop = false;
            // 
            // textBoxAmplitude3
            // 
            this.textBoxAmplitude3.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAmplitude3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxAmplitude3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBoxAmplitude3.BorderRadius = 0;
            this.textBoxAmplitude3.BorderSize = 2;
            this.textBoxAmplitude3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAmplitude3.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxAmplitude3.Location = new System.Drawing.Point(23, 81);
            this.textBoxAmplitude3.Multiline = false;
            this.textBoxAmplitude3.Name = "textBoxAmplitude3";
            this.textBoxAmplitude3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxAmplitude3.PasswordChar = false;
            this.textBoxAmplitude3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxAmplitude3.PlaceholderText = "Амплитуда";
            this.textBoxAmplitude3.Size = new System.Drawing.Size(142, 31);
            this.textBoxAmplitude3.TabIndex = 25;
            this.textBoxAmplitude3.Texts = "";
            this.textBoxAmplitude3.UnderlinedStyle = false;
            this.textBoxAmplitude3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxAverage3
            // 
            this.textBoxAverage3.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAverage3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxAverage3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBoxAverage3.BorderRadius = 0;
            this.textBoxAverage3.BorderSize = 2;
            this.textBoxAverage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAverage3.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxAverage3.Location = new System.Drawing.Point(24, 132);
            this.textBoxAverage3.Multiline = false;
            this.textBoxAverage3.Name = "textBoxAverage3";
            this.textBoxAverage3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxAverage3.PasswordChar = false;
            this.textBoxAverage3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxAverage3.PlaceholderText = "Мат. ождиание";
            this.textBoxAverage3.Size = new System.Drawing.Size(142, 31);
            this.textBoxAverage3.TabIndex = 24;
            this.textBoxAverage3.Texts = "";
            this.textBoxAverage3.UnderlinedStyle = false;
            this.textBoxAverage3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxQuadraticDeviation3
            // 
            this.textBoxQuadraticDeviation3.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxQuadraticDeviation3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxQuadraticDeviation3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBoxQuadraticDeviation3.BorderRadius = 0;
            this.textBoxQuadraticDeviation3.BorderSize = 2;
            this.textBoxQuadraticDeviation3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuadraticDeviation3.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxQuadraticDeviation3.Location = new System.Drawing.Point(23, 186);
            this.textBoxQuadraticDeviation3.Multiline = false;
            this.textBoxQuadraticDeviation3.Name = "textBoxQuadraticDeviation3";
            this.textBoxQuadraticDeviation3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxQuadraticDeviation3.PasswordChar = false;
            this.textBoxQuadraticDeviation3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxQuadraticDeviation3.PlaceholderText = "Квадр. отклон.";
            this.textBoxQuadraticDeviation3.Size = new System.Drawing.Size(142, 31);
            this.textBoxQuadraticDeviation3.TabIndex = 23;
            this.textBoxQuadraticDeviation3.Texts = "";
            this.textBoxQuadraticDeviation3.UnderlinedStyle = false;
            this.textBoxQuadraticDeviation3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxQuadraticDeviation2
            // 
            this.textBoxQuadraticDeviation2.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxQuadraticDeviation2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxQuadraticDeviation2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBoxQuadraticDeviation2.BorderRadius = 0;
            this.textBoxQuadraticDeviation2.BorderSize = 2;
            this.textBoxQuadraticDeviation2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuadraticDeviation2.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxQuadraticDeviation2.Location = new System.Drawing.Point(20, 187);
            this.textBoxQuadraticDeviation2.Multiline = false;
            this.textBoxQuadraticDeviation2.Name = "textBoxQuadraticDeviation2";
            this.textBoxQuadraticDeviation2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxQuadraticDeviation2.PasswordChar = false;
            this.textBoxQuadraticDeviation2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxQuadraticDeviation2.PlaceholderText = "Квадр. отклон.";
            this.textBoxQuadraticDeviation2.Size = new System.Drawing.Size(142, 31);
            this.textBoxQuadraticDeviation2.TabIndex = 22;
            this.textBoxQuadraticDeviation2.Texts = "";
            this.textBoxQuadraticDeviation2.UnderlinedStyle = false;
            this.textBoxQuadraticDeviation2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxAverage2
            // 
            this.textBoxAverage2.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAverage2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxAverage2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBoxAverage2.BorderRadius = 0;
            this.textBoxAverage2.BorderSize = 2;
            this.textBoxAverage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAverage2.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxAverage2.Location = new System.Drawing.Point(20, 132);
            this.textBoxAverage2.Multiline = false;
            this.textBoxAverage2.Name = "textBoxAverage2";
            this.textBoxAverage2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxAverage2.PasswordChar = false;
            this.textBoxAverage2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxAverage2.PlaceholderText = "Мат. ождиание";
            this.textBoxAverage2.Size = new System.Drawing.Size(142, 31);
            this.textBoxAverage2.TabIndex = 21;
            this.textBoxAverage2.Texts = "";
            this.textBoxAverage2.UnderlinedStyle = false;
            this.textBoxAverage2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxAmplitude2
            // 
            this.textBoxAmplitude2.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAmplitude2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxAmplitude2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBoxAmplitude2.BorderRadius = 0;
            this.textBoxAmplitude2.BorderSize = 2;
            this.textBoxAmplitude2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAmplitude2.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxAmplitude2.Location = new System.Drawing.Point(20, 81);
            this.textBoxAmplitude2.Multiline = false;
            this.textBoxAmplitude2.Name = "textBoxAmplitude2";
            this.textBoxAmplitude2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxAmplitude2.PasswordChar = false;
            this.textBoxAmplitude2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxAmplitude2.PlaceholderText = "Амплитуда";
            this.textBoxAmplitude2.Size = new System.Drawing.Size(142, 31);
            this.textBoxAmplitude2.TabIndex = 20;
            this.textBoxAmplitude2.Texts = "";
            this.textBoxAmplitude2.UnderlinedStyle = false;
            this.textBoxAmplitude2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxQuadraticDeviation1
            // 
            this.textBoxQuadraticDeviation1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxQuadraticDeviation1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxQuadraticDeviation1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBoxQuadraticDeviation1.BorderRadius = 0;
            this.textBoxQuadraticDeviation1.BorderSize = 2;
            this.textBoxQuadraticDeviation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuadraticDeviation1.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxQuadraticDeviation1.Location = new System.Drawing.Point(20, 187);
            this.textBoxQuadraticDeviation1.Multiline = false;
            this.textBoxQuadraticDeviation1.Name = "textBoxQuadraticDeviation1";
            this.textBoxQuadraticDeviation1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxQuadraticDeviation1.PasswordChar = false;
            this.textBoxQuadraticDeviation1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxQuadraticDeviation1.PlaceholderText = "Квадр. отклон.";
            this.textBoxQuadraticDeviation1.Size = new System.Drawing.Size(142, 31);
            this.textBoxQuadraticDeviation1.TabIndex = 19;
            this.textBoxQuadraticDeviation1.Texts = "";
            this.textBoxQuadraticDeviation1.UnderlinedStyle = false;
            this.textBoxQuadraticDeviation1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxAverage1
            // 
            this.textBoxAverage1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAverage1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxAverage1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBoxAverage1.BorderRadius = 0;
            this.textBoxAverage1.BorderSize = 2;
            this.textBoxAverage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAverage1.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxAverage1.Location = new System.Drawing.Point(20, 132);
            this.textBoxAverage1.Multiline = false;
            this.textBoxAverage1.Name = "textBoxAverage1";
            this.textBoxAverage1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxAverage1.PasswordChar = false;
            this.textBoxAverage1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxAverage1.PlaceholderText = "Мат. ождиание";
            this.textBoxAverage1.Size = new System.Drawing.Size(142, 31);
            this.textBoxAverage1.TabIndex = 18;
            this.textBoxAverage1.Texts = "";
            this.textBoxAverage1.UnderlinedStyle = false;
            this.textBoxAverage1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxAmplitude1
            // 
            this.textBoxAmplitude1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAmplitude1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxAmplitude1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBoxAmplitude1.BorderRadius = 0;
            this.textBoxAmplitude1.BorderSize = 2;
            this.textBoxAmplitude1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAmplitude1.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxAmplitude1.Location = new System.Drawing.Point(20, 81);
            this.textBoxAmplitude1.Multiline = false;
            this.textBoxAmplitude1.Name = "textBoxAmplitude1";
            this.textBoxAmplitude1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxAmplitude1.PasswordChar = false;
            this.textBoxAmplitude1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxAmplitude1.PlaceholderText = "Амплитуда";
            this.textBoxAmplitude1.Size = new System.Drawing.Size(142, 31);
            this.textBoxAmplitude1.TabIndex = 17;
            this.textBoxAmplitude1.Texts = "";
            this.textBoxAmplitude1.UnderlinedStyle = false;
            this.textBoxAmplitude1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxQuadraticDeviationCharacteristic
            // 
            this.textBoxQuadraticDeviationCharacteristic.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxQuadraticDeviationCharacteristic.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxQuadraticDeviationCharacteristic.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBoxQuadraticDeviationCharacteristic.BorderRadius = 0;
            this.textBoxQuadraticDeviationCharacteristic.BorderSize = 2;
            this.textBoxQuadraticDeviationCharacteristic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuadraticDeviationCharacteristic.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxQuadraticDeviationCharacteristic.Location = new System.Drawing.Point(23, 109);
            this.textBoxQuadraticDeviationCharacteristic.Multiline = false;
            this.textBoxQuadraticDeviationCharacteristic.Name = "textBoxQuadraticDeviationCharacteristic";
            this.textBoxQuadraticDeviationCharacteristic.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxQuadraticDeviationCharacteristic.PasswordChar = false;
            this.textBoxQuadraticDeviationCharacteristic.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxQuadraticDeviationCharacteristic.PlaceholderText = "Квадр. отклон.";
            this.textBoxQuadraticDeviationCharacteristic.Size = new System.Drawing.Size(142, 31);
            this.textBoxQuadraticDeviationCharacteristic.TabIndex = 20;
            this.textBoxQuadraticDeviationCharacteristic.Texts = "";
            this.textBoxQuadraticDeviationCharacteristic.UnderlinedStyle = false;
            // 
            // textBoxAmplitudeCharacteristic
            // 
            this.textBoxAmplitudeCharacteristic.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAmplitudeCharacteristic.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxAmplitudeCharacteristic.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBoxAmplitudeCharacteristic.BorderRadius = 0;
            this.textBoxAmplitudeCharacteristic.BorderSize = 2;
            this.textBoxAmplitudeCharacteristic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAmplitudeCharacteristic.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxAmplitudeCharacteristic.Location = new System.Drawing.Point(23, 61);
            this.textBoxAmplitudeCharacteristic.Multiline = false;
            this.textBoxAmplitudeCharacteristic.Name = "textBoxAmplitudeCharacteristic";
            this.textBoxAmplitudeCharacteristic.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxAmplitudeCharacteristic.PasswordChar = false;
            this.textBoxAmplitudeCharacteristic.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxAmplitudeCharacteristic.PlaceholderText = "Амплитуда";
            this.textBoxAmplitudeCharacteristic.Size = new System.Drawing.Size(142, 31);
            this.textBoxAmplitudeCharacteristic.TabIndex = 19;
            this.textBoxAmplitudeCharacteristic.Texts = "";
            this.textBoxAmplitudeCharacteristic.UnderlinedStyle = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1319, 761);
            this.Controls.Add(this.convolutionGraph);
            this.Controls.Add(this.impulseCharacteristicGraph);
            this.Controls.Add(this.GRAPH);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelGeneralSettings.ResumeLayout(false);
            this.panelGeneralSettings.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalSettingsLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Harmonic2Logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Harmonic1Logo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRAPH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.impulseCharacteristicGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.convolutionGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GRAPH;
        private System.Windows.Forms.Panel panelGeneralSettings;
        private System.Windows.Forms.ComboBox comboBoxSignalWidth;
        private System.Windows.Forms.ComboBox comboBoxHarmonics;
        private System.Windows.Forms.PictureBox generalSettingsLogo;
        private System.Windows.Forms.Label labelGeneralSettings;
        private System.Windows.Forms.Label labelHarmonics;
        private System.Windows.Forms.Label labelSignalWidth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelHarmonic1;
        private System.Windows.Forms.PictureBox Harmonic1Logo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelHarmonic3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelHarmonic2;
        private System.Windows.Forms.PictureBox Harmonic2Logo;
        private System.Windows.Forms.Button buttonModeling;
        private System.Windows.Forms.Label labelPhaseDescret;
        private System.Windows.Forms.TextBox textBoxPhaseDescret;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonColorPick;
        private System.Windows.Forms.PictureBox impulseCharacteristicGraph;
        private System.Windows.Forms.Label labelNoiseLevel;
        private System.Windows.Forms.TextBox textBoxNoiseLevel;
        private customDesignForWForms.CustomControls.textBox_ByIlya textBoxAmplitude1;
        private customDesignForWForms.CustomControls.textBox_ByIlya textBoxAmplitude2;
        private customDesignForWForms.CustomControls.textBox_ByIlya textBoxQuadraticDeviation1;
        private customDesignForWForms.CustomControls.textBox_ByIlya textBoxAverage1;
        private customDesignForWForms.CustomControls.textBox_ByIlya textBoxQuadraticDeviation3;
        private customDesignForWForms.CustomControls.textBox_ByIlya textBoxQuadraticDeviation2;
        private customDesignForWForms.CustomControls.textBox_ByIlya textBoxAverage2;
        private customDesignForWForms.CustomControls.textBox_ByIlya textBoxAmplitude3;
        private customDesignForWForms.CustomControls.textBox_ByIlya textBoxAverage3;
        private System.Windows.Forms.Label labelSignalEnergy;
        private System.Windows.Forms.TextBox textBoxSignalEnergy;
        private System.Windows.Forms.PictureBox convolutionGraph;
        private System.Windows.Forms.Panel panel4;
        private customDesignForWForms.CustomControls.textBox_ByIlya textBoxQuadraticDeviationCharacteristic;
        private customDesignForWForms.CustomControls.textBox_ByIlya textBoxAmplitudeCharacteristic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAccuracy;
    }
}

