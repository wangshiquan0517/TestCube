using System;
using System.Windows.Forms;

namespace TestCube.UISamples
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            WireEvents();
        }

        private void WireEvents()
        {
            this.Load += MainForm_Load;
            btnReadNow.Click += BtnReadNow_Click;
            btnAddGraph.Click += BtnAddGraph_Click;
            btnImport.Click += BtnImport_Click;
            btnExport.Click += BtnExport_Click;
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            // Example: populate tree with a sample connection and device
            var root = new TreeNode("Connections");
            var conn = new TreeNode("COM3 9600 - MainBus");
            conn.Nodes.Add(new TreeNode("DemoMeterA (SN001)"));
            root.Nodes.Add(conn);
            treeConnections.Nodes.Add(root);
            root.Expand();

            // Example: setup DataGridView columns
            if (dgvDevices.Columns.Count == 0)
            {
                dgvDevices.Columns.Add("Model", "Model");
                dgvDevices.Columns.Add("SN", "SN");
                dgvDevices.Columns.Add("Address", "Address");
                dgvDevices.Columns.Add("Protocol", "Protocol");
                dgvDevices.AutoResizeColumns();
            }
        }

        private void BtnImport_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Import action (placeholder)");
        }

        private void BtnExport_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Export action (placeholder)");
        }

        private void BtnReadNow_Click(object? sender, EventArgs e)
        {
            // Placeholder: start a single read operation (should be async in real code)
            toolStripStatusLabel.Text = "Reading...";
            // Simulate done
            timerSimulateStop.Start();
        }

        private void BtnAddGraph_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Add to graph (placeholder)");
        }

        private void TimerSimulateStop_Tick(object? sender, EventArgs e)
        {
            timerSimulateStop.Stop();
            toolStripStatusLabel.Text = "Ready";
            MessageBox.Show("Read completed (simulated)");
        }
    }
}