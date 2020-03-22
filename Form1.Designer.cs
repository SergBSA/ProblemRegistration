namespace ProblemRegistration
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.lbDept = new System.Windows.Forms.ListBox();
            this.lbEmployee = new System.Windows.Forms.ListBox();
            this.lbEqTeam = new System.Windows.Forms.ListBox();
            this.lbEqList = new System.Windows.Forms.ListBox();
            this.lbEqPart = new System.Windows.Forms.ListBox();
            this.lbEqPoint = new System.Windows.Forms.ListBox();
            this.lbPlans = new System.Windows.Forms.ListBox();
            this.lbSensor = new System.Windows.Forms.ListBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnNO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lTeam = new System.Windows.Forms.Label();
            this.lDept = new System.Windows.Forms.Label();
            this.lEmployee = new System.Windows.Forms.Label();
            this.lPlan = new System.Windows.Forms.Label();
            this.lList = new System.Windows.Forms.Label();
            this.lSensor = new System.Windows.Forms.Label();
            this.lPart = new System.Windows.Forms.Label();
            this.lPoint = new System.Windows.Forms.Label();
            this.lDescription = new System.Windows.Forms.Label();
            this.lCreated = new System.Windows.Forms.Label();
            this.lbCreated = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // datepicker
            // 
            this.datepicker.Location = new System.Drawing.Point(12, 42);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(205, 22);
            this.datepicker.TabIndex = 0;
            this.datepicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbDept
            // 
            this.lbDept.FormattingEnabled = true;
            this.lbDept.ItemHeight = 16;
            this.lbDept.Location = new System.Drawing.Point(280, 42);
            this.lbDept.Name = "lbDept";
            this.lbDept.Size = new System.Drawing.Size(205, 164);
            this.lbDept.TabIndex = 1;
            this.lbDept.SelectedIndexChanged += new System.EventHandler(this.lbDept_SelectedIndexChanged);
            // 
            // lbEmployee
            // 
            this.lbEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEmployee.FormattingEnabled = true;
            this.lbEmployee.ItemHeight = 16;
            this.lbEmployee.Location = new System.Drawing.Point(520, 42);
            this.lbEmployee.Name = "lbEmployee";
            this.lbEmployee.Size = new System.Drawing.Size(252, 164);
            this.lbEmployee.TabIndex = 2;
            this.lbEmployee.SelectedIndexChanged += new System.EventHandler(this.lbEmployee_SelectedIndexChanged);
            // 
            // lbEqTeam
            // 
            this.lbEqTeam.FormattingEnabled = true;
            this.lbEqTeam.ItemHeight = 16;
            this.lbEqTeam.Location = new System.Drawing.Point(12, 96);
            this.lbEqTeam.Name = "lbEqTeam";
            this.lbEqTeam.Size = new System.Drawing.Size(205, 148);
            this.lbEqTeam.TabIndex = 3;
            this.lbEqTeam.SelectedIndexChanged += new System.EventHandler(this.lbEqTeam_SelectedIndexChanged);
            // 
            // lbEqList
            // 
            this.lbEqList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbEqList.FormattingEnabled = true;
            this.lbEqList.ItemHeight = 16;
            this.lbEqList.Location = new System.Drawing.Point(12, 280);
            this.lbEqList.Name = "lbEqList";
            this.lbEqList.Size = new System.Drawing.Size(205, 164);
            this.lbEqList.TabIndex = 4;
            this.lbEqList.SelectedIndexChanged += new System.EventHandler(this.lbEqList_SelectedIndexChanged);
            // 
            // lbEqPart
            // 
            this.lbEqPart.FormattingEnabled = true;
            this.lbEqPart.ItemHeight = 16;
            this.lbEqPart.Location = new System.Drawing.Point(283, 354);
            this.lbEqPart.Name = "lbEqPart";
            this.lbEqPart.Size = new System.Drawing.Size(205, 148);
            this.lbEqPart.TabIndex = 5;
            this.lbEqPart.SelectedIndexChanged += new System.EventHandler(this.lbEqPart_SelectedIndexChanged);
            // 
            // lbEqPoint
            // 
            this.lbEqPoint.AccessibleDescription = "123";
            this.lbEqPoint.AccessibleName = "345";
            this.lbEqPoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEqPoint.FormattingEnabled = true;
            this.lbEqPoint.ItemHeight = 16;
            this.lbEqPoint.Location = new System.Drawing.Point(520, 354);
            this.lbEqPoint.Name = "lbEqPoint";
            this.lbEqPoint.Size = new System.Drawing.Size(252, 148);
            this.lbEqPoint.TabIndex = 6;
            this.lbEqPoint.SelectedIndexChanged += new System.EventHandler(this.lbEqPoint_SelectedIndexChanged);
            // 
            // lbPlans
            // 
            this.lbPlans.FormattingEnabled = true;
            this.lbPlans.ItemHeight = 16;
            this.lbPlans.Location = new System.Drawing.Point(15, 483);
            this.lbPlans.Name = "lbPlans";
            this.lbPlans.Size = new System.Drawing.Size(205, 148);
            this.lbPlans.TabIndex = 7;
            this.lbPlans.SelectedIndexChanged += new System.EventHandler(this.lbPlans_SelectedIndexChanged);
            // 
            // lbSensor
            // 
            this.lbSensor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSensor.FormattingEnabled = true;
            this.lbSensor.ItemHeight = 16;
            this.lbSensor.Location = new System.Drawing.Point(804, 42);
            this.lbSensor.Name = "lbSensor";
            this.lbSensor.Size = new System.Drawing.Size(205, 580);
            this.lbSensor.TabIndex = 8;
            this.lbSensor.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(280, 526);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(492, 60);
            this.txtDescription.TabIndex = 9;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Location = new System.Drawing.Point(280, 592);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(205, 39);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnNO
            // 
            this.btnNO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNO.Location = new System.Drawing.Point(567, 592);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(205, 39);
            this.btnNO.TabIndex = 11;
            this.btnNO.Text = "Cancel";
            this.btnNO.UseVisualStyleBackColor = true;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата/время проблемы";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lTeam
            // 
            this.lTeam.AutoSize = true;
            this.lTeam.Location = new System.Drawing.Point(9, 76);
            this.lTeam.Name = "lTeam";
            this.lTeam.Size = new System.Drawing.Size(62, 17);
            this.lTeam.TabIndex = 13;
            this.lTeam.Text = "Участок";
            // 
            // lDept
            // 
            this.lDept.AutoSize = true;
            this.lDept.Location = new System.Drawing.Point(280, 22);
            this.lDept.Name = "lDept";
            this.lDept.Size = new System.Drawing.Size(50, 17);
            this.lDept.TabIndex = 14;
            this.lDept.Text = "Отдел";
            this.lDept.Click += new System.EventHandler(this.label3_Click);
            // 
            // lEmployee
            // 
            this.lEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lEmployee.AutoSize = true;
            this.lEmployee.Location = new System.Drawing.Point(517, 22);
            this.lEmployee.Name = "lEmployee";
            this.lEmployee.Size = new System.Drawing.Size(78, 17);
            this.lEmployee.TabIndex = 15;
            this.lEmployee.Text = "Сотрудник";
            // 
            // lPlan
            // 
            this.lPlan.AutoSize = true;
            this.lPlan.Location = new System.Drawing.Point(12, 463);
            this.lPlan.Name = "lPlan";
            this.lPlan.Size = new System.Drawing.Size(66, 17);
            this.lPlan.TabIndex = 16;
            this.lPlan.Text = "№ плана";
            // 
            // lList
            // 
            this.lList.AutoSize = true;
            this.lList.Location = new System.Drawing.Point(9, 260);
            this.lList.Name = "lList";
            this.lList.Size = new System.Drawing.Size(70, 17);
            this.lList.TabIndex = 17;
            this.lList.Text = "Участок2";
            // 
            // lSensor
            // 
            this.lSensor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lSensor.AutoSize = true;
            this.lSensor.Location = new System.Drawing.Point(801, 22);
            this.lSensor.Name = "lSensor";
            this.lSensor.Size = new System.Drawing.Size(129, 17);
            this.lSensor.TabIndex = 18;
            this.lSensor.Text = "№ тех. устройства";
            // 
            // lPart
            // 
            this.lPart.AutoSize = true;
            this.lPart.Location = new System.Drawing.Point(277, 334);
            this.lPart.Name = "lPart";
            this.lPart.Size = new System.Drawing.Size(47, 17);
            this.lPart.TabIndex = 19;
            this.lPart.Text = "Часть\r\n";
            // 
            // lPoint
            // 
            this.lPoint.AutoSize = true;
            this.lPoint.Location = new System.Drawing.Point(517, 334);
            this.lPoint.Name = "lPoint";
            this.lPoint.Size = new System.Drawing.Size(48, 17);
            this.lPoint.TabIndex = 20;
            this.lPoint.Text = "Точка";
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(280, 505);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(145, 17);
            this.lDescription.TabIndex = 21;
            this.lDescription.Text = "Описание проблемы\r\n";
            // 
            // lCreated
            // 
            this.lCreated.AutoSize = true;
            this.lCreated.Location = new System.Drawing.Point(280, 221);
            this.lCreated.Name = "lCreated";
            this.lCreated.Size = new System.Drawing.Size(220, 17);
            this.lCreated.TabIndex = 23;
            this.lCreated.Text = "Зарегистрированные проблемы\r\n";
            // 
            // lbCreated
            // 
            this.lbCreated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCreated.FormattingEnabled = true;
            this.lbCreated.ItemHeight = 16;
            this.lbCreated.Location = new System.Drawing.Point(280, 241);
            this.lbCreated.Name = "lbCreated";
            this.lbCreated.Size = new System.Drawing.Size(492, 84);
            this.lbCreated.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 666);
            this.Controls.Add(this.lbCreated);
            this.Controls.Add(this.lCreated);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.lPoint);
            this.Controls.Add(this.lPart);
            this.Controls.Add(this.lSensor);
            this.Controls.Add(this.lList);
            this.Controls.Add(this.lPlan);
            this.Controls.Add(this.lEmployee);
            this.Controls.Add(this.lDept);
            this.Controls.Add(this.lTeam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbSensor);
            this.Controls.Add(this.lbPlans);
            this.Controls.Add(this.lbEqPoint);
            this.Controls.Add(this.lbEqPart);
            this.Controls.Add(this.lbEqList);
            this.Controls.Add(this.lbEqTeam);
            this.Controls.Add(this.lbEmployee);
            this.Controls.Add(this.lbDept);
            this.Controls.Add(this.datepicker);
            this.MinimumSize = new System.Drawing.Size(1002, 672);
            this.Name = "Form1";
            this.Text = "New Problem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.ListBox lbDept;
        private System.Windows.Forms.ListBox lbEmployee;
        private System.Windows.Forms.ListBox lbEqTeam;
        private System.Windows.Forms.ListBox lbEqList;
        private System.Windows.Forms.ListBox lbEqPart;
        private System.Windows.Forms.ListBox lbEqPoint;
        private System.Windows.Forms.ListBox lbPlans;
        private System.Windows.Forms.ListBox lbSensor;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lTeam;
        private System.Windows.Forms.Label lDept;
        private System.Windows.Forms.Label lEmployee;
        private System.Windows.Forms.Label lPlan;
        private System.Windows.Forms.Label lList;
        private System.Windows.Forms.Label lSensor;
        private System.Windows.Forms.Label lPart;
        private System.Windows.Forms.Label lPoint;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.Label lCreated;
        private System.Windows.Forms.ListBox lbCreated;
    }
}

