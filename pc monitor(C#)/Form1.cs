using System;
using OpenHardwareMonitor.Hardware;
using System.Windows.Forms;
using System.IO;
using System.Management;

namespace pc
{
    public partial class Form1 : Form
    {
        public class UpdateVisitor : IVisitor
        {
            public void VisitComputer(IComputer computer)
            {
                computer.Traverse(this);
            }
            public void VisitHardware(IHardware hardware)
            {
                hardware.Update();
                foreach (IHardware subHardware in hardware.SubHardware)
                    subHardware.Accept(this);
            }
            public void VisitSensor(ISensor sensor) { }
            public void VisitParameter(IParameter parameter) { }
        }
        static UpdateVisitor updateVisitor = new UpdateVisitor();
        static Computer computer = new Computer();
        public Form1()
        {
            computer.Open();

            computer.CPUEnabled = true;
            computer.GPUEnabled = true;
            computer.MainboardEnabled = true;
            computer.RAMEnabled = true;
            computer.FanControllerEnabled = true;
            computer.HDDEnabled = true;
            InitializeComponent();
            InitializeTimer();           
        }
        private void InitializeTimer()
        {            
            Timer1.Interval = 500;
            Timer1.Tick += new EventHandler(Timer1_Tick);
            Timer1.Enabled = true;
        }
        private void Timer1_Tick(object Sender, EventArgs e)
        {
            computer.Accept(updateVisitor);
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.CPU)
                {
                    cpuid.Text = computer.Hardware[i].Name;
                    int powertotal = 0;
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        //找到溫度
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                        {
                            if (computer.Hardware[i].Sensors[j].Name == "CPU Package")  //我只獲取整個package的溫度，需要其他core的溫度就改這裡
                                tempshow.Text = computer.Hardware[i].Sensors[j].Value.ToString() + "°C";
                        }
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Load)
                        {
                            if (computer.Hardware[i].Sensors[j].Name == "CPU Total")
                                circularProgressBar1.Value = (int)computer.Hardware[i].Sensors[j].Value;
                                circularProgressBar1.Text = circularProgressBar1.Value.ToString() + "%";
                                circularProgressBar1.Update();
                        }
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Power)
                        {
                            if (computer.Hardware[i].Sensors[j].Name == "CPU Package" || computer.Hardware[i].Sensors[j].Name == "CPU Cores" || computer.Hardware[i].Sensors[j].Name == "CPU Graphics" || computer.Hardware[i].Sensors[j].Name == "CPU DRAM")
                                powertotal += (int)computer.Hardware[i].Sensors[j].Value;
                        }
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Clock)
                        {
                            if (computer.Hardware[i].Sensors[j].Name == "CPU Core #1")
                            {
                                 float freq = (float)computer.Hardware[i].Sensors[j].Value;
                                 freq /= 1000;
                                 string freqtext = string.Format("{0:f2}", freq);
                                 freqshow.Text = freqtext + "GHz";
                            }
                        }
                    }
                    powershow.Text = powertotal.ToString() + " W";
                }
                if (computer.Hardware[i].HardwareType == HardwareType.RAM)
                {
                    MemoryID.Text = computer.Hardware[i].Name;
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Load)
                        {
                            if (computer.Hardware[i].Sensors[j].Name == "Memory")
                                circularProgressBar2.Value = (int)computer.Hardware[i].Sensors[j].Value;
                            circularProgressBar2.Text = circularProgressBar2.Value.ToString() + "%";
                            circularProgressBar2.Update();
                        }
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Data)
                        {
                            string memory;
                            if (computer.Hardware[i].Sensors[j].Name == "Used Memory")
                            {
                                memory = string.Format("{0:f2}", computer.Hardware[i].Sensors[j].Value);
                                usedmemoryshow.Text = memory + "GB";
                            }
                            if (computer.Hardware[i].Sensors[j].Name == "Available Memory")
                            {
                                memory = string.Format("{0:f2}", computer.Hardware[i].Sensors[j].Value);
                                availablememoryshow.Text = memory + "GB";
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.GpuNvidia)
                {
                    gpuid.Text = computer.Hardware[i].Name;
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Clock)
                        {
                            string gpustr;
                            if (computer.Hardware[i].Sensors[j].Name == "GPU Core")
                            {
                                gpustr = string.Format("{0:f2}", computer.Hardware[i].Sensors[j].Value);
                                gpucoreshow.Text = gpustr + "MHz";
                            }
                            if (computer.Hardware[i].Sensors[j].Name == "GPU Memory")
                            {
                                gpustr = string.Format("{0:f2}", computer.Hardware[i].Sensors[j].Value);
                                gpumemoryshow.Text = gpustr + "MHz";
                            }
                            if (computer.Hardware[i].Sensors[j].Name == "GPU Shader")
                            {
                                gpustr = string.Format("{0:f2}", computer.Hardware[i].Sensors[j].Value);
                                gpushadershow.Text = gpustr + "MHz";
                            }
                        }
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                        {
                            if (computer.Hardware[i].Sensors[j].Name == "GPU Core")
                            {
                                gputempshow.Text = computer.Hardware[i].Sensors[j].Value.ToString() + "°C";
                            }
                        }
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Fan)
                        {
                            if (computer.Hardware[i].Sensors[j].Name == "GPU")
                            {
                                gpufanshow.Text = computer.Hardware[i].Sensors[j].Value.ToString() + " RPM";
                            }
                        }

                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.SmallData)
                        {
                            if (computer.Hardware[i].Sensors[j].Name == "GPU Memory Free")
                            {
                                gpumemoryavailableshow.Text = computer.Hardware[i].Sensors[j].Value.ToString() + "MB";
                            }
                            if (computer.Hardware[i].Sensors[j].Name == "GPU Memory Used")
                            {
                                gpumemoryusedshow.Text = computer.Hardware[i].Sensors[j].Value.ToString() + "MB";
                            }
                            if (computer.Hardware[i].Sensors[j].Name == "GPU Memory Total")
                            {
                                gpumemorytotalshow.Text = computer.Hardware[i].Sensors[j].Value.ToString() + "MB";
                            }
                        }
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Load)
                        {
                            if (computer.Hardware[i].Sensors[j].Name == "GPU Core")
                            {
                                circularProgressBar3.Value = (int)computer.Hardware[i].Sensors[j].Value;
                                circularProgressBar3.Text = circularProgressBar3.Value.ToString() + "%";
                                circularProgressBar3.Update();
                            }
                            if (computer.Hardware[i].Sensors[j].Name == "GPU Memory")
                            {
                                circularProgressBar4.Value = (int)computer.Hardware[i].Sensors[j].Value;
                                circularProgressBar4.Text = circularProgressBar4.Value.ToString() + "%";
                                circularProgressBar4.Update();
                            }
                        }
                    }
                }
            }     
        }
    }
}
