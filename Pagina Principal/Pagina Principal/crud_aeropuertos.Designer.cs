namespace Pagina_Principal
{
    partial class crud_aeropuertos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.co = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.co,
            this.no,
            this.lo,
            this.ia});
            this.dataGridView1.Location = new System.Drawing.Point(58, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(473, 256);
            this.dataGridView1.TabIndex = 1;
            //this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            //this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // co
            // 
            this.co.HeaderText = "Codigo";
            this.co.Name = "co";
            // 
            // no
            // 
            this.no.HeaderText = "Nombre";
            this.no.Name = "no";
            // 
            // lo
            // 
            this.lo.HeaderText = "Localizacion";
            this.lo.Name = "lo";
            this.lo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ia
            // 
            this.ia.HeaderText = "IATA";
            this.ia.Name = "ia";
            // 
            // crud_aeropuertos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 365);
            this.Controls.Add(this.dataGridView1);
            this.Name = "crud_aeropuertos";
            this.Text = "crud_aeropuertos";
            this.Load += new System.EventHandler(this.crud_aeropuertos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn co;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewComboBoxColumn lo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ia;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}