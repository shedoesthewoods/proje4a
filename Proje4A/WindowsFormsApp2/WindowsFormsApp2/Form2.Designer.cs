namespace WindowsFormsApp2
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
            this.dijkstraButton = new System.Windows.Forms.Button();
            this.breadthFirstButton = new System.Windows.Forms.Button();
            this.minSpanningTreeButton = new System.Windows.Forms.Button();
            this.txtDijkstra2 = new System.Windows.Forms.TextBox();
            this.txtDikstra1 = new System.Windows.Forms.TextBox();
            this.txtBreadFirst = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dijkstraButton
            // 
            this.dijkstraButton.Location = new System.Drawing.Point(144, 17);
            this.dijkstraButton.Name = "dijkstraButton";
            this.dijkstraButton.Size = new System.Drawing.Size(75, 23);
            this.dijkstraButton.TabIndex = 0;
            this.dijkstraButton.Text = "Çalıştır";
            this.dijkstraButton.UseVisualStyleBackColor = true;
            this.dijkstraButton.Click += new System.EventHandler(this.dijkstraButton_Click);
            // 
            // breadthFirstButton
            // 
            this.breadthFirstButton.Location = new System.Drawing.Point(144, 17);
            this.breadthFirstButton.Name = "breadthFirstButton";
            this.breadthFirstButton.Size = new System.Drawing.Size(75, 23);
            this.breadthFirstButton.TabIndex = 1;
            this.breadthFirstButton.Text = "Çalıştır";
            this.breadthFirstButton.UseVisualStyleBackColor = true;
            this.breadthFirstButton.Click += new System.EventHandler(this.breadthFirstButton_Click);
            // 
            // minSpanningTreeButton
            // 
            this.minSpanningTreeButton.Location = new System.Drawing.Point(66, 19);
            this.minSpanningTreeButton.Name = "minSpanningTreeButton";
            this.minSpanningTreeButton.Size = new System.Drawing.Size(102, 23);
            this.minSpanningTreeButton.TabIndex = 2;
            this.minSpanningTreeButton.Text = "Çalıştır\r\n";
            this.minSpanningTreeButton.UseVisualStyleBackColor = true;
            this.minSpanningTreeButton.Click += new System.EventHandler(this.minSpanningTreeButton_Click);
            // 
            // txtDijkstra2
            // 
            this.txtDijkstra2.Location = new System.Drawing.Point(75, 19);
            this.txtDijkstra2.Name = "txtDijkstra2";
            this.txtDijkstra2.Size = new System.Drawing.Size(63, 20);
            this.txtDijkstra2.TabIndex = 3;
            // 
            // txtDikstra1
            // 
            this.txtDikstra1.Location = new System.Drawing.Point(6, 19);
            this.txtDikstra1.Name = "txtDikstra1";
            this.txtDikstra1.Size = new System.Drawing.Size(63, 20);
            this.txtDikstra1.TabIndex = 4;
            // 
            // txtBreadFirst
            // 
            this.txtBreadFirst.Location = new System.Drawing.Point(6, 19);
            this.txtBreadFirst.Name = "txtBreadFirst";
            this.txtBreadFirst.Size = new System.Drawing.Size(132, 20);
            this.txtBreadFirst.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDikstra1);
            this.groupBox1.Controls.Add(this.txtDijkstra2);
            this.groupBox1.Controls.Add(this.dijkstraButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 49);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dijkstra";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBreadFirst);
            this.groupBox2.Controls.Add(this.breadthFirstButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 48);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BreadthFirst";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.minSpanningTreeButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 50);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MinSpanningTree";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 181);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dijkstraButton;
        private System.Windows.Forms.Button breadthFirstButton;
        private System.Windows.Forms.Button minSpanningTreeButton;
        private System.Windows.Forms.TextBox txtDijkstra2;
        private System.Windows.Forms.TextBox txtDikstra1;
        private System.Windows.Forms.TextBox txtBreadFirst;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}