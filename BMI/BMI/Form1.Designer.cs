
namespace HW02_09156104
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.high = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmButton = new System.Windows.Forms.RadioButton();
            this.mButton = new System.Windows.Forms.RadioButton();
            this.compute = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hintlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(62, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "身高:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(62, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "體重:";
            // 
            // high
            // 
            this.high.Location = new System.Drawing.Point(132, 74);
            this.high.Name = "high";
            this.high.Size = new System.Drawing.Size(78, 29);
            this.high.TabIndex = 2;
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(132, 137);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(78, 29);
            this.weight.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(253, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "公斤";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "BMI計算";
            // 
            // cmButton
            // 
            this.cmButton.AutoSize = true;
            this.cmButton.Checked = true;
            this.cmButton.Location = new System.Drawing.Point(228, 79);
            this.cmButton.Name = "cmButton";
            this.cmButton.Size = new System.Drawing.Size(69, 22);
            this.cmButton.TabIndex = 6;
            this.cmButton.TabStop = true;
            this.cmButton.Text = "公分";
            this.cmButton.UseVisualStyleBackColor = true;
            // 
            // mButton
            // 
            this.mButton.AutoSize = true;
            this.mButton.Location = new System.Drawing.Point(324, 82);
            this.mButton.Name = "mButton";
            this.mButton.Size = new System.Drawing.Size(69, 22);
            this.mButton.TabIndex = 7;
            this.mButton.Text = "公尺";
            this.mButton.UseVisualStyleBackColor = true;
            // 
            // compute
            // 
            this.compute.BackColor = System.Drawing.Color.Red;
            this.compute.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.compute.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.compute.Location = new System.Drawing.Point(66, 205);
            this.compute.Name = "compute";
            this.compute.Size = new System.Drawing.Size(244, 46);
            this.compute.TabIndex = 8;
            this.compute.Text = "計算標準體重";
            this.compute.UseVisualStyleBackColor = false;
            this.compute.Click += new System.EventHandler(this.compute_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(107, 283);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // hintlabel
            // 
            this.hintlabel.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hintlabel.Location = new System.Drawing.Point(88, 445);
            this.hintlabel.Name = "hintlabel";
            this.hintlabel.Size = new System.Drawing.Size(174, 39);
            this.hintlabel.TabIndex = 11;
            this.hintlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 522);
            this.Controls.Add(this.hintlabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.compute);
            this.Controls.Add(this.mButton);
            this.Controls.Add(this.cmButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.high);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "HW02_09156104";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox high;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton cmButton;
        private System.Windows.Forms.RadioButton mButton;
        private System.Windows.Forms.Button compute;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label hintlabel;
    }
}

