
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgw_oborudovanie = new System.Windows.Forms.DataGridView();
            this.resoranyDataSet = new PerevoschikovRestorany.ResoranyDataSet();
            this.restoranyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranyTableAdapter = new PerevoschikovRestorany.ResoranyDataSetTableAdapters.restoranyTableAdapter();
            this.postavshikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavshikiTableAdapter = new PerevoschikovRestorany.ResoranyDataSetTableAdapters.postavshikiTableAdapter();
            this.oborudovanieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oborudovanieTableAdapter = new PerevoschikovRestorany.ResoranyDataSetTableAdapters.oborudovanieTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgw_postavshiki = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgw_restorany = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add_oborudovanie = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_oborudovanie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resoranyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudovanieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_postavshiki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_restorany)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "статистика";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgw_oborudovanie);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "оборудование";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgw_postavshiki);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "поставщики";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_add_oborudovanie);
            this.tabPage4.Controls.Add(this.dgw_restorany);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "рестораны";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgw_oborudovanie
            // 
            this.dgw_oborudovanie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_oborudovanie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgw_oborudovanie.Location = new System.Drawing.Point(151, 6);
            this.dgw_oborudovanie.Name = "dgw_oborudovanie";
            this.dgw_oborudovanie.Size = new System.Drawing.Size(633, 410);
            this.dgw_oborudovanie.TabIndex = 0;
            // 
            // resoranyDataSet
            // 
            this.resoranyDataSet.DataSetName = "ResoranyDataSet";
            this.resoranyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restoranyBindingSource
            // 
            this.restoranyBindingSource.DataMember = "restorany";
            this.restoranyBindingSource.DataSource = this.resoranyDataSet;
            // 
            // restoranyTableAdapter
            // 
            this.restoranyTableAdapter.ClearBeforeFill = true;
            // 
            // postavshikiBindingSource
            // 
            this.postavshikiBindingSource.DataMember = "postavshiki";
            this.postavshikiBindingSource.DataSource = this.resoranyDataSet;
            // 
            // postavshikiTableAdapter
            // 
            this.postavshikiTableAdapter.ClearBeforeFill = true;
            // 
            // oborudovanieBindingSource
            // 
            this.oborudovanieBindingSource.DataMember = "oborudovanie";
            this.oborudovanieBindingSource.DataSource = this.resoranyDataSet;
            // 
            // oborudovanieTableAdapter
            // 
            this.oborudovanieTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "k_oborud";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // dgw_postavshiki
            // 
            this.dgw_postavshiki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_postavshiki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgw_postavshiki.Location = new System.Drawing.Point(151, 6);
            this.dgw_postavshiki.Name = "dgw_postavshiki";
            this.dgw_postavshiki.Size = new System.Drawing.Size(633, 410);
            this.dgw_postavshiki.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "k_oborud";
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dgw_restorany
            // 
            this.dgw_restorany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_restorany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.dgw_restorany.Location = new System.Drawing.Point(151, 6);
            this.dgw_restorany.Name = "dgw_restorany";
            this.dgw_restorany.Size = new System.Drawing.Size(633, 410);
            this.dgw_restorany.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "k_oborud";
            this.dataGridViewTextBoxColumn2.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // btn_add_oborudovanie
            // 
            this.btn_add_oborudovanie.Location = new System.Drawing.Point(8, 6);
            this.btn_add_oborudovanie.Name = "btn_add_oborudovanie";
            this.btn_add_oborudovanie.Size = new System.Drawing.Size(137, 52);
            this.btn_add_oborudovanie.TabIndex = 2;
            this.btn_add_oborudovanie.Text = "добавить";
            this.btn_add_oborudovanie.UseVisualStyleBackColor = true;
            this.btn_add_oborudovanie.Click += new System.EventHandler(this.btn_add_oborudovanie_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_oborudovanie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resoranyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudovanieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_postavshiki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_restorany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgw_oborudovanie;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private ResoranyDataSet resoranyDataSet;
        private System.Windows.Forms.BindingSource restoranyBindingSource;
        private ResoranyDataSetTableAdapters.restoranyTableAdapter restoranyTableAdapter;
        private System.Windows.Forms.BindingSource postavshikiBindingSource;
        private ResoranyDataSetTableAdapters.postavshikiTableAdapter postavshikiTableAdapter;
        private System.Windows.Forms.BindingSource oborudovanieBindingSource;
        private ResoranyDataSetTableAdapters.oborudovanieTableAdapter oborudovanieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgw_postavshiki;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgw_restorany;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btn_add_oborudovanie;
    }
}