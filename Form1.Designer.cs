namespace Tip_Calculator
{
   partial class frmMain
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
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.panel1 = new System.Windows.Forms.Panel();
         this.label3 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.lblTip = new System.Windows.Forms.Label();
         this.lblTotal = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.LabelXXX = new System.Windows.Forms.Label();
         this.panel2 = new System.Windows.Forms.Panel();
         this.txtPeople = new System.Windows.Forms.NumericUpDown();
         this.txtTip = new System.Windows.Forms.NumericUpDown();
         this.txtBillAmount = new System.Windows.Forms.TextBox();
         this.label8 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.tableLayoutPanel1.SuspendLayout();
         this.panel1.SuspendLayout();
         this.panel2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.txtPeople)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtTip)).BeginInit();
         this.SuspendLayout();
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.ColumnCount = 2;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
         this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
         this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 1;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 561);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // panel1
         // 
         this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.panel1.Controls.Add(this.label3);
         this.panel1.Controls.Add(this.label1);
         this.panel1.Controls.Add(this.lblTip);
         this.panel1.Controls.Add(this.lblTotal);
         this.panel1.Controls.Add(this.label2);
         this.panel1.Controls.Add(this.LabelXXX);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel1.Location = new System.Drawing.Point(445, 3);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(436, 555);
         this.panel1.TabIndex = 0;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(37, 316);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(57, 13);
         this.label3.TabIndex = 1;
         this.label3.Text = "per person";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(37, 206);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(57, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "per person";
         // 
         // lblTip
         // 
         this.lblTip.AutoSize = true;
         this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTip.Location = new System.Drawing.Point(178, 175);
         this.lblTip.Name = "lblTip";
         this.lblTip.Size = new System.Drawing.Size(102, 39);
         this.lblTip.TabIndex = 0;
         this.lblTip.Text = "$0.00";
         // 
         // lblTotal
         // 
         this.lblTotal.AutoSize = true;
         this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTotal.Location = new System.Drawing.Point(176, 275);
         this.lblTotal.Name = "lblTotal";
         this.lblTotal.Size = new System.Drawing.Size(145, 54);
         this.lblTotal.TabIndex = 0;
         this.lblTotal.Text = "$0.00";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(34, 285);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(75, 31);
         this.label2.TabIndex = 0;
         this.label2.Text = "Total";
         // 
         // LabelXXX
         // 
         this.LabelXXX.AutoSize = true;
         this.LabelXXX.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LabelXXX.Location = new System.Drawing.Point(34, 175);
         this.LabelXXX.Name = "LabelXXX";
         this.LabelXXX.Size = new System.Drawing.Size(52, 31);
         this.LabelXXX.TabIndex = 0;
         this.LabelXXX.Text = "Tip";
         // 
         // panel2
         // 
         this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.panel2.Controls.Add(this.txtPeople);
         this.panel2.Controls.Add(this.txtTip);
         this.panel2.Controls.Add(this.txtBillAmount);
         this.panel2.Controls.Add(this.label8);
         this.panel2.Controls.Add(this.label7);
         this.panel2.Controls.Add(this.label6);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel2.Location = new System.Drawing.Point(3, 3);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(436, 555);
         this.panel2.TabIndex = 1;
         // 
         // txtPeople
         // 
         this.txtPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtPeople.Location = new System.Drawing.Point(62, 321);
         this.txtPeople.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
         this.txtPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.txtPeople.Name = "txtPeople";
         this.txtPeople.Size = new System.Drawing.Size(120, 30);
         this.txtPeople.TabIndex = 2;
         this.txtPeople.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.txtPeople.ValueChanged += new System.EventHandler(this.txtPeople_ValueChanged);
         // 
         // txtTip
         // 
         this.txtTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtTip.Location = new System.Drawing.Point(60, 241);
         this.txtTip.Name = "txtTip";
         this.txtTip.Size = new System.Drawing.Size(120, 30);
         this.txtTip.TabIndex = 1;
         this.txtTip.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
         this.txtTip.ValueChanged += new System.EventHandler(this.txtTip_ValueChanged);
         // 
         // txtBillAmount
         // 
         this.txtBillAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtBillAmount.Location = new System.Drawing.Point(60, 155);
         this.txtBillAmount.Name = "txtBillAmount";
         this.txtBillAmount.Size = new System.Drawing.Size(204, 30);
         this.txtBillAmount.TabIndex = 0;
         this.txtBillAmount.TextChanged += new System.EventHandler(this.txtBillAmount_TextChanged);
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label8.Location = new System.Drawing.Point(31, 285);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(166, 25);
         this.label8.TabIndex = 0;
         this.label8.Text = "Number of people";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.Location = new System.Drawing.Point(31, 206);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(63, 25);
         this.label7.TabIndex = 0;
         this.label7.Text = "Tip %";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.Location = new System.Drawing.Point(31, 118);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(37, 25);
         this.label6.TabIndex = 0;
         this.label6.Text = "Bill";
         // 
         // frmMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(884, 561);
         this.Controls.Add(this.tableLayoutPanel1);
         this.MinimumSize = new System.Drawing.Size(750, 500);
         this.Name = "frmMain";
         this.ShowIcon = false;
         this.Text = "Tip Calculator";
         this.tableLayoutPanel1.ResumeLayout(false);
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.txtPeople)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtTip)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label lblTip;
      private System.Windows.Forms.Label lblTotal;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label LabelXXX;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.NumericUpDown txtPeople;
      private System.Windows.Forms.NumericUpDown txtTip;
      private System.Windows.Forms.TextBox txtBillAmount;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label6;
   }
}

