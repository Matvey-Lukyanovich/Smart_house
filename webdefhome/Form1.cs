using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using System.IO;

namespace webdefhome
{
    public partial class main : Form
    {

        bool a1 = false;
        bool a2 = false;
        bool a3 = false;


        bool b13 = true;
        bool b14 = true;
        bool b15 = true;
        bool b16 = true;

        bool b24 = false;
        //Ip-Address and Port of Modbus-TCP-Server
        ModbusClient modbusClient;

        public main()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string s = DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss");





            datetime.Text = s;


        }


        private void control_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            pir1.Visible = true;
            pir2.Visible = true;
            pir3.Visible = true;
            pir4.Visible = true;
            water1.Visible = true;
            water2.Visible = true;
            water3.Visible = true;
            water4.Visible = true;
            fire1.Visible = true;
            fire2.Visible = true;
            fire3.Visible = true;
            fire4.Visible = true;
            door1.Visible = true;
            door2.Visible = true;
            door3.Visible = true;
            door4.Visible = true;
            panelcontrol.Visible = true;
            panelsettings.Visible = false;
        }

        private void scene_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            pir1.Visible = false;
            pir2.Visible = false;
            pir3.Visible = false;
            pir4.Visible = false;
            water1.Visible = false;
            water2.Visible = false;
            water3.Visible = false;
            water4.Visible = false;
            fire1.Visible = false;
            fire2.Visible = false;
            fire3.Visible = false;
            fire4.Visible = false;
            door1.Visible = false;
            door2.Visible = false;
            door3.Visible = false;
            door4.Visible = false;
        }

        private void off_Click(object sender, EventArgs e)
        {
            modbusClient.WriteSingleCoil(17, false);

            File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Клапон Воды : OFF ");
        }

        private void clon_Click(object sender, EventArgs e)
        {
            modbusClient.WriteSingleCoil(17, true);

            File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Клапон Воды : ON ");
        }

        private void settings_Click(object sender, EventArgs e)
        {
            panelsettings.Visible = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {

           

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                modbusClient.Disconnect();
            }
            catch { }
        }

        private void Timer2_Tick_1(object sender, EventArgs e)
        {
            bool[] readCoils = modbusClient.ReadCoils(0, 23);

            bool b1 = readCoils[0];
            bool b2 = readCoils[1];
            bool b3 = readCoils[2];
            bool b4 = readCoils[3];

            bool b5 = readCoils[4];
            bool b6 = readCoils[5];
            bool b7 = readCoils[6];
            bool b8 = readCoils[7];

            bool b9 = readCoils[8];
            bool b10 = readCoils[9];
            bool b11 = readCoils[10];
            bool b12 = readCoils[11];

            bool b20 = readCoils[19];




            if (b20)
            {

                //движение
                if (b1)
                { pir1.BackColor = Color.Red; }
                else pir1.BackColor = Color.Silver;

                if (b2)
                { pir2.BackColor = Color.Red; }
                else pir2.BackColor = Color.Silver;

                if (b3)
                { pir3.BackColor = Color.Red; }
                else pir3.BackColor = Color.Silver;

                if (b4)
                { pir4.BackColor = Color.Red; }
                else pir4.BackColor = Color.Silver;

                if (b1 | b2 | b3 | b4 | alrm1) //движение
                {
                    alrm1 = true;
                    if (!a1)
                    {
                        a1 = true;
                        File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Движение !!! " + "\r\n       " + "Произведены следущие действиея:" + "\r\n            " + "-Входная Дверь : Закрыта  " + "\r\n            " + "-Черный Вход : Закрыт  " + "\r\n            " + "-Ворота : Закрыты   " + "\r\n            " + "-Гаражные Ворота : Закрыты    ");
                       
                    }
                    modbusClient.WriteSingleCoil(12, true);
                    modbusClient.WriteSingleCoil(13, true);
                    modbusClient.WriteSingleCoil(14, true);
                    modbusClient.WriteSingleCoil(15, true);

                    alarmpc.Visible = true;
                }


                if (b4 | b5 | b6 | b7 | alrm2) //wlaga
                {
                    alrm2 = true;
                    if (!a2)
                    {
                        a2 = true;
                        File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Влажность !!! " + "\r\n       " + "Произведены следущие действиея:" + "\r\n            " + "-Розетки : OFF  " + "\r\n            " + "-Клапон Воды : OFF  " + "\r\n            " + "-Лампочки : OFF  " + "\r\n            " + "-Аварийная Вытяжка : ON   ");

                    }
                    modbusClient.WriteSingleCoil(16, false);
                    modbusClient.WriteSingleCoil(17, false);
                    modbusClient.WriteSingleCoil(18, false);
                    modbusClient.WriteSingleCoil(21, true);

                    alarmpc.Visible = true;
                }


                if (b8 | b9 | b10 | b11 | alrm3) //fire
                {
                    alrm3 = true;
                    if (!a3)
                    {
                        a3 = true;
                        File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Огонь !!! " + "\r\n       " + "Произведены следущие действиея:" + "\r\n            " + "-Розетки : OFF  " + "\r\n            " + "-Лампочки : OFF  " + "\r\n            " + "-Аварийная Вытяжка : ON   " + "\r\n            " + " Аварийное Освещений : ON " + "\r\n            " + " Вентиляция : OFF ");

                    }
                    modbusClient.WriteSingleCoil(16, false);
                    modbusClient.WriteSingleCoil(18, false);
                    modbusClient.WriteSingleCoil(21, true);

                    modbusClient.WriteSingleCoil(20, true);

                    modbusClient.WriteSingleCoil(22, false);

                    alarmpc.Visible = true;
                }




                // влага
                if (b5)
                { water1.BackColor = Color.Red; }
                else water1.BackColor = Color.Silver;

                if (b6)
                { water2.BackColor = Color.Red; }
                else water2.BackColor = Color.Silver;

                if (b7)
                { water3.BackColor = Color.Red; }
                else water3.BackColor = Color.Silver;

                if (b8)
                { water4.BackColor = Color.Red; }
                else water4.BackColor = Color.Silver;

                // fire
                if (b9)
                { fire1.BackColor = Color.Red; }
                else fire1.BackColor = Color.Silver;

                if (b10)
                { fire2.BackColor = Color.Red; }
                else fire2.BackColor = Color.Silver;

                if (b11)
                { fire3.BackColor = Color.Red; }
                else fire3.BackColor = Color.Silver;

                if (b12)
                { fire4.BackColor = Color.Red; }
                else fire4.BackColor = Color.Silver;







            }
            else
            {
                pir1.BackColor = Color.Silver;
                pir2.BackColor = Color.Silver;
                pir3.BackColor = Color.Silver;
                pir4.BackColor = Color.Silver;

                water1.BackColor = Color.Silver;
                water2.BackColor = Color.Silver;
                water3.BackColor = Color.Silver;
                water4.BackColor = Color.Silver;


                fire1.BackColor = Color.Silver;
                fire2.BackColor = Color.Silver;
                fire3.BackColor = Color.Silver;
                fire4.BackColor = Color.Silver;
            }




             b13 = readCoils[12];
             b14 = readCoils[13];
             b15 = readCoils[14];
             b16 = readCoils[15];

            bool b17 = readCoils[16];
            bool b18 = readCoils[17];
            bool b19 = readCoils[18];
            
            bool b21 = readCoils[20];
            bool b22 = readCoils[21];
            bool b23 = readCoils[22];






            if (!b13)
            { door1.BackColor = Color.Lime; }
            else if (alrm1) door1.BackColor = Color.Red; else door1.BackColor = Color.Orange;

            if (!b14)
            { door2.BackColor = Color.Lime; }
            else if (alrm1) door2.BackColor = Color.Red; else door2.BackColor = Color.Orange;

            if (!b15)
            { door3.BackColor = Color.Lime; }
            else if (alrm1) door3.BackColor = Color.Red; else door3.BackColor = Color.Orange;

            if (!b16)
            { door4.BackColor = Color.Lime; }
            else if (alrm1) door4.BackColor = Color.Red; else door4.BackColor = Color.Orange;



            if (b17)
            {
                rozon.BackColor = Color.Lime;
                rozoff.BackColor = Color.Silver;
            }
            else
            {
                rozon.BackColor = Color.Silver;
                rozoff.BackColor = Color.Red;
            }

            if (b18)
            {
                clon.BackColor = Color.Lime;
                off.BackColor = Color.Silver;
            }
            else
            {
                clon.BackColor = Color.Silver;
                off.BackColor = Color.Red;
            }

            if (b19)
            {
                lampon.BackColor = Color.Lime;
                lampoff.BackColor = Color.Silver;
            }
            else
            {
                lampon.BackColor = Color.Silver;
                lampoff.BackColor = Color.Red;
            }

            if (b20)
            {
                button2.BackColor = Color.Lime;
                button1.BackColor = Color.Silver;
            }
            else
            {
                button2.BackColor = Color.Silver;
                button1.BackColor = Color.Red;
            }

            if (b21)
            {
                alarmlighton.BackColor = Color.Lime;
                alarmlightoff.BackColor = Color.Silver;
            }
            else
            {
                alarmlighton.BackColor = Color.Silver;
                alarmlightoff.BackColor = Color.Red;
            }

            if (b22)
            {
                airon.BackColor = Color.Lime;
                airoff.BackColor = Color.Silver;
            }
            else
            {
                airon.BackColor = Color.Silver;
                airoff.BackColor = Color.Red;
            }

            if (b23)
            {
                venton.BackColor = Color.Lime;
                ventoff.BackColor = Color.Silver;
            }
            else
            {
                venton.BackColor = Color.Silver;
                ventoff.BackColor = Color.Red;
            }

        }

        private void Sosbtn_Click(object sender, EventArgs e)
        {
            alarmpc.Visible = !false;
            File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " SOS !!! ");

            modbusClient.WriteSingleCoil(23, true);
        }


        bool alrm1 = false;
        bool alrm2 = false;
        bool alrm3 = false;

        private void Alarmpc_Click(object sender, EventArgs e)
        {
            alarmpc.Visible = false;
            alrm1 = false;
            alrm2 = false;
            alrm3 = false;
            a1 = false;
            a2 = false;
            a3 = false;
            File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Произведен сброс Аварий ");


            modbusClient.WriteSingleCoil(23, !true);

        }

        private void Rozon_Click(object sender, EventArgs e)
        {
            modbusClient.WriteSingleCoil(16, true);
            File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Розетки : ON ");
        }

        private void Lampon_Click(object sender, EventArgs e)
        {
            modbusClient.WriteSingleCoil(18, true);

            File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Лампочки : ON ");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            modbusClient.WriteSingleCoil(19, true);

            File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Датчики : ON ");
        }

        private void Alarmlighton_Click(object sender, EventArgs e)
        {
            modbusClient.WriteSingleCoil(20, true);

            File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Аварийное Освещений : ON ");
        }

        private void Airon_Click(object sender, EventArgs e)
        {
            modbusClient.WriteSingleCoil(21, true);

            File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Аварийная Вытяжка : ON ");
        }

        private void Venton_Click(object sender, EventArgs e)
        {
            modbusClient.WriteSingleCoil(22, true);

            File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Вентиляция : ON ");
        }

        private void Rozoff_Click(object sender, EventArgs e)
        {
            modbusClient.WriteSingleCoil(16, false);

            File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Розетки : OFF ");
        }

        private void Lampoff_Click(object sender, EventArgs e)
        {
            modbusClient.WriteSingleCoil(18, false);

            File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Лампочки : OFF ");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            alarmpc.Visible = false;
            alrm1 = false;
            alrm2 = false;
            alrm3 = false;
            a1 = false;
            a2 = false;
            a3 = false;
            modbusClient.WriteSingleCoil(19, false);

            File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Датчики : OFF ");
        }

        private void Alarmlightoff_Click(object sender, EventArgs e)
        {
            modbusClient.WriteSingleCoil(20, false);

            File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Аварийное Освещений : OFF ");
        }

        private void Airoff_Click(object sender, EventArgs e)
        {
            modbusClient.WriteSingleCoil(21, false);

            File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Аварийная Вытяжка : OFF ");
        }

        private void Ventoff_Click(object sender, EventArgs e)
        {
            modbusClient.WriteSingleCoil(22, false);

            File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Вентиляция : OFF ");
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Хозяин ушел  " + "\r\n       " + "Произведены следущие действиея:" + "\r\n            " + "-Входная Дверь : Закрыта  " + "\r\n            " + "-Черный Вход : Закрыт  " + "\r\n            " + "-Ворота : Закрыты   " + "\r\n            " + "-Гаражные Ворота : Закрыты    " + "\r\n            " + "-Розетки : OFF  " + "\r\n            " + "-Клапон Воды : OFF " + "\r\n            " + "-Лампочки : OFF  " + "\r\n            " + "-Датчики : ON " + "\r\n            "+ "-Аварийное Освещений : OFF " + "\r\n            " + "-Аварийная Вытяжка : OFF   " + "\r\n            " + "-Вентиляция : OFF ");
           

            alrm1 = false;
            alrm2 = false;
            alrm3 = false;
            a1 = false;
            a2 = false;
            a3 = false;

            modbusClient.WriteSingleCoil(16, false);
            modbusClient.WriteSingleCoil(17, false);
            modbusClient.WriteSingleCoil(18, false);
            modbusClient.WriteSingleCoil(19, true);
            modbusClient.WriteSingleCoil(20, false);
            modbusClient.WriteSingleCoil(21, false);
            modbusClient.WriteSingleCoil(22, false);
            modbusClient.WriteSingleCoil(12, !false);
            modbusClient.WriteSingleCoil(13, !false);
            modbusClient.WriteSingleCoil(14, !false);
            modbusClient.WriteSingleCoil(15, !false);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Хозяин пришел  " + "\r\n       " + "Произведены следущие действиея:" + "\r\n            " + "-Входная Дверь : Открыта   " + "\r\n            " + "-Черный Вход : Открыт    " + "\r\n            " + "-Ворота : Открыты    " + "\r\n            " + "-Гаражные Ворота : Открыты    " + "\r\n            " + "-Розетки : ON  " + "\r\n            " + "-Клапон Воды : ON " + "\r\n            " + "-Лампочки : ON  " + "\r\n            " + "-Датчики : OFF " + "\r\n            " + "-Аварийное Освещений : OFF " + "\r\n            " + "-Аварийная Вытяжка : OFF   " + "\r\n            " + "-Вентиляция : ON ");

            alrm1 = false;
            alrm2 = false;
            alrm3 = false;
            a1 = false;
            a2 = false;
            a3 = false;


            modbusClient.WriteSingleCoil(16, !false);
            modbusClient.WriteSingleCoil(17, !false);
            modbusClient.WriteSingleCoil(18, !false);
            modbusClient.WriteSingleCoil(19, !true);
            modbusClient.WriteSingleCoil(20, false);
            modbusClient.WriteSingleCoil(21, false);
            modbusClient.WriteSingleCoil(22, !false);
            modbusClient.WriteSingleCoil(12, false);
            modbusClient.WriteSingleCoil(13, false);
            modbusClient.WriteSingleCoil(14, false);
            modbusClient.WriteSingleCoil(15, false);

            alarmpc.Visible = false;
            alrm1 = false;
            alrm2 = false;
            alrm3 = false;
        }
       
        private void Door1_Click(object sender, EventArgs e)
        {
          if (!alrm1) modbusClient.WriteSingleCoil(12, !b13); 
          if(b13) File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Входная Дверь : Открыта "); else File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Входная Дверь : Закрыта ");
        }

        private void Door2_Click(object sender, EventArgs e)
        {
            if (!alrm1) modbusClient.WriteSingleCoil(13, !b14);
            if (b14) File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Черный Вход : Открыт "); else File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Черный Вход : Закрыт ");

        }

        private void Door3_Click(object sender, EventArgs e)
        {
            if (!alrm1) modbusClient.WriteSingleCoil(14, !b15);
            if (b15) File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Ворота : Открыты "); else File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Ворота : Закрыты ");

        }

        private void Door4_Click(object sender, EventArgs e)
        {
            if (!alrm1) modbusClient.WriteSingleCoil(15, !b16);
            if (b16) File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Гаражные Ворота : Открыты "); else File.AppendAllText(@"Alarm.txt", " " + "\r\n" + datetime.Text + " - " + " Гаражные Ворота : Закрыты ");

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                string s = textBox1.Text;
                modbusClient = new ModbusClient(s, 502);
                timer2.Enabled = true;
                modbusClient.Connect();
            }
            catch { MessageBox.Show("Ошибка. Не удалось подключится. \r\nПроверьте правильность введенного IPv4. "); }
        }
    }
}
