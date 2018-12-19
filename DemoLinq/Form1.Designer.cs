namespace LinqDemo
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
            this.btnsimplelinq = new System.Windows.Forms.Button();
            this.btnlinqwithlambdas = new System.Windows.Forms.Button();
            this.btnorderby = new System.Windows.Forms.Button();
            this.btnthenby = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnWhere = new System.Windows.Forms.Button();
            this.btnForEach = new System.Windows.Forms.Button();
            this.btnAllBiographies = new System.Windows.Forms.Button();
            this.btnextensionmethod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsimplelinq
            // 
            this.btnsimplelinq.Location = new System.Drawing.Point(233, 18);
            this.btnsimplelinq.Name = "btnsimplelinq";
            this.btnsimplelinq.Size = new System.Drawing.Size(155, 23);
            this.btnsimplelinq.TabIndex = 0;
            this.btnsimplelinq.Text = "Simple Linq";
            this.btnsimplelinq.UseVisualStyleBackColor = true;
            this.btnsimplelinq.Click += new System.EventHandler(this.btnsimplelinq_Click);
            // 
            // btnlinqwithlambdas
            // 
            this.btnlinqwithlambdas.Location = new System.Drawing.Point(233, 78);
            this.btnlinqwithlambdas.Name = "btnlinqwithlambdas";
            this.btnlinqwithlambdas.Size = new System.Drawing.Size(155, 23);
            this.btnlinqwithlambdas.TabIndex = 2;
            this.btnlinqwithlambdas.Text = "Linq With Lambdas";
            this.btnlinqwithlambdas.UseVisualStyleBackColor = true;
            this.btnlinqwithlambdas.Click += new System.EventHandler(this.btnlinqwithlambdas_Click);
            // 
            // btnorderby
            // 
            this.btnorderby.Location = new System.Drawing.Point(233, 140);
            this.btnorderby.Name = "btnorderby";
            this.btnorderby.Size = new System.Drawing.Size(155, 23);
            this.btnorderby.TabIndex = 4;
            this.btnorderby.Text = "OrderBy";
            this.btnorderby.UseVisualStyleBackColor = true;
            this.btnorderby.Click += new System.EventHandler(this.btnorderby_Click);
            // 
            // btnthenby
            // 
            this.btnthenby.Location = new System.Drawing.Point(233, 169);
            this.btnthenby.Name = "btnthenby";
            this.btnthenby.Size = new System.Drawing.Size(155, 23);
            this.btnthenby.TabIndex = 5;
            this.btnthenby.Text = "ThenBy";
            this.btnthenby.UseVisualStyleBackColor = true;
            this.btnthenby.Click += new System.EventHandler(this.btnthenby_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(233, 198);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(155, 23);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(233, 289);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(155, 23);
            this.btnfirst.TabIndex = 9;
            this.btnfirst.Text = "First";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // txtResults
            // 
            this.txtResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(7, 345);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(652, 224);
            this.txtResults.TabIndex = 6;
            // 
            // btnWhere
            // 
            this.btnWhere.Location = new System.Drawing.Point(233, 107);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(155, 23);
            this.btnWhere.TabIndex = 3;
            this.btnWhere.Text = "Where";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // btnForEach
            // 
            this.btnForEach.Location = new System.Drawing.Point(233, 229);
            this.btnForEach.Name = "btnForEach";
            this.btnForEach.Size = new System.Drawing.Size(155, 23);
            this.btnForEach.TabIndex = 7;
            this.btnForEach.Text = "ForEach";
            this.btnForEach.UseVisualStyleBackColor = true;
            this.btnForEach.Click += new System.EventHandler(this.btnForEach_Click);
            // 
            // btnAllBiographies
            // 
            this.btnAllBiographies.Location = new System.Drawing.Point(233, 260);
            this.btnAllBiographies.Name = "btnAllBiographies";
            this.btnAllBiographies.Size = new System.Drawing.Size(155, 23);
            this.btnAllBiographies.TabIndex = 8;
            this.btnAllBiographies.Text = "All Biographies";
            this.btnAllBiographies.UseVisualStyleBackColor = true;
            this.btnAllBiographies.Click += new System.EventHandler(this.btnAllBiographies_Click);
            // 
            // btnextensionmethod
            // 
            this.btnextensionmethod.Location = new System.Drawing.Point(233, 47);
            this.btnextensionmethod.Name = "btnextensionmethod";
            this.btnextensionmethod.Size = new System.Drawing.Size(155, 23);
            this.btnextensionmethod.TabIndex = 1;
            this.btnextensionmethod.Text = "Extension Method";
            this.btnextensionmethod.UseVisualStyleBackColor = true;
            this.btnextensionmethod.Click += new System.EventHandler(this.btnextensionmethod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 581);
            this.Controls.Add(this.btnextensionmethod);
            this.Controls.Add(this.btnAllBiographies);
            this.Controls.Add(this.btnForEach);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnthenby);
            this.Controls.Add(this.btnorderby);
            this.Controls.Add(this.btnlinqwithlambdas);
            this.Controls.Add(this.btnsimplelinq);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsimplelinq;
        private System.Windows.Forms.Button btnlinqwithlambdas;
        private System.Windows.Forms.Button btnorderby;
        private System.Windows.Forms.Button btnthenby;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button btnForEach;
        private System.Windows.Forms.Button btnAllBiographies;
        private System.Windows.Forms.Button btnextensionmethod;
    }
}

