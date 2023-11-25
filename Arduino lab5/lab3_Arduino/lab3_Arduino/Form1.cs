using lab3_Arduino.Models;
using System.IO.Ports;

namespace lab3_Arduino
{
    /// <summary>
    /// Mode type for LED stripe
    /// </summary>
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

    /// <summary>
    /// Main Form
    /// </summary>
    public partial class Form1 : Form
    {
        public bool isOn = false;
        public ModeType mode = ModeType.Off;
        public SerialPort serialPort = new SerialPort("COM6", 9600);
        public List<IniModel> iniModels = new List<IniModel>();

        /// <summary>
        /// Constructor Form for first initialize data
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            ChangeCheckStatusAllRadioBtn(false);
            DisableStatusRadioButton(false);
            //serialPort.Open();
        }

        /// <summary>
        /// Change status all radio button 
        /// </summary>
        public void ChangeCheckStatusAllRadioBtn(bool checkStatus)
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

        /// <summary>
        /// Set disable property in radio button
        /// </summary>
        public void DisableStatusRadioButton(bool status)
        {
            StaticRadioBtn.Enabled = status;
            SlowModeRadioBtn.Enabled = status;
            MediumModeRadioBtn.Enabled = status;
            FastModeRadioBtn.Enabled = status;
            VeryFastModeRadioBtn.Enabled = status;
            CustomModeRadioBtn.Enabled = status;
            CustomModeTextBox.Enabled = status;
        }

        /// <summary>
        /// Functional static mode radio button 
        /// </summary>
        public void StaticRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!isOn) return;

            iniModels.Clear();
            mode = ModeType.StaticMode;

            iniModels.Add(GetIniModelMode());
            WriteIni(iniModels);
            ReadIniAndSend();
        }

        /// <summary>
        /// Functional slowed mode radio button 
        /// </summary>
        public void SlowModeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!isOn) return;

            iniModels.Clear();
            mode = ModeType.SloweMode;

            iniModels.Add(GetIniModelMode());
            WriteIni(iniModels);
            ReadIniAndSend();
        }

        /// <summary>
        /// Functional medium mode radio button 
        /// </summary>
        public void MediumModeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!isOn) return;

            iniModels.Clear();
            mode = ModeType.MediumMode;

            iniModels.Add(GetIniModelMode());
            WriteIni(iniModels);
            ReadIniAndSend();
        }

        /// <summary>
        /// Functional fast mode radio button 
        /// </summary>
        public void FastModeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!isOn) return;

            iniModels.Clear();
            mode = ModeType.FastMode;

            iniModels.Add(GetIniModelMode());
            WriteIni(iniModels);
            ReadIniAndSend();
        }

        /// <summary>
        /// Functional very fast radio button 
        /// </summary>
        public void VeryFastModeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!isOn) return;

            iniModels.Clear();
            mode = ModeType.VeryFastMode;

            iniModels.Add(GetIniModelMode());
            WriteIni(iniModels);
            ReadIniAndSend();
        }

        /// <summary>
        /// Functional custom mode radio button 
        /// </summary>
        public void CustomModeRadioBtn_CheckedChanged(object sender, EventArgs e)
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

        /// <summary>
        /// Function return object type IniModel
        /// </summary>
        public IniModel GetIniModelMode()
        {
            var model = new IniModel()
            {
                Name = "mode",
                Value = ((int)mode).ToString(),
            };

            return model;
        }

        /// <summary>
        /// Function write data in ini file, if file name does not exist create new file 
        /// </summary>
        public void WriteIni(List<IniModel> iniModels)
        {
            string iniContents = "";
            foreach (var iniModel in iniModels)
            {
                iniContents += $"{iniModel.Name}={iniModel.Value}\n";
            }
            File.WriteAllText("data.ini", iniContents);
        }

        /// <summary>
        /// Function send file ini to arduino ide
        /// </summary>
        public void ReadIniAndSend()
        {
            using (StreamReader sr = new StreamReader("data.ini"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    //serialPort.WriteLine(line);
                }
            }
        }

        /// <summary>
        /// Function has logic with on/off button
        /// </summary>
        public void OnOffBtn_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Function set custom delay value 
        /// </summary>
        public void SetBtn_Click(object sender, EventArgs e)
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