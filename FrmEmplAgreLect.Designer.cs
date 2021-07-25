
namespace Proyecto_Biblioteca
{
    partial class FrmEmplAgreLect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmplAgreLect));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Guardar_NuevoLect = new System.Windows.Forms.Button();
            this.txt_ID_NuevoLect = new System.Windows.Forms.TextBox();
            this.txt_Nombre_NuevoLect = new System.Windows.Forms.TextBox();
            this.txt_Ape_NuevoLect = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(429, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(831, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUEVO LECTOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(95, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(95, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOMBRE: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(95, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "APELLIDO :";
            // 
            // btn_Guardar_NuevoLect
            // 
            this.btn_Guardar_NuevoLect.BackColor = System.Drawing.Color.Silver;
            this.btn_Guardar_NuevoLect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Guardar_NuevoLect.Location = new System.Drawing.Point(1127, 570);
            this.btn_Guardar_NuevoLect.Name = "btn_Guardar_NuevoLect";
            this.btn_Guardar_NuevoLect.Size = new System.Drawing.Size(262, 83);
            this.btn_Guardar_NuevoLect.TabIndex = 4;
            this.btn_Guardar_NuevoLect.Text = "Guardar";
            this.btn_Guardar_NuevoLect.UseVisualStyleBackColor = false;
            // 
            // txt_ID_NuevoLect
            // 
            this.txt_ID_NuevoLect.Location = new System.Drawing.Point(308, 266);
            this.txt_ID_NuevoLect.Name = "txt_ID_NuevoLect";
            this.txt_ID_NuevoLect.Size = new System.Drawing.Size(177, 44);
            this.txt_ID_NuevoLect.TabIndex = 5;
            // 
            // txt_Nombre_NuevoLect
            // 
            this.txt_Nombre_NuevoLect.Location = new System.Drawing.Point(308, 390);
            this.txt_Nombre_NuevoLect.Name = "txt_Nombre_NuevoLect";
            this.txt_Nombre_NuevoLect.Size = new System.Drawing.Size(169, 44);
            this.txt_Nombre_NuevoLect.TabIndex = 6;
            // 
            // txt_Ape_NuevoLect
            // 
            this.txt_Ape_NuevoLect.Location = new System.Drawing.Point(308, 504);
            this.txt_Ape_NuevoLect.Name = "txt_Ape_NuevoLect";
            this.txt_Ape_NuevoLect.Size = new System.Drawing.Size(169, 44);
            this.txt_Ape_NuevoLect.TabIndex = 7;
            // 
            // FrmEmplAgreLect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1597, 754);
            this.Controls.Add(this.txt_Ape_NuevoLect);
            this.Controls.Add(this.txt_Nombre_NuevoLect);
            this.Controls.Add(this.txt_ID_NuevoLect);
            this.Controls.Add(this.btn_Guardar_NuevoLect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEmplAgreLect";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGREGAR LECTOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Guardar_NuevoLect;
        private System.Windows.Forms.TextBox txt_ID_NuevoLect;
        private System.Windows.Forms.TextBox txt_Nombre_NuevoLect;
        private System.Windows.Forms.TextBox txt_Ape_NuevoLect;
    }
}