using System.ComponentModel;

namespace POOF
{
    partial class UcAdmin
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabAdminPage1 = new System.Windows.Forms.TabPage();
            this.btnAdminAddUser = new System.Windows.Forms.Button();
            this.txtAdminPass = new System.Windows.Forms.TextBox();
            this.lblAdminPass = new System.Windows.Forms.Label();
            this.lblAdminBirth = new System.Windows.Forms.Label();
            this.dtpAdminBirth = new System.Windows.Forms.DateTimePicker();
            this.txtAdminDUI = new System.Windows.Forms.TextBox();
            this.lblAdminDUI = new System.Windows.Forms.Label();
            this.txtAdminLname = new System.Windows.Forms.TextBox();
            this.lblAdminLname = new System.Windows.Forms.Label();
            this.cmbAdminDept = new System.Windows.Forms.ComboBox();
            this.lblAdminDept = new System.Windows.Forms.Label();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.lblVigil = new System.Windows.Forms.Label();
            this.tabAdminPage2 = new System.Windows.Forms.TabPage();
            this.tlpEmplo = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAdminLogs = new System.Windows.Forms.DataGridView();
            this.lblVigilRegister = new System.Windows.Forms.Label();
            this.tabAdminPage3 = new System.Windows.Forms.TabPage();
            this.dgvAdminSum2 = new System.Windows.Forms.DataGridView();
            this.lblAdminSum2 = new System.Windows.Forms.Label();
            this.dgvAdminSum = new System.Windows.Forms.DataGridView();
            this.lblAdminSum1 = new System.Windows.Forms.Label();
            this.tabAdmin.SuspendLayout();
            this.tabAdminPage1.SuspendLayout();
            this.tabAdminPage2.SuspendLayout();
            this.tlpEmplo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvAdminLogs)).BeginInit();
            this.tabAdminPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvAdminSum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvAdminSum)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabAdminPage1);
            this.tabAdmin.Controls.Add(this.tabAdminPage2);
            this.tabAdmin.Controls.Add(this.tabAdminPage3);
            this.tabAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAdmin.Location = new System.Drawing.Point(0, 0);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(521, 524);
            this.tabAdmin.TabIndex = 0;
            this.tabAdmin.SelectedIndexChanged += new System.EventHandler(this.tabAdmin_SelectedIndexChanged);
            // 
            // tabAdminPage1
            // 
            this.tabAdminPage1.Controls.Add(this.btnAdminAddUser);
            this.tabAdminPage1.Controls.Add(this.txtAdminPass);
            this.tabAdminPage1.Controls.Add(this.lblAdminPass);
            this.tabAdminPage1.Controls.Add(this.lblAdminBirth);
            this.tabAdminPage1.Controls.Add(this.dtpAdminBirth);
            this.tabAdminPage1.Controls.Add(this.txtAdminDUI);
            this.tabAdminPage1.Controls.Add(this.lblAdminDUI);
            this.tabAdminPage1.Controls.Add(this.txtAdminLname);
            this.tabAdminPage1.Controls.Add(this.lblAdminLname);
            this.tabAdminPage1.Controls.Add(this.cmbAdminDept);
            this.tabAdminPage1.Controls.Add(this.lblAdminDept);
            this.tabAdminPage1.Controls.Add(this.txtAdminName);
            this.tabAdminPage1.Controls.Add(this.lblAdminName);
            this.tabAdminPage1.Controls.Add(this.lblVigil);
            this.tabAdminPage1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabAdminPage1.Location = new System.Drawing.Point(4, 22);
            this.tabAdminPage1.Name = "tabAdminPage1";
            this.tabAdminPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminPage1.Size = new System.Drawing.Size(513, 498);
            this.tabAdminPage1.TabIndex = 0;
            this.tabAdminPage1.Text = "Mantenimiento";
            this.tabAdminPage1.UseVisualStyleBackColor = true;
            // 
            // btnAdminAddUser
            // 
            this.btnAdminAddUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAdminAddUser.Location = new System.Drawing.Point(176, 381);
            this.btnAdminAddUser.Name = "btnAdminAddUser";
            this.btnAdminAddUser.Size = new System.Drawing.Size(164, 45);
            this.btnAdminAddUser.TabIndex = 30;
            this.btnAdminAddUser.Text = "Crear usuario";
            this.btnAdminAddUser.UseVisualStyleBackColor = true;
            this.btnAdminAddUser.Click += new System.EventHandler(this.btnAdminAddUser_Click);
            // 
            // txtAdminPass
            // 
            this.txtAdminPass.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtAdminPass.Location = new System.Drawing.Point(235, 320);
            this.txtAdminPass.Name = "txtAdminPass";
            this.txtAdminPass.Size = new System.Drawing.Size(189, 25);
            this.txtAdminPass.TabIndex = 29;
            // 
            // lblAdminPass
            // 
            this.lblAdminPass.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAdminPass.Location = new System.Drawing.Point(74, 320);
            this.lblAdminPass.Name = "lblAdminPass";
            this.lblAdminPass.Size = new System.Drawing.Size(119, 25);
            this.lblAdminPass.TabIndex = 28;
            this.lblAdminPass.Text = "Contraseña: ";
            this.lblAdminPass.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblAdminBirth
            // 
            this.lblAdminBirth.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAdminBirth.Location = new System.Drawing.Point(74, 215);
            this.lblAdminBirth.Name = "lblAdminBirth";
            this.lblAdminBirth.Size = new System.Drawing.Size(155, 25);
            this.lblAdminBirth.TabIndex = 27;
            this.lblAdminBirth.Text = "Fecha de nacimiento: ";
            this.lblAdminBirth.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dtpAdminBirth
            // 
            this.dtpAdminBirth.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dtpAdminBirth.Location = new System.Drawing.Point(235, 215);
            this.dtpAdminBirth.Name = "dtpAdminBirth";
            this.dtpAdminBirth.Size = new System.Drawing.Size(189, 22);
            this.dtpAdminBirth.TabIndex = 26;
            // 
            // txtAdminDUI
            // 
            this.txtAdminDUI.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtAdminDUI.Location = new System.Drawing.Point(235, 164);
            this.txtAdminDUI.Name = "txtAdminDUI";
            this.txtAdminDUI.Size = new System.Drawing.Size(189, 25);
            this.txtAdminDUI.TabIndex = 25;
            // 
            // lblAdminDUI
            // 
            this.lblAdminDUI.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAdminDUI.Location = new System.Drawing.Point(74, 164);
            this.lblAdminDUI.Name = "lblAdminDUI";
            this.lblAdminDUI.Size = new System.Drawing.Size(144, 25);
            this.lblAdminDUI.TabIndex = 24;
            this.lblAdminDUI.Text = "DUI del empleado: ";
            this.lblAdminDUI.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtAdminLname
            // 
            this.txtAdminLname.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtAdminLname.Location = new System.Drawing.Point(235, 109);
            this.txtAdminLname.Name = "txtAdminLname";
            this.txtAdminLname.Size = new System.Drawing.Size(189, 25);
            this.txtAdminLname.TabIndex = 23;
            // 
            // lblAdminLname
            // 
            this.lblAdminLname.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAdminLname.Location = new System.Drawing.Point(74, 109);
            this.lblAdminLname.Name = "lblAdminLname";
            this.lblAdminLname.Size = new System.Drawing.Size(155, 25);
            this.lblAdminLname.TabIndex = 22;
            this.lblAdminLname.Text = "Apellido del empleado:";
            this.lblAdminLname.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbAdminDept
            // 
            this.cmbAdminDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdminDept.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbAdminDept.FormattingEnabled = true;
            this.cmbAdminDept.Location = new System.Drawing.Point(235, 267);
            this.cmbAdminDept.Name = "cmbAdminDept";
            this.cmbAdminDept.Size = new System.Drawing.Size(189, 25);
            this.cmbAdminDept.TabIndex = 19;
            // 
            // lblAdminDept
            // 
            this.lblAdminDept.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAdminDept.Location = new System.Drawing.Point(74, 263);
            this.lblAdminDept.Name = "lblAdminDept";
            this.lblAdminDept.Size = new System.Drawing.Size(119, 29);
            this.lblAdminDept.TabIndex = 18;
            this.lblAdminDept.Text = "Departamento: ";
            this.lblAdminDept.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtAdminName
            // 
            this.txtAdminName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtAdminName.Location = new System.Drawing.Point(235, 55);
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.Size = new System.Drawing.Size(189, 25);
            this.txtAdminName.TabIndex = 17;
            // 
            // lblAdminName
            // 
            this.lblAdminName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAdminName.Location = new System.Drawing.Point(74, 55);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(155, 25);
            this.lblAdminName.TabIndex = 16;
            this.lblAdminName.Text = "Nombre del empleado: ";
            this.lblAdminName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblVigil
            // 
            this.lblVigil.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblVigil.Location = new System.Drawing.Point(22, 3);
            this.lblVigil.Name = "lblVigil";
            this.lblVigil.Size = new System.Drawing.Size(374, 36);
            this.lblVigil.TabIndex = 15;
            this.lblVigil.Text = "Nuevo usuario: ";
            this.lblVigil.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tabAdminPage2
            // 
            this.tabAdminPage2.Controls.Add(this.tlpEmplo);
            this.tabAdminPage2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabAdminPage2.Location = new System.Drawing.Point(4, 22);
            this.tabAdminPage2.Name = "tabAdminPage2";
            this.tabAdminPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminPage2.Size = new System.Drawing.Size(513, 498);
            this.tabAdminPage2.TabIndex = 1;
            this.tabAdminPage2.Text = "Historial";
            this.tabAdminPage2.UseVisualStyleBackColor = true;
            // 
            // tlpEmplo
            // 
            this.tlpEmplo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpEmplo.ColumnCount = 1;
            this.tlpEmplo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmplo.Controls.Add(this.dgvAdminLogs, 0, 1);
            this.tlpEmplo.Controls.Add(this.lblVigilRegister, 0, 0);
            this.tlpEmplo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEmplo.Location = new System.Drawing.Point(3, 3);
            this.tlpEmplo.Name = "tlpEmplo";
            this.tlpEmplo.RowCount = 2;
            this.tlpEmplo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpEmplo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tlpEmplo.Size = new System.Drawing.Size(507, 492);
            this.tlpEmplo.TabIndex = 4;
            // 
            // dgvAdminLogs
            // 
            this.dgvAdminLogs.AllowUserToAddRows = false;
            this.dgvAdminLogs.AllowUserToDeleteRows = false;
            this.dgvAdminLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdminLogs.Location = new System.Drawing.Point(3, 85);
            this.dgvAdminLogs.Name = "dgvAdminLogs";
            this.dgvAdminLogs.ReadOnly = true;
            this.dgvAdminLogs.Size = new System.Drawing.Size(501, 404);
            this.dgvAdminLogs.TabIndex = 1;
            // 
            // lblVigilRegister
            // 
            this.lblVigilRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVigilRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblVigilRegister.Location = new System.Drawing.Point(3, 0);
            this.lblVigilRegister.Name = "lblVigilRegister";
            this.lblVigilRegister.Size = new System.Drawing.Size(501, 82);
            this.lblVigilRegister.TabIndex = 2;
            this.lblVigilRegister.Text = "Historial ";
            this.lblVigilRegister.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tabAdminPage3
            // 
            this.tabAdminPage3.Controls.Add(this.dgvAdminSum2);
            this.tabAdminPage3.Controls.Add(this.lblAdminSum2);
            this.tabAdminPage3.Controls.Add(this.dgvAdminSum);
            this.tabAdminPage3.Controls.Add(this.lblAdminSum1);
            this.tabAdminPage3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabAdminPage3.Location = new System.Drawing.Point(4, 22);
            this.tabAdminPage3.Name = "tabAdminPage3";
            this.tabAdminPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminPage3.Size = new System.Drawing.Size(513, 498);
            this.tabAdminPage3.TabIndex = 2;
            this.tabAdminPage3.Text = "Resúmenes";
            this.tabAdminPage3.UseVisualStyleBackColor = true;
            // 
            // dgvAdminSum2
            // 
            this.dgvAdminSum2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminSum2.Location = new System.Drawing.Point(6, 70);
            this.dgvAdminSum2.Name = "dgvAdminSum2";
            this.dgvAdminSum2.Size = new System.Drawing.Size(501, 133);
            this.dgvAdminSum2.TabIndex = 21;
            // 
            // lblAdminSum2
            // 
            this.lblAdminSum2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAdminSum2.Location = new System.Drawing.Point(6, 35);
            this.lblAdminSum2.Name = "lblAdminSum2";
            this.lblAdminSum2.Size = new System.Drawing.Size(235, 32);
            this.lblAdminSum2.TabIndex = 20;
            this.lblAdminSum2.Text = "Departamento mas concurrido: ";
            this.lblAdminSum2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dgvAdminSum
            // 
            this.dgvAdminSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminSum.Location = new System.Drawing.Point(6, 280);
            this.dgvAdminSum.Name = "dgvAdminSum";
            this.dgvAdminSum.Size = new System.Drawing.Size(501, 138);
            this.dgvAdminSum.TabIndex = 19;
            // 
            // lblAdminSum1
            // 
            this.lblAdminSum1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAdminSum1.Location = new System.Drawing.Point(6, 245);
            this.lblAdminSum1.Name = "lblAdminSum1";
            this.lblAdminSum1.Size = new System.Drawing.Size(235, 32);
            this.lblAdminSum1.TabIndex = 18;
            this.lblAdminSum1.Text = "Empleados dentro de la empresa: ";
            this.lblAdminSum1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // UcAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tabAdmin);
            this.Name = "UcAdmin";
            this.Size = new System.Drawing.Size(521, 524);
            this.tabAdmin.ResumeLayout(false);
            this.tabAdminPage1.ResumeLayout(false);
            this.tabAdminPage1.PerformLayout();
            this.tabAdminPage2.ResumeLayout(false);
            this.tlpEmplo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvAdminLogs)).EndInit();
            this.tabAdminPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvAdminSum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvAdminSum)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAdminAddUser;
        private System.Windows.Forms.ComboBox cmbAdminDept;
        private System.Windows.Forms.DataGridView dgvAdminLogs;
        private System.Windows.Forms.DataGridView dgvAdminSum;
        private System.Windows.Forms.DataGridView dgvAdminSum2;
        private System.Windows.Forms.DateTimePicker dtpAdminBirth;
        private System.Windows.Forms.Label lblAdminBirth;
        private System.Windows.Forms.Label lblAdminDept;
        private System.Windows.Forms.Label lblAdminDUI;
        private System.Windows.Forms.Label lblAdminLname;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label lblAdminPass;
        private System.Windows.Forms.Label lblAdminSum1;
        private System.Windows.Forms.Label lblAdminSum2;
        private System.Windows.Forms.Label lblVigil;
        private System.Windows.Forms.Label lblVigilRegister;
        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabAdminPage1;
        private System.Windows.Forms.TabPage tabAdminPage2;
        private System.Windows.Forms.TabPage tabAdminPage3;
        private System.Windows.Forms.TableLayoutPanel tlpEmplo;
        private System.Windows.Forms.TextBox txtAdminDUI;
        private System.Windows.Forms.TextBox txtAdminLname;
        private System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.TextBox txtAdminPass;

        #endregion
    }
}