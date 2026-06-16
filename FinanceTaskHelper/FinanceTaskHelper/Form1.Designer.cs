namespace FinanceTaskHelper
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // Метки баланса
            this.labelBalance = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();

            // Группа Доходов
            this.groupIncome = new System.Windows.Forms.GroupBox();
            this.txtIncomeAmount = new System.Windows.Forms.TextBox();
            this.cmbIncomeCategory = new System.Windows.Forms.ComboBox();
            this.txtIncomeSource = new System.Windows.Forms.TextBox();
            this.btnAddIncome = new System.Windows.Forms.Button();
            this.labelIncomeAmount = new System.Windows.Forms.Label();
            this.labelIncomeCategory = new System.Windows.Forms.Label();
            this.labelIncomeSource = new System.Windows.Forms.Label();

            // Группа Расходов
            this.groupExpense = new System.Windows.Forms.GroupBox();
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.cmbExpenseCategory = new System.Windows.Forms.ComboBox();
            this.txtExpenseDesc = new System.Windows.Forms.TextBox();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.labelExpenseAmount = new System.Windows.Forms.Label();
            this.labelExpenseCategory = new System.Windows.Forms.Label();
            this.labelExpenseDesc = new System.Windows.Forms.Label();

            // Группа Задач
            this.groupTasks = new System.Windows.Forms.GroupBox();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.dtpTaskDeadline = new System.Windows.Forms.DateTimePicker();
            this.cmbTaskPriority = new System.Windows.Forms.ComboBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.labelTaskTitle = new System.Windows.Forms.Label();
            this.labelTaskDeadline = new System.Windows.Forms.Label();
            this.labelTaskPriority = new System.Windows.Forms.Label();

            // Список задач и кнопка
            this.listTasks = new System.Windows.Forms.ListBox();
            this.btnCompleteTask = new System.Windows.Forms.Button();

            // Таблица транзакций
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();

            // ===== НОВАЯ КНОПКА ОЧИСТКИ =====
            this.btnClearTransactions = new System.Windows.Forms.Button();

            // Панель статуса
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();

            this.groupIncome.SuspendLayout();
            this.groupExpense.SuspendLayout();
            this.groupTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // ==================================================
            // labelBalance
            // ==================================================
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelBalance.Location = new System.Drawing.Point(20, 20);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(78, 25);
            this.labelBalance.TabIndex = 0;
            this.labelBalance.Text = "Баланс:";

            // ==================================================
            // lblBalance
            // ==================================================
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblBalance.Location = new System.Drawing.Point(104, 18);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(63, 29);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "0 ₽";
            this.lblBalance.ForeColor = System.Drawing.Color.Green;

            // ==================================================
            // Группа ДОХОДЫ
            // ==================================================
            this.groupIncome.Text = "➕ ДОХОДЫ";
            this.groupIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupIncome.Location = new System.Drawing.Point(20, 70);
            this.groupIncome.Size = new System.Drawing.Size(350, 200);
            this.groupIncome.TabIndex = 2;
            this.groupIncome.TabStop = false;

            this.labelIncomeAmount.AutoSize = true;
            this.labelIncomeAmount.Location = new System.Drawing.Point(15, 35);
            this.labelIncomeAmount.Text = "Сумма:";
            this.labelIncomeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);

            this.txtIncomeAmount.Location = new System.Drawing.Point(120, 32);
            this.txtIncomeAmount.Size = new System.Drawing.Size(200, 22);
            this.txtIncomeAmount.TabIndex = 3;

            this.labelIncomeCategory.AutoSize = true;
            this.labelIncomeCategory.Location = new System.Drawing.Point(15, 75);
            this.labelIncomeCategory.Text = "Категория:";

            this.cmbIncomeCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIncomeCategory.Location = new System.Drawing.Point(120, 72);
            this.cmbIncomeCategory.Size = new System.Drawing.Size(200, 24);
            this.cmbIncomeCategory.Items.AddRange(new object[] { "Зарплата", "Подарок", "Кэшбэк", "Фриланс", "Другое" });
            this.cmbIncomeCategory.SelectedIndex = 0;

            this.labelIncomeSource.AutoSize = true;
            this.labelIncomeSource.Location = new System.Drawing.Point(15, 115);
            this.labelIncomeSource.Text = "Источник:";

            this.txtIncomeSource.Location = new System.Drawing.Point(120, 112);
            this.txtIncomeSource.Size = new System.Drawing.Size(200, 22);
            this.txtIncomeSource.Text = "";
            this.txtIncomeSource.TabIndex = 5;

            this.btnAddIncome.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIncome.Location = new System.Drawing.Point(120, 150);
            this.btnAddIncome.Size = new System.Drawing.Size(200, 35);
            this.btnAddIncome.Text = "ДОБАВИТЬ ДОХОД";
            this.btnAddIncome.UseVisualStyleBackColor = false;
            this.btnAddIncome.Click += new System.EventHandler(this.btnAddIncome_Click);

            this.groupIncome.Controls.Add(this.labelIncomeAmount);
            this.groupIncome.Controls.Add(this.txtIncomeAmount);
            this.groupIncome.Controls.Add(this.labelIncomeCategory);
            this.groupIncome.Controls.Add(this.cmbIncomeCategory);
            this.groupIncome.Controls.Add(this.labelIncomeSource);
            this.groupIncome.Controls.Add(this.txtIncomeSource);
            this.groupIncome.Controls.Add(this.btnAddIncome);

            // ==================================================
            // Группа РАСХОДЫ
            // ==================================================
            this.groupExpense.Text = "➖ РАСХОДЫ";
            this.groupExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupExpense.Location = new System.Drawing.Point(390, 70);
            this.groupExpense.Size = new System.Drawing.Size(350, 200);
            this.groupExpense.TabIndex = 6;
            this.groupExpense.TabStop = false;

            this.labelExpenseAmount.AutoSize = true;
            this.labelExpenseAmount.Location = new System.Drawing.Point(15, 35);
            this.labelExpenseAmount.Text = "Сумма:";

            this.txtExpenseAmount.Location = new System.Drawing.Point(120, 32);
            this.txtExpenseAmount.Size = new System.Drawing.Size(200, 22);
            this.txtExpenseAmount.TabIndex = 7;

            this.labelExpenseCategory.AutoSize = true;
            this.labelExpenseCategory.Location = new System.Drawing.Point(15, 75);
            this.labelExpenseCategory.Text = "Категория:";

            this.cmbExpenseCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpenseCategory.Location = new System.Drawing.Point(120, 72);
            this.cmbExpenseCategory.Size = new System.Drawing.Size(200, 24);
            this.cmbExpenseCategory.Items.AddRange(new object[] { "Еда", "Транспорт", "Развлечения", "ЖКХ", "Здоровье", "Другое" });
            this.cmbExpenseCategory.SelectedIndex = 0;

            this.labelExpenseDesc.AutoSize = true;
            this.labelExpenseDesc.Location = new System.Drawing.Point(15, 115);
            this.labelExpenseDesc.Text = "Описание:";

            this.txtExpenseDesc.Location = new System.Drawing.Point(120, 112);
            this.txtExpenseDesc.Size = new System.Drawing.Size(200, 22);
            this.txtExpenseDesc.Text = "";
            this.txtExpenseDesc.TabIndex = 9;

            this.btnAddExpense.BackColor = System.Drawing.Color.LightCoral;
            this.btnAddExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExpense.Location = new System.Drawing.Point(120, 150);
            this.btnAddExpense.Size = new System.Drawing.Size(200, 35);
            this.btnAddExpense.Text = "ДОБАВИТЬ РАСХОД";
            this.btnAddExpense.UseVisualStyleBackColor = false;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);

            this.groupExpense.Controls.Add(this.labelExpenseAmount);
            this.groupExpense.Controls.Add(this.txtExpenseAmount);
            this.groupExpense.Controls.Add(this.labelExpenseCategory);
            this.groupExpense.Controls.Add(this.cmbExpenseCategory);
            this.groupExpense.Controls.Add(this.labelExpenseDesc);
            this.groupExpense.Controls.Add(this.txtExpenseDesc);
            this.groupExpense.Controls.Add(this.btnAddExpense);

            // ==================================================
            // Группа ЗАДАЧИ
            // ==================================================
            this.groupTasks.Text = "📋 ЗАДАЧИ";
            this.groupTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupTasks.Location = new System.Drawing.Point(20, 290);
            this.groupTasks.Size = new System.Drawing.Size(720, 150);
            this.groupTasks.TabIndex = 10;
            this.groupTasks.TabStop = false;

            this.labelTaskTitle.AutoSize = true;
            this.labelTaskTitle.Location = new System.Drawing.Point(15, 35);
            this.labelTaskTitle.Text = "Задача:";

            this.txtTaskTitle.Location = new System.Drawing.Point(120, 32);
            this.txtTaskTitle.Size = new System.Drawing.Size(250, 22);
            this.txtTaskTitle.TabIndex = 11;

            this.labelTaskDeadline.AutoSize = true;
            this.labelTaskDeadline.Location = new System.Drawing.Point(420, 35);
            this.labelTaskDeadline.Text = "Срок до:";

            this.dtpTaskDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTaskDeadline.Location = new System.Drawing.Point(500, 32);
            this.dtpTaskDeadline.Size = new System.Drawing.Size(180, 22);
            this.dtpTaskDeadline.TabIndex = 12;
            this.dtpTaskDeadline.Value = System.DateTime.Now.AddDays(7);

            this.labelTaskPriority.AutoSize = true;
            this.labelTaskPriority.Location = new System.Drawing.Point(15, 75);
            this.labelTaskPriority.Text = "Приоритет:";

            this.cmbTaskPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaskPriority.Location = new System.Drawing.Point(120, 72);
            this.cmbTaskPriority.Size = new System.Drawing.Size(150, 24);
            this.cmbTaskPriority.Items.AddRange(new object[] { "Низкий", "Средний", "Высокий" });
            this.cmbTaskPriority.SelectedIndex = 1;

            this.btnAddTask.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Location = new System.Drawing.Point(500, 65);
            this.btnAddTask.Size = new System.Drawing.Size(180, 35);
            this.btnAddTask.Text = "ДОБАВИТЬ ЗАДАЧУ";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);

            this.groupTasks.Controls.Add(this.labelTaskTitle);
            this.groupTasks.Controls.Add(this.txtTaskTitle);
            this.groupTasks.Controls.Add(this.labelTaskDeadline);
            this.groupTasks.Controls.Add(this.dtpTaskDeadline);
            this.groupTasks.Controls.Add(this.labelTaskPriority);
            this.groupTasks.Controls.Add(this.cmbTaskPriority);
            this.groupTasks.Controls.Add(this.btnAddTask);

            // ==================================================
            // Список задач и кнопка ВЫПОЛНЕНО
            // ==================================================
            this.listTasks.FormattingEnabled = true;
            this.listTasks.ItemHeight = 16;
            this.listTasks.Location = new System.Drawing.Point(20, 460);
            this.listTasks.Size = new System.Drawing.Size(550, 180);
            this.listTasks.TabIndex = 13;

            this.btnCompleteTask.BackColor = System.Drawing.Color.Gold;
            this.btnCompleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteTask.Location = new System.Drawing.Point(600, 500);
            this.btnCompleteTask.Size = new System.Drawing.Size(140, 50);
            this.btnCompleteTask.Text = "✓ ВЫПОЛНЕНО";
            this.btnCompleteTask.UseVisualStyleBackColor = false;
            this.btnCompleteTask.Click += new System.EventHandler(this.btnCompleteTask_Click);

            // ==================================================
            // ТАБЛИЦА ТРАНЗАКЦИЙ (исправлена прокрутка)
            // ==================================================
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells; // лучше чем Fill
            this.dgvTransactions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical; // принудительно вертикальная прокрутка
            this.dgvTransactions.Location = new System.Drawing.Point(20, 660);
            this.dgvTransactions.Size = new System.Drawing.Size(720, 200);
            this.dgvTransactions.TabIndex = 14;

            // ==================================================
            // КНОПКА ОБНОВИТЬ
            // ==================================================
            this.btnRefresh.BackColor = System.Drawing.Color.LightGray;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(600, 600);
            this.btnRefresh.Size = new System.Drawing.Size(140, 40);
            this.btnRefresh.Text = "🔄 ОБНОВИТЬ";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // ==================================================
            // НОВАЯ КНОПКА ОЧИСТИТЬ ВСЕ ТРАНЗАКЦИИ
            // ==================================================
            this.btnClearTransactions.BackColor = System.Drawing.Color.IndianRed;
            this.btnClearTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTransactions.Location = new System.Drawing.Point(600, 460); // рядом со списком задач
            this.btnClearTransactions.Size = new System.Drawing.Size(140, 35);
            this.btnClearTransactions.Text = "🗑️ ОЧИСТИТЬ ВСЕ";
            this.btnClearTransactions.UseVisualStyleBackColor = false;
            this.btnClearTransactions.Click += new System.EventHandler(this.btnClearTransactions_Click);

            // ==================================================
            // СТАТУС БАР
            // ==================================================
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripStatusLabel });
            this.statusStrip.Location = new System.Drawing.Point(0, 880);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(770, 22);
            this.statusStrip.TabIndex = 15;
            this.toolStripStatusLabel.Text = "Готово к работе";

            // ==================================================
            // ФОРМА
            // ==================================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 920);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClearTransactions);   // добавлена
            this.Controls.Add(this.listTasks);
            this.Controls.Add(this.btnCompleteTask);
            this.Controls.Add(this.groupTasks);
            this.Controls.Add(this.groupExpense);
            this.Controls.Add(this.groupIncome);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.labelBalance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер финансов и задач";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);

            // ==================================================
            // Завершение инициализации
            // ==================================================
            this.groupIncome.ResumeLayout(false);
            this.groupIncome.PerformLayout();
            this.groupExpense.ResumeLayout(false);
            this.groupExpense.PerformLayout();
            this.groupTasks.ResumeLayout(false);
            this.groupTasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // ==================================================
        // ПОЛЯ (добавлена кнопка очистки)
        // ==================================================
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label lblBalance;

        private System.Windows.Forms.GroupBox groupIncome;
        private System.Windows.Forms.TextBox txtIncomeAmount;
        private System.Windows.Forms.ComboBox cmbIncomeCategory;
        private System.Windows.Forms.TextBox txtIncomeSource;
        private System.Windows.Forms.Button btnAddIncome;
        private System.Windows.Forms.Label labelIncomeAmount;
        private System.Windows.Forms.Label labelIncomeCategory;
        private System.Windows.Forms.Label labelIncomeSource;

        private System.Windows.Forms.GroupBox groupExpense;
        private System.Windows.Forms.TextBox txtExpenseAmount;
        private System.Windows.Forms.ComboBox cmbExpenseCategory;
        private System.Windows.Forms.TextBox txtExpenseDesc;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Label labelExpenseAmount;
        private System.Windows.Forms.Label labelExpenseCategory;
        private System.Windows.Forms.Label labelExpenseDesc;

        private System.Windows.Forms.GroupBox groupTasks;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.DateTimePicker dtpTaskDeadline;
        private System.Windows.Forms.ComboBox cmbTaskPriority;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label labelTaskTitle;
        private System.Windows.Forms.Label labelTaskDeadline;
        private System.Windows.Forms.Label labelTaskPriority;

        private System.Windows.Forms.ListBox listTasks;
        private System.Windows.Forms.Button btnCompleteTask;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;

        // НОВОЕ ПОЛЕ
        private System.Windows.Forms.Button btnClearTransactions;
    }
}