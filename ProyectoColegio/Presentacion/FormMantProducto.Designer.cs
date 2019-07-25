namespace MODERN_GUI_2
{
    partial class FormMantProducto
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpreciofff = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtdescrip = new System.Windows.Forms.TextBox();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("DFMincho-W5", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(37, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(129, 37);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(244, 24);
            this.txtid.TabIndex = 26;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(431, 190);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 35);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(287, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 24;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DFMincho-W5", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(37, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Stock:";
            // 
            // txtpreciofff
            // 
            this.txtpreciofff.AutoSize = true;
            this.txtpreciofff.Font = new System.Drawing.Font("DFMincho-W5", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreciofff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpreciofff.Location = new System.Drawing.Point(37, 125);
            this.txtpreciofff.Name = "txtpreciofff";
            this.txtpreciofff.Size = new System.Drawing.Size(54, 17);
            this.txtpreciofff.TabIndex = 22;
            this.txtpreciofff.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DFMincho-W5", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(37, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DFMincho-W5", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(37, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Categoria:";
            // 
            // txtstock
            // 
            this.txtstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstock.Location = new System.Drawing.Point(129, 151);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(244, 24);
            this.txtstock.TabIndex = 19;
            // 
            // txtprecio
            // 
            this.txtprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(129, 122);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(244, 24);
            this.txtprecio.TabIndex = 18;
            // 
            // txtdescrip
            // 
            this.txtdescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescrip.Location = new System.Drawing.Point(129, 93);
            this.txtdescrip.Name = "txtdescrip";
            this.txtdescrip.Size = new System.Drawing.Size(244, 24);
            this.txtdescrip.TabIndex = 17;
            // 
            // txtcategoria
            // 
            this.txtcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategoria.Location = new System.Drawing.Point(129, 64);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(244, 24);
            this.txtcategoria.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MODERN_GUI_2.Properties.Resources.icono_cliente;
            this.pictureBox1.Location = new System.Drawing.Point(413, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // FormMantProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(567, 238);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpreciofff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtdescrip);
            this.Controls.Add(this.txtcategoria);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMantProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormMantProducto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtpreciofff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.TextBox txtstock;
        public System.Windows.Forms.TextBox txtprecio;
        public System.Windows.Forms.TextBox txtdescrip;
        public System.Windows.Forms.TextBox txtcategoria;
    }
}