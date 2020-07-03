using System.ComponentModel;

namespace POOF
{
    partial class UcEmplo
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
            this.dgvEmplo = new System.Windows.Forms.DataGridView();
            this.tlpEmplo = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmplo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.dgvEmplo)).BeginInit();
            this.tlpEmplo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmplo
            // 
            this.dgvEmplo.AllowUserToAddRows = false;
            this.dgvEmplo.AllowUserToDeleteRows = false;
            this.dgvEmplo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmplo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmplo.Location = new System.Drawing.Point(3, 70);
            this.dgvEmplo.Name = "dgvEmplo";
            this.dgvEmplo.ReadOnly = true;
            this.dgvEmplo.Size = new System.Drawing.Size(390, 331);
            this.dgvEmplo.TabIndex = 1;
            // 
            // tlpEmplo
            // 
            this.tlpEmplo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpEmplo.ColumnCount = 1;
            this.tlpEmplo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmplo.Controls.Add(this.dgvEmplo, 0, 1);
            this.tlpEmplo.Controls.Add(this.lblEmplo, 0, 0);
            this.tlpEmplo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEmplo.Location = new System.Drawing.Point(0, 0);
            this.tlpEmplo.Name = "tlpEmplo";
            this.tlpEmplo.RowCount = 2;
            this.tlpEmplo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpEmplo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tlpEmplo.Size = new System.Drawing.Size(396, 404);
            this.tlpEmplo.TabIndex = 2;
            // 
            // lblEmplo
            // 
            this.lblEmplo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmplo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblEmplo.Location = new System.Drawing.Point(3, 0);
            this.lblEmplo.Name = "lblEmplo";
            this.lblEmplo.Size = new System.Drawing.Size(390, 67);
            this.lblEmplo.TabIndex = 2;
            this.lblEmplo.Text = "Historial ";
            this.lblEmplo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // UcEmplo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpEmplo);
            this.Name = "UcEmplo";
            this.Size = new System.Drawing.Size(396, 404);
            this.Load += new System.EventHandler(this.UcEmplo_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dgvEmplo)).EndInit();
            this.tlpEmplo.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvEmplo;
        private System.Windows.Forms.Label lblEmplo;
        private System.Windows.Forms.TableLayoutPanel tlpEmplo;

        #endregion
    }
}