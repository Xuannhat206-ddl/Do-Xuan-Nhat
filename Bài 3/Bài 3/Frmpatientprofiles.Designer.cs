using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Bài_3
{
    partial class frmPatientProfiles
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvPatients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            SuspendLayout();
            //
            // dgvPatients
            //
            dgvPatients.AllowUserToAddRows = false;
            dgvPatients.AllowUserToDeleteRows = false;
            dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvPatients.Location = new System.Drawing.Point(0, 0);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.ReadOnly = true;
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.Size = new System.Drawing.Size(700, 400);
            dgvPatients.TabIndex = 0;
            //
            // frmPatientProfiles
            //
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(700, 400);
            Controls.Add(dgvPatients);
            Name = "frmPatientProfiles";
            Text = "Hồ sơ Bệnh nhân";
            Load += frmPatientProfiles_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvPatients;
    }
}