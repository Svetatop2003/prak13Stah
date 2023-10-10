namespace prak13Stah.DBCon
{
    partial class FormAddActivity
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
            this.components = new System.ComponentModel.Container();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAddActivity = new System.Windows.Forms.Button();
            this.buttonAddJuri = new System.Windows.Forms.Button();
            this.labelNewActivity = new System.Windows.Forms.Label();
            this.NameLb = new System.Windows.Forms.Label();
            this.labelPlan = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelModerator = new System.Windows.Forms.Label();
            this.labelJuri = new System.Windows.Forms.Label();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eventPlanIDComboBox = new System.Windows.Forms.ComboBox();
            this.juriComboBox = new System.Windows.Forms.ComboBox();
            this.ModeratorComboBox = new System.Windows.Forms.ComboBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 19);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAddActivity
            // 
            this.buttonAddActivity.Location = new System.Drawing.Point(130, 307);
            this.buttonAddActivity.Name = "buttonAddActivity";
            this.buttonAddActivity.Size = new System.Drawing.Size(237, 23);
            this.buttonAddActivity.TabIndex = 1;
            this.buttonAddActivity.Text = "Добавить новую активность";
            this.buttonAddActivity.UseVisualStyleBackColor = true;
            this.buttonAddActivity.Click += new System.EventHandler(this.buttonAddActivity_Click);
            // 
            // buttonAddJuri
            // 
            this.buttonAddJuri.Location = new System.Drawing.Point(357, 238);
            this.buttonAddJuri.Name = "buttonAddJuri";
            this.buttonAddJuri.Size = new System.Drawing.Size(75, 23);
            this.buttonAddJuri.TabIndex = 2;
            this.buttonAddJuri.Text = "Добавить";
            this.buttonAddJuri.UseVisualStyleBackColor = true;
            this.buttonAddJuri.Click += new System.EventHandler(this.buttonAddJuri_Click);
            // 
            // labelNewActivity
            // 
            this.labelNewActivity.AutoSize = true;
            this.labelNewActivity.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewActivity.Location = new System.Drawing.Point(93, 19);
            this.labelNewActivity.Name = "labelNewActivity";
            this.labelNewActivity.Size = new System.Drawing.Size(340, 31);
            this.labelNewActivity.TabIndex = 3;
            this.labelNewActivity.Text = "Добавление новой активности";
            // 
            // NameLb
            // 
            this.NameLb.AutoSize = true;
            this.NameLb.Location = new System.Drawing.Point(127, 72);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(57, 13);
            this.NameLb.TabIndex = 4;
            this.NameLb.Text = "Название";
            // 
            // labelPlan
            // 
            this.labelPlan.AutoSize = true;
            this.labelPlan.Location = new System.Drawing.Point(105, 100);
            this.labelPlan.Name = "labelPlan";
            this.labelPlan.Size = new System.Drawing.Size(79, 13);
            this.labelPlan.TabIndex = 5;
            this.labelPlan.Text = "План события";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(150, 140);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(34, 13);
            this.labelDay.TabIndex = 6;
            this.labelDay.Text = "День";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(120, 179);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(70, 13);
            this.labelStart.TabIndex = 7;
            this.labelStart.Text = "Начало мер.";
            // 
            // labelModerator
            // 
            this.labelModerator.AutoSize = true;
            this.labelModerator.Location = new System.Drawing.Point(127, 212);
            this.labelModerator.Name = "labelModerator";
            this.labelModerator.Size = new System.Drawing.Size(63, 13);
            this.labelModerator.TabIndex = 8;
            this.labelModerator.Text = "Модератор";
            // 
            // labelJuri
            // 
            this.labelJuri.AutoSize = true;
            this.labelJuri.Location = new System.Drawing.Point(146, 238);
            this.labelJuri.Name = "labelJuri";
            this.labelJuri.Size = new System.Drawing.Size(38, 13);
            this.labelJuri.TabIndex = 9;
            this.labelJuri.Text = "Жюри";
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(208, 137);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(121, 20);
            this.dayTextBox.TabIndex = 10;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(208, 65);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(121, 20);
            this.titleTextBox.TabIndex = 11;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(208, 173);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker.TabIndex = 12;
            // 
            // eventPlanIDComboBox
            // 
            this.eventPlanIDComboBox.DataSource = this.eventBindingSource;
            this.eventPlanIDComboBox.DisplayMember = "Title";
            this.eventPlanIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventPlanIDComboBox.FormattingEnabled = true;
            this.eventPlanIDComboBox.Location = new System.Drawing.Point(208, 100);
            this.eventPlanIDComboBox.Name = "eventPlanIDComboBox";
            this.eventPlanIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.eventPlanIDComboBox.TabIndex = 13;
            this.eventPlanIDComboBox.ValueMember = "ID";
            // 
            // juriComboBox
            // 
            this.juriComboBox.DataSource = this.usersBindingSource2;
            this.juriComboBox.DisplayMember = "Surname";
            this.juriComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.juriComboBox.FormattingEnabled = true;
            this.juriComboBox.Location = new System.Drawing.Point(208, 238);
            this.juriComboBox.Name = "juriComboBox";
            this.juriComboBox.Size = new System.Drawing.Size(121, 21);
            this.juriComboBox.TabIndex = 14;
            this.juriComboBox.ValueMember = "ID";
            // 
            // ModeratorComboBox
            // 
            this.ModeratorComboBox.DataSource = this.usersBindingSource;
            this.ModeratorComboBox.DisplayMember = "Surname";
            this.ModeratorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeratorComboBox.FormattingEnabled = true;
            this.ModeratorComboBox.Location = new System.Drawing.Point(208, 209);
            this.ModeratorComboBox.Name = "ModeratorComboBox";
            this.ModeratorComboBox.Size = new System.Drawing.Size(121, 21);
            this.ModeratorComboBox.TabIndex = 15;
            this.ModeratorComboBox.ValueMember = "ID";
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(prak13Stah.DBCon.Event);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(prak13Stah.DBCon.User);
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataSource = typeof(prak13Stah.DBCon.User);
            // 
            // FormAddActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 369);
            this.Controls.Add(this.ModeratorComboBox);
            this.Controls.Add(this.juriComboBox);
            this.Controls.Add(this.eventPlanIDComboBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.labelJuri);
            this.Controls.Add(this.labelModerator);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelPlan);
            this.Controls.Add(this.NameLb);
            this.Controls.Add(this.labelNewActivity);
            this.Controls.Add(this.buttonAddJuri);
            this.Controls.Add(this.buttonAddActivity);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormAddActivity";
            this.Text = "FormAddActivity";
            this.Load += new System.EventHandler(this.FormAddActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAddActivity;
        private System.Windows.Forms.Button buttonAddJuri;
        private System.Windows.Forms.Label labelNewActivity;
        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.Label labelPlan;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelModerator;
        private System.Windows.Forms.Label labelJuri;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox eventPlanIDComboBox;
        private System.Windows.Forms.ComboBox juriComboBox;
        private System.Windows.Forms.ComboBox ModeratorComboBox;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource2;
    }
}