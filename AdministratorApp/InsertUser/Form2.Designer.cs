namespace InsertUser
{
    partial class Form2
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
            this.dataGridUtenti = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.checkedListUtenti = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_elimina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUtenti)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridUtenti
            // 
            this.dataGridUtenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUtenti.Location = new System.Drawing.Point(12, 70);
            this.dataGridUtenti.Name = "dataGridUtenti";
            this.dataGridUtenti.RowHeadersWidth = 51;
            this.dataGridUtenti.RowTemplate.Height = 29;
            this.dataGridUtenti.Size = new System.Drawing.Size(421, 330);
            this.dataGridUtenti.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(144, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dati Utenti";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(436, 70);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(26, 330);
            this.vScrollBar1.TabIndex = 2;
            // 
            // checkedListUtenti
            // 
            this.checkedListUtenti.FormattingEnabled = true;
            this.checkedListUtenti.Location = new System.Drawing.Point(521, 88);
            this.checkedListUtenti.Name = "checkedListUtenti";
            this.checkedListUtenti.Size = new System.Drawing.Size(256, 290);
            this.checkedListUtenti.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(506, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleziona gli utenti da eliminare";
            // 
            // btn_elimina
            // 
            this.btn_elimina.Location = new System.Drawing.Point(595, 393);
            this.btn_elimina.Name = "btn_elimina";
            this.btn_elimina.Size = new System.Drawing.Size(120, 29);
            this.btn_elimina.TabIndex = 5;
            this.btn_elimina.Text = "Elimina";
            this.btn_elimina.UseVisualStyleBackColor = true;
            this.btn_elimina.Click += new System.EventHandler(this.btn_elimina_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 481);
            this.Controls.Add(this.btn_elimina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListUtenti);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridUtenti);
            this.Name = "Form2";
//            this.Text = "Form2";
  //          this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUtenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridUtenti;
        private Label label1;
        private VScrollBar vScrollBar1;
        private CheckedListBox checkedListUtenti;
        private Label label2;
        private Button btn_elimina;
    }
}