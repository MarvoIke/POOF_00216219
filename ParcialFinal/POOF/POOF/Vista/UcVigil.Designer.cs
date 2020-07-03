using System.ComponentModel;

namespace POOF
{
    partial class UcVigil
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
            this.tabVigil = new System.Windows.Forms.TabControl();
            this.tabVigilPage1 = new System.Windows.Forms.TabPage();
            this.btnVigil = new System.Windows.Forms.Button();
            this.txtVigilTemp = new System.Windows.Forms.TextBox();
            this.lblVigilTemp = new System.Windows.Forms.Label();
            this.cmbVigilInOut = new System.Windows.Forms.ComboBox();
            this.lblVigilInOut = new System.Windows.Forms.Label();
            this.txtVigilUser = new System.Windows.Forms.TextBox();
            this.lblVigilUser = new System.Windows.Forms.Label();
            this.lblVigil = new System.Windows.Forms.Label();
            this.tabVigilPage2 = new System.Windows.Forms.TabPage();
            this.tlpEmplo = new System.Windows.Forms.TableLayoutPanel();
            this.dgvVigil = new System.Windows.Forms.DataGridView();
            this.lblVigilRegister = new System.Windows.Forms.Label();
            this.tabVigil.SuspendLayout();
            this.tabVigilPage1.SuspendLayout();
            this.tabVigilPage2.SuspendLayout();
            this.tlpEmplo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvVigil)).BeginInit();
            this.SuspendLayout();
            // 
            // tabVigil
            // 
            this.tabVigil.Controls.Add(this.tabVigilPage1);
            this.tabVigil.Controls.Add(this.tabVigilPage2);
            this.tabVigil.Location = new System.Drawing.Point(0, 0);
            this.tabVigil.Name = "tabVigil";
            this.tabVigil.SelectedIndex = 0;
            this.tabVigil.Size = new System.Drawing.Size(466, 443);
            this.tabVigil.TabIndex = 0;
            // 
            // tabVigilPage1
            // 
            this.tabVigilPage1.Controls.Add(this.btnVigil);
            this.tabVigilPage1.Controls.Add(this.txtVigilTemp);
            this.tabVigilPage1.Controls.Add(this.lblVigilTemp);
            this.tabVigilPage1.Controls.Add(this.cmbVigilInOut);
            this.tabVigilPage1.Controls.Add(this.lblVigilInOut);
            this.tabVigilPage1.Controls.Add(this.txtVigilUser);
            this.tabVigilPage1.Controls.Add(this.lblVigilUser);
            this.tabVigilPage1.Controls.Add(this.lblVigil);
            this.tabVigilPage1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabVigilPage1.Location = new System.Drawing.Point(4, 22);
            this.tabVigilPage1.Name = "tabVigilPage1";
            this.tabVigilPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabVigilPage1.Size = new System.Drawing.Size(458, 417);
            this.tabVigilPage1.TabIndex = 0;
            this.tabVigilPage1.Text = "Asistencia";
            this.tabVigilPage1.UseVisualStyleBackColor = true;
            // 
            // btnVigil
            // 
            this.btnVigil.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnVigil.Location = new System.Drawing.Point(154, 339);
            this.btnVigil.Name = "btnVigil";
            this.btnVigil.Size = new System.Drawing.Size(164, 45);
            this.btnVigil.TabIndex = 15;
            this.btnVigil.Text = "Listo";
            this.btnVigil.UseVisualStyleBackColor = true;
            this.btnVigil.Click += new System.EventHandler(this.btnVigil_Click);
            // 
            // txtVigilTemp
            // 
            this.txtVigilTemp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtVigilTemp.Location = new System.Drawing.Point(243, 271);
            this.txtVigilTemp.Name = "txtVigilTemp";
            this.txtVigilTemp.Size = new System.Drawing.Size(161, 29);
            this.txtVigilTemp.TabIndex = 14;
            // 
            // lblVigilTemp
            // 
            this.lblVigilTemp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblVigilTemp.Location = new System.Drawing.Point(70, 255);
            this.lblVigilTemp.Name = "lblVigilTemp";
            this.lblVigilTemp.Size = new System.Drawing.Size(167, 45);
            this.lblVigilTemp.TabIndex = 13;
            this.lblVigilTemp.Text = "Temperatura del empleado: ";
            // 
            // cmbVigilInOut
            // 
            this.cmbVigilInOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVigilInOut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbVigilInOut.FormattingEnabled = true;
            this.cmbVigilInOut.Location = new System.Drawing.Point(243, 190);
            this.cmbVigilInOut.Name = "cmbVigilInOut";
            this.cmbVigilInOut.Size = new System.Drawing.Size(159, 29);
            this.cmbVigilInOut.TabIndex = 12;
            // 
            // lblVigilInOut
            // 
            this.lblVigilInOut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblVigilInOut.Location = new System.Drawing.Point(70, 190);
            this.lblVigilInOut.Name = "lblVigilInOut";
            this.lblVigilInOut.Size = new System.Drawing.Size(167, 32);
            this.lblVigilInOut.TabIndex = 11;
            this.lblVigilInOut.Text = "Empleado está: ";
            this.lblVigilInOut.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtVigilUser
            // 
            this.txtVigilUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtVigilUser.Location = new System.Drawing.Point(243, 119);
            this.txtVigilUser.Name = "txtVigilUser";
            this.txtVigilUser.Size = new System.Drawing.Size(161, 29);
            this.txtVigilUser.TabIndex = 10;
            // 
            // lblVigilUser
            // 
            this.lblVigilUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblVigilUser.Location = new System.Drawing.Point(70, 119);
            this.lblVigilUser.Name = "lblVigilUser";
            this.lblVigilUser.Size = new System.Drawing.Size(167, 32);
            this.lblVigilUser.TabIndex = 9;
            this.lblVigilUser.Text = "Carné del empleado: ";
            this.lblVigilUser.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblVigil
            // 
            this.lblVigil.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblVigil.Location = new System.Drawing.Point(55, 3);
            this.lblVigil.Name = "lblVigil";
            this.lblVigil.Size = new System.Drawing.Size(374, 48);
            this.lblVigil.TabIndex = 8;
            this.lblVigil.Text = "Asistencia: ";
            this.lblVigil.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tabVigilPage2
            // 
            this.tabVigilPage2.Controls.Add(this.tlpEmplo);
            this.tabVigilPage2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabVigilPage2.Location = new System.Drawing.Point(4, 22);
            this.tabVigilPage2.Name = "tabVigilPage2";
            this.tabVigilPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabVigilPage2.Size = new System.Drawing.Size(458, 417);
            this.tabVigilPage2.TabIndex = 1;
            this.tabVigilPage2.Text = "Registros";
            this.tabVigilPage2.UseVisualStyleBackColor = true;
            // 
            // tlpEmplo
            // 
            this.tlpEmplo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpEmplo.ColumnCount = 1;
            this.tlpEmplo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmplo.Controls.Add(this.dgvVigil, 0, 1);
            this.tlpEmplo.Controls.Add(this.lblVigilRegister, 0, 0);
            this.tlpEmplo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEmplo.Location = new System.Drawing.Point(3, 3);
            this.tlpEmplo.Name = "tlpEmplo";
            this.tlpEmplo.RowCount = 2;
            this.tlpEmplo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpEmplo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tlpEmplo.Size = new System.Drawing.Size(452, 411);
            this.tlpEmplo.TabIndex = 3;
            // 
            // dgvVigil
            // 
            this.dgvVigil.AllowUserToAddRows = false;
            this.dgvVigil.AllowUserToDeleteRows = false;
            this.dgvVigil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVigil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVigil.Location = new System.Drawing.Point(3, 71);
            this.dgvVigil.Name = "dgvVigil";
            this.dgvVigil.ReadOnly = true;
            this.dgvVigil.Size = new System.Drawing.Size(446, 337);
            this.dgvVigil.TabIndex = 1;
            // 
            // lblVigilRegister
            // 
            this.lblVigilRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVigilRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblVigilRegister.Location = new System.Drawing.Point(3, 0);
            this.lblVigilRegister.Name = "lblVigilRegister";
            this.lblVigilRegister.Size = new System.Drawing.Size(446, 68);
            this.lblVigilRegister.TabIndex = 2;
            this.lblVigilRegister.Text = "Historial ";
            this.lblVigilRegister.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // UcVigil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabVigil);
            this.Name = "UcVigil";
            this.Size = new System.Drawing.Size(506, 462);
            this.Load += new System.EventHandler(this.UcVigil_Load);
            this.tabVigil.ResumeLayout(false);
            this.tabVigilPage1.ResumeLayout(false);
            this.tabVigilPage1.PerformLayout();
            this.tabVigilPage2.ResumeLayout(false);
            this.tlpEmplo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvVigil)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnVigil;
        private System.Windows.Forms.ComboBox cmbVigilInOut;
        private System.Windows.Forms.DataGridView dgvVigil;
        private System.Windows.Forms.Label lblVigil;
        private System.Windows.Forms.Label lblVigilInOut;
        private System.Windows.Forms.Label lblVigilRegister;
        private System.Windows.Forms.Label lblVigilTemp;
        private System.Windows.Forms.Label lblVigilUser;
        private System.Windows.Forms.TabControl tabVigil;
        private System.Windows.Forms.TabPage tabVigilPage1;
        private System.Windows.Forms.TabPage tabVigilPage2;
        private System.Windows.Forms.TableLayoutPanel tlpEmplo;
        private System.Windows.Forms.TextBox txtVigilTemp;
        private System.Windows.Forms.TextBox txtVigilUser;

        #endregion
    }
}