using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace SerialPortEmulator
{
    public partial class Form1 : Form
    {
        //to be filled into AvailablePortsListBox
        private string[] availablePorts;

        //port names to assign into the SerialPort constructor param. eg:COM1,COM2,COM3,etc..
        private List<string> portNames = new List<string>();

        //list of real serial ports that has been added
        private List<SerialPort> realSerialPorts = new List<SerialPort>();

        //array of virtual serial ports. First port open from here. Second port from another software. Use pairing software to pair 2 ports
        private SerialPort[] virtualSerialPort = new SerialPort[2];

        public Form1()
        {
            InitializeComponent();

            #region assign all port names into availableports variable
            availablePorts = SerialPort.GetPortNames();
            #endregion

            #region add list of ports into the AvailablePortsListBox Component & VirtualPortsComboBox Component     
            foreach (var item in availablePorts)
            {
                AvailablePortsListBox.Items.Add(item);
                VirtualPort1ComboBox.Items.Add(item);
                VirtualPort2ComboBox.Items.Add(item);
            }
            #endregion
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            #region assign the selected item from the AvailablePortsListBox Componenet into a variable
            var selectedAvailablePorts = AvailablePortsListBox.SelectedItem;
            #endregion

            #region add the selected available ports into the AddedPortsListBox Component
            AddedPortsListBox.Items.Add(selectedAvailablePorts);
            #endregion

            #region remove the selected port from the AvailablePortsListBox Component once added
            AvailablePortsListBox.Items.Remove(selectedAvailablePorts);
            #endregion
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if(AddedPortsListBox.SelectedIndex != -1)
            {
                #region assign the selected added port item from the AddedPortsListBox Component into a variable
                var selectedAddedPorts = AddedPortsListBox.SelectedItem;
                #endregion

                #region remove the selected added ports into the AddedPortsListBox Component
                AddedPortsListBox.Items.Remove(selectedAddedPorts);
                #endregion

                #region add back the removed added ports into the AvailablePortsListBox Component
                AvailablePortsListBox.Items.Add(selectedAddedPorts);
                #endregion

                #region sort back the AvailablePortsListBox alphabetically
                AvailablePortsListBox.Sorted = true;
                #endregion
            }
        }

        private void ConfigurePorts()
        {
            foreach (var item in AddedPortsListBox.Items)
            {
                portNames.Add(item.ToString());
            }

            for (int i = 0; i < portNames.Count; i++)
            {
                realSerialPorts.Add(new SerialPort(portNames[i], 9600, Parity.None, 8, StopBits.One));

                realSerialPorts[i].Open();
            }

            string[] selectedVirtualPortNames = new string[2];

            selectedVirtualPortNames[0] = VirtualPort1ComboBox.SelectedItem.ToString();
            selectedVirtualPortNames[1] = VirtualPort1ComboBox.SelectedItem.ToString();

            virtualSerialPort[0] = new SerialPort(selectedVirtualPortNames[0], 9600, Parity.None, 8, StopBits.One);
            virtualSerialPort[1] = new SerialPort(selectedVirtualPortNames[1], 9600, Parity.None, 8, StopBits.One);

            virtualSerialPort[0].Open();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            ConfigurePorts();

            Connect();
        }

        private void Connect()
        {
            string[] values = new string[realSerialPorts.Count];

            string finalValue = null;

            while (true)
            {
                for (int i = 0; i < realSerialPorts.Count; i++)
                {
                    values[i] = realSerialPorts[i].ReadLine();
                    
                }

                virtualSerialPort[0].WriteLine(Int32.Parse(values[0]) + "," + values[1]);
            }
        }
    }
}
