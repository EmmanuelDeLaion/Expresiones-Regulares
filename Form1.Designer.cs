namespace Automatas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtQ0 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtQ1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtQ2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQ0
            // 
            this.txtQ0.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txtQ0.BorderColorIdle = System.Drawing.Color.SlateBlue;
            this.txtQ0.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtQ0.BorderThickness = 1;
            this.txtQ0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQ0.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQ0.ForeColor = System.Drawing.Color.Silver;
            this.txtQ0.isPassword = false;
            this.txtQ0.Location = new System.Drawing.Point(71, 65);
            this.txtQ0.Margin = new System.Windows.Forms.Padding(4);
            this.txtQ0.Name = "txtQ0";
            this.txtQ0.Size = new System.Drawing.Size(292, 44);
            this.txtQ0.TabIndex = 0;
            this.txtQ0.Text = "Ingrese q0";
            this.txtQ0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQ0.OnValueChanged += new System.EventHandler(this.txtQ1_OnValueChanged);
            this.txtQ0.Enter += new System.EventHandler(this.txtQ0_Enter);
            this.txtQ0.Leave += new System.EventHandler(this.txtQ0_Leave);
            // 
            // txtQ1
            // 
            this.txtQ1.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txtQ1.BorderColorIdle = System.Drawing.Color.DarkViolet;
            this.txtQ1.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtQ1.BorderThickness = 1;
            this.txtQ1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQ1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQ1.ForeColor = System.Drawing.Color.Silver;
            this.txtQ1.isPassword = false;
            this.txtQ1.Location = new System.Drawing.Point(71, 128);
            this.txtQ1.Margin = new System.Windows.Forms.Padding(4);
            this.txtQ1.Name = "txtQ1";
            this.txtQ1.Size = new System.Drawing.Size(292, 44);
            this.txtQ1.TabIndex = 1;
            this.txtQ1.Text = "Ingrese q1";
            this.txtQ1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQ1.OnValueChanged += new System.EventHandler(this.txtQ1_OnValueChanged_1);
            this.txtQ1.Enter += new System.EventHandler(this.txtQ1_Enter);
            this.txtQ1.Leave += new System.EventHandler(this.txtQ1_Leave);
            // 
            // txtQ2
            // 
            this.txtQ2.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txtQ2.BorderColorIdle = System.Drawing.Color.Crimson;
            this.txtQ2.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtQ2.BorderThickness = 1;
            this.txtQ2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQ2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQ2.ForeColor = System.Drawing.Color.Silver;
            this.txtQ2.isPassword = false;
            this.txtQ2.Location = new System.Drawing.Point(71, 192);
            this.txtQ2.Margin = new System.Windows.Forms.Padding(4);
            this.txtQ2.Name = "txtQ2";
            this.txtQ2.Size = new System.Drawing.Size(292, 44);
            this.txtQ2.TabIndex = 2;
            this.txtQ2.Text = "Ingrese q2";
            this.txtQ2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQ2.OnValueChanged += new System.EventHandler(this.txtQ3_OnValueChanged);
            this.txtQ2.Enter += new System.EventHandler(this.txtQ2_Enter);
            this.txtQ2.Leave += new System.EventHandler(this.txtQ2_Leave);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(105, 256);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(107, 58);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(405, 65);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(355, 195);
            this.txtResultado.TabIndex = 4;
            this.txtResultado.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Expresiones regulares";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "q0:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(25, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "q1:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(25, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "q2:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(218, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 58);
            this.button1.TabIndex = 9;
            this.button1.Text = "Borrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 343);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtQ2);
            this.Controls.Add(this.txtQ1);
            this.Controls.Add(this.txtQ0);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox txtQ0;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtQ1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtQ2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RichTextBox txtResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

