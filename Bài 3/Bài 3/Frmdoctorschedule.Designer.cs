using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Bài_3
{
    partial class frmDoctorSchedule
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
            dgvSchedule = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();
            //
            // dgvSchedule
            //
            dgvSchedule.AllowUserToAddRows = false;
            dgvSchedule.AllowUserToDeleteRows = false;
            dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvSchedule.Location = new System.Drawing.Point(0, 0);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.ReadOnly = true;
            dgvSchedule.RowHeadersWidth = 51;
            dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvSchedule.Size = new System.Drawing.Size(700, 400);
            dgvSchedule.TabIndex = 0;
            //
            // frmDoctorSchedule
            //
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(700, 400);
            Controls.Add(dgvSchedule);
            Name = "frmDoctorSchedule";
            Text = "Lịch trực Bác sĩ";
            Load += frmDoctorSchedule_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvSchedule;
    }
}