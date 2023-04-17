
namespace diseño
{
    partial class Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.txtProductos = new System.Windows.Forms.TextBox();
            this.Subtotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(254, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(608, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(39, 67);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(345, 150);
            this.dgvVentas.TabIndex = 6;
            this.dgvVentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellDoubleClick);
            // 
            // txtProductos
            // 
            this.txtProductos.Location = new System.Drawing.Point(39, 239);
            this.txtProductos.Multiline = true;
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.Size = new System.Drawing.Size(428, 62);
            this.txtProductos.TabIndex = 7;
            this.txtProductos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ventas_KeyPress);
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSize = true;
            this.Subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Subtotal.Location = new System.Drawing.Point(205, 317);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(82, 20);
            this.Subtotal.TabIndex = 8;
            this.Subtotal.Text = "Subtotal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(243, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Iva:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(227, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total:";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSub.Location = new System.Drawing.Point(293, 317);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(47, 20);
            this.lblSub.TabIndex = 11;
            this.lblSub.Text = "label";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIva.Location = new System.Drawing.Point(293, 351);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(47, 20);
            this.lblIva.TabIndex = 12;
            this.lblIva.Text = "label";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotal.Location = new System.Drawing.Point(293, 388);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 20);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "label";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(11)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(655, 429);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblIva);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Subtotal);
            this.Controls.Add(this.txtProductos);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ventas_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.TextBox txtProductos;
        private System.Windows.Forms.Label Subtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblTotal;
    }
}