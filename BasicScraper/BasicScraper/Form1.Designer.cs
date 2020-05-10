namespace BasicScraper
{
    partial class Form1
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
            this.textBoxBrowserBar = new System.Windows.Forms.TextBox();
            this.buttonScrape = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonToJson = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBrowserBar
            // 
            this.textBoxBrowserBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxBrowserBar.Location = new System.Drawing.Point(12, 12);
            this.textBoxBrowserBar.Name = "textBoxBrowserBar";
            this.textBoxBrowserBar.Size = new System.Drawing.Size(543, 29);
            this.textBoxBrowserBar.TabIndex = 0;
            this.textBoxBrowserBar.Text = "https://trove.fandom.com/wiki/Blocks#zzzz";
            // 
            // buttonScrape
            // 
            this.buttonScrape.Location = new System.Drawing.Point(561, 12);
            this.buttonScrape.Name = "buttonScrape";
            this.buttonScrape.Size = new System.Drawing.Size(89, 29);
            this.buttonScrape.TabIndex = 1;
            this.buttonScrape.Text = "Scrape";
            this.buttonScrape.UseVisualStyleBackColor = true;
            this.buttonScrape.Click += new System.EventHandler(this.buttonScrape_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 390);
            this.dataGridView1.TabIndex = 2;
            // 
            // buttonToJson
            // 
            this.buttonToJson.Location = new System.Drawing.Point(656, 12);
            this.buttonToJson.Name = "buttonToJson";
            this.buttonToJson.Size = new System.Drawing.Size(132, 29);
            this.buttonToJson.TabIndex = 3;
            this.buttonToJson.Text = "Serialize and Save";
            this.buttonToJson.UseVisualStyleBackColor = true;
            this.buttonToJson.Click += new System.EventHandler(this.buttonToJson_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonToJson);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonScrape);
            this.Controls.Add(this.textBoxBrowserBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBrowserBar;
        private System.Windows.Forms.Button buttonScrape;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonToJson;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

