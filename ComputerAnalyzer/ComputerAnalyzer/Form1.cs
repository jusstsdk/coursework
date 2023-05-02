using System.Data;
using System.Management;

namespace ComputerAnalyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hardwareComboBox.Items.Add("CPU");
            hardwareComboBox.Items.Add("GPU");
            hardwareComboBox.Items.Add("Motherboard");
            hardwareComboBox.SelectedIndex = 0;

            hardwareGridView.AllowUserToAddRows = false;
            hardwareGridView.AllowUserToDeleteRows = false;
            hardwareGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void hardwareComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Value", typeof(string));

            if (hardwareComboBox.SelectedIndex == 0)
            {
                foreach (var mo in new ManagementObjectSearcher("root\\cimv2", "select * from win32_processor").Get())
                {
                    table.Rows.Add("Name", (string)mo["name"]);
                    table.Rows.Add("Caption", (string)mo["caption"]);

                    string numberOfCores = mo["NumberOfCores"].ToString();
                    table.Rows.Add("NumberOfCors", numberOfCores);

                    string numberOfEnabledCore = mo["NumberOfEnabledCore"].ToString();
                    table.Rows.Add("NumberOfEnabledCore", numberOfEnabledCore);

                    string numberOfLogicalProcessors = mo["NumberOfLogicalProcessors"].ToString();
                    table.Rows.Add("NumberOfLogicalProcessors", numberOfLogicalProcessors);

                    string maxClockSpeed = mo["MaxClockSpeed"].ToString();
                    table.Rows.Add("MaxClockSpeed", maxClockSpeed);

                    string threadCount = mo["ThreadCount"].ToString();
                    table.Rows.Add("ThreadCount", threadCount);
                }
              
            }
            else if (hardwareComboBox.SelectedIndex == 1)
            {
                foreach (var mo in new ManagementObjectSearcher("root\\cimv2", "select * from win32_videocontroller").Get())
                {
                    table.Rows.Add("Name", (string)mo["name"]);
                    table.Rows.Add("AdapterCompatibility", (string)mo["AdapterCompatibility"]);
                    table.Rows.Add("DeviceID", (string)mo["DeviceID"]);

                    string availability = mo["Availability"].ToString();
                    table.Rows.Add("Availability", availability);

                    table.Rows.Add("", "");
                }
            }
            else if (hardwareComboBox.SelectedIndex == 2)
            {
                foreach (var mo in new ManagementObjectSearcher("root\\cimv2", "select * from win32_baseboard").Get())
                {
                    table.Rows.Add("Product", (string)mo["Product"]);
                    table.Rows.Add("Caption", (string)mo["caption"]);

                    string poweredOn = mo["PoweredOn"].ToString();
                    table.Rows.Add("PoweredOn", poweredOn);

                    table.Rows.Add("Manufacturer", (string)mo["Manufacturer"]);

                    string removable = mo["removable"].ToString();
                    table.Rows.Add("Removable", removable);

                    string replaceable = mo["replaceable"].ToString();
                    table.Rows.Add("Replaceable", replaceable);
                }
                  
            }

            hardwareGridView.DataSource = table;
        }
    }
}