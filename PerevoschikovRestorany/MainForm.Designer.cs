
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
            this.btn_move_to_restoran = new System.Windows.Forms.Button();
            this.cb_rest_address_search1 = new System.Windows.Forms.ComboBox();
            this.btn_update_equipments = new System.Windows.Forms.Button();
            this.dgw_stock = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_supplier_naim = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ser_num = new System.Windows.Forms.TextBox();
            this.btn_add_to_stock = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_search_supplier = new System.Windows.Forms.Button();
            this.cb_suppliers_search = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_add_new_Equipment = new System.Windows.Forms.Button();
            this.btn_update_Suppliers_equipment = new System.Windows.Forms.Button();
            this.dgw_suppliers = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btn_add_restoran = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nazv_Restoran = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_addres_Restoran = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_move_to_stock = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_search_restoran_address = new System.Windows.Forms.Button();
            this.cb_rest_address_search = new System.Windows.Forms.ComboBox();
            this.btn_Update_Restorany = new System.Windows.Forms.Button();
            this.dgw_restorany = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btn_update_equipment_all = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_naim_equipment = new System.Windows.Forms.TextBox();
            this.btn_add_equipments_all = new System.Windows.Forms.Button();
            this.dgw_equipment_all = new System.Windows.Forms.DataGridView();
            this.btn_do_document = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_stock)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_suppliers)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_restorany)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_equipment_all)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
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
            this.tabPage2.Controls.Add(this.btn_do_document);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.btn_update_equipments);
            this.tabPage2.Controls.Add(this.dgw_stock);
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
            this.groupBox3.Controls.Add(this.btn_move_to_restoran);
            this.groupBox3.Controls.Add(this.cb_rest_address_search1);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 54);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ресторан";
            // 
            // btn_move_to_restoran
            // 
            this.btn_move_to_restoran.Location = new System.Drawing.Point(171, 19);
            this.btn_move_to_restoran.Name = "btn_move_to_restoran";
            this.btn_move_to_restoran.Size = new System.Drawing.Size(105, 23);
            this.btn_move_to_restoran.TabIndex = 1;
            this.btn_move_to_restoran.Text = "Переместить";
            this.btn_move_to_restoran.UseVisualStyleBackColor = true;
            this.btn_move_to_restoran.Click += new System.EventHandler(this.btn_move_to_restoran_Click);
            // 
            // cb_rest_address_search1
            // 
            this.cb_rest_address_search1.FormattingEnabled = true;
            this.cb_rest_address_search1.Location = new System.Drawing.Point(6, 19);
            this.cb_rest_address_search1.Name = "cb_rest_address_search1";
            this.cb_rest_address_search1.Size = new System.Drawing.Size(159, 21);
            this.cb_rest_address_search1.TabIndex = 0;
            // 
            // btn_update_equipments
            // 
            this.btn_update_equipments.Location = new System.Drawing.Point(12, 66);
            this.btn_update_equipments.Name = "btn_update_equipments";
            this.btn_update_equipments.Size = new System.Drawing.Size(270, 52);
            this.btn_update_equipments.TabIndex = 4;
            this.btn_update_equipments.Text = "обновить";
            this.btn_update_equipments.UseVisualStyleBackColor = true;
            this.btn_update_equipments.Click += new System.EventHandler(this.btn_update_equipments_Click);
            // 
            // dgw_stock
            // 
            this.dgw_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_stock.Location = new System.Drawing.Point(294, 6);
            this.dgw_stock.Name = "dgw_stock";
            this.dgw_stock.Size = new System.Drawing.Size(666, 410);
            this.dgw_stock.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox10);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.btn_update_Suppliers_equipment);
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
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label4);
            this.groupBox10.Controls.Add(this.tb_supplier_naim);
            this.groupBox10.Controls.Add(this.button1);
            this.groupBox10.Location = new System.Drawing.Point(8, 65);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(282, 94);
            this.groupBox10.TabIndex = 10;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Добавление поставщика";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "наименование";
            // 
            // tb_supplier_naim
            // 
            this.tb_supplier_naim.Location = new System.Drawing.Point(6, 32);
            this.tb_supplier_naim.Name = "tb_supplier_naim";
            this.tb_supplier_naim.Size = new System.Drawing.Size(270, 20);
            this.tb_supplier_naim.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_ser_num);
            this.groupBox1.Controls.Add(this.btn_add_to_stock);
            this.groupBox1.Location = new System.Drawing.Point(8, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 101);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "склад";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "серийный номер(5 знаков)";
            // 
            // tb_ser_num
            // 
            this.tb_ser_num.Location = new System.Drawing.Point(6, 37);
            this.tb_ser_num.MaxLength = 5;
            this.tb_ser_num.Name = "tb_ser_num";
            this.tb_ser_num.Size = new System.Drawing.Size(270, 20);
            this.tb_ser_num.TabIndex = 7;
            // 
            // btn_add_to_stock
            // 
            this.btn_add_to_stock.Location = new System.Drawing.Point(5, 63);
            this.btn_add_to_stock.Name = "btn_add_to_stock";
            this.btn_add_to_stock.Size = new System.Drawing.Size(271, 29);
            this.btn_add_to_stock.TabIndex = 5;
            this.btn_add_to_stock.Text = "добавить на склад";
            this.btn_add_to_stock.UseVisualStyleBackColor = true;
            this.btn_add_to_stock.Click += new System.EventHandler(this.btn_add_to_stock_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_search_supplier);
            this.groupBox5.Controls.Add(this.cb_suppliers_search);
            this.groupBox5.Location = new System.Drawing.Point(8, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(282, 51);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Поставщик";
            // 
            // btn_search_supplier
            // 
            this.btn_search_supplier.Location = new System.Drawing.Point(171, 19);
            this.btn_search_supplier.Name = "btn_search_supplier";
            this.btn_search_supplier.Size = new System.Drawing.Size(105, 23);
            this.btn_search_supplier.TabIndex = 1;
            this.btn_search_supplier.Text = "Найти";
            this.btn_search_supplier.UseVisualStyleBackColor = true;
            this.btn_search_supplier.Click += new System.EventHandler(this.btn_search_supplier_Click);
            // 
            // cb_suppliers_search
            // 
            this.cb_suppliers_search.FormattingEnabled = true;
            this.cb_suppliers_search.Location = new System.Drawing.Point(6, 19);
            this.cb_suppliers_search.Name = "cb_suppliers_search";
            this.cb_suppliers_search.Size = new System.Drawing.Size(159, 21);
            this.cb_suppliers_search.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_add_new_Equipment);
            this.groupBox2.Location = new System.Drawing.Point(8, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 73);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поставляемое оборудование";
            // 
            // btn_add_new_Equipment
            // 
            this.btn_add_new_Equipment.Location = new System.Drawing.Point(5, 19);
            this.btn_add_new_Equipment.Name = "btn_add_new_Equipment";
            this.btn_add_new_Equipment.Size = new System.Drawing.Size(271, 47);
            this.btn_add_new_Equipment.TabIndex = 6;
            this.btn_add_new_Equipment.Text = "добавить оборудование";
            this.btn_add_new_Equipment.UseVisualStyleBackColor = true;
            this.btn_add_new_Equipment.Click += new System.EventHandler(this.btn_add_new_Equipment_Click);
            // 
            // btn_update_Suppliers_equipment
            // 
            this.btn_update_Suppliers_equipment.Location = new System.Drawing.Point(14, 351);
            this.btn_update_Suppliers_equipment.Name = "btn_update_Suppliers_equipment";
            this.btn_update_Suppliers_equipment.Size = new System.Drawing.Size(270, 52);
            this.btn_update_Suppliers_equipment.TabIndex = 4;
            this.btn_update_Suppliers_equipment.Text = "обновить";
            this.btn_update_Suppliers_equipment.UseVisualStyleBackColor = true;
            this.btn_update_Suppliers_equipment.Click += new System.EventHandler(this.btn_update_Suppliers_equipment_Click);
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
            this.tabPage4.Controls.Add(this.groupBox8);
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
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Transparent;
            this.groupBox8.Controls.Add(this.btn_add_restoran);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.tb_nazv_Restoran);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Controls.Add(this.tb_addres_Restoran);
            this.groupBox8.Location = new System.Drawing.Point(6, 60);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(282, 134);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Рестран";
            // 
            // btn_add_restoran
            // 
            this.btn_add_restoran.Location = new System.Drawing.Point(5, 103);
            this.btn_add_restoran.Name = "btn_add_restoran";
            this.btn_add_restoran.Size = new System.Drawing.Size(270, 23);
            this.btn_add_restoran.TabIndex = 2;
            this.btn_add_restoran.Text = "добавить ресторан";
            this.btn_add_restoran.UseVisualStyleBackColor = true;
            this.btn_add_restoran.Click += new System.EventHandler(this.btn_add_restoran_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "адрес";
            // 
            // tb_nazv_Restoran
            // 
            this.tb_nazv_Restoran.Location = new System.Drawing.Point(6, 35);
            this.tb_nazv_Restoran.Name = "tb_nazv_Restoran";
            this.tb_nazv_Restoran.Size = new System.Drawing.Size(270, 20);
            this.tb_nazv_Restoran.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "название";
            // 
            // tb_addres_Restoran
            // 
            this.tb_addres_Restoran.Location = new System.Drawing.Point(5, 77);
            this.tb_addres_Restoran.Name = "tb_addres_Restoran";
            this.tb_addres_Restoran.Size = new System.Drawing.Size(270, 20);
            this.tb_addres_Restoran.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_move_to_stock);
            this.groupBox6.Location = new System.Drawing.Point(6, 200);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(282, 49);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Оборудование";
            // 
            // btn_move_to_stock
            // 
            this.btn_move_to_stock.Location = new System.Drawing.Point(6, 19);
            this.btn_move_to_stock.Name = "btn_move_to_stock";
            this.btn_move_to_stock.Size = new System.Drawing.Size(270, 23);
            this.btn_move_to_stock.TabIndex = 2;
            this.btn_move_to_stock.Text = "Переместить на склад";
            this.btn_move_to_stock.UseVisualStyleBackColor = true;
            this.btn_move_to_stock.Click += new System.EventHandler(this.btn_move_to_stock_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_search_restoran_address);
            this.groupBox4.Controls.Add(this.cb_rest_address_search);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(282, 48);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Адрес ресторана";
            // 
            // btn_search_restoran_address
            // 
            this.btn_search_restoran_address.Location = new System.Drawing.Point(171, 19);
            this.btn_search_restoran_address.Name = "btn_search_restoran_address";
            this.btn_search_restoran_address.Size = new System.Drawing.Size(105, 23);
            this.btn_search_restoran_address.TabIndex = 1;
            this.btn_search_restoran_address.Text = "Найти";
            this.btn_search_restoran_address.UseVisualStyleBackColor = true;
            this.btn_search_restoran_address.Click += new System.EventHandler(this.btn_search_restoran_address_Click);
            // 
            // cb_rest_address_search
            // 
            this.cb_rest_address_search.FormattingEnabled = true;
            this.cb_rest_address_search.Location = new System.Drawing.Point(6, 19);
            this.cb_rest_address_search.Name = "cb_rest_address_search";
            this.cb_rest_address_search.Size = new System.Drawing.Size(159, 21);
            this.cb_rest_address_search.TabIndex = 0;
            // 
            // btn_Update_Restorany
            // 
            this.btn_Update_Restorany.Location = new System.Drawing.Point(11, 255);
            this.btn_Update_Restorany.Name = "btn_Update_Restorany";
            this.btn_Update_Restorany.Size = new System.Drawing.Size(270, 52);
            this.btn_Update_Restorany.TabIndex = 3;
            this.btn_Update_Restorany.Text = "обновить";
            this.btn_Update_Restorany.UseVisualStyleBackColor = true;
            this.btn_Update_Restorany.Click += new System.EventHandler(this.btn_Update_Restorany_Click);
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
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btn_update_equipment_all);
            this.tabPage5.Controls.Add(this.groupBox9);
            this.tabPage5.Controls.Add(this.dgw_equipment_all);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(982, 424);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "оборудование";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btn_update_equipment_all
            // 
            this.btn_update_equipment_all.Location = new System.Drawing.Point(13, 103);
            this.btn_update_equipment_all.Name = "btn_update_equipment_all";
            this.btn_update_equipment_all.Size = new System.Drawing.Size(268, 23);
            this.btn_update_equipment_all.TabIndex = 5;
            this.btn_update_equipment_all.Text = "обновить";
            this.btn_update_equipment_all.UseVisualStyleBackColor = true;
            this.btn_update_equipment_all.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label3);
            this.groupBox9.Controls.Add(this.tb_naim_equipment);
            this.groupBox9.Controls.Add(this.btn_add_equipments_all);
            this.groupBox9.Location = new System.Drawing.Point(8, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(280, 91);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "оборудование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "наименование";
            // 
            // tb_naim_equipment
            // 
            this.tb_naim_equipment.Location = new System.Drawing.Point(5, 35);
            this.tb_naim_equipment.Name = "tb_naim_equipment";
            this.tb_naim_equipment.Size = new System.Drawing.Size(268, 20);
            this.tb_naim_equipment.TabIndex = 3;
            // 
            // btn_add_equipments_all
            // 
            this.btn_add_equipments_all.Location = new System.Drawing.Point(5, 61);
            this.btn_add_equipments_all.Name = "btn_add_equipments_all";
            this.btn_add_equipments_all.Size = new System.Drawing.Size(268, 23);
            this.btn_add_equipments_all.TabIndex = 1;
            this.btn_add_equipments_all.Text = "добавить";
            this.btn_add_equipments_all.UseVisualStyleBackColor = true;
            this.btn_add_equipments_all.Click += new System.EventHandler(this.btn_add_equipments_all_Click);
            // 
            // dgw_equipment_all
            // 
            this.dgw_equipment_all.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_equipment_all.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgw_equipment_all.Location = new System.Drawing.Point(294, 8);
            this.dgw_equipment_all.Name = "dgw_equipment_all";
            this.dgw_equipment_all.Size = new System.Drawing.Size(680, 410);
            this.dgw_equipment_all.TabIndex = 2;
            // 
            // btn_do_document
            // 
            this.btn_do_document.Location = new System.Drawing.Point(12, 124);
            this.btn_do_document.Name = "btn_do_document";
            this.btn_do_document.Size = new System.Drawing.Size(270, 52);
            this.btn_do_document.TabIndex = 6;
            this.btn_do_document.Text = "Сформировать документ";
            this.btn_do_document.UseVisualStyleBackColor = true;
            this.btn_do_document.Click += new System.EventHandler(this.btn_do_document_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgw_stock)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_suppliers)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_restorany)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_equipment_all)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgw_stock;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgw_suppliers;
        private System.Windows.Forms.DataGridView dgw_restorany;
        private System.Windows.Forms.Button btn_add_restoran;
        private System.Windows.Forms.Button btn_Update_Restorany;
        private System.Windows.Forms.Button btn_update_equipments;
        private System.Windows.Forms.Button btn_update_Suppliers_equipment;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_search_supplier;
        private System.Windows.Forms.ComboBox cb_suppliers_search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_add_new_Equipment;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_search_restoran_address;
        private System.Windows.Forms.ComboBox cb_rest_address_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_add_to_stock;
        private System.Windows.Forms.Button btn_move_to_restoran;
        private System.Windows.Forms.ComboBox cb_rest_address_search1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_move_to_stock;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nazv_Restoran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_addres_Restoran;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox tb_naim_equipment;
        private System.Windows.Forms.Button btn_add_equipments_all;
        private System.Windows.Forms.DataGridView dgw_equipment_all;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_update_equipment_all;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_supplier_naim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_ser_num;
        private System.Windows.Forms.Button btn_do_document;
    }
}