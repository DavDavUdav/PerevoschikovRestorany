
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_equipment = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_suppliers_name = new System.Windows.Forms.ComboBox();
            this.btn_add_equipment_to_Supplier = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_equipment);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 65);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оборудование";
            // 
            // cb_equipment
            // 
            this.cb_equipment.FormattingEnabled = true;
            this.cb_equipment.Location = new System.Drawing.Point(6, 32);
            this.cb_equipment.Name = "cb_equipment";
            this.cb_equipment.Size = new System.Drawing.Size(186, 21);
            this.cb_equipment.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_suppliers_name);
            this.groupBox3.Location = new System.Drawing.Point(225, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 49);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поставщик";
            // 
            // cb_suppliers_name
            // 
            this.cb_suppliers_name.FormattingEnabled = true;
            this.cb_suppliers_name.Location = new System.Drawing.Point(6, 19);
            this.cb_suppliers_name.Name = "cb_suppliers_name";
            this.cb_suppliers_name.Size = new System.Drawing.Size(189, 21);
            this.cb_suppliers_name.TabIndex = 7;
            // 
            // btn_add_equipment_to_Supplier
            // 
            this.btn_add_equipment_to_Supplier.Location = new System.Drawing.Point(12, 178);
            this.btn_add_equipment_to_Supplier.Name = "btn_add_equipment_to_Supplier";
            this.btn_add_equipment_to_Supplier.Size = new System.Drawing.Size(414, 33);
            this.btn_add_equipment_to_Supplier.TabIndex = 9;
            this.btn_add_equipment_to_Supplier.Text = "Добавить";
            this.btn_add_equipment_to_Supplier.UseVisualStyleBackColor = true;
            this.btn_add_equipment_to_Supplier.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_price);
            this.groupBox2.Location = new System.Drawing.Point(119, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 49);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цена";
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(7, 20);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(188, 20);
            this.tb_price.TabIndex = 0;
            // 
            // AddOborudovanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 223);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_add_equipment_to_Supplier);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(446, 262);
            this.Name = "AddOborudovanie";
            this.Text = "AddOborudovanie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_add_equipment_to_Supplier;
        private System.Windows.Forms.ComboBox cb_equipment;
        private System.Windows.Forms.ComboBox cb_suppliers_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_price;
    }
}