using System;
using System.Windows.Forms;
using FinanceTaskHelper.Classes;

namespace FinanceTaskHelper
{
    public partial class Form1 : Form
    {
        private FinanceTaskManager manager;
        private BindingSource bindingSourceTransactions; // для автоматического обновления

        public Form1()
        {
            InitializeComponent();
            manager = new FinanceTaskManager();
            bindingSourceTransactions = new BindingSource();
            bindingSourceTransactions.DataSource = manager.Transactions;
            RefreshAll();
            toolStripStatusLabel.Text = $"Загружено транзакций: {manager.Transactions.Count}, задач: {manager.Tasks.Count}";
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtIncomeAmount.Text, out decimal amount) && amount > 0)
            {
                manager.AddIncome(amount, cmbIncomeCategory.Text, txtIncomeSource.Text);
                manager.SaveData();
                RefreshAll();
                txtIncomeAmount.Clear();
                txtIncomeSource.Clear();
                toolStripStatusLabel.Text = "✅ Доход добавлен";
            }
            else
                MessageBox.Show("Введите сумму больше 0", "Ошибка");
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtExpenseAmount.Text, out decimal amount) && amount > 0)
            {
                manager.AddExpense(amount, cmbExpenseCategory.Text, txtExpenseDesc.Text);
                manager.SaveData();
                RefreshAll();
                txtExpenseAmount.Clear();
                txtExpenseDesc.Clear();
                toolStripStatusLabel.Text = "✅ Расход добавлен";
            }
            else
                MessageBox.Show("Введите сумму больше 0", "Ошибка");
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTaskTitle.Text))
            {
                manager.AddTask(txtTaskTitle.Text, dtpTaskDeadline.Value, cmbTaskPriority.SelectedIndex + 1);
                manager.SaveData();
                RefreshAll();
                txtTaskTitle.Clear();
                toolStripStatusLabel.Text = "✅ Задача добавлена";
            }
            else
                MessageBox.Show("Введите название задачи", "Ошибка");
        }

        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            if (listTasks.SelectedItem != null)
            {
                manager.MarkTaskDone(((TaskItem)listTasks.SelectedItem).Id);
                manager.SaveData();
                RefreshAll();
                toolStripStatusLabel.Text = "🎉 Задача выполнена";
            }
            else
                MessageBox.Show("Выберите задачу", "Ошибка");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshAll();
            toolStripStatusLabel.Text = "🔄 Обновлено";
        }

        // ===== Новая кнопка "Очистить транзакции" =====
        private void btnClearTransactions_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить все транзакции?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                manager.ClearTransactions();
                RefreshAll();
                toolStripStatusLabel.Text = "🗑️ Все транзакции удалены";
            }
        }

        private void RefreshAll()
        {
            decimal balance = manager.GetBalance();
            lblBalance.Text = balance.ToString("N2") + " ₽";
            lblBalance.ForeColor = balance >= 0 ? System.Drawing.Color.Green : System.Drawing.Color.Red;

            // Привязываем через BindingSource, чтобы изменения отображались сразу
            bindingSourceTransactions.ResetBindings(false);
            dgvTransactions.DataSource = bindingSourceTransactions;

            // Скрываем Id
            if (dgvTransactions.Columns.Count > 0)
                dgvTransactions.Columns["Id"].Visible = false;

            // Автоширина
            dgvTransactions.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Задачи
            listTasks.DataSource = null;
            listTasks.DataSource = manager.GetActiveTasks();
            listTasks.DisplayMember = "Title";

            toolStripStatusLabel.Text = $"Транзакций: {manager.Transactions.Count}, активных задач: {manager.GetActiveTasks().Count}";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            manager.SaveData();
        }
    }
}