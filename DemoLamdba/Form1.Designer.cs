namespace Lambdas
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
            this.btntraditionaldelegate = new System.Windows.Forms.Button();
            this.btnanonymousmethod = new System.Windows.Forms.Button();
            this.btnsimplelamdaexpression = new System.Windows.Forms.Button();
            this.btnlamdawithoutinference = new System.Windows.Forms.Button();
            this.btnlamdawithmultipleparameters = new System.Windows.Forms.Button();
            this.btnlambdawithcodeblock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btntraditionaldelegate
            // 
            this.btntraditionaldelegate.Location = new System.Drawing.Point(47, 24);
            this.btntraditionaldelegate.Name = "btntraditionaldelegate";
            this.btntraditionaldelegate.Size = new System.Drawing.Size(296, 23);
            this.btntraditionaldelegate.TabIndex = 0;
            this.btntraditionaldelegate.Text = "Traditional Delegate";
            this.btntraditionaldelegate.UseVisualStyleBackColor = true;
            this.btntraditionaldelegate.Click += new System.EventHandler(this.btntraditionaldelegate_Click);
            // 
            // btnanonymousmethod
            // 
            this.btnanonymousmethod.Location = new System.Drawing.Point(47, 53);
            this.btnanonymousmethod.Name = "btnanonymousmethod";
            this.btnanonymousmethod.Size = new System.Drawing.Size(296, 23);
            this.btnanonymousmethod.TabIndex = 1;
            this.btnanonymousmethod.Text = "Anonymous Method";
            this.btnanonymousmethod.UseVisualStyleBackColor = true;
            this.btnanonymousmethod.Click += new System.EventHandler(this.btnanonymousmethod_Click);
            // 
            // btnsimplelamdaexpression
            // 
            this.btnsimplelamdaexpression.Location = new System.Drawing.Point(47, 85);
            this.btnsimplelamdaexpression.Name = "btnsimplelamdaexpression";
            this.btnsimplelamdaexpression.Size = new System.Drawing.Size(296, 23);
            this.btnsimplelamdaexpression.TabIndex = 2;
            this.btnsimplelamdaexpression.Text = "Simple Lambda Expression";
            this.btnsimplelamdaexpression.UseVisualStyleBackColor = true;
            this.btnsimplelamdaexpression.Click += new System.EventHandler(this.btnsimplelamdaexpression_Click);
            // 
            // btnlamdawithoutinference
            // 
            this.btnlamdawithoutinference.Location = new System.Drawing.Point(47, 114);
            this.btnlamdawithoutinference.Name = "btnlamdawithoutinference";
            this.btnlamdawithoutinference.Size = new System.Drawing.Size(296, 23);
            this.btnlamdawithoutinference.TabIndex = 3;
            this.btnlamdawithoutinference.Text = "Lambda Without Inference";
            this.btnlamdawithoutinference.UseVisualStyleBackColor = true;
            this.btnlamdawithoutinference.Click += new System.EventHandler(this.btnlamdawithoutinference_Click);
            // 
            // btnlamdawithmultipleparameters
            // 
            this.btnlamdawithmultipleparameters.Location = new System.Drawing.Point(47, 143);
            this.btnlamdawithmultipleparameters.Name = "btnlamdawithmultipleparameters";
            this.btnlamdawithmultipleparameters.Size = new System.Drawing.Size(296, 23);
            this.btnlamdawithmultipleparameters.TabIndex = 4;
            this.btnlamdawithmultipleparameters.Text = "Lambda With Multiple Parameters";
            this.btnlamdawithmultipleparameters.UseVisualStyleBackColor = true;
            this.btnlamdawithmultipleparameters.Click += new System.EventHandler(this.btnlamdawithmultipleparameters_Click);
            // 
            // btnlambdawithcodeblock
            // 
            this.btnlambdawithcodeblock.Location = new System.Drawing.Point(47, 172);
            this.btnlambdawithcodeblock.Name = "btnlambdawithcodeblock";
            this.btnlambdawithcodeblock.Size = new System.Drawing.Size(296, 23);
            this.btnlambdawithcodeblock.TabIndex = 5;
            this.btnlambdawithcodeblock.Text = "Lambda With Code Block";
            this.btnlambdawithcodeblock.UseVisualStyleBackColor = true;
            this.btnlambdawithcodeblock.Click += new System.EventHandler(this.btnlambdawithcodeblock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 223);
            this.Controls.Add(this.btnlambdawithcodeblock);
            this.Controls.Add(this.btnlamdawithmultipleparameters);
            this.Controls.Add(this.btnlamdawithoutinference);
            this.Controls.Add(this.btnsimplelamdaexpression);
            this.Controls.Add(this.btnanonymousmethod);
            this.Controls.Add(this.btntraditionaldelegate);
            this.Name = "Form1";
            this.Text = "Lambdas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntraditionaldelegate;
        private System.Windows.Forms.Button btnanonymousmethod;
        private System.Windows.Forms.Button btnsimplelamdaexpression;
        private System.Windows.Forms.Button btnlamdawithoutinference;
        private System.Windows.Forms.Button btnlamdawithmultipleparameters;
        private System.Windows.Forms.Button btnlambdawithcodeblock;
    }
}

