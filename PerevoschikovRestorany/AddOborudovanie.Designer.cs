
namespace PerevoschikovRestorany
{
    partial class AddOborudovanie
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
            this.tb_name_Equipment = new System.Windows.Forms.TextBox();
            this.tb_serial_Number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_address = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_address = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_supplier_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_location = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование оборудования";
            // 
            // tb_name_Equipment
            // 
            this.tb_name_Equipment.Location = new System.Drawing.Point(9, 32);
            this.tb_name_Equipment.Name = "tb_name_Equipment";
            this.tb_name_Equipment.Size = new System.Drawing.Size(183, 20);
            this.tb_name_Equipment.TabIndex = 1;
            // 
            // tb_serial_Number
            // 
            this.tb_serial_Number.Location = new System.Drawing.Point(9, 75);
            this.tb_serial_Number.Name = "tb_serial_Number";
            this.tb_serial_Number.Size = new System.Drawing.Size(183, 20);
            this.tb_serial_Number.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Серийный номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата поставки";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.tb_name_Equipment);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_serial_Number);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 172);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оборудование";
            // 
            // cb_address
            // 
            this.cb_address.FormattingEnabled = true;
            this.cb_address.Location = new System.Drawing.Point(9, 74);
            this.cb_address.Name = "cb_address";
            this.cb_address.Size = new System.Drawing.Size(183, 21);
            this.cb_address.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_location);
            this.groupBox2.Controls.Add(this.cb_address);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label_address);
            this.groupBox2.Location = new System.Drawing.Point(219, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 103);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Местонахождение";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(6, 59);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(94, 13);
            this.label_address.TabIndex = 0;
            this.label_address.Text = "Адрес ресторана";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tb_supplier_name);
            this.groupBox3.Location = new System.Drawing.Point(219, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 63);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поставщик";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Имя поставщика";
            // 
            // tb_supplier_name
            // 
            this.tb_supplier_name.Location = new System.Drawing.Point(9, 34);
            this.tb_supplier_name.Name = "tb_supplier_name";
            this.tb_supplier_name.Size = new System.Drawing.Size(183, 20);
            this.tb_supplier_name.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(408, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_location
            // 
            this.cb_location.FormattingEnabled = true;
            this.cb_location.Items.AddRange(new object[] {
            "Склад",
            "Ресторан"});
            this.cb_location.Location = new System.Drawing.Point(9, 32);
            this.cb_location.Name = "cb_location";
            this.cb_location.Size = new System.Drawing.Size(183, 21);
            this.cb_location.TabIndex = 7;
            this.cb_location.SelectedIndexChanged += new System.EventHandler(this.cb_location_SelectedIndexChanged);
            this.cb_location.SelectionChangeCommitted += new System.EventHandler(this.cb_location_SelectionChangeCommitted);
            this.cb_location.SelectedValueChanged += new System.EventHandler(this.cb_location_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "определенеие места";
            // 
            // AddOborudovanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 223);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(446, 262);
            this.MinimumSize = new System.Drawing.Size(446, 262);
            this.Name = "AddOborudovanie";
            this.Text = "AddOborudovanie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name_Equipment;
        private System.Windows.Forms.TextBox tb_serial_Number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.TextBox tb_supplier_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_address;
        private System.Windows.Forms.ComboBox cb_location;
        private System.Windows.Forms.Label label4;
    }
}