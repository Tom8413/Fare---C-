namespace Fare
{
    partial class Form1
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
            this.TotalNumberOfPeople = new System.Windows.Forms.NumericUpDown();
            this.MusicInTheCar = new System.Windows.Forms.CheckBox();
            this.AirConditioningInTheCar = new System.Windows.Forms.CheckBox();
            this.TransportOfEquipment = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WhatPassengersCanDo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DriversAttention = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalCost = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TotalNumberOfPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalNumberOfPeople
            // 
            this.TotalNumberOfPeople.Location = new System.Drawing.Point(93, 60);
            this.TotalNumberOfPeople.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.TotalNumberOfPeople.Name = "TotalNumberOfPeople";
            this.TotalNumberOfPeople.Size = new System.Drawing.Size(120, 20);
            this.TotalNumberOfPeople.TabIndex = 0;
            this.TotalNumberOfPeople.ValueChanged += new System.EventHandler(this.TotalNumberOfPeople_ValueChanged);
            // 
            // MusicInTheCar
            // 
            this.MusicInTheCar.AutoSize = true;
            this.MusicInTheCar.Location = new System.Drawing.Point(93, 134);
            this.MusicInTheCar.Name = "MusicInTheCar";
            this.MusicInTheCar.Size = new System.Drawing.Size(54, 17);
            this.MusicInTheCar.TabIndex = 1;
            this.MusicInTheCar.Text = "Music";
            this.MusicInTheCar.UseVisualStyleBackColor = true;
            this.MusicInTheCar.CheckedChanged += new System.EventHandler(this.MusicInTheCar_CheckedChanged);
            // 
            // AirConditioningInTheCar
            // 
            this.AirConditioningInTheCar.AutoSize = true;
            this.AirConditioningInTheCar.Location = new System.Drawing.Point(93, 178);
            this.AirConditioningInTheCar.Name = "AirConditioningInTheCar";
            this.AirConditioningInTheCar.Size = new System.Drawing.Size(98, 17);
            this.AirConditioningInTheCar.TabIndex = 2;
            this.AirConditioningInTheCar.Text = "Air conditioning";
            this.AirConditioningInTheCar.UseVisualStyleBackColor = true;
            this.AirConditioningInTheCar.CheckedChanged += new System.EventHandler(this.AirConditioningInTheCar_CheckedChanged);
            // 
            // TransportOfEquipment
            // 
            this.TransportOfEquipment.AutoSize = true;
            this.TransportOfEquipment.Location = new System.Drawing.Point(93, 228);
            this.TransportOfEquipment.Name = "TransportOfEquipment";
            this.TransportOfEquipment.Size = new System.Drawing.Size(135, 17);
            this.TransportOfEquipment.TabIndex = 3;
            this.TransportOfEquipment.Text = "Transport of equipment";
            this.TransportOfEquipment.UseVisualStyleBackColor = true;
            this.TransportOfEquipment.CheckedChanged += new System.EventHandler(this.TransportOfEquipment_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(386, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "PROMOTION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(386, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "If you\'re driving in 4 people, ";
            // 
            // WhatPassengersCanDo
            // 
            this.WhatPassengersCanDo.AutoSize = true;
            this.WhatPassengersCanDo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WhatPassengersCanDo.Location = new System.Drawing.Point(421, 178);
            this.WhatPassengersCanDo.Name = "WhatPassengersCanDo";
            this.WhatPassengersCanDo.Size = new System.Drawing.Size(128, 15);
            this.WhatPassengersCanDo.TabIndex = 6;
            this.WhatPassengersCanDo.Text = "What passengers can do";
            this.WhatPassengersCanDo.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(421, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Driver\'s reaction";
            this.label4.Visible = false;
            // 
            // DriversAttention
            // 
            this.DriversAttention.AutoSize = true;
            this.DriversAttention.Location = new System.Drawing.Point(563, 232);
            this.DriversAttention.Name = "DriversAttention";
            this.DriversAttention.Size = new System.Drawing.Size(86, 13);
            this.DriversAttention.TabIndex = 8;
            this.DriversAttention.Text = "Driver\'s attention";
            this.DriversAttention.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "sing",
            "converse",
            "vomit",
            "eat"});
            this.comboBox1.Location = new System.Drawing.Point(566, 175);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "What the are doing";
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Number of People";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(90, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total cost";
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSize = true;
            this.TotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TotalCost.Location = new System.Drawing.Point(215, 369);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(0, 20);
            this.TotalCost.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(386, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(291, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "YOU DO NOT PAY FOR THE AIR CONDITIONING";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TotalCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DriversAttention);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WhatPassengersCanDo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TransportOfEquipment);
            this.Controls.Add(this.AirConditioningInTheCar);
            this.Controls.Add(this.MusicInTheCar);
            this.Controls.Add(this.TotalNumberOfPeople);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TotalNumberOfPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown TotalNumberOfPeople;
        private System.Windows.Forms.CheckBox MusicInTheCar;
        private System.Windows.Forms.CheckBox AirConditioningInTheCar;
        private System.Windows.Forms.CheckBox TransportOfEquipment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label WhatPassengersCanDo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DriversAttention;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TotalCost;
        private System.Windows.Forms.Label label9;
    }
}

