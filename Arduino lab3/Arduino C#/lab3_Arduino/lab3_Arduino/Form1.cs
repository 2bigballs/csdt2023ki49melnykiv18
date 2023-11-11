using lab3_Arduino.Models;
using System.IO.Ports;

namespace lab3_Arduino
{
    public enum ModeType
    {
        Off,
        StaticMode,
        SloweMode,
        MediumMode,
        FastMode,
        VeryFastMode,
        CustomMode
    }

    public partial class Form1 : Form
    {
        public bool isOn = false;
        public ModeType mode = ModeType.Off;
        SerialPort serialPort = new SerialPort("COM6", 9600);
        public List<IniModel> iniModels = new List<IniModel>();

        public Form1()
        {
            InitializeComponent();
            ChangeCheckStatusAllRadioBtn(false);
            DisableStatusRadioButton(false);
            serialPort.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ChangeCheckStatusAllRadioBtn(bool checkStatus)
        {
            if (checkStatus)
            {
                StaticRadioBtn.Checked = checkStatus;
                return;
            }

            DisableStatusRadioButton(false);
            StaticRadioBtn.Checked = checkStatus;
            SlowModeRadioBtn.Checked = checkStatus;
            MediumModeRadioBtn.Checked = checkStatus;
            FastModeRadioBtn.Checked = checkStatus;
            VeryFastModeRadioBtn.Checked = checkStatus;
            CustomModeRadioBtn.Checked = checkStatus;
        }

        private void DisableStatusRadioButton(bool status)
        {
            StaticRadioBtn.Enabled = status;
            SlowModeRadioBtn.Enabled = status;
            MediumModeRadioBtn.Enabled = status;
            FastModeRadioBtn.Enabled = status;
            VeryFastModeRadioBtn.Enabled = status;
            CustomModeRadioBtn.Enabled = status;
            CustomModeTextBox.Enabled = status;
        }

        private void StaticRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!isOn) return;

            iniModels.Clear();
            mode = ModeType.StaticMode;

            iniModels.Add(GetIniModelMode());
            WriteIni(iniModels);
            ReadIniAndSend();
        }

        private void SlowModeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!isOn) return;

            iniModels.Clear();
            mode = ModeType.SloweMode;

            iniModels.Add(GetIniModelMode());
            WriteIni(iniModels);
            ReadIniAndSend();
        }

        private void MediumModeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!isOn) return;

            iniModels.Clear();
            mode = ModeType.MediumMode;

            iniModels.Add(GetIniModelMode());
            WriteIni(iniModels);
            ReadIniAndSend();
        }

        private void FastModeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!isOn) return;

            iniModels.Clear();
            mode = ModeType.FastMode;

            iniModels.Add(GetIniModelMode());
            WriteIni(iniModels);
            ReadIniAndSend();
        }

        private void VeryFastModeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!isOn) return;

            iniModels.Clear();
            mode = ModeType.VeryFastMode;

            iniModels.Add(GetIniModelMode());
            WriteIni(iniModels);
            ReadIniAndSend();
        }

        private void CustomModeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!isOn) return;

            iniModels.Clear();

            mode = ModeType.CustomMode;

            iniModels.Add(GetIniModelMode());

            iniModels.Add(new IniModel()
            {
                Name = "delay",
                Value = CustomModeTextBox.Text
            });

            WriteIni(iniModels);
            ReadIniAndSend();
        }

        private IniModel GetIniModelMode()
        {
            var model = new IniModel()
            {
                Name = "mode",
                Value = ((int)mode).ToString(),
            };

            return model;
        }

        private void WriteIni(List<IniModel> iniModels)
        {
            string iniContents = "";
            foreach (var iniModel in iniModels)
            {
                iniContents += $"{iniModel.Name}={iniModel.Value}\n";
            }
            File.WriteAllText("data.ini", iniContents);
        }


        private void ReadIniAndSend()
        {
            using (StreamReader sr = new StreamReader("data.ini"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    serialPort.WriteLine(line);
                }
            }
        }

        private void CustomModeTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void OnOffBtn_Click(object sender, EventArgs e)
        {
            isOn = !isOn;

            if (isOn)
            {
                mode = ModeType.StaticMode;
                OnOffTextField.Text = "On";

                iniModels.Clear();
                iniModels.Add(GetIniModelMode());
                WriteIni(iniModels);
                ReadIniAndSend();

                ChangeCheckStatusAllRadioBtn(true);
                DisableStatusRadioButton(true);
            }
            else
            {
                mode = ModeType.Off;

                iniModels.Clear();
                iniModels.Add(GetIniModelMode());
                WriteIni(iniModels);
                ReadIniAndSend();

                OnOffTextField.Text = "Off";
                ChangeCheckStatusAllRadioBtn(false);
                DisableStatusRadioButton(false);
            }
        }

        private void SetBtn_Click(object sender, EventArgs e)
        {
            if (!isOn) return;

            iniModels.Clear();

            iniModels.Add(GetIniModelMode());

            iniModels.Add(new IniModel()
            {
                Name = "delay",
                Value = CustomModeTextBox.Text
            });

            WriteIni(iniModels);
            ReadIniAndSend();
        }
    }
}