
namespace Generator_Hasel_Graficzny
{
    partial class Generator_V2
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generator_V2));
            this.Button_Gen = new System.Windows.Forms.Button();
            this.TxtOne = new System.Windows.Forms.TextBox();
            this.chBOne = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.btn_Delete_All = new System.Windows.Forms.Button();
            this.TxtTwo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Gen
            // 
            this.Button_Gen.BackColor = System.Drawing.Color.Red;
            this.Button_Gen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Gen.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Gen.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Button_Gen.Location = new System.Drawing.Point(267, 206);
            this.Button_Gen.Name = "Button_Gen";
            this.Button_Gen.Size = new System.Drawing.Size(245, 75);
            this.Button_Gen.TabIndex = 0;
            this.Button_Gen.Text = "Generate";
            this.Button_Gen.UseVisualStyleBackColor = false;
            this.Button_Gen.Click += new System.EventHandler(this.Button_Gen_Click);
            // 
            // TxtOne
            // 
            this.TxtOne.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtOne.ForeColor = System.Drawing.SystemColors.Info;
            this.TxtOne.Location = new System.Drawing.Point(223, 160);
            this.TxtOne.Name = "TxtOne";
            this.TxtOne.ReadOnly = true;
            this.TxtOne.Size = new System.Drawing.Size(333, 40);
            this.TxtOne.TabIndex = 1;
            // 
            // chBOne
            // 
            this.chBOne.AutoSize = true;
            this.chBOne.Location = new System.Drawing.Point(562, 183);
            this.chBOne.Name = "chBOne";
            this.chBOne.Size = new System.Drawing.Size(80, 17);
            this.chBOne.TabIndex = 2;
            this.chBOne.Text = "checkBox1";
            this.chBOne.UseVisualStyleBackColor = true;
            this.chBOne.CheckedChanged += new System.EventHandler(this.chBOne_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(583, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Save to file";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(254, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.Red;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Btn_Delete.Location = new System.Drawing.Point(267, 287);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(245, 75);
            this.Btn_Delete.TabIndex = 5;
            this.Btn_Delete.Text = "Delete_Last";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // btn_Delete_All
            // 
            this.btn_Delete_All.BackColor = System.Drawing.Color.Red;
            this.btn_Delete_All.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete_All.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_All.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_Delete_All.Location = new System.Drawing.Point(267, 368);
            this.btn_Delete_All.Name = "btn_Delete_All";
            this.btn_Delete_All.Size = new System.Drawing.Size(245, 75);
            this.btn_Delete_All.TabIndex = 6;
            this.btn_Delete_All.Text = "Delete_All";
            this.btn_Delete_All.UseVisualStyleBackColor = false;
            this.btn_Delete_All.Click += new System.EventHandler(this.btn_Delete_All_Click);
            // 
            // TxtTwo
            // 
            this.TxtTwo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtTwo.ForeColor = System.Drawing.SystemColors.Info;
            this.TxtTwo.Location = new System.Drawing.Point(562, 241);
            this.TxtTwo.Name = "TxtTwo";
            this.TxtTwo.Size = new System.Drawing.Size(226, 40);
            this.TxtTwo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(653, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "Add label";
            // 
            // Generator_V2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTwo);
            this.Controls.Add(this.btn_Delete_All);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chBOne);
            this.Controls.Add(this.TxtOne);
            this.Controls.Add(this.Button_Gen);
            this.Name = "Generator_V2";
            this.Text = "Generator_V2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Gen;
        private System.Windows.Forms.TextBox TxtOne;
        private System.Windows.Forms.CheckBox chBOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button btn_Delete_All;
        private System.Windows.Forms.TextBox TxtTwo;
        private System.Windows.Forms.Label label2;
    }
}

