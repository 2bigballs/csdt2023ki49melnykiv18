using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab3_Arduino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab3_Arduino.Models;
using Moq;
using System.IO.Ports;
using System.Windows.Forms;

namespace lab3_Arduino.Tests
{
    public class SerialPortWrapper : ISerialPort
    {
        private readonly SerialPort _serialPort;

        public SerialPortWrapper(SerialPort serialPort)
        {
            _serialPort = serialPort;
        }
        public void WriteLine(string value)
        {
            _serialPort.WriteLine(value);
        }
    }

    // Інтерфейс для SerialPort, щоб його можна було мокувати.
    public interface ISerialPort
    {
        void WriteLine(string value);
    }

    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        [DataRow(true)]
        public void ChangeCheckStatusAllRadioBtnTestTrue(bool checkStatus)
        {
            var form = new Form1();

            // Act
            form.ChangeCheckStatusAllRadioBtn(checkStatus);

            // Assert
            Assert.IsTrue(form.StaticRadioBtn.Checked);
            Assert.IsFalse(form.SlowModeRadioBtn.Checked);
            Assert.IsFalse(form.MediumModeRadioBtn.Checked);
            Assert.IsFalse(form.FastModeRadioBtn.Checked);
            Assert.IsFalse(form.VeryFastModeRadioBtn.Checked);
            Assert.IsFalse(form.CustomModeRadioBtn.Checked);
        }

        [TestMethod()]
        [DataRow(false)]
        public void ChangeCheckStatusAllRadioBtnTestFalse(bool checkStatus)
        {
            var form = new Form1();

            // Act
            form.ChangeCheckStatusAllRadioBtn(checkStatus);

            // Assert
            Assert.IsFalse(form.StaticRadioBtn.Checked);
            Assert.IsFalse(form.SlowModeRadioBtn.Checked);
            Assert.IsFalse(form.MediumModeRadioBtn.Checked);
            Assert.IsFalse(form.FastModeRadioBtn.Checked);
            Assert.IsFalse(form.VeryFastModeRadioBtn.Checked);
            Assert.IsFalse(form.CustomModeRadioBtn.Checked);
        }


        [TestMethod]
        [DataRow(true)]
        public void DisableStatusRadioButtonTestTrue(bool status)
        {
            // Arrange
            var form = new Form1();

            // Act
            form.DisableStatusRadioButton(status);

            // Assert
            Assert.IsTrue(form.StaticRadioBtn.Enabled);
            Assert.IsTrue(form.SlowModeRadioBtn.Enabled);
            Assert.IsTrue(form.MediumModeRadioBtn.Enabled);
            Assert.IsTrue(form.FastModeRadioBtn.Enabled);
            Assert.IsTrue(form.VeryFastModeRadioBtn.Enabled);
            Assert.IsTrue(form.CustomModeRadioBtn.Enabled);
            Assert.IsTrue(form.CustomModeTextBox.Enabled);
        }

        [TestMethod]
        [DataRow(false)]
        public void DisableStatusRadioButtonTestFalse(bool status)
        {
            // Arrange
            var form = new Form1();

            // Act
            form.DisableStatusRadioButton(status);

            // Assert
            Assert.IsFalse(form.StaticRadioBtn.Enabled);
            Assert.IsFalse(form.SlowModeRadioBtn.Enabled);
            Assert.IsFalse(form.MediumModeRadioBtn.Enabled);
            Assert.IsFalse(form.FastModeRadioBtn.Enabled);
            Assert.IsFalse(form.VeryFastModeRadioBtn.Enabled);
            Assert.IsFalse(form.CustomModeRadioBtn.Enabled);
            Assert.IsFalse(form.CustomModeTextBox.Enabled);
        }

        [TestMethod]
        public void GetIniModelModeTest()
        {
            // Arrange
            var form = new Form1();
            form.mode = ModeType.FastMode;

            // Act
            var result = form.GetIniModelMode();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("mode", result.Name);
            Assert.AreEqual("4", result.Value); 
        }

        [TestMethod()]
        public void WriteIniTest()
        {
            // Arrange
            var form = new Form1();
            var iniModels = new List<IniModel>
            {
                new IniModel { Name = "mode", Value = "1" },
                new IniModel { Name = "delay", Value = "100" }
            };

            // Act
            form.WriteIni(iniModels);

            // Assert
            string contents = File.ReadAllText("data.ini");
            Assert.IsTrue(contents.Contains("mode=1"));
            Assert.IsTrue(contents.Contains("delay=100"));
        }

