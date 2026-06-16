using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Windows.Forms;

namespace FinanceTaskHelper.Classes
{
    public class FinanceTaskManager
    {
        public List<Transaction> Transactions { get; private set; } = new List<Transaction>();
        public List<TaskItem> Tasks { get; private set; } = new List<TaskItem>();

        private int nextTransId = 1;
        private int nextTaskId = 1;
        private string transFile = "Data\\transactions.txt";
        private string tasksFile = "Data\\tasks.txt";

        public FinanceTaskManager()
        {
            LoadData();
        }

        public void AddIncome(decimal amount, string category, string source)
        {
            Transactions.Add(new Transaction(nextTransId, DateTime.Now, amount, category, "Income", source));
            nextTransId++;
        }

        public void AddExpense(decimal amount, string category, string description)
        {
            Transactions.Add(new Transaction(nextTransId, DateTime.Now, amount, category, "Expense", description));
            nextTransId++;
        }

        public decimal GetBalance()
        {
            decimal income = 0, expense = 0;
            foreach (var t in Transactions)
            {
                if (t.Type == "Income") income += t.Amount;
                else if (t.Type == "Expense") expense += t.Amount;
            }
            return income - expense;
        }

        public void AddTask(string title, DateTime deadline, int priority)
        {
            Tasks.Add(new TaskItem(nextTaskId, title, deadline, false, priority));
            nextTaskId++;
        }

        public void MarkTaskDone(int taskId)
        {
            foreach (var t in Tasks)
                if (t.Id == taskId) { t.IsDone = true; break; }
        }

        public List<TaskItem> GetActiveTasks()
        {
            var active = new List<TaskItem>();
            foreach (var t in Tasks)
                if (!t.IsDone) active.Add(t);
            return active;
        }

        // Очистка всех транзакций
        public void ClearTransactions()
        {
            Transactions.Clear();
            nextTransId = 1;
            SaveData();
        }

        // ======== СОХРАНЕНИЕ ========
        public void SaveData()
        {
            try
            {
                if (!Directory.Exists("Data")) Directory.CreateDirectory("Data");

                using (StreamWriter writer = new StreamWriter(transFile, false, System.Text.Encoding.UTF8))
                {
                    writer.WriteLine(nextTransId);
                    writer.WriteLine(Transactions.Count);
                    foreach (var t in Transactions)
                    {
                        writer.WriteLine(t.Id);
                        writer.WriteLine(t.Date.ToString("dd.MM.yyyy HH:mm:ss"));
                        writer.WriteLine(t.Amount.ToString(CultureInfo.InvariantCulture));
                        writer.WriteLine(t.Category);
                        writer.WriteLine(t.Type);
                        writer.WriteLine(t.Note);
                    }
                }

                using (StreamWriter writer = new StreamWriter(tasksFile, false, System.Text.Encoding.UTF8))
                {
                    writer.WriteLine(nextTaskId);
                    writer.WriteLine(Tasks.Count);
                    foreach (var t in Tasks)
                    {
                        writer.WriteLine(t.Id);
                        writer.WriteLine(t.Title);
                        writer.WriteLine(t.Deadline.ToString("dd.MM.yyyy HH:mm:ss"));
                        writer.WriteLine(t.IsDone);
                        writer.WriteLine(t.Priority);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }

        // ======== ЗАГРУЗКА (игнорируем пустые строки) ========
        public void LoadData()
        {
            try
            {
                // Загружаем транзакции
                if (File.Exists(transFile))
                {
                    using (StreamReader reader = new StreamReader(transFile, System.Text.Encoding.UTF8))
                    {
                        string line;
                        // Пропускаем пустые строки до первого непустого
                        while ((line = reader.ReadLine()) != null && string.IsNullOrWhiteSpace(line)) { }
                        if (line == null) return;
                        nextTransId = int.Parse(line);

                        while ((line = reader.ReadLine()) != null && string.IsNullOrWhiteSpace(line)) { }
                        if (line == null) return;
                        int count = int.Parse(line);

                        Transactions.Clear();
                        for (int i = 0; i < count; i++)
                        {
                            // Пропускаем пустые строки между записями
                            while ((line = reader.ReadLine()) != null && string.IsNullOrWhiteSpace(line)) { }
                            if (line == null) break;
                            Transaction t = new Transaction();
                            t.Id = int.Parse(line);

                            while ((line = reader.ReadLine()) != null && string.IsNullOrWhiteSpace(line)) { }
                            if (line == null) break;
                            t.Date = DateTime.ParseExact(line, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

                            while ((line = reader.ReadLine()) != null && string.IsNullOrWhiteSpace(line)) { }
                            if (line == null) break;
                            t.Amount = decimal.Parse(line, CultureInfo.InvariantCulture);

                            while ((line = reader.ReadLine()) != null && string.IsNullOrWhiteSpace(line)) { }
                            if (line == null) break;
                            t.Category = line;

                            while ((line = reader.ReadLine()) != null && string.IsNullOrWhiteSpace(line)) { }
                            if (line == null) break;
                            t.Type = line;

                            while ((line = reader.ReadLine()) != null && string.IsNullOrWhiteSpace(line)) { }
                            if (line == null) break;
                            t.Note = line;

                            Transactions.Add(t);
                        }
                    }
                }

                // Аналогично для задач
                if (File.Exists(tasksFile))
                {
                    using (StreamReader reader = new StreamReader(tasksFile, System.Text.Encoding.UTF8))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null && string.IsNullOrWhiteSpace(line)) { }
                        if (line == null) return;
                        nextTaskId = int.Parse(line);

                        while ((line = reader.ReadLine()) != null && string.IsNullOrWhiteSpace(line)) { }
                        if (line == null) return;
                        int count = int.Parse(line);

                        Tasks.Clear();
                        for (int i = 0; i < count; i++)
                        {
                            while ((line = reader.ReadLine()) != null && string.IsNullOrWhiteSpace(line)) { }
                            if (line == null) break;
                            TaskItem t = new TaskItem();
                            t.Id = int.Parse(line);

                            while ((line = reader.ReadLine()) != null && string.IsNullOrWhiteSpace(line)) { }
                            if (line == null) break;
                            t.Title = line;

                            while ((line = reader.ReadLine()) != null && string.IsNullOrWhiteSpace(line)) { }
                            if (line == null) break;
                            t.Deadline = DateTime.ParseExact(line, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

                            while ((line = reader.ReadLine()) != null && string.IsNullOrWhiteSpace(line)) { }
                            if (line == null) break;
                            t.IsDone = bool.Parse(line);

                            while ((line = reader.ReadLine()) != null && string.IsNullOrWhiteSpace(line)) { }
                            if (line == null) break;
                            t.Priority = int.Parse(line);

                            Tasks.Add(t);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message);
            }
        }
    }
}