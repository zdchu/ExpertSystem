namespace Expertsystem
{
    partial class Expert_System
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

      #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Reasoning = new System.Windows.Forms.Button();
            this.label_Input = new System.Windows.Forms.Label();
            this.label_Result = new System.Windows.Forms.Label();
            this.button_Ontology = new System.Windows.Forms.Button();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button_Reasoning.Location = new System.Drawing.Point(646, 118);
            this.button_Reasoning.Name = "button1";
            this.button_Reasoning.Size = new System.Drawing.Size(172, 68);
            this.button_Reasoning.TabIndex = 0;
            this.button_Reasoning.Text = "推理";
            this.button_Reasoning.UseVisualStyleBackColor = true;
            this.button_Reasoning.Click += new System.EventHandler(this.button_Reasoning_Click);
            // 
            // label1
            // 
            this.label_Input.AutoSize = true;
            this.label_Input.Location = new System.Drawing.Point(30, 71);
            this.label_Input.Name = "label1";
            this.label_Input.Size = new System.Drawing.Size(106, 24);
            this.label_Input.TabIndex = 1;
            this.label_Input.Text = "输入问题";
            // 
            // label2
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.Location = new System.Drawing.Point(344, 71);
            this.label_Result.Name = "label2";
            this.label_Result.Size = new System.Drawing.Size(106, 24);
            this.label_Result.TabIndex = 2;
            this.label_Result.Text = "推理过程";
            // 
            // button2
            // 
            this.button_Ontology.Location = new System.Drawing.Point(646, 418);
            this.button_Ontology.Name = "button2";
            this.button_Ontology.Size = new System.Drawing.Size(172, 68);
            this.button_Ontology.TabIndex = 3;
            this.button_Ontology.Text = "本体库更新";
            this.button_Ontology.UseVisualStyleBackColor = true;
            this.button_Ontology.Click += new System.EventHandler(this.button_Ontology_Click);
            // 
            // textBox1
            // 
            this.textBox_Input.AcceptsReturn = true;
            this.textBox_Input.Location = new System.Drawing.Point(22, 118);
            this.textBox_Input.Multiline = true;
            this.textBox_Input.Name = "textBox1";
            this.textBox_Input.Size = new System.Drawing.Size(270, 368);
            this.textBox_Input.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox_Result.AcceptsReturn = true;
            this.textBox_Result.Location = new System.Drawing.Point(338, 118);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox2";
            this.textBox_Result.Size = new System.Drawing.Size(270, 368);
            this.textBox_Result.TabIndex = 6;
            // 
            // Expert_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 609);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.button_Ontology);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.label_Input);
            this.Controls.Add(this.button_Reasoning);
            this.IsMdiContainer = true;
            this.Name = "Expert_System";
            this.Text = "ExpertSystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Reasoning;
        private System.Windows.Forms.Label label_Input;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Button button_Ontology;

        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.TextBox textBox_Result;
    }
}