        [TestMethod()]
        public void StaticRadioBtnTest()
        {
            // Arrange
            var form = new Form1();
            form.isOn = true;
            bool eventHandled = false;

            // Subscribe to the event to check its handling
            form.StaticRadioBtn.CheckedChanged += (sender, args) => eventHandled = true;

            // Act
            form.StaticRadioBtn.Checked = true;

            // Manually trigger the CheckedChanged event
            form.StaticRadioBtn_CheckedChanged(null, EventArgs.Empty);

            // Assert
            Assert.IsTrue(eventHandled, "CheckedChanged event should be handled");
            Assert.AreEqual(ModeType.StaticMode, form.mode);
        }

        [TestMethod()]
        public void SlowedRadioBtnTest()
        {
            // Arrange
            var form = new Form1();
            form.isOn = true;
            bool eventHandled = false;

            // Subscribe to the event to check its handling
            form.SlowModeRadioBtn.CheckedChanged += (sender, args) => eventHandled = true;

            // Act
            form.SlowModeRadioBtn.Checked = true;

            // Manually trigger the CheckedChanged event
            form.SlowModeRadioBtn_CheckedChanged(null, EventArgs.Empty);

            // Assert
            Assert.IsTrue(eventHandled, "CheckedChanged event should be handled");
            Assert.AreEqual(ModeType.SloweMode, form.mode);
        }

        [TestMethod()]
        public void MediumRadioBtnTest()
        {
            // Arrange
            var form = new Form1();
            form.isOn = true;
            bool eventHandled = false;

            // Subscribe to the event to check its handling
            form.MediumModeRadioBtn.CheckedChanged += (sender, args) => eventHandled = true;

            // Act
            form.MediumModeRadioBtn.Checked = true;

            // Manually trigger the CheckedChanged event
            form.MediumModeRadioBtn_CheckedChanged(null, EventArgs.Empty);

            // Assert
            Assert.IsTrue(eventHandled, "CheckedChanged event should be handled");
            Assert.AreEqual(ModeType.MediumMode, form.mode);
        }

        [TestMethod()]
        public void FastRadioBtnTest()
        {
            // Arrange
            var form = new Form1();
            form.isOn = true;
            bool eventHandled = false;

            // Subscribe to the event to check its handling
            form.FastModeRadioBtn.CheckedChanged += (sender, args) => eventHandled = true;

            // Act
            form.FastModeRadioBtn.Checked = true;

            // Manually trigger the CheckedChanged event
            form.FastModeRadioBtn_CheckedChanged(null, EventArgs.Empty);

            // Assert
            Assert.IsTrue(eventHandled, "CheckedChanged event should be handled");
            Assert.AreEqual(ModeType.FastMode, form.mode);
        }

        [TestMethod()]
        public void VeryFastRadioBtnTest()
        {
            // Arrange
            var form = new Form1();
            form.isOn = true;
            bool eventHandled = false;

            // Subscribe to the event to check its handling
            form.VeryFastModeRadioBtn.CheckedChanged += (sender, args) => eventHandled = true;

            // Act
            form.VeryFastModeRadioBtn.Checked = true;

            // Manually trigger the CheckedChanged event
            form.VeryFastModeRadioBtn_CheckedChanged(null, EventArgs.Empty);

            // Assert
            Assert.IsTrue(eventHandled, "CheckedChanged event should be handled");
            Assert.AreEqual(ModeType.VeryFastMode, form.mode);
        }

        [TestMethod()]
        public void CustomRadioBtnTest()
        {
            // Arrange
            var form = new Form1();
            form.isOn = true;
            bool eventHandled = false;

            // Subscribe to the event to check its handling
            form.CustomModeRadioBtn.CheckedChanged += (sender, args) => eventHandled = true;

            // Act
            form.CustomModeRadioBtn.Checked = true;

            // Manually trigger the CheckedChanged event
            form.CustomModeRadioBtn_CheckedChanged(null, EventArgs.Empty);

            // Assert
            Assert.IsTrue(eventHandled, "CheckedChanged event should be handled");
            Assert.AreEqual(ModeType.CustomMode, form.mode);
        }

        [TestMethod]
        [DataRow(true)]
        public void OffBtnTest(bool currentStateIsOn)
        {
            // Arrange
            var form = new Form1();
            form.isOn = currentStateIsOn;

            form.OnOffBtn_Click(null, EventArgs.Empty);

            Assert.AreEqual(ModeType.Off, form.mode);
        }

        [TestMethod]
        [DataRow(false)]
        public void OnBtnTest(bool currentStateIsOn)
        {
            // Arrange
            var form = new Form1();
            form.isOn = currentStateIsOn;

            form.OnOffBtn_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual(ModeType.StaticMode, form.mode);
        }

    }
}