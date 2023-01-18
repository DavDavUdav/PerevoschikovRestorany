
namespace PerevoschikovRestorany
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_update_equipments = new System.Windows.Forms.Button();
            this.btn_add_equipment = new System.Windows.Forms.Button();
            this.dgw_oborudovanie = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_add_postavshik = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgw_suppliers = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btn_Update_Restorany = new System.Windows.Forms.Button();
            this.btn_add_restoran = new System.Windows.Forms.Button();
            this.dgw_restorany = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_oborudovanie)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_suppliers)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_restorany)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(990, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(982, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "статистика";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.btn_update_equipments);
            this.tabPage2.Controls.Add(this.btn_add_equipment);
            this.tabPage2.Controls.Add(this.dgw_oborudovanie);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(982, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Склад";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 54);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ресторан";
            // 
            // btn_update_equipments
            // 
            this.btn_update_equipments.Location = new System.Drawing.Point(147, 66);
            this.btn_update_equipments.Name = "btn_update_equipments";
            this.btn_update_equipments.Size = new System.Drawing.Size(137, 52);
            this.btn_update_equipments.TabIndex = 4;
            this.btn_update_equipments.Text = "обновить";
            this.btn_update_equipments.UseVisualStyleBackColor = true;
            this.btn_update_equipments.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_add_equipment
            // 
            this.btn_add_equipment.Location = new System.Drawing.Point(8, 66);
            this.btn_add_equipment.Name = "btn_add_equipment";
            this.btn_add_equipment.Size = new System.Drawing.Size(137, 52);
            this.btn_add_equipment.TabIndex = 3;
            this.btn_add_equipment.Text = "добавить";
            this.btn_add_equipment.UseVisualStyleBackColor = true;
            this.btn_add_equipment.Click += new System.EventHandler(this.btn_add_equipment_Click);
            // 
            // dgw_oborudovanie
            // 
            this.dgw_oborudovanie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_oborudovanie.Location = new System.Drawing.Point(294, 6);
            this.dgw_oborudovanie.Name = "dgw_oborudovanie";
            this.dgw_oborudovanie.Size = new System.Drawing.Size(666, 410);
            this.dgw_oborudovanie.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.dgw_suppliers);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(982, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "поставщики";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_add_postavshik);
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.comboBox3);
            this.groupBox5.Location = new System.Drawing.Point(8, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(282, 86);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Поставщик";
            // 
            // btn_add_postavshik
            // 
            this.btn_add_postavshik.Location = new System.Drawing.Point(6, 46);
            this.btn_add_postavshik.Name = "btn_add_postavshik";
            this.btn_add_postavshik.Size = new System.Drawing.Size(270, 29);
            this.btn_add_postavshik.TabIndex = 5;
            this.btn_add_postavshik.Text = "добавить";
            this.btn_add_postavshik.UseVisualStyleBackColor = true;
            this.btn_add_postavshik.Click += new System.EventHandler(this.btn_add_postavshik_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(171, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Найти";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(6, 19);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(159, 21);
            this.comboBox3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(8, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 76);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поставляемое оборудование";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "добавить оборудование поставщику";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(276, 52);
            this.button2.TabIndex = 4;
            this.button2.Text = "обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgw_suppliers
            // 
            this.dgw_suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_suppliers.Location = new System.Drawing.Point(296, 8);
            this.dgw_suppliers.Name = "dgw_suppliers";
            this.dgw_suppliers.Size = new System.Drawing.Size(678, 410);
            this.dgw_suppliers.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.btn_Update_Restorany);
            this.tabPage4.Controls.Add(this.dgw_restorany);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(982, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "рестораны";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_add_restoran);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(282, 75);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Адрес ресторана";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(171, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Найти";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(159, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // btn_Update_Restorany
            // 
            this.btn_Update_Restorany.Location = new System.Drawing.Point(12, 142);
            this.btn_Update_Restorany.Name = "btn_Update_Restorany";
            this.btn_Update_Restorany.Size = new System.Drawing.Size(270, 52);
            this.btn_Update_Restorany.TabIndex = 3;
            this.btn_Update_Restorany.Text = "обновить";
            this.btn_Update_Restorany.UseVisualStyleBackColor = true;
            this.btn_Update_Restorany.Click += new System.EventHandler(this.btn_Update_Restorany_Click);
            // 
            // btn_add_restoran
            // 
            this.btn_add_restoran.Location = new System.Drawing.Point(6, 46);
            this.btn_add_restoran.Name = "btn_add_restoran";
            this.btn_add_restoran.Size = new System.Drawing.Size(270, 23);
            this.btn_add_restoran.TabIndex = 2;
            this.btn_add_restoran.Text = "добавить ресторан";
            this.btn_add_restoran.UseVisualStyleBackColor = true;
            this.btn_add_restoran.Click += new System.EventHandler(this.btn_add_oborudovanie_Click);
            // 
            // dgw_restorany
            // 
            this.dgw_restorany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_restorany.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgw_restorany.Location = new System.Drawing.Point(294, 6);
            this.dgw_restorany.Name = "dgw_restorany";
            this.dgw_restorany.Size = new System.Drawing.Size(680, 410);
            this.dgw_restorany.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Location = new System.Drawing.Point(8, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 54);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "склад";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(270, 29);
            this.button6.TabIndex = 5;
            this.button6.Text = "добавить на склад";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(270, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "Переместить на склад";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button7);
            this.groupBox6.Location = new System.Drawing.Point(6, 87);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(282, 49);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Оборудование";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(171, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Переместить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_oborudovanie)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_suppliers)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_restorany)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgw_oborudovanie;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgw_suppliers;
        private System.Windows.Forms.DataGridView dgw_restorany;
        private System.Windows.Forms.Button btn_add_restoran;
        private System.Windows.Forms.Button btn_Update_Restorany;
        private System.Windows.Forms.Button btn_add_equipment;
        private System.Windows.Forms.Button btn_update_equipments;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_add_postavshik;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button7;
    }
}