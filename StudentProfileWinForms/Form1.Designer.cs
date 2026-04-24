namespace StudentProfileWinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label lblDaysAttended;
        private System.Windows.Forms.TextBox txtDaysAttended;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox rtbOutput;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.lblDaysAttended = new System.Windows.Forms.Label();
            this.txtDaysAttended = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(350, 25);
            this.lblTitle.Text = "Student Readiness Capture System";

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 55);
            this.lblName.Text = "Full Name:";

            // txtName
            this.txtName.Location = new System.Drawing.Point(120, 52);
            this.txtName.Size = new System.Drawing.Size(200, 23);

            // lblAge
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(14, 85);
            this.lblAge.Text = "Age (16-100):";

            // txtAge
            this.txtAge.Location = new System.Drawing.Point(120, 82);
            this.txtAge.Size = new System.Drawing.Size(60, 23);

            // lblGrade
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(14, 115);
            this.lblGrade.Text = "Grade % (0-100):";

            // txtGrade
            this.txtGrade.Location = new System.Drawing.Point(120, 112);
            this.txtGrade.Size = new System.Drawing.Size(60, 23);

            // lblDaysAttended
            this.lblDaysAttended.AutoSize = true;
            this.lblDaysAttended.Location = new System.Drawing.Point(14, 145);
            this.lblDaysAttended.Text = "Days Attended:";

            // txtDaysAttended
            this.txtDaysAttended.Location = new System.Drawing.Point(120, 142);
            this.txtDaysAttended.Size = new System.Drawing.Size(60, 23);

            // btnProcess
            this.btnProcess.Location = new System.Drawing.Point(17, 180);
            this.btnProcess.Size = new System.Drawing.Size(100, 30);
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(130, 180);
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // rtbOutput
            this.rtbOutput.Font = new System.Drawing.Font("Consolas", 10F);
            this.rtbOutput.Location = new System.Drawing.Point(17, 225);
            this.rtbOutput.Size = new System.Drawing.Size(450, 220);
            this.rtbOutput.ReadOnly = true;

            // Form1
            this.ClientSize = new System.Drawing.Size(490, 460);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblDaysAttended);
            this.Controls.Add(this.txtDaysAttended);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rtbOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Smart Student Profile Processor";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}