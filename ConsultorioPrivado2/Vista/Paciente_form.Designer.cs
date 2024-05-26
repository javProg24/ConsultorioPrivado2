namespace ConsultorioPrivado.Vista
{
    partial class Paciente_form
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
            paciente_dgv = new DataGridView();
            label1 = new Label();
            nuevoPaciente_Button = new Button();
            ((System.ComponentModel.ISupportInitialize)paciente_dgv).BeginInit();
            SuspendLayout();
            // 
            // paciente_dgv
            // 
            paciente_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            paciente_dgv.Location = new Point(43, 104);
            paciente_dgv.Name = "paciente_dgv";
            paciente_dgv.Size = new Size(666, 178);
            paciente_dgv.TabIndex = 0;
            paciente_dgv.CellContentClick += paciente_dgv_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 60);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 1;
            label1.Text = "Pacientes Agregados:";
            // 
            // nuevoPaciente_Button
            // 
            nuevoPaciente_Button.Location = new Point(519, 60);
            nuevoPaciente_Button.Name = "nuevoPaciente_Button";
            nuevoPaciente_Button.Size = new Size(100, 25);
            nuevoPaciente_Button.TabIndex = 2;
            nuevoPaciente_Button.Text = "Nuevo Paciente";
            nuevoPaciente_Button.UseVisualStyleBackColor = true;
            nuevoPaciente_Button.Click += nuevoPaciente_Button_Click;
            // 
            // Paciente_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 405);
            Controls.Add(nuevoPaciente_Button);
            Controls.Add(label1);
            Controls.Add(paciente_dgv);
            Name = "Paciente_form";
            Text = "Paciente_form";
            Load += Paciente_form_Load;
            ((System.ComponentModel.ISupportInitialize)paciente_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView paciente_dgv;
        private Label label1;
        protected Button nuevoPaciente_Button;
    }
}