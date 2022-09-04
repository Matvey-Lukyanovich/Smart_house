namespace webdefhome
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.control = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.panelcontrol = new System.Windows.Forms.Panel();
            this.door4 = new System.Windows.Forms.Button();
            this.door3 = new System.Windows.Forms.Button();
            this.door2 = new System.Windows.Forms.Button();
            this.door1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.fire4 = new System.Windows.Forms.Button();
            this.fire3 = new System.Windows.Forms.Button();
            this.fire2 = new System.Windows.Forms.Button();
            this.fire1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.water4 = new System.Windows.Forms.Button();
            this.water3 = new System.Windows.Forms.Button();
            this.water2 = new System.Windows.Forms.Button();
            this.water1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pir4 = new System.Windows.Forms.Button();
            this.pir3 = new System.Windows.Forms.Button();
            this.pir2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pir1 = new System.Windows.Forms.Button();
            this.panelsettings = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ventoff = new System.Windows.Forms.Button();
            this.venton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.airoff = new System.Windows.Forms.Button();
            this.airon = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.alarmlightoff = new System.Windows.Forms.Button();
            this.alarmlighton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sensor = new System.Windows.Forms.Label();
            this.lampoff = new System.Windows.Forms.Button();
            this.lampon = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.off = new System.Windows.Forms.Button();
            this.clon = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rozoff = new System.Windows.Forms.Button();
            this.rozon = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.datetime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.alarmpc = new System.Windows.Forms.PictureBox();
            this.sosbtn = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panelcontrol.SuspendLayout();
            this.panelsettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alarmpc)).BeginInit();
            this.SuspendLayout();
            // 
            // control
            // 
            this.control.BackColor = System.Drawing.Color.Gray;
            this.control.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.control.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.control.ForeColor = System.Drawing.Color.Black;
            this.control.Location = new System.Drawing.Point(9, 10);
            this.control.Margin = new System.Windows.Forms.Padding(2);
            this.control.Name = "control";
            this.control.Size = new System.Drawing.Size(130, 49);
            this.control.TabIndex = 0;
            this.control.Text = "Датчики";
            this.control.UseVisualStyleBackColor = false;
            this.control.Click += new System.EventHandler(this.control_Click);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.Gray;
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.settings.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settings.ForeColor = System.Drawing.Color.Black;
            this.settings.Location = new System.Drawing.Point(9, 63);
            this.settings.Margin = new System.Windows.Forms.Padding(2);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(130, 49);
            this.settings.TabIndex = 2;
            this.settings.Text = "Настройки\r\nУправление";
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // panelcontrol
            // 
            this.panelcontrol.BackColor = System.Drawing.Color.Gray;
            this.panelcontrol.Controls.Add(this.door4);
            this.panelcontrol.Controls.Add(this.door3);
            this.panelcontrol.Controls.Add(this.door2);
            this.panelcontrol.Controls.Add(this.door1);
            this.panelcontrol.Controls.Add(this.label4);
            this.panelcontrol.Controls.Add(this.fire4);
            this.panelcontrol.Controls.Add(this.fire3);
            this.panelcontrol.Controls.Add(this.fire2);
            this.panelcontrol.Controls.Add(this.fire1);
            this.panelcontrol.Controls.Add(this.label3);
            this.panelcontrol.Controls.Add(this.water4);
            this.panelcontrol.Controls.Add(this.water3);
            this.panelcontrol.Controls.Add(this.water2);
            this.panelcontrol.Controls.Add(this.water1);
            this.panelcontrol.Controls.Add(this.label2);
            this.panelcontrol.Controls.Add(this.pir4);
            this.panelcontrol.Controls.Add(this.pir3);
            this.panelcontrol.Controls.Add(this.pir2);
            this.panelcontrol.Controls.Add(this.label1);
            this.panelcontrol.Controls.Add(this.pir1);
            this.panelcontrol.Location = new System.Drawing.Point(152, 10);
            this.panelcontrol.Margin = new System.Windows.Forms.Padding(2);
            this.panelcontrol.Name = "panelcontrol";
            this.panelcontrol.Size = new System.Drawing.Size(363, 266);
            this.panelcontrol.TabIndex = 3;
            // 
            // door4
            // 
            this.door4.BackColor = System.Drawing.Color.Silver;
            this.door4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.door4.Location = new System.Drawing.Point(274, 216);
            this.door4.Margin = new System.Windows.Forms.Padding(2);
            this.door4.Name = "door4";
            this.door4.Size = new System.Drawing.Size(70, 24);
            this.door4.TabIndex = 19;
            this.door4.Text = "Гараж врт.";
            this.door4.UseVisualStyleBackColor = false;
            this.door4.Visible = false;
            this.door4.Click += new System.EventHandler(this.Door4_Click);
            // 
            // door3
            // 
            this.door3.BackColor = System.Drawing.Color.Silver;
            this.door3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.door3.Location = new System.Drawing.Point(200, 216);
            this.door3.Margin = new System.Windows.Forms.Padding(2);
            this.door3.Name = "door3";
            this.door3.Size = new System.Drawing.Size(70, 24);
            this.door3.TabIndex = 18;
            this.door3.Text = "Ворота";
            this.door3.UseVisualStyleBackColor = false;
            this.door3.Visible = false;
            this.door3.Click += new System.EventHandler(this.Door3_Click);
            // 
            // door2
            // 
            this.door2.BackColor = System.Drawing.Color.Silver;
            this.door2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.door2.Location = new System.Drawing.Point(274, 188);
            this.door2.Margin = new System.Windows.Forms.Padding(2);
            this.door2.Name = "door2";
            this.door2.Size = new System.Drawing.Size(70, 24);
            this.door2.TabIndex = 17;
            this.door2.Text = "Черный вх.";
            this.door2.UseVisualStyleBackColor = false;
            this.door2.Visible = false;
            this.door2.Click += new System.EventHandler(this.Door2_Click);
            // 
            // door1
            // 
            this.door1.BackColor = System.Drawing.Color.Silver;
            this.door1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.door1.Location = new System.Drawing.Point(200, 188);
            this.door1.Margin = new System.Windows.Forms.Padding(2);
            this.door1.Name = "door1";
            this.door1.Size = new System.Drawing.Size(70, 24);
            this.door1.TabIndex = 16;
            this.door1.Text = "Вход. дв.";
            this.door1.UseVisualStyleBackColor = false;
            this.door1.Visible = false;
            this.door1.Click += new System.EventHandler(this.Door1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(214, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Двери и ворота";
            this.label4.Visible = false;
            // 
            // fire4
            // 
            this.fire4.BackColor = System.Drawing.Color.Silver;
            this.fire4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fire4.Location = new System.Drawing.Point(88, 216);
            this.fire4.Margin = new System.Windows.Forms.Padding(2);
            this.fire4.Name = "fire4";
            this.fire4.Size = new System.Drawing.Size(70, 24);
            this.fire4.TabIndex = 14;
            this.fire4.Text = "4";
            this.fire4.UseVisualStyleBackColor = false;
            this.fire4.Visible = false;
            // 
            // fire3
            // 
            this.fire3.BackColor = System.Drawing.Color.Silver;
            this.fire3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fire3.Location = new System.Drawing.Point(14, 216);
            this.fire3.Margin = new System.Windows.Forms.Padding(2);
            this.fire3.Name = "fire3";
            this.fire3.Size = new System.Drawing.Size(70, 24);
            this.fire3.TabIndex = 13;
            this.fire3.Text = "3";
            this.fire3.UseVisualStyleBackColor = false;
            this.fire3.Visible = false;
            // 
            // fire2
            // 
            this.fire2.BackColor = System.Drawing.Color.Silver;
            this.fire2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fire2.Location = new System.Drawing.Point(88, 188);
            this.fire2.Margin = new System.Windows.Forms.Padding(2);
            this.fire2.Name = "fire2";
            this.fire2.Size = new System.Drawing.Size(70, 24);
            this.fire2.TabIndex = 12;
            this.fire2.Text = "2";
            this.fire2.UseVisualStyleBackColor = false;
            this.fire2.Visible = false;
            // 
            // fire1
            // 
            this.fire1.BackColor = System.Drawing.Color.Silver;
            this.fire1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fire1.Location = new System.Drawing.Point(14, 188);
            this.fire1.Margin = new System.Windows.Forms.Padding(2);
            this.fire1.Name = "fire1";
            this.fire1.Size = new System.Drawing.Size(70, 24);
            this.fire1.TabIndex = 11;
            this.fire1.Text = "1";
            this.fire1.UseVisualStyleBackColor = false;
            this.fire1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Датчики огня и дыма";
            this.label3.Visible = false;
            // 
            // water4
            // 
            this.water4.BackColor = System.Drawing.Color.Silver;
            this.water4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.water4.Location = new System.Drawing.Point(274, 72);
            this.water4.Margin = new System.Windows.Forms.Padding(2);
            this.water4.Name = "water4";
            this.water4.Size = new System.Drawing.Size(70, 24);
            this.water4.TabIndex = 9;
            this.water4.Text = "4";
            this.water4.UseVisualStyleBackColor = false;
            this.water4.Visible = false;
            // 
            // water3
            // 
            this.water3.BackColor = System.Drawing.Color.Silver;
            this.water3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.water3.Location = new System.Drawing.Point(200, 72);
            this.water3.Margin = new System.Windows.Forms.Padding(2);
            this.water3.Name = "water3";
            this.water3.Size = new System.Drawing.Size(70, 24);
            this.water3.TabIndex = 8;
            this.water3.Text = "3";
            this.water3.UseVisualStyleBackColor = false;
            this.water3.Visible = false;
            // 
            // water2
            // 
            this.water2.BackColor = System.Drawing.Color.Silver;
            this.water2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.water2.Location = new System.Drawing.Point(274, 44);
            this.water2.Margin = new System.Windows.Forms.Padding(2);
            this.water2.Name = "water2";
            this.water2.Size = new System.Drawing.Size(70, 24);
            this.water2.TabIndex = 7;
            this.water2.Text = "2";
            this.water2.UseVisualStyleBackColor = false;
            this.water2.Visible = false;
            // 
            // water1
            // 
            this.water1.BackColor = System.Drawing.Color.Silver;
            this.water1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.water1.Location = new System.Drawing.Point(200, 44);
            this.water1.Margin = new System.Windows.Forms.Padding(2);
            this.water1.Name = "water1";
            this.water1.Size = new System.Drawing.Size(70, 24);
            this.water1.TabIndex = 6;
            this.water1.Text = "1";
            this.water1.UseVisualStyleBackColor = false;
            this.water1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(200, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Датчики влажности";
            this.label2.Visible = false;
            // 
            // pir4
            // 
            this.pir4.BackColor = System.Drawing.Color.Silver;
            this.pir4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pir4.Location = new System.Drawing.Point(88, 72);
            this.pir4.Margin = new System.Windows.Forms.Padding(2);
            this.pir4.Name = "pir4";
            this.pir4.Size = new System.Drawing.Size(70, 24);
            this.pir4.TabIndex = 4;
            this.pir4.Text = "4";
            this.pir4.UseVisualStyleBackColor = false;
            this.pir4.Visible = false;
            // 
            // pir3
            // 
            this.pir3.BackColor = System.Drawing.Color.Silver;
            this.pir3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pir3.Location = new System.Drawing.Point(14, 72);
            this.pir3.Margin = new System.Windows.Forms.Padding(2);
            this.pir3.Name = "pir3";
            this.pir3.Size = new System.Drawing.Size(70, 24);
            this.pir3.TabIndex = 3;
            this.pir3.Text = "3";
            this.pir3.UseVisualStyleBackColor = false;
            this.pir3.Visible = false;
            // 
            // pir2
            // 
            this.pir2.BackColor = System.Drawing.Color.Silver;
            this.pir2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pir2.Location = new System.Drawing.Point(88, 43);
            this.pir2.Margin = new System.Windows.Forms.Padding(2);
            this.pir2.Name = "pir2";
            this.pir2.Size = new System.Drawing.Size(70, 24);
            this.pir2.TabIndex = 2;
            this.pir2.Text = "2";
            this.pir2.UseVisualStyleBackColor = false;
            this.pir2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Датчики движения";
            this.label1.Visible = false;
            // 
            // pir1
            // 
            this.pir1.BackColor = System.Drawing.Color.Silver;
            this.pir1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pir1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pir1.Location = new System.Drawing.Point(14, 43);
            this.pir1.Margin = new System.Windows.Forms.Padding(2);
            this.pir1.Name = "pir1";
            this.pir1.Size = new System.Drawing.Size(70, 24);
            this.pir1.TabIndex = 0;
            this.pir1.Text = "1";
            this.pir1.UseVisualStyleBackColor = false;
            this.pir1.Visible = false;
            // 
            // panelsettings
            // 
            this.panelsettings.BackColor = System.Drawing.Color.Gray;
            this.panelsettings.Controls.Add(this.button3);
            this.panelsettings.Controls.Add(this.button4);
            this.panelsettings.Controls.Add(this.ventoff);
            this.panelsettings.Controls.Add(this.venton);
            this.panelsettings.Controls.Add(this.label10);
            this.panelsettings.Controls.Add(this.airoff);
            this.panelsettings.Controls.Add(this.airon);
            this.panelsettings.Controls.Add(this.label9);
            this.panelsettings.Controls.Add(this.alarmlightoff);
            this.panelsettings.Controls.Add(this.alarmlighton);
            this.panelsettings.Controls.Add(this.label8);
            this.panelsettings.Controls.Add(this.button1);
            this.panelsettings.Controls.Add(this.button2);
            this.panelsettings.Controls.Add(this.sensor);
            this.panelsettings.Controls.Add(this.lampoff);
            this.panelsettings.Controls.Add(this.lampon);
            this.panelsettings.Controls.Add(this.label7);
            this.panelsettings.Controls.Add(this.off);
            this.panelsettings.Controls.Add(this.clon);
            this.panelsettings.Controls.Add(this.label6);
            this.panelsettings.Controls.Add(this.rozoff);
            this.panelsettings.Controls.Add(this.rozon);
            this.panelsettings.Controls.Add(this.label5);
            this.panelsettings.Location = new System.Drawing.Point(152, 11);
            this.panelsettings.Margin = new System.Windows.Forms.Padding(2);
            this.panelsettings.Name = "panelsettings";
            this.panelsettings.Size = new System.Drawing.Size(363, 266);
            this.panelsettings.TabIndex = 20;
            this.panelsettings.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(290, 240);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 24);
            this.button3.TabIndex = 22;
            this.button3.Text = "Я пришел";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(230, 240);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 24);
            this.button4.TabIndex = 21;
            this.button4.Text = "Я ушел";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // ventoff
            // 
            this.ventoff.BackColor = System.Drawing.Color.Silver;
            this.ventoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ventoff.Location = new System.Drawing.Point(211, 177);
            this.ventoff.Margin = new System.Windows.Forms.Padding(2);
            this.ventoff.Name = "ventoff";
            this.ventoff.Size = new System.Drawing.Size(56, 24);
            this.ventoff.TabIndex = 20;
            this.ventoff.Text = "Выкл";
            this.ventoff.UseVisualStyleBackColor = false;
            this.ventoff.Click += new System.EventHandler(this.Ventoff_Click);
            // 
            // venton
            // 
            this.venton.BackColor = System.Drawing.Color.Silver;
            this.venton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.venton.Location = new System.Drawing.Point(151, 177);
            this.venton.Margin = new System.Windows.Forms.Padding(2);
            this.venton.Name = "venton";
            this.venton.Size = new System.Drawing.Size(56, 24);
            this.venton.TabIndex = 19;
            this.venton.Text = "Вкл";
            this.venton.UseVisualStyleBackColor = false;
            this.venton.Click += new System.EventHandler(this.Venton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(10, 180);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Вентиляция:";
            // 
            // airoff
            // 
            this.airoff.BackColor = System.Drawing.Color.Silver;
            this.airoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.airoff.Location = new System.Drawing.Point(211, 149);
            this.airoff.Margin = new System.Windows.Forms.Padding(2);
            this.airoff.Name = "airoff";
            this.airoff.Size = new System.Drawing.Size(56, 24);
            this.airoff.TabIndex = 17;
            this.airoff.Text = "Выкл";
            this.airoff.UseVisualStyleBackColor = false;
            this.airoff.Click += new System.EventHandler(this.Airoff_Click);
            // 
            // airon
            // 
            this.airon.BackColor = System.Drawing.Color.Silver;
            this.airon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.airon.Location = new System.Drawing.Point(151, 149);
            this.airon.Margin = new System.Windows.Forms.Padding(2);
            this.airon.Name = "airon";
            this.airon.Size = new System.Drawing.Size(56, 24);
            this.airon.TabIndex = 16;
            this.airon.Text = "Вкл";
            this.airon.UseVisualStyleBackColor = false;
            this.airon.Click += new System.EventHandler(this.Airon_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(10, 152);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Аварийная вытяжка:";
            // 
            // alarmlightoff
            // 
            this.alarmlightoff.BackColor = System.Drawing.Color.Silver;
            this.alarmlightoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alarmlightoff.Location = new System.Drawing.Point(211, 122);
            this.alarmlightoff.Margin = new System.Windows.Forms.Padding(2);
            this.alarmlightoff.Name = "alarmlightoff";
            this.alarmlightoff.Size = new System.Drawing.Size(56, 24);
            this.alarmlightoff.TabIndex = 14;
            this.alarmlightoff.Text = "Выкл";
            this.alarmlightoff.UseVisualStyleBackColor = false;
            this.alarmlightoff.Click += new System.EventHandler(this.Alarmlightoff_Click);
            // 
            // alarmlighton
            // 
            this.alarmlighton.BackColor = System.Drawing.Color.Silver;
            this.alarmlighton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alarmlighton.Location = new System.Drawing.Point(151, 122);
            this.alarmlighton.Margin = new System.Windows.Forms.Padding(2);
            this.alarmlighton.Name = "alarmlighton";
            this.alarmlighton.Size = new System.Drawing.Size(56, 24);
            this.alarmlighton.TabIndex = 13;
            this.alarmlighton.Text = "Вкл";
            this.alarmlighton.UseVisualStyleBackColor = false;
            this.alarmlighton.Click += new System.EventHandler(this.Alarmlighton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(9, 125);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Аварийное освещение:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(211, 93);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 24);
            this.button1.TabIndex = 11;
            this.button1.Text = "Выкл";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(151, 93);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 24);
            this.button2.TabIndex = 10;
            this.button2.Text = "Вкл";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // sensor
            // 
            this.sensor.AutoSize = true;
            this.sensor.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sensor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sensor.Location = new System.Drawing.Point(10, 97);
            this.sensor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sensor.Name = "sensor";
            this.sensor.Size = new System.Drawing.Size(60, 16);
            this.sensor.TabIndex = 9;
            this.sensor.Text = "Датчики:";
            // 
            // lampoff
            // 
            this.lampoff.BackColor = System.Drawing.Color.Silver;
            this.lampoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lampoff.Location = new System.Drawing.Point(211, 65);
            this.lampoff.Margin = new System.Windows.Forms.Padding(2);
            this.lampoff.Name = "lampoff";
            this.lampoff.Size = new System.Drawing.Size(56, 24);
            this.lampoff.TabIndex = 8;
            this.lampoff.Text = "Выкл";
            this.lampoff.UseVisualStyleBackColor = false;
            this.lampoff.Click += new System.EventHandler(this.Lampoff_Click);
            // 
            // lampon
            // 
            this.lampon.BackColor = System.Drawing.Color.Silver;
            this.lampon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lampon.Location = new System.Drawing.Point(151, 65);
            this.lampon.Margin = new System.Windows.Forms.Padding(2);
            this.lampon.Name = "lampon";
            this.lampon.Size = new System.Drawing.Size(56, 24);
            this.lampon.TabIndex = 7;
            this.lampon.Text = "Вкл";
            this.lampon.UseVisualStyleBackColor = false;
            this.lampon.Click += new System.EventHandler(this.Lampon_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(10, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Лампочки:";
            // 
            // off
            // 
            this.off.BackColor = System.Drawing.Color.Silver;
            this.off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.off.Location = new System.Drawing.Point(211, 37);
            this.off.Margin = new System.Windows.Forms.Padding(2);
            this.off.Name = "off";
            this.off.Size = new System.Drawing.Size(56, 24);
            this.off.TabIndex = 5;
            this.off.Text = "Выкл";
            this.off.UseVisualStyleBackColor = false;
            this.off.Click += new System.EventHandler(this.off_Click);
            // 
            // clon
            // 
            this.clon.BackColor = System.Drawing.Color.Silver;
            this.clon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clon.Location = new System.Drawing.Point(151, 37);
            this.clon.Margin = new System.Windows.Forms.Padding(2);
            this.clon.Name = "clon";
            this.clon.Size = new System.Drawing.Size(56, 24);
            this.clon.TabIndex = 4;
            this.clon.Text = "Вкл";
            this.clon.UseVisualStyleBackColor = false;
            this.clon.Click += new System.EventHandler(this.clon_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(10, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Кл. воды:";
            // 
            // rozoff
            // 
            this.rozoff.BackColor = System.Drawing.Color.Silver;
            this.rozoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rozoff.Location = new System.Drawing.Point(211, 8);
            this.rozoff.Margin = new System.Windows.Forms.Padding(2);
            this.rozoff.Name = "rozoff";
            this.rozoff.Size = new System.Drawing.Size(56, 24);
            this.rozoff.TabIndex = 2;
            this.rozoff.Text = "Выкл";
            this.rozoff.UseVisualStyleBackColor = false;
            this.rozoff.Click += new System.EventHandler(this.Rozoff_Click);
            // 
            // rozon
            // 
            this.rozon.BackColor = System.Drawing.Color.Silver;
            this.rozon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rozon.Location = new System.Drawing.Point(151, 8);
            this.rozon.Margin = new System.Windows.Forms.Padding(2);
            this.rozon.Name = "rozon";
            this.rozon.Size = new System.Drawing.Size(56, 24);
            this.rozon.TabIndex = 1;
            this.rozon.Text = "Вкл";
            this.rozon.UseVisualStyleBackColor = false;
            this.rozon.Click += new System.EventHandler(this.Rozon_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(10, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Розетки:";
            // 
            // datetime
            // 
            this.datetime.AutoSize = true;
            this.datetime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datetime.ForeColor = System.Drawing.Color.Gray;
            this.datetime.Location = new System.Drawing.Point(316, 279);
            this.datetime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(212, 19);
            this.datetime.TabIndex = 0;
            this.datetime.Text = "dd MMMM yyyy | HH:mm:ss";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // alarmpc
            // 
            this.alarmpc.Image = ((System.Drawing.Image)(resources.GetObject("alarmpc.Image")));
            this.alarmpc.Location = new System.Drawing.Point(9, 171);
            this.alarmpc.Margin = new System.Windows.Forms.Padding(2);
            this.alarmpc.Name = "alarmpc";
            this.alarmpc.Size = new System.Drawing.Size(130, 106);
            this.alarmpc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.alarmpc.TabIndex = 0;
            this.alarmpc.TabStop = false;
            this.alarmpc.Visible = false;
            this.alarmpc.Click += new System.EventHandler(this.Alarmpc_Click);
            // 
            // sosbtn
            // 
            this.sosbtn.BackColor = System.Drawing.Color.Red;
            this.sosbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sosbtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sosbtn.ForeColor = System.Drawing.Color.White;
            this.sosbtn.Location = new System.Drawing.Point(9, 117);
            this.sosbtn.Margin = new System.Windows.Forms.Padding(2);
            this.sosbtn.Name = "sosbtn";
            this.sosbtn.Size = new System.Drawing.Size(130, 49);
            this.sosbtn.TabIndex = 4;
            this.sosbtn.Text = "SOS";
            this.sosbtn.UseVisualStyleBackColor = false;
            this.sosbtn.Click += new System.EventHandler(this.Sosbtn_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick_1);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(68, 281);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(87, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "192.168.1.8";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(23, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "IPv4 :";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(166, 281);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 19);
            this.button5.TabIndex = 23;
            this.button5.Text = "ON";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(517, 302);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panelsettings);
            this.Controls.Add(this.sosbtn);
            this.Controls.Add(this.alarmpc);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.panelcontrol);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.control);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система безопасности \"Умный дом\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelcontrol.ResumeLayout(false);
            this.panelcontrol.PerformLayout();
            this.panelsettings.ResumeLayout(false);
            this.panelsettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alarmpc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button control;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Panel panelcontrol;
        private System.Windows.Forms.Label datetime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox alarmpc;
        private System.Windows.Forms.Button door4;
        private System.Windows.Forms.Button door3;
        private System.Windows.Forms.Button door2;
        private System.Windows.Forms.Button door1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button fire4;
        private System.Windows.Forms.Button fire3;
        private System.Windows.Forms.Button fire2;
        private System.Windows.Forms.Button fire1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button water4;
        private System.Windows.Forms.Button water3;
        private System.Windows.Forms.Button water2;
        private System.Windows.Forms.Button water1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button pir4;
        private System.Windows.Forms.Button pir3;
        private System.Windows.Forms.Button pir2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pir1;
        private System.Windows.Forms.Button sosbtn;
        private System.Windows.Forms.Panel panelsettings;
        private System.Windows.Forms.Label sensor;
        private System.Windows.Forms.Button lampoff;
        private System.Windows.Forms.Button lampon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button off;
        private System.Windows.Forms.Button clon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button rozoff;
        private System.Windows.Forms.Button rozon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ventoff;
        private System.Windows.Forms.Button venton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button airoff;
        private System.Windows.Forms.Button airon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button alarmlightoff;
        private System.Windows.Forms.Button alarmlighton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5;
    }
}

