using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeControlAudio
{
    public partial class frmMain : MetroForm
    {
        public int soma;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            muteOff();
            timer1.Interval = 1000;

            string[] tempo = txtTempo.Text.Split(':');

            int horas = Convert.ToInt32(tempo[0]);
            int minutos = Convert.ToInt32(tempo[1]);
            int segundos = Convert.ToInt32(tempo[2]);

            soma = (horas * 3600) + (minutos * 60) + segundos;
            timer1.Start();
        }

        private void btParar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            soma -= 1;
            string[] values = txtTempo.Text.Split(':');

            TimeSpan ts = TimeSpan.FromSeconds(soma);

            txtTempo.Text = ts.Hours.ToString().PadLeft(2, '0') +
                ts.Minutes.ToString().PadLeft(2, '0') +
                ts.Seconds.ToString().PadLeft(2, '0');

            if (soma == 0)
            {
                timer1.Stop();
                muteOn();
            }
        }
        private void muteOn()
        {
            try
            {
                //Instantiate an Enumerator to find audio devices
                NAudio.CoreAudioApi.MMDeviceEnumerator MMDE = new NAudio.CoreAudioApi.MMDeviceEnumerator();
                //Get all the devices, no matter what condition or status
                NAudio.CoreAudioApi.MMDeviceCollection DevCol = MMDE.EnumerateAudioEndPoints(NAudio.CoreAudioApi.DataFlow.All, NAudio.CoreAudioApi.DeviceState.All);
                //Loop through all devices
                foreach (NAudio.CoreAudioApi.MMDevice dev in DevCol)
                {
                    try
                    {
                        //Show us the human understandable name of the device
                        System.Diagnostics.Debug.Print(dev.FriendlyName);
                        //Mute it
                        dev.AudioEndpointVolume.Mute = true;
                    }
                    catch (Exception ex)
                    {
                        //Do something with exception when an audio endpoint could not be muted
                    }
                }
            }
            catch (Exception ex)
            {
                //When something happend that prevent us to iterate through the devices
            }
        }

        private void muteOff()
        {
            try
            {
                //Instantiate an Enumerator to find audio devices
                NAudio.CoreAudioApi.MMDeviceEnumerator MMDE = new NAudio.CoreAudioApi.MMDeviceEnumerator();
                //Get all the devices, no matter what condition or status
                NAudio.CoreAudioApi.MMDeviceCollection DevCol = MMDE.EnumerateAudioEndPoints(NAudio.CoreAudioApi.DataFlow.All, NAudio.CoreAudioApi.DeviceState.All);
                //Loop through all devices
                foreach (NAudio.CoreAudioApi.MMDevice dev in DevCol)
                {
                    try
                    {
                        //Show us the human understandable name of the device
                        System.Diagnostics.Debug.Print(dev.FriendlyName);
                        //Mute it
                        dev.AudioEndpointVolume.Mute = false;
                    }
                    catch (Exception ex)
                    {
                        //Do something with exception when an audio endpoint could not be muted
                    }
                }
            }
            catch (Exception ex)
            {
                //When something happend that prevent us to iterate through the devices
            }
        }
    }
}
